﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.AccountManagement;
using HomeAccountingSystem.BaseInformation;
using HomeAccountingSystem.MainUserControl;
using TZXControlLibrary.ButtonEx;

namespace HomeAccountingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            if (this.DesignMode)
            {
                SQLServerHelper.connectionString = "";
            }
            InitializeComponent();
        }
        // 退出系统
        public bool m_isTuichu = true;
        // 退出系统是否询问
        public bool m_isInquiry = true;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.topUserInfoUserControl1.delegateCloseMainPage = delegateCloseMainPage;
        }

        private void delegateCloseMainPage(bool isTuichu)
        {
            m_isInquiry = Program.m_MainForm.m_isInquiry;
            m_isTuichu = isTuichu;
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!this.formMainClose())
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 退出还是注销
        /// </summary>
        /// <param name="isTuichu"></param>
        public bool formMainClose()
        {
            bool isClosePage = false;
            if (m_isTuichu == true)
            {
                if (MessageBox.Show("确定要退出系统？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // 隐藏的登录页面也退出
                    Program.m_LoginForm.Close();

                    isClosePage = true;
                }
            }
            else
            {   
                // 退出是否询问
                if (this.m_isInquiry == true)
                {
                    if (MessageBox.Show("确定要注销系统？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        // 隐藏的登录页面显示
                        Program.m_LoginForm.Show();

                        isClosePage = true;
                    }
                }
                else
                {
                    // 隐藏的登录页面显示
                    Program.m_LoginForm.Show();

                    isClosePage = true;
                }
                    
            }
            return isClosePage;
        }

        private void btnInitialValue_Click(object sender, EventArgs e)
        {
            BaseInfoForm formBaseInfo = new BaseInfoForm();
            formBaseInfo.ShowDialog();
        }
        
        // 支出
        private void btnExpenditure_Click(object sender, EventArgs e)
        {
            SpendingAccountsForm form = new SpendingAccountsForm();
            form.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // 获取按钮
            TzxRoundedButton btn = sender as TzxRoundedButton;
            if (btn == null)
            {
                return;
            }
            string btnName = btn.Name;
            switch (btnName)
            {
                case "btnIncome":
                    IncomeAccountsForm form = new IncomeAccountsForm();
                    form.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
