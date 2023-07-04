
namespace EntityPrivilegeCopy
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadDataBtn = new System.Windows.Forms.Button();
            this.targetEntityListClb = new System.Windows.Forms.CheckedListBox();
            this.excuteBtn = new System.Windows.Forms.Button();
            this.sourceEntityCmb = new System.Windows.Forms.ComboBox();
            this.solutionCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterTargetEntityTxb = new System.Windows.Forms.TextBox();
            this.privilegeTypeClb = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.previewBtn = new System.Windows.Forms.Button();
            this.exportSolutionBtn = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(951, 42);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(170, 36);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // LoadDataBtn
            // 
            this.LoadDataBtn.Location = new System.Drawing.Point(49, 67);
            this.LoadDataBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadDataBtn.Name = "LoadDataBtn";
            this.LoadDataBtn.Size = new System.Drawing.Size(237, 39);
            this.LoadDataBtn.TabIndex = 5;
            this.LoadDataBtn.Text = "Load Data";
            this.LoadDataBtn.UseVisualStyleBackColor = true;
            this.LoadDataBtn.Click += new System.EventHandler(this.LoadDataBtn_Click);
            // 
            // targetEntityListClb
            // 
            this.targetEntityListClb.CheckOnClick = true;
            this.targetEntityListClb.FormattingEnabled = true;
            this.targetEntityListClb.Location = new System.Drawing.Point(49, 298);
            this.targetEntityListClb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetEntityListClb.Name = "targetEntityListClb";
            this.targetEntityListClb.Size = new System.Drawing.Size(653, 312);
            this.targetEntityListClb.TabIndex = 7;
            this.targetEntityListClb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.targetEntityListClb_ItemCheck);
            // 
            // excuteBtn
            // 
            this.excuteBtn.Location = new System.Drawing.Point(579, 67);
            this.excuteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.excuteBtn.Name = "excuteBtn";
            this.excuteBtn.Size = new System.Drawing.Size(112, 39);
            this.excuteBtn.TabIndex = 8;
            this.excuteBtn.Text = "Execute";
            this.excuteBtn.UseVisualStyleBackColor = true;
            this.excuteBtn.Click += new System.EventHandler(this.excuteBtn_Click);
            // 
            // sourceEntityCmb
            // 
            this.sourceEntityCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sourceEntityCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sourceEntityCmb.FormattingEnabled = true;
            this.sourceEntityCmb.Location = new System.Drawing.Point(49, 160);
            this.sourceEntityCmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceEntityCmb.Name = "sourceEntityCmb";
            this.sourceEntityCmb.Size = new System.Drawing.Size(655, 33);
            this.sourceEntityCmb.TabIndex = 9;
            // 
            // solutionCmb
            // 
            this.solutionCmb.FormattingEnabled = true;
            this.solutionCmb.Location = new System.Drawing.Point(47, 682);
            this.solutionCmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solutionCmb.Name = "solutionCmb";
            this.solutionCmb.Size = new System.Drawing.Size(655, 33);
            this.solutionCmb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Source Entity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Target Entity(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 651);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Security Role Solution:";
            // 
            // filterTargetEntityTxb
            // 
            this.filterTargetEntityTxb.Location = new System.Drawing.Point(49, 248);
            this.filterTargetEntityTxb.Name = "filterTargetEntityTxb";
            this.filterTargetEntityTxb.Size = new System.Drawing.Size(483, 31);
            this.filterTargetEntityTxb.TabIndex = 14;
            this.filterTargetEntityTxb.TextChanged += new System.EventHandler(this.filterTargetEntityTxb_TextChanged);
            // 
            // privilegeTypeClb
            // 
            this.privilegeTypeClb.CheckOnClick = true;
            this.privilegeTypeClb.FormattingEnabled = true;
            this.privilegeTypeClb.Location = new System.Drawing.Point(47, 784);
            this.privilegeTypeClb.Name = "privilegeTypeClb";
            this.privilegeTypeClb.Size = new System.Drawing.Size(390, 228);
            this.privilegeTypeClb.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 735);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Copy Privilege Type:";
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(736, 67);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(106, 39);
            this.previewBtn.TabIndex = 18;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Visible = false;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // exportSolutionBtn
            // 
            this.exportSolutionBtn.Location = new System.Drawing.Point(345, 67);
            this.exportSolutionBtn.Name = "exportSolutionBtn";
            this.exportSolutionBtn.Size = new System.Drawing.Size(189, 39);
            this.exportSolutionBtn.TabIndex = 19;
            this.exportSolutionBtn.Text = "Export Solution";
            this.exportSolutionBtn.UseVisualStyleBackColor = true;
            this.exportSolutionBtn.Click += new System.EventHandler(this.exportSolutionBtn_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exportSolutionBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.privilegeTypeClb);
            this.Controls.Add(this.filterTargetEntityTxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solutionCmb);
            this.Controls.Add(this.sourceEntityCmb);
            this.Controls.Add(this.excuteBtn);
            this.Controls.Add(this.targetEntityListClb);
            this.Controls.Add(this.LoadDataBtn);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(951, 1076);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Button LoadDataBtn;
        private System.Windows.Forms.CheckedListBox targetEntityListClb;
        private System.Windows.Forms.Button excuteBtn;
        private System.Windows.Forms.ComboBox sourceEntityCmb;
        private System.Windows.Forms.ComboBox solutionCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterTargetEntityTxb;
        private System.Windows.Forms.CheckedListBox privilegeTypeClb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button exportSolutionBtn;
    }
}
