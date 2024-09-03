
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
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.loadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.targetEntityListClb = new System.Windows.Forms.CheckedListBox();
            this.sourceEntityCmb = new System.Windows.Forms.ComboBox();
            this.solutionCmb = new System.Windows.Forms.ComboBox();
            this.filterTargetEntityTxb = new System.Windows.Forms.TextBox();
            this.privilegeTypeClb = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create = new System.Windows.Forms.DataGridViewImageColumn();
            this.Read = new System.Windows.Forms.DataGridViewImageColumn();
            this.Write = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Append = new System.Windows.Forms.DataGridViewImageColumn();
            this.AppendTo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Assign = new System.Windows.Forms.DataGridViewImageColumn();
            this.Share = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.toolStripSplitButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1862, 42);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::EntityPrivilegeCopy.Properties.Resources.close_circle;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(100, 36);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAllToolStripMenuItem,
            this.loadFromSolutionToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::EntityPrivilegeCopy.Properties.Resources.reload_time;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(116, 36);
            this.toolStripSplitButton1.Text = "Load";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // loadAllToolStripMenuItem
            // 
            this.loadAllToolStripMenuItem.Image = global::EntityPrivilegeCopy.Properties.Resources.exclaimination;
            this.loadAllToolStripMenuItem.Name = "loadAllToolStripMenuItem";
            this.loadAllToolStripMenuItem.Size = new System.Drawing.Size(356, 44);
            this.loadAllToolStripMenuItem.Text = "Load All";
            this.loadAllToolStripMenuItem.Click += new System.EventHandler(this.LoadDataBtn_Click);
            // 
            // loadFromSolutionToolStripMenuItem
            // 
            this.loadFromSolutionToolStripMenuItem.Image = global::EntityPrivilegeCopy.Properties.Resources.select;
            this.loadFromSolutionToolStripMenuItem.Name = "loadFromSolutionToolStripMenuItem";
            this.loadFromSolutionToolStripMenuItem.Size = new System.Drawing.Size(356, 44);
            this.loadFromSolutionToolStripMenuItem.Text = "Load From Solution";
            this.loadFromSolutionToolStripMenuItem.Click += new System.EventHandler(this.LoadDataBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::EntityPrivilegeCopy.Properties.Resources.export;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(205, 36);
            this.toolStripButton1.Text = "Export Solution";
            this.toolStripButton1.Click += new System.EventHandler(this.ExportSolutionBtn_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::EntityPrivilegeCopy.Properties.Resources.play_square;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(124, 36);
            this.toolStripButton2.Text = "Execute";
            this.toolStripButton2.Click += new System.EventHandler(this.ExcuteBtn_Click);
            // 
            // targetEntityListClb
            // 
            this.targetEntityListClb.CheckOnClick = true;
            this.targetEntityListClb.FormattingEnabled = true;
            this.targetEntityListClb.Location = new System.Drawing.Point(8, 82);
            this.targetEntityListClb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.targetEntityListClb.Name = "targetEntityListClb";
            this.targetEntityListClb.Size = new System.Drawing.Size(656, 256);
            this.targetEntityListClb.TabIndex = 7;
            this.targetEntityListClb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TargetEntityListClb_ItemCheck);
            // 
            // sourceEntityCmb
            // 
            this.sourceEntityCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sourceEntityCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sourceEntityCmb.FormattingEnabled = true;
            this.sourceEntityCmb.Location = new System.Drawing.Point(8, 30);
            this.sourceEntityCmb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sourceEntityCmb.Name = "sourceEntityCmb";
            this.sourceEntityCmb.Size = new System.Drawing.Size(656, 33);
            this.sourceEntityCmb.TabIndex = 9;
            // 
            // solutionCmb
            // 
            this.solutionCmb.FormattingEnabled = true;
            this.solutionCmb.Location = new System.Drawing.Point(8, 30);
            this.solutionCmb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.solutionCmb.Name = "solutionCmb";
            this.solutionCmb.Size = new System.Drawing.Size(656, 33);
            this.solutionCmb.TabIndex = 11;
            // 
            // filterTargetEntityTxb
            // 
            this.filterTargetEntityTxb.Location = new System.Drawing.Point(8, 32);
            this.filterTargetEntityTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterTargetEntityTxb.Name = "filterTargetEntityTxb";
            this.filterTargetEntityTxb.Size = new System.Drawing.Size(656, 31);
            this.filterTargetEntityTxb.TabIndex = 14;
            this.filterTargetEntityTxb.TextChanged += new System.EventHandler(this.FilterTargetEntityTxb_TextChanged);
            // 
            // privilegeTypeClb
            // 
            this.privilegeTypeClb.CheckOnClick = true;
            this.privilegeTypeClb.FormattingEnabled = true;
            this.privilegeTypeClb.Location = new System.Drawing.Point(8, 72);
            this.privilegeTypeClb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privilegeTypeClb.Name = "privilegeTypeClb";
            this.privilegeTypeClb.Size = new System.Drawing.Size(656, 172);
            this.privilegeTypeClb.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceEntityCmb);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(676, 80);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Entity:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterTargetEntityTxb);
            this.groupBox2.Controls.Add(this.targetEntityListClb);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(676, 372);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Entity(s):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.solutionCmb);
            this.groupBox3.Location = new System.Drawing.Point(12, 526);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(676, 80);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Security Role Solution:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.privilegeTypeClb);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 614);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(676, 272);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Copy Privilege Type:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(434, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 29);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Select/Unselect All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.resultGridView);
            this.groupBox5.Location = new System.Drawing.Point(696, 58);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1155, 828);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Role,
            this.Entity,
            this.Create,
            this.Read,
            this.Write,
            this.Delete,
            this.Append,
            this.AppendTo,
            this.Assign,
            this.Share});
            this.resultGridView.Location = new System.Drawing.Point(8, 32);
            this.resultGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultGridView.MultiSelect = false;
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.RowHeadersVisible = false;
            this.resultGridView.RowHeadersWidth = 82;
            this.resultGridView.RowTemplate.Height = 33;
            this.resultGridView.Size = new System.Drawing.Size(1145, 784);
            this.resultGridView.TabIndex = 0;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 10;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 101;
            // 
            // Entity
            // 
            this.Entity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Entity.HeaderText = "Entity";
            this.Entity.MinimumWidth = 10;
            this.Entity.Name = "Entity";
            this.Entity.ReadOnly = true;
            this.Entity.Width = 111;
            // 
            // Create
            // 
            this.Create.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Create.HeaderText = "Create";
            this.Create.MinimumWidth = 20;
            this.Create.Name = "Create";
            this.Create.ReadOnly = true;
            this.Create.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Create.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Create.Width = 121;
            // 
            // Read
            // 
            this.Read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Read.HeaderText = "Read";
            this.Read.MinimumWidth = 20;
            this.Read.Name = "Read";
            this.Read.ReadOnly = true;
            this.Read.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Read.Width = 108;
            // 
            // Write
            // 
            this.Write.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Write.HeaderText = "Write";
            this.Write.MinimumWidth = 20;
            this.Write.Name = "Write";
            this.Write.ReadOnly = true;
            this.Write.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Write.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Write.Width = 107;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 20;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 119;
            // 
            // Append
            // 
            this.Append.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Append.HeaderText = "Append";
            this.Append.MinimumWidth = 20;
            this.Append.Name = "Append";
            this.Append.ReadOnly = true;
            this.Append.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Append.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Append.Width = 131;
            // 
            // AppendTo
            // 
            this.AppendTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AppendTo.HeaderText = "Append To";
            this.AppendTo.MinimumWidth = 20;
            this.AppendTo.Name = "AppendTo";
            this.AppendTo.ReadOnly = true;
            this.AppendTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AppendTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AppendTo.Width = 162;
            // 
            // Assign
            // 
            this.Assign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Assign.HeaderText = "Assign";
            this.Assign.MinimumWidth = 20;
            this.Assign.Name = "Assign";
            this.Assign.ReadOnly = true;
            this.Assign.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Assign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Assign.Width = 122;
            // 
            // Share
            // 
            this.Share.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Share.HeaderText = "Share";
            this.Share.MinimumWidth = 20;
            this.Share.Name = "Share";
            this.Share.ReadOnly = true;
            this.Share.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Share.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Share.Width = 114;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1862, 898);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.CheckedListBox targetEntityListClb;
        private System.Windows.Forms.ComboBox sourceEntityCmb;
        private System.Windows.Forms.ComboBox solutionCmb;
        private System.Windows.Forms.TextBox filterTargetEntityTxb;
        private System.Windows.Forms.CheckedListBox privilegeTypeClb;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem loadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity;
        private System.Windows.Forms.DataGridViewImageColumn Create;
        private System.Windows.Forms.DataGridViewImageColumn Read;
        private System.Windows.Forms.DataGridViewImageColumn Write;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Append;
        private System.Windows.Forms.DataGridViewImageColumn AppendTo;
        private System.Windows.Forms.DataGridViewImageColumn Assign;
        private System.Windows.Forms.DataGridViewImageColumn Share;
    }
}
