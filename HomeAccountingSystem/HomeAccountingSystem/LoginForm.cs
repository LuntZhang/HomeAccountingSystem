﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;

namespace HomeAccountingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // 测试数据库连接
            DatabaseManager.DatabaseConnection();
        }

        // 退出
        private void escBtn_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        // 登录
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string strAccount = this.textBoxAccount.Text.Trim();
            string strPwd = this.textBoxPwd.Text.Trim();
            bool isSuccess = jt_yh_zl.Instance.Exists(strAccount, strPwd);
            if(isSuccess == false)
            {
                MessageBox.Show("用户名或密码错误，请重新输入！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.Hide();
                MainForm formMain = new MainForm();
                formMain.ShowDialog();
            }

        }
    }
}