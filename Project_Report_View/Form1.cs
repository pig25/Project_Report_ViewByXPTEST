using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Report_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Font = Properties.Settings.Default.Font;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = this.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = this.BackColor;
            dataGridView1.DefaultCellStyle.BackColor = this.BackColor;
            dataGridView1.EnableHeadersVisualStyles = false;
            
            dataGridView1.BackgroundColor= this.BackColor;
            SetFont();

            tslB_Refresh_Click(null,null);
        }
        private void SetFont()
        {  
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = this.Font;
            dataGridView1.DefaultCellStyle.Font = this.Font;
            dataGridView1.AutoResizeRows();
            dataGridView1.AutoResizeColumns();
        }
        private void tslb_Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = this.Font;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog.Font;
                Properties.Settings.Default.Font = this.Font;
                Properties.Settings.Default.Save();
                SetFont();
            }
        }

        private void tslB_Refresh_Click(object sender, EventArgs e)
        {
            ReportDataContext reportDataContext = new ReportDataContext();
            dataGridView1.DataSource = reportDataContext.sheudle.ToList();
            SetFont();
        }
    }
}
