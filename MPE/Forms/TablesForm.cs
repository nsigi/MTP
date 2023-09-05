using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MPE
{
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
        }

        public void AddTable(int t)
        {
            var dataGridView1 = CreateTable();
            var collection = new[] { 2, 3, 4, 5, 6, 7, 8 }.Select(x => Math.Pow(10, -x)).ToArray();
            for (int i = 0; i < collection.Length; ++i)
            {
                collection[i] = Task1Solver.GetN(collection[i]);
            }
            dataGridView1.Rows.Add("N", collection[0], collection[1], collection[2], collection[3], collection[4], collection[5], collection[6]);
            //dataGridView1.Rows.Add
            dataGridView1.Rows.Add(string.Format("t = {0}", t));
            panelMenu.Controls.Add(dataGridView1);
        }

        private DataGridView CreateTable()
        {
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridView1 = new DataGridView();
            panelMenu.SuspendLayout();
            ((ISupportInitialize)(dataGridView1)).BeginInit();
            SuspendLayout();
            var eps = new DataGridViewTextBoxColumn();
            var с2 = new DataGridViewTextBoxColumn();
            var c3 = new DataGridViewTextBoxColumn();
            var c4 = new DataGridViewTextBoxColumn();
            var c5 = new DataGridViewTextBoxColumn();
            var c6 = new DataGridViewTextBoxColumn();
            var c7 = new DataGridViewTextBoxColumn();
            var c8 = new DataGridViewTextBoxColumn();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            //dataGridView1.AutoSize = true;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            eps,
            с2,
            c3,
            c4,
            c5,
            c6,
            c7,
            c8});
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1129, 136);
            dataGridView1.TabIndex = 0;
            // 
            // eps
            // 
            eps.HeaderText = "ε";
            eps.Name = "eps";
            eps.ReadOnly = true;
            // 
            // с2
            // 
            с2.HeaderText = "10^-2";
            с2.Name = "с2";
            с2.ReadOnly = true;
            // 
            // c3
            // 
            c3.HeaderText = "10^-3";
            c3.Name = "c3";
            c3.ReadOnly = true;
            // 
            // c4
            // 
            c4.HeaderText = "10^-4";
            c4.Name = "c4";
            c4.ReadOnly = true;
            // 
            // c5
            // 
            c5.HeaderText = "10^-5";
            c5.Name = "c5";
            c5.ReadOnly = true;
            // 
            // c6
            // 
            c6.HeaderText = "10^-6";
            c6.Name = "c6";
            c6.ReadOnly = true;
            // 
            // c7
            // 
            c7.HeaderText = "10^-7";
            c7.Name = "c7";
            c7.ReadOnly = true;
            // 
            // c8
            // 
            c8.HeaderText = "10^-8";
            c8.Name = "c8";
            c8.ReadOnly = true;
            panelMenu.ResumeLayout(false);
            ((ISupportInitialize)(dataGridView1)).EndInit();
            ResumeLayout(false);
            return dataGridView1;
        }

        private void btnAddTable_Click_1(object sender, EventArgs e)
        {
            int[] t = new int[] { -1 };
            var form = new AddTableForm(t);
            form.ShowDialog();
            if (t[0] != -1)
            {
                AddTable(t[0]);
            }
        }
    }
}
