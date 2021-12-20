using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using EntityPrivilegeCopy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPrivilegeCopy
{
    public class CommonHelper
    {
        private IOrganizationService service;
        public CommonHelper(IOrganizationService organizationService)
        {
            service = organizationService;
        }

        public ControlDataSourceModel EntityDefinitionsToControlDataSourceModel(EntityMetadata[] ec)
        {
            var controlDataSourceModel = new ControlDataSourceModel { ControlDataItemModel = new List<ControlDataItemModel>() };
            foreach (var entity in ec)
            {
                var controlDataItemModel = new ControlDataItemModel();
                controlDataItemModel.Id = entity.MetadataId.ToString();
                if (!string.IsNullOrEmpty(entity.LogicalName))
                {
                    controlDataItemModel.LogicalName = entity.LogicalName;
                }
                var displayName = entity.DisplayName;
                if(displayName?.UserLocalizedLabel?.Label != null)
                {
                    controlDataItemModel.DisplayName = displayName?.UserLocalizedLabel?.Label;
                }
                else if(displayName?.LocalizedLabels != null && displayName.LocalizedLabels.Count > 0)
                {
                    var localLabel = displayName.LocalizedLabels.FirstOrDefault(x => x.LanguageCode == 1033);
                    if(localLabel != null)
                    {
                        controlDataItemModel.DisplayName = localLabel.Label;
                    }
                    else
                    {
                        controlDataItemModel.DisplayName = displayName.LocalizedLabels.FirstOrDefault()?.Label;
                    }
                }
                // ignore some entities with no display name
                if (!string.IsNullOrWhiteSpace(controlDataItemModel.DisplayName))
                {
                    controlDataSourceModel.ControlDataItemModel.Add(controlDataItemModel);
                }                
            }
            controlDataSourceModel.ControlDataItemModel = controlDataSourceModel.ControlDataItemModel.OrderBy(x => x.DisplayName).ToList();
            return controlDataSourceModel;
        }
        public ControlDataSourceModel SolutionsToControlDataSourceModel(EntityCollection ec)
        {
            var controlDataSourceModel = new ControlDataSourceModel { ControlDataItemModel = new List<ControlDataItemModel>() };
            foreach (var entity in ec.Entities)
            {
                var controlDataItemModel = new ControlDataItemModel();
                controlDataItemModel.Id = entity.Id.ToString();
                if (!string.IsNullOrEmpty(entity.GetAttributeValue<string>("uniquename")))
                {
                    controlDataItemModel.LogicalName = entity.GetAttributeValue<string>("uniquename");
                }
                if (!string.IsNullOrEmpty(entity.GetAttributeValue<string>("friendlyname")))
                {
                    controlDataItemModel.DisplayName = entity.GetAttributeValue<string>("friendlyname");
                }
                controlDataSourceModel.ControlDataItemModel.Add(controlDataItemModel);
            }
            controlDataSourceModel.ControlDataItemModel = controlDataSourceModel.ControlDataItemModel.OrderBy(x => x.DisplayName).ToList();
            return controlDataSourceModel;
        }

        public ControlDataSourceModel SecurityRoleToControlDataSourceModel(EntityCollection ec)
        {
            var controlDataSourceModel = new ControlDataSourceModel { ControlDataItemModel = new List<ControlDataItemModel>() };
            foreach (var entity in ec.Entities)
            {
                var controlDataItemModel = new ControlDataItemModel();
                controlDataItemModel.Id = entity.Id.ToString();
                if (!string.IsNullOrEmpty(entity.GetAttributeValue<string>("name")))
                {
                    controlDataItemModel.LogicalName = entity.GetAttributeValue<string>("name");
                    controlDataItemModel.DisplayName = entity.GetAttributeValue<string>("name");
                }
                controlDataSourceModel.ControlDataItemModel.Add(controlDataItemModel);
            }
            return controlDataSourceModel;
        }

        public EntityMetadata[] GetEntityDefinitions()
        {
            var request = new RetrieveAllEntitiesRequest();
            var response = service.Execute(request) as RetrieveAllEntitiesResponse;
            return response.EntityMetadata;
        }

        public EntityCollection GetSolutions()
        {
            var query = new QueryExpression("solution");
            query.NoLock = true;
            query.ColumnSet.AddColumns("uniquename", "friendlyname");
            query.AddOrder("createdon", OrderType.Descending);
            return service.RetrieveMultiple(query);
        }
        public EntityCollection GetSecurityRolesInSolution(Guid solutionId)
        {
            var query = new QueryExpression("role");
            query.NoLock = true;
            query.ColumnSet.AddColumns("name");
            var linkToSolutionComponent = query.AddLink("solutioncomponent", "roleid", "objectid", JoinOperator.Inner);
            // Role = 20. More info ref https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/developer/entities/solutioncomponent?view=op-9-1#componenttype-options
            linkToSolutionComponent.LinkCriteria.AddCondition(new ConditionExpression("componenttype", ConditionOperator.Equal, 20));
            linkToSolutionComponent.LinkCriteria.AddCondition(new ConditionExpression("solutionid", ConditionOperator.Equal, solutionId));
            return service.RetrieveMultiple(query);
        }


        public RetrieveEntityResponse GetEntityMetadata(string entityLogicalName, EntityFilters filter)
        {
            var request = new RetrieveEntityRequest
            {
                EntityFilters = filter,
                LogicalName = entityLogicalName
            };
            return service.Execute(request) as RetrieveEntityResponse;
        }

        public List<RetrieveEntityResponse> GetEntityMetadata(List<string> entityLogicalNames, EntityFilters filter)
        {
            var responseList = new List<RetrieveEntityResponse>();
            foreach (var entityLogicalName in entityLogicalNames)
            {
                var request = new RetrieveEntityRequest
                {
                    EntityFilters = filter,
                    LogicalName = entityLogicalName
                };
                var response = service.Execute(request) as RetrieveEntityResponse;
                responseList.Add(response);
            }
            return responseList;
        }

        public List<Entity> GetSolutionComponents(string solutionUniqueName, EnumDefine.ComponentType componentType)
        {
            var entityList = new List<Entity>();
            var query = new QueryExpression("solutioncomponent");
            query.NoLock = true;
            query.ColumnSet.AddColumns("objectid");
            query.Criteria.FilterOperator = LogicalOperator.And;
            query.Criteria.AddCondition("componenttype", ConditionOperator.Equal, componentType.GetHashCode());
            var link = query.AddLink("solution", "solutionid", "solutionid", JoinOperator.Inner);
            link.EntityAlias = "solutionlink";
            link.LinkCriteria.AddCondition(new ConditionExpression("uniquename", ConditionOperator.Equal, solutionUniqueName));
            entityList = service.RetrieveMultiple(query)?.Entities.ToList();
            return entityList;
        }

        public List<Entity> GetRolePrivileges(Guid roleId, Guid[] privilegeIds)
        {
            var entityList = new List<Entity>();
            var query = new QueryExpression("roleprivileges");
            query.NoLock = true;
            query.ColumnSet.AddColumns("privilegedepthmask", "roleid", "privilegeid");
            query.Criteria.FilterOperator = LogicalOperator.And;
            var link1 = query.AddLink("role", "roleid", "roleid", JoinOperator.Inner);
            link1.EntityAlias = "rolelink";
            link1.LinkCriteria.AddCondition(new ConditionExpression("roleid", ConditionOperator.Equal, roleId));
            var link2 = query.AddLink("privilege", "privilegeid", "privilegeid", JoinOperator.Inner);
            link2.EntityAlias = "privilegelink";
            link2.LinkCriteria.AddCondition(new ConditionExpression("privilegeid", ConditionOperator.In, privilegeIds));
            entityList = service.RetrieveMultiple(query)?.Entities.ToList();
            return entityList;
        }

        public int MappingPrivilegeMaskToPrivilegeDepth(int privilegeMask)
        {
            var privilegeDepth = -1;
            switch (privilegeMask)
            {
                case 1:
                    privilegeDepth = 0;
                    break;
                case 2:
                    privilegeDepth = 1;
                    break;
                case 4:
                    privilegeDepth = 2;
                    break;
                case 8:
                    privilegeDepth = 3;
                    break;
            }
            return privilegeDepth;
        }

        public string MappingPrivilegeDepthToString(int privilegeDepth)
        {
            var str = "";
            switch (privilegeDepth)
            {
                case 0:
                    str = "Basic";
                    break;
                case 2:
                    str = "Deep";
                    break;
                case 3:
                    str = "Global";
                    break;
                case 1:
                    str = "Local";
                    break;
            }
            return str;
        }
    }
}
