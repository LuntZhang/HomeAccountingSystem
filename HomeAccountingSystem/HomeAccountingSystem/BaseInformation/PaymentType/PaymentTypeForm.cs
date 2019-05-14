using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.Model;

namespace HomeAccountingSystem.BaseInformation.PaymentType
{
    public  enum PayType
    {
        Cash = 0,
        WeChat =1,
        Alipay = 2,
        BankCard = 3
    }

    public partial class PaymentTypeForm : Form
    {
        public PaymentTypeForm()
        {
            InitializeComponent();
        }

        private int m_selectRow = 0;  //选中行

        private void PaymentTypeForm_Load(object sender, EventArgs e)
        {
            this.loadDataList();
        }

        /// <summary>
        /// 加载页面数据
        /// </summary>
        public void loadDataList()
        {
            this.gridControlDataList.DataSource = PaymentTypeManager.Instance.PaymentTypeDataList();
            this.selectRow();
        }

        /// <summary>
        /// 选中行
        /// </summary>
        public void selectRow()
        {
            if (this.gridViewDataList.RowCount==0)
            {
                return;
            }
            this.gridViewDataList.FocusedRowHandle = m_selectRow;
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            EditPaymentTypeForm formEditPaymentType = new EditPaymentTypeForm();
            formEditPaymentType.m_paymentTypeForm = this;
            formEditPaymentType.ShowDialog();
        }

        private void buttonXModify_Click(object sender, EventArgs e)
        {
            if (this.gridViewDataList.RowCount == 0)
            {
                MessageBox.Show("没有可修改数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.gridViewDataList.SelectedRowsCount == 0)
            {
                MessageBox.Show("请选择一条数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            m_selectRow = this.gridViewDataList.FocusedRowHandle;
            // 取出pk
            int selectRow = this.gridViewDataList.GetSelectedRows()[0];
            int pk = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(selectRow, "pk").ToString());
            jt_zffs zffsModel = PaymentTypeManager.Instance.GetModel(pk);
            //打开页面
            EditPaymentTypeForm formEditPaymentType = new EditPaymentTypeForm();
            formEditPaymentType.m_paymentTypeForm = this;
            formEditPaymentType.m_zffsModel = zffsModel;
            formEditPaymentType.ShowDialog();
        }

        private void buttonXDelete_Click(object sender, EventArgs e)
        {
            if (this.gridViewDataList.SelectedRowsCount == 0)
            {
                MessageBox.Show("请选择一条数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 取出pk
            int selectRow = this.gridViewDataList.GetSelectedRows()[0];
            int pk = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(selectRow, "pk").ToString());
            bool isSuccess = PaymentTypeManager.Instance.Delete(pk);
            if (isSuccess)
            {
                MessageBox.Show("删除成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.loadDataList();
            }
            else
            {
                MessageBox.Show("删除失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonXRefresh_Click(object sender, EventArgs e)
        {
            this.loadDataList();
        }

        private void buttonXExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void gridControlDataList_DoubleClick(object sender, EventArgs e)
        {
            this.buttonXModify_Click(null,null);
        }
    }
}
