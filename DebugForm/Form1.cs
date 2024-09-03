using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            //this.dataGridView1.Columns.Add(new DataGridViewImageColumn());
            for (int i = 0; i < 10; i++)
            {
                this.dataGridView1.Rows.Add(new DataGridViewRow());
                this.dataGridView1.Rows[i].Cells[0].Value = "ssss";
                //this.dataGridView1.Rows[i].Cells[1].Value = Image.FromFile("../debug/Resources/role_0.gif");

                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = i }); // role name
                row.Cells.Add(new DataGridViewImageCell());
                //row.Cells[1].Value = Image.FromFile("../debug/Resources/role_0.gif");
                this.dataGridView1.Rows.Add(row);
                this.dataGridView1.Columns[1].DefaultCellStyle.NullValue = null;
            }
            this.dataGridView1.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, this.checkBox1.Checked);
            }
        }
    }
}
