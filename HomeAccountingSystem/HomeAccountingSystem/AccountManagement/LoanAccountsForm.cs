﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeAccountingSystem.AccountManagement
{
    public partial class LoanAccountsForm : Form
    {
        public LoanAccountsForm()
        {
            InitializeComponent();
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            EditLoanAccountsForm form = new EditLoanAccountsForm();
            form.ShowDialog();
        }
    }
}
