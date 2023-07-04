
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
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(951, 42);
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
            this.targetEntityListClb.Location = new System.Drawing.Point(7, 69);
            this.targetEntityListClb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetEntityListClb.Name = "targetEntityListClb";
            this.targetEntityListClb.Size = new System.Drawing.Size(653, 312);
            this.targetEntityListClb.TabIndex = 7;
            this.targetEntityListClb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TargetEntityListClb_ItemCheck);
            // 
            // sourceEntityCmb
            // 
            this.sourceEntityCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sourceEntityCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sourceEntityCmb.FormattingEnabled = true;
            this.sourceEntityCmb.Location = new System.Drawing.Point(7, 29);
            this.sourceEntityCmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceEntityCmb.Name = "sourceEntityCmb";
            this.sourceEntityCmb.Size = new System.Drawing.Size(655, 33);
            this.sourceEntityCmb.TabIndex = 9;
            // 
            // solutionCmb
            // 
            this.solutionCmb.FormattingEnabled = true;
            this.solutionCmb.Location = new System.Drawing.Point(7, 29);
            this.solutionCmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solutionCmb.Name = "solutionCmb";
            this.solutionCmb.Size = new System.Drawing.Size(653, 33);
            this.solutionCmb.TabIndex = 11;
            // 
            // filterTargetEntityTxb
            // 
            this.filterTargetEntityTxb.Location = new System.Drawing.Point(6, 30);
            this.filterTargetEntityTxb.Name = "filterTargetEntityTxb";
            this.filterTargetEntityTxb.Size = new System.Drawing.Size(483, 31);
            this.filterTargetEntityTxb.TabIndex = 14;
            this.filterTargetEntityTxb.TextChanged += new System.EventHandler(this.FilterTargetEntityTxb_TextChanged);
            // 
            // privilegeTypeClb
            // 
            this.privilegeTypeClb.CheckOnClick = true;
            this.privilegeTypeClb.FormattingEnabled = true;
            this.privilegeTypeClb.Location = new System.Drawing.Point(6, 34);
            this.privilegeTypeClb.Name = "privilegeTypeClb";
            this.privilegeTypeClb.Size = new System.Drawing.Size(390, 228);
            this.privilegeTypeClb.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceEntityCmb);
            this.groupBox1.Location = new System.Drawing.Point(11, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Entity:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterTargetEntityTxb);
            this.groupBox2.Controls.Add(this.targetEntityListClb);
            this.groupBox2.Location = new System.Drawing.Point(11, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 386);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Entity(s):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.solutionCmb);
            this.groupBox3.Location = new System.Drawing.Point(11, 513);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 70);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Security Role Solution:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.privilegeTypeClb);
            this.groupBox4.Location = new System.Drawing.Point(11, 589);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 268);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Copy Privilege Type:";
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(951, 1076);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
    }
}
