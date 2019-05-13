using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace HomeAccountingSystem.BaseInformation
{
    public partial class BaseInfoForm : Form
    {
        public BaseInfoForm()
        {
            InitializeComponent();
        }

        private void metroTileItem_Click(object sender, EventArgs e)
        {
            if (sender is MetroTileItem)
            {
                MetroTileItem toolStripButton = (MetroTileItem)sender;
                if (toolStripButton.Tag != null)
                {
                    string text = toolStripButton.Tag.ToString();
                    //string short_name = text.Substring(text.LastIndexOf(".") + 1);

                    // 使用反射打开页面
                    this.activeLoadForm(text);
                }
            }
        }

        /// <summary>
        ///  使用反射打开新页面
        /// </summary>
        /// <param name="long_formname"></param>
        /// <param name="short_formname"></param>
        public void activeLoadForm(string long_formname)
        {
            Form form = null;
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            form = (Form)executingAssembly.CreateInstance(long_formname);
            form.Owner = this;
            //form = (Form)Assembly.Load(long_formname).CreateInstance(short_formname);
            if (form != null)
            {
                form.Owner = this;
            }
            if (form != null)
            {
                if (form.WindowState != FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                form.ShowDialog();
            }
        }
    }
}
