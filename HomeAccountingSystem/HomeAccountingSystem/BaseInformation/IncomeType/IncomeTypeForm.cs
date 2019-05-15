using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeAccountingSystem.BaseInformation.IncomeType
{
    public partial class IncomeTypeForm : Form
    {
        public IncomeTypeForm()
        {
            InitializeComponent();
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            this.gridView1.AddNewRow();

            this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, "a", 0);//列初始值1

            this.gridView1.FocusedRowHandle--;
        
        }

        private void IncomeTypeForm_Load(object sender, EventArgs e)
        {
            this.gridControl1.Select();
        }
    }
}
