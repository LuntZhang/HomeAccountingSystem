using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeAccountingSystem.Utility
{
    class MessageBoxFunction
    {
        /// <summary>
        /// 询问/删除提示信息
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool showQuestionMessageBox(string content)
        {
            return (MessageBox.Show(content, "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }

        /// <summary>
        /// 警告提示提示信息
        /// </summary>
        /// <param name="prompString"></param>
        public static void showWarningMessageBox(string content)
        {
            MessageBox.Show(content, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 提示保存成功
        /// </summary>
        /// <param name="prompString"></param>
        public static void showSaveSuccessMessageBox()
        {
            MessageBox.Show("保存成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 通用提示提示信息
        /// </summary>
        /// <param name="prompString"></param>
        public static void showInfoMessageBox(string content)
        {
            MessageBox.Show(content, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示通用确认提示信息框
        /// </summary>
        /// <param name="prompString">提示内容字符串</param>
        public static bool showVerifyInfoMessageBox(string content)
        {
            return (MessageBox.Show(content, "系统消息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK);
        }
    }
}
