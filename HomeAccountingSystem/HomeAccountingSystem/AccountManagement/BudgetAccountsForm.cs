using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeAccountingSystem.AccountManagement
{
    public partial class BudgetAccountsForm : Form
    {
        public BudgetAccountsForm()
        {
            InitializeComponent();
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            EditBudgetAccountsForm form = new EditBudgetAccountsForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                //this.loadDataList();
            }
        }
    }
}
