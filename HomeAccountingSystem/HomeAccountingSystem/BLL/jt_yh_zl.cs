﻿/**  
* jt_yh_zl.cs
*
* 功 能： N/A
* 类 名： jt_yh_zl
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 21:15:54   N/A    初版        
*/
using System;
using System.Data;
using System.Collections.Generic;     
using HomeAccountingSystem.Model;
namespace HomeAccountingSystem.BLL
{
	/// <summary>
	/// 用户资料表
	/// </summary>
	public partial class jt_yh_zl
	{
        #region Instance
        private static jt_yh_zl instance = new jt_yh_zl();
        public static jt_yh_zl Instance
        {
            get { return jt_yh_zl.instance; }
        }

        #endregion
        private readonly HomeAccountingSystem.DAL.jt_yh_zl dal=new HomeAccountingSystem.DAL.jt_yh_zl();
		public jt_yh_zl()
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
		public bool Add(HomeAccountingSystem.Model.jt_yh_zl model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HomeAccountingSystem.Model.jt_yh_zl model)
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
		public HomeAccountingSystem.Model.jt_yh_zl GetModel(int pk)
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
		public List<HomeAccountingSystem.Model.jt_yh_zl> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HomeAccountingSystem.Model.jt_yh_zl> DataTableToList(DataTable dt)
		{
			List<HomeAccountingSystem.Model.jt_yh_zl> modelList = new List<HomeAccountingSystem.Model.jt_yh_zl>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HomeAccountingSystem.Model.jt_yh_zl model;
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
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string account, string password)
        {
            return dal.Exists(account, password);
        }
        #endregion  ExtensionMethod
    }
}

