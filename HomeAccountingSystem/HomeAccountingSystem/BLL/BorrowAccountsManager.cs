﻿/**  
* jt_jr_zm.cs
*
* 功 能： N/A
* 类 名： jt_jr_zm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 21:15:52   N/A    初版  
*/
using System;
using System.Data;
using System.Collections.Generic;
using HomeAccountingSystem.Model;
namespace HomeAccountingSystem.BLL
{
	/// <summary>
	/// 借入账目表
	/// </summary>
	public partial class BorrowAccountsManager
	{
        #region

        private static BorrowAccountsManager instance = new BorrowAccountsManager();

        public static BorrowAccountsManager Instance
        {
            get
            {
                return BorrowAccountsManager.instance;
            }
        }

        #endregion

        private readonly HomeAccountingSystem.DAL.jt_jr_zm dal=new HomeAccountingSystem.DAL.jt_jr_zm();
		public BorrowAccountsManager()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk)
		{
			return dal.Exists(pk);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HomeAccountingSystem.Model.jt_jr_zm model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HomeAccountingSystem.Model.jt_jr_zm model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int pk)
		{
			
			return dal.Delete(pk);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HomeAccountingSystem.Model.jt_jr_zm GetModel(int pk)
		{
			
			return dal.GetModel(pk);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HomeAccountingSystem.Model.jt_jr_zm> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HomeAccountingSystem.Model.jt_jr_zm> DataTableToList(DataTable dt)
		{
			List<HomeAccountingSystem.Model.jt_jr_zm> modelList = new List<HomeAccountingSystem.Model.jt_jr_zm>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HomeAccountingSystem.Model.jt_jr_zm model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public DataTable getBorrowAccountsData(DateTime startTime, DateTime endTime)
        {
            string strTime = string.Format("t_jr_time>='{0}' and t_jr_time<='{1}'", startTime, endTime);
            string strSql = string.Format(
                 strTime + "  order by t_create_time desc"
                );
            DataTable dataTable = null;
            DataSet dataSet = this.GetList(strSql);
            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dataTable = dataSet.Tables[0];
            }
            dataTable.Columns.Add("row", typeof(string));
            dataTable.Columns.Add("v_accrual", typeof(string));
            dataTable.Columns.Add("b_gh_flag", typeof(bool));
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                int index = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    index++;
                    item["row"] = index;
                    item["v_accrual"] = item["f_accrual"].ToString() + "%";
                    item["b_gh_flag"] = item["i_gh_flag"].ToString() == "1" ? true : false;
                }
            }
            return dataTable;
        }
        #endregion  ExtensionMethod
    }
}

