using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using EntityPrivilegeCopy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;

namespace EntityPrivilegeCopy
{
    public partial class MyPluginControl : PluginControlBase
    {
        #region IGitHubPlugin implementation

        public string RepositoryName => "EntityPrivilegeCopy";

        public string UserName => "ranistar";

        #endregion IGitHubPlugin implementation

        #region IHelpPlugin implementation

        //public string HelpUrl => "https://github.com/ranistar/EntityPrivilegeCopy.git";

        #endregion IHelpPlugin implementation
        public event EventHandler SendMessageToStatusBar;

        private Settings mySettings;

        private CommonHelper commonHelper;
        private EntityMetadata[] EntityDifinitions;
        private EntityCollection Solutions;
        private List<ControlDataItemModel> TargetEntityDataList;
        private List<ControlDataItemModel> CheckedTargetEntutyList = new List<ControlDataItemModel>();
        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            commonHelper = new CommonHelper(Service);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        #region Control Data Bind and Refresh
        private void SourceEntityCmbBind()
        {
            var entityControlDataModel = commonHelper.EntityDefinitionsToControlDataSourceModel(EntityDifinitions);
            this.sourceEntityCmb.DataSource = entityControlDataModel.ControlDataItemModel;
            this.sourceEntityCmb.ValueMember = "Id";
            this.sourceEntityCmb.DisplayMember = "DisplayName";
        }

        private void SolutionCmbBind()
        {
            var solutionControlDataModel = commonHelper.SolutionsToControlDataSourceModel(Solutions);
            this.solutionCmb.DataSource = solutionControlDataModel.ControlDataItemModel;
            this.solutionCmb.ValueMember = "Id";
            this.solutionCmb.DisplayMember = "DisplayName";
        }

        private void TargetEntityClbBind()
        {
            var entityControlDataModel = commonHelper.EntityDefinitionsToControlDataSourceModel(EntityDifinitions);
            TargetEntityDataList = entityControlDataModel.ControlDataItemModel;
            ((ListBox)this.targetEntityListClb).DataSource = entityControlDataModel.ControlDataItemModel;
            ((ListBox)this.targetEntityListClb).ValueMember = "Id";
            ((ListBox)this.targetEntityListClb).DisplayMember = "DisplayName";
        }

        private void PrivilegeTypeClbBind()
        {
            var privilegeTypeControlDataModel = new ControlDataSourceModel { ControlDataItemModel = new List<ControlDataItemModel>() };
            foreach (var privilegeType in Enum.GetValues(typeof(PrivilegeType)))
            {
                if (privilegeType.GetHashCode() != PrivilegeType.None.GetHashCode())
                {
                    privilegeTypeControlDataModel.ControlDataItemModel.Add(new ControlDataItemModel
                    {
                        DisplayName = privilegeType.ToString(),
                        LogicalName = privilegeType.GetHashCode().ToString(),
                        Id = privilegeType.GetHashCode().ToString()
                    });
                }
            }
            ((ListBox)this.privilegeTypeClb).DataSource = privilegeTypeControlDataModel.ControlDataItemModel;
            ((ListBox)this.privilegeTypeClb).ValueMember = "Id";
            ((ListBox)this.privilegeTypeClb).DisplayMember = "DisplayName";
        }
        #endregion

        private void LoadDataBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += $"\r\nLoad start.";
            EntityDifinitions = commonHelper.GetEntityDefinitions();
            Solutions = commonHelper.GetSolutions();

            //SecurityRoles = commonHelper.GetSecurityRolesInSolution(solutionId);
            // bind Entity ComboBox
            SourceEntityCmbBind();
            // bind Solution ComboBox
            SolutionCmbBind();
            TargetEntityClbBind();
            PrivilegeTypeClbBind();
            this.textBox1.Text += $"\r\nLoad end.";
        }

        private void excuteBtn_Click(object sender, EventArgs e)
        {
            // only one of entity list can select more than one item

            var sourceEntityData = this.sourceEntityCmb.SelectedItem as ControlDataItemModel;
            var targetEntityNames = CheckedTargetEntutyList.Select(x => x.LogicalName).ToList();
            var copyPrivilegeTypes = new List<int>();
            foreach (var checkedItem in this.privilegeTypeClb.CheckedItems)
            {
                copyPrivilegeTypes.Add(int.Parse((checkedItem as ControlDataItemModel).Id));
            }
            var solutionData = this.solutionCmb.SelectedItem as ControlDataItemModel;
            if (!string.IsNullOrEmpty(solutionData?.Id))
            {
                var rolesData = commonHelper.GetSecurityRolesInSolution(new Guid(solutionData.Id));
                if (rolesData.Entities.Count == 0)
                {
                    MessageBox.Show($"Found {rolesData.Entities.Count} role(s) in solution {solutionData.DisplayName}");
                    return;
                }
                Copy(sourceEntityData.LogicalName, targetEntityNames, rolesData, copyPrivilegeTypes, false);
            }
        }

        // do the copy
        private void Copy(string sourceEntityName, List<string> targetEntityNames, EntityCollection roles, List<int> copyPrivilegeTypes, bool isPreview = true)
        {
            //get source entity privileges
            var sourceEntityPrivilegeMetadatas = commonHelper.GetEntityMetadata(sourceEntityName, EntityFilters.Privileges);
            //get target entities privileges
            var targetEntityPrivilegeMetadatas = commonHelper.GetEntityMetadata(targetEntityNames, EntityFilters.Privileges);

            var transactionRequest = new ExecuteTransactionRequest
            {
                Requests = new OrganizationRequestCollection(),
                ReturnResponses = true
            };
            foreach (var role in roles.Entities)
            {
                var addPrivileges = new List<RolePrivilege>();
                var addPrivilegesRoleRequest = new AddPrivilegesRoleRequest { RoleId = role.Id };
                //get role privileges relationship for source entity
                var sourceEntityRolePrivileges = commonHelper.GetRolePrivileges(role.Id, sourceEntityPrivilegeMetadatas.EntityMetadata.Privileges.Select(x => x.PrivilegeId).ToArray());
                foreach (var sourceEntityRolePrivilege in sourceEntityRolePrivileges)
                {
                    //privilege Type
                    var privilegeMetadata = sourceEntityPrivilegeMetadatas.EntityMetadata.Privileges.Where(x => x.PrivilegeId == sourceEntityRolePrivilege.GetAttributeValue<Guid>("privilegeid")).FirstOrDefault() as SecurityPrivilegeMetadata;
                    var privilegeType = privilegeMetadata.PrivilegeType;
                    if (copyPrivilegeTypes.Contains(privilegeType.GetHashCode()))
                    {
                        //privilege Depth(https://docs.microsoft.com/en-us/dotnet/api/microsoft.crm.sdk.messages.privilegedepth?view=dynamics-general-ce-9)
                        var privilegeMask = sourceEntityRolePrivilege.GetAttributeValue<int>("privilegedepthmask");
                        var privilegeDepth = commonHelper.MappingPrivilegeMaskToPrivilegeDepth(privilegeMask);
                        foreach (var targetEntityPrivilegeMetadata in targetEntityPrivilegeMetadatas)
                        {
                            if (targetEntityPrivilegeMetadata.EntityMetadata.OwnershipType.Value == OwnershipTypes.OrganizationOwned)
                            {
                                privilegeDepth = 3;
                            }
                            if (targetEntityPrivilegeMetadata.EntityMetadata.Privileges.Any(x => x.PrivilegeType == privilegeType))
                            {
                                var targetPrivilegeMetadata = targetEntityPrivilegeMetadata.EntityMetadata.Privileges.First(x => x.PrivilegeType == privilegeType);
                                addPrivileges.Add(new RolePrivilege(privilegeDepth, targetPrivilegeMetadata.PrivilegeId));
                                this.textBox1.Text += ($"\r\nRole name:{role.GetAttributeValue<string>("name")}, privilegeType: {privilegeType}, privilegeId: {targetPrivilegeMetadata.PrivilegeId}, depth: {commonHelper.MappingPrivilegeDepthToString(privilegeDepth)}");
                            }
                        }
                    }
                }
                addPrivilegesRoleRequest.Privileges = addPrivileges.ToArray();
                if (addPrivileges.Count > 0)
                {
                    transactionRequest.Requests.Add(addPrivilegesRoleRequest);
                }
            }
            if (!isPreview)
            {
                var response = Service.Execute(transactionRequest);
            }
        }

        // TODO filter item in Target entity ListCheckBox
        private void filterTargetEntityTxb_TextChanged(object sender, EventArgs e)
        {
            var txt = this.filterTargetEntityTxb.Text;
            if (string.IsNullOrEmpty(txt))
            {
                ((ListBox)this.targetEntityListClb).DataSource = TargetEntityDataList;
                ((ListBox)this.targetEntityListClb).ValueMember = "Id";
                ((ListBox)this.targetEntityListClb).DisplayMember = "DisplayName";
            }
            else
            {
                ((ListBox)this.targetEntityListClb).DataSource = TargetEntityDataList.Where(x => x.DisplayName.ToLower().Contains(txt.ToLower()))?.ToList();
                ((ListBox)this.targetEntityListClb).ValueMember = "Id";
                ((ListBox)this.targetEntityListClb).DisplayMember = "DisplayName";
            }
            for (int i = 0; i < this.targetEntityListClb.Items.Count; i++)
            {
                var item = this.targetEntityListClb.Items[i];
                this.targetEntityListClb.SetItemChecked(this.targetEntityListClb.Items.IndexOf(item), CheckedTargetEntutyList.Contains(item));
            }
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            var sourceEntityData = this.sourceEntityCmb.SelectedItem as ControlDataItemModel;
            var targetEntityNames = CheckedTargetEntutyList.Select(x=>x.LogicalName).ToList();
            foreach (var checkedItem in this.targetEntityListClb.CheckedItems)
            {
                targetEntityNames.Add((checkedItem as ControlDataItemModel).LogicalName);
            }
            var copyPrivilegeTypes = new List<int>();
            foreach (var checkedItem in this.privilegeTypeClb.CheckedItems)
            {
                copyPrivilegeTypes.Add(int.Parse((checkedItem as ControlDataItemModel).Id));
            }
            var solutionData = this.solutionCmb.SelectedItem as ControlDataItemModel;
            if (!string.IsNullOrEmpty(solutionData?.Id))
            {
                var rolesData = commonHelper.GetSecurityRolesInSolution(new Guid(solutionData.Id));
                if (rolesData.Entities.Count == 0)
                {
                    MessageBox.Show($"Found {rolesData.Entities.Count} role(s) in solution {solutionData.DisplayName}");
                    return;
                }
                Copy(sourceEntityData.LogicalName, targetEntityNames, rolesData, copyPrivilegeTypes);
            }
        }

        private void exportSolutionBtn_Click(object sender, EventArgs e)
        {

        }

        private void targetEntityListClb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var selectedItem = (sender as CheckedListBox).Items[e.Index] as ControlDataItemModel;
            if (e.NewValue == CheckState.Checked)
            {                
                if (!CheckedTargetEntutyList.Contains(selectedItem))
                {
                    CheckedTargetEntutyList.Add(selectedItem);
                }
            }
            else
            {
                if (CheckedTargetEntutyList.Contains(selectedItem))
                {
                    CheckedTargetEntutyList.Remove(selectedItem);
                }
            }
        }
    }
}