using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.Model;

namespace HomeAccountingSystem.BaseInformation.ExpendType
{
    public partial class ExpendTypeForm : Form
    {
        public ExpendTypeForm()
        {
            InitializeComponent();
        }

        // 要删除的pk集合
        private ArrayList m_pkArray = new ArrayList();

        private void ExpendTypeForm_Load(object sender, EventArgs e)
        {
            loadDataList();
        }

        /// <summary>
        ///  从数据库刷新
        /// </summary>
        private void loadDataList()
        {
            this.gridControlDataList.DataSource = ExpendTypeManager.Instance.ExpendTypeDataList();
        }
        /// <summary>
        /// 编辑页面刷新
        /// </summary>
        private void loadEditData()
        {
            if (this.gridViewDataList.RowCount == 0)
            {
                return;
            }
            int rowCount = this.gridViewDataList.RowCount;
            int row = 1;
            int no = 1;
            for (int i = 0; i < rowCount; i++)
            {
                if (i == 0)
                {
                    this.gridViewDataList.SetRowCellValue(i, "row", 1);
                    this.gridViewDataList.SetRowCellValue(i, "v_zc_no", 1001);
                }
                else
                {
                    row = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(i - 1, "row").ToString());
                    no = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(i - 1, "v_zc_no").ToString());
                    this.gridViewDataList.SetRowCellValue(i, "row", row + 1);
                    this.gridViewDataList.SetRowCellValue(i, "v_zc_no", no + 1);
                }
            }
        }

        // 新增按钮
        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            string row = "";
            string no = "";
            if (this.gridViewDataList.RowCount > 0)
            {
                row = this.gridViewDataList.GetRowCellValue(this.gridViewDataList.RowCount - 1, "row").ToString();
                no = this.gridViewDataList.GetRowCellValue(this.gridViewDataList.RowCount - 1, "v_zc_no").ToString();
                string name = this.gridViewDataList.GetRowCellValue(this.gridViewDataList.RowCount - 1, "v_zclx_name").ToString();
                if(string.IsNullOrEmpty(row) || string.IsNullOrEmpty(no) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("不能填空值！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
   
            DataTable dt = (DataTable)this.gridControlDataList.DataSource;
            if (dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("row");
                dt.Columns.Add("v_zc_no");
                dt.Columns.Add("v_zclx_name");
                dt.Columns.Add("pk");
            }
            DataRow dr = dt.NewRow();
            if(!string.IsNullOrEmpty(row))
            {
                dr["row"] = Convert.ToInt32(row) + 1;
                dr["v_zc_no"] = Convert.ToInt32(no) + 1;
                dr["pk"] = -1;
            }
            else
            {
                dr["row"] = 1;
                dr["v_zc_no"] = 1001;
                dr["pk"] = -1;
            }
            dt.Rows.Add(dr);
            this.gridControlDataList.DataSource = dt;
            this.gridViewDataList.RefreshData();
            this.gridViewDataList.FocusedRowHandle = this.gridViewDataList.RowCount - 1;
            this.gridViewDataList.FocusedColumn = this.gridViewDataList.Columns["v_zclx_name"]; //设置焦点列
            this.gridViewDataList.ShowEditor();
        }

        // 保存按钮
        private void buttonXSave_Click(object sender, EventArgs e)
        {
            int rowCount = this.gridViewDataList.RowCount;
            int success = rowCount;
            int pk = -2;
            jt_zc_lx zclxModel = null;
            string row = null;
            string no = null;
            for (int i=0; i<rowCount;i++)
            {
                row = this.gridViewDataList.GetRowCellValue(i, "row").ToString();
                no = this.gridViewDataList.GetRowCellValue(i, "v_zc_no").ToString();
                string name = this.gridViewDataList.GetRowCellValue(i, "v_zclx_name").ToString();
                if (string.IsNullOrEmpty(row) || string.IsNullOrEmpty(no) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("不能填空值！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pk = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(i,"pk").ToString());
                if (pk > -1)    // 修改
                {
                    zclxModel = ExpendTypeManager.Instance.GetModel(pk);
                    zclxModel.v_zc_no = this.gridViewDataList.GetRowCellValue(i, "v_zc_no").ToString();
                    zclxModel.v_zclx_name = this.gridViewDataList.GetRowCellValue(i, "v_zclx_name").ToString();
                    bool isSuccessUpdate = ExpendTypeManager.Instance.Update(zclxModel);
                    if(isSuccessUpdate)
                    {
                        success--;
                    }
                }
                else   // 新增
                {
                    zclxModel = new jt_zc_lx();
                    zclxModel.v_zc_no =this.gridViewDataList.GetRowCellValue(i, "v_zc_no").ToString();
                    zclxModel.v_zclx_name = this.gridViewDataList.GetRowCellValue(i, "v_zclx_name").ToString();
                    zclxModel.t_create_time = DateTime.Now;
                    bool isSuccessAdd = ExpendTypeManager.Instance.Add(zclxModel);
                    if (isSuccessAdd)
                    {
                        success--;
                    }
                }
            }
            // 删除
            if (m_pkArray.Count > 0)
            {
                foreach (int item in m_pkArray)
                {
                    bool isSuccessDelete = ExpendTypeManager.Instance.Delete(item);
                    if (isSuccessDelete)
                    {
                        success--;
                    }
                }
            
            }
            if(success == 0)
            {
                MessageBox.Show("保存成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 删除按钮
        private void buttonXDelete_Click(object sender, EventArgs e)
        {
            if (this.gridViewDataList.SelectedRowsCount == 0)
            {
                MessageBox.Show("请选择一行数据进行操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pk = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(this.gridViewDataList.FocusedRowHandle, "pk").ToString());
            if (pk > -1)
            {
                this.gridViewDataList.DeleteRow(this.gridViewDataList.GetSelectedRows()[0]);
                m_pkArray.Add(pk);
            }
            else
            {
                this.gridViewDataList.DeleteRow(this.gridViewDataList.GetSelectedRows()[0]);
            }
            this.loadEditData();
        }

        // 退出按钮
        private void buttonXExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // 刷新按钮
        private void tzxButtonExRefresh_Click(object sender, EventArgs e)
        {
            this.loadDataList();
        }
    }
}
