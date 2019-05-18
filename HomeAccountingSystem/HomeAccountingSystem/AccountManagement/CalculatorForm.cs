using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TZXControlLibrary.ButtonEx;

namespace HomeAccountingSystem.AccountManagement
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        // 输入的整体
        private string m_inputAll = "";
        // 输入的当前值
        private string m_currentInputValue = "0";
        // 当前计算值
        public decimal m_currentNumber = 0;
        // 上次按钮的值
        private string m_beforeBtnValue = null;
        // 上次按键的运算符号 
        private string m_beforeSymbol = null;

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            loadPage();
        }

        /// <summary>
        /// 页面加载
        /// </summary>
        private void loadPage()
        {
            this.richTextBoxInputOperation.Text = m_inputAll;
            this.labelNumber.Text = m_currentInputValue;
        }

        /// <summary>
        /// 全部按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            // 获取按钮的Text值
            TzxButtonEx btn = sender as TzxButtonEx;
            if(btn == null)
            {
                return;
            }
            string content = btn.Text.Trim();
            // 判断这次输入是否是数字
            if (Regex.IsMatch(content, @"^[+-]?\d*$"))
            {
                this.isNumber(content);
            }
            else
            {
                this.isSymbol(content);
            }
            m_beforeBtnValue = content;
            //if(content!="＝")
            //{
            //    m_inputAll += content;
            //}

            if ("＋－×÷＝".Contains(content))
            {
                m_beforeSymbol = content;
            }
            loadPage();
        }

        private decimal mathematicalOperation(decimal value)
        {
            decimal operationValue = 0;
            switch (m_beforeSymbol)
            {
                case "＋":
                    operationValue = m_currentNumber + value;
                    break;
                case "－":
                    operationValue = m_currentNumber - value;
                    break;
                case "×":
                    operationValue = m_currentNumber * value;
                    break;
                case "÷":
                    operationValue = m_currentNumber / value;
                    break;
                case "＝":
                    operationValue = m_currentNumber;
                    break;
                default:
                    break;
            }
            return operationValue;
        }

        private void isSymbol(string content)
        {
            // 判断上次的输入
            // 1>上次输入是空
            if (m_beforeBtnValue == null)
            {
                m_currentNumber = Convert.ToDecimal(m_currentInputValue);
                // 显示
                m_currentInputValue = m_currentNumber.ToString().Trim();
            }
            // 2>上次输入不是空，是数字
            else if(Regex.IsMatch(m_beforeBtnValue, @"^[+-]?\d*$"))
            {
                // 判断上次的操作符
                // 上次操作符为空 
                if (m_beforeSymbol == null)
                {
                    m_currentNumber = Convert.ToDecimal(m_currentInputValue);
                    m_currentInputValue = m_currentNumber.ToString().Trim();
                }
                else    //不为空则计算
                {
                    m_currentNumber = mathematicalOperation(Convert.ToDecimal(m_currentInputValue));
                    m_currentInputValue = m_currentNumber.ToString();
                }
                m_inputAll += content;
            }
            else
            {
                m_inputAll = m_inputAll.Remove(m_inputAll.Length -1);
                m_inputAll += content;
            }
        }
        /// <summary>
        /// 当前输入的是数字
        /// </summary>
        private void isNumber(string content)
        {
            // 判断上次的输入
            // 1>上次输入是空
            if(m_beforeBtnValue == null)
            {
                m_currentInputValue = content.Trim();
                m_inputAll = content;
            }
            // 2>上次输入不是空，是数字
            else if(Regex.IsMatch(m_beforeBtnValue, @"^[+-]?\d*$"))
            {
                // 是数字则后缀添加
                m_currentInputValue = m_currentInputValue.Trim() + content.Trim();
                m_inputAll += content;
            }
            // 3>上次输入不是空，是符号＋－×÷
            else if("＋－×÷".Contains(m_beforeBtnValue))
            {
                m_currentInputValue = content.Trim();
                m_inputAll += content;
            }
            // 4>上次输入不是空，是符号＝
            else if (m_beforeBtnValue == "＝")
            {
                m_currentInputValue = content.Trim();
                //清理之前计算的值
                m_inputAll = content;
                m_currentNumber = 0;
            } 
        }

        // CE 清理当前
        private void btnClearError_Click(object sender, EventArgs e)
        {
            m_beforeBtnValue = m_beforeSymbol;
            m_inputAll = m_inputAll.Remove(m_inputAll.Length - m_currentInputValue.Length);
            m_currentInputValue = "";
            loadPage();
        }

        // C 清理全部
        private void buttonXClear_Click(object sender, EventArgs e)
        {
            m_currentInputValue = "";
            m_currentNumber = 0;
            m_inputAll = "";
            m_beforeBtnValue = null;
            m_beforeSymbol = null;
            loadPage();
        }

        // <- 退格
        private void btnBS_Click(object sender, EventArgs e)
        {
            if(m_currentInputValue != null&& m_currentInputValue.Length>0)
            {
                m_currentInputValue = m_currentInputValue.Remove(m_currentInputValue.Length-1);
            }
            loadPage();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void btnESC_Click(object sender, EventArgs e)
        {
            m_currentNumber = 0;
            base.Close();
        }
    }
}
