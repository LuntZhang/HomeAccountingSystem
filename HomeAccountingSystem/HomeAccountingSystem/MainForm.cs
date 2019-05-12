using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.MainUserControl;

namespace HomeAccountingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // 退出系统
        public bool m_isTuichu = true;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.topUserInfoUserControl1.delegateCloseMainPage = delegateCloseMainPage;
        }

        private void delegateCloseMainPage(bool isTuichu)
        {
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
                if (MessageBox.Show("确定要注销系统？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // 隐藏的登录页面显示
                    Program.m_LoginForm.Show();

                    isClosePage = true;
                }
            }
            return isClosePage;
        }
    }
}
