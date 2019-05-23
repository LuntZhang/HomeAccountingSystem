/**  版本信息模板在安装目录下，可自行修改。
* jt_ys_zm.cs
*
* 功 能： N/A
* 类 名： jt_ys_zm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 21:15:55   N/A    初版　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;                            
namespace HomeAccountingSystem.DAL
{
	/// <summary>
	/// 数据访问类:jt_ys_zm
	/// </summary>
	public partial class jt_ys_zm
	{
		public jt_ys_zm()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SQLServerHelper.GetMaxID("pk", "jt_ys_zm"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from jt_ys_zm");
			strSql.Append(" where pk=@pk ");
			SqlParameter[] parameters = {
					new SqlParameter("@pk", SqlDbType.Int,4)			};
			parameters[0].Value = pk;

			return SQLServerHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HomeAccountingSystem.Model.jt_ys_zm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into jt_ys_zm(");
			strSql.Append("v_yszm_no,v_yszm_name,t_date_start,t_date_end,f_ys_money,v_remark,t_create_time,i_delete,v_jz_user_pk,v_jz_user_name)");
			strSql.Append(" values (");
			strSql.Append("@v_yszm_no,@v_yszm_name,@t_date_start,@t_date_end,@f_ys_money,@v_remark,@t_create_time,@i_delete,@v_jz_user_pk,@v_jz_user_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@pk", SqlDbType.Int,4),
					new SqlParameter("@v_yszm_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_yszm_name", SqlDbType.VarChar,256),
					new SqlParameter("@t_date_start", SqlDbType.DateTime),
					new SqlParameter("@t_date_end", SqlDbType.DateTime),
					new SqlParameter("@f_ys_money", SqlDbType.Float,8),
					new SqlParameter("@v_remark", SqlDbType.VarChar,256),
					new SqlParameter("@t_create_time", SqlDbType.DateTime),
					new SqlParameter("@i_delete", SqlDbType.Int,4),
                    new SqlParameter("@v_jz_user_pk", SqlDbType.VarChar,256),
                    new SqlParameter("@v_jz_user_name", SqlDbType.VarChar,256),
 
            };
			parameters[0].Value = model.pk;
			parameters[1].Value = model.v_yszm_no;
			parameters[2].Value = model.v_yszm_name;
			parameters[3].Value = model.t_date_start;
			parameters[4].Value = model.t_date_end;
			parameters[5].Value = model.f_ys_money;
			parameters[6].Value = model.v_remark;
			parameters[7].Value = model.t_create_time;
			parameters[8].Value = model.i_delete; 
            parameters[9].Value = model.v_jz_user_pk;
            parameters[10].Value = model.v_jz_user_name;                                                                             
            int rows=SQLServerHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HomeAccountingSystem.Model.jt_ys_zm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update jt_ys_zm set ");
			strSql.Append("v_yszm_no=@v_yszm_no,");
			strSql.Append("v_yszm_name=@v_yszm_name,");
			strSql.Append("t_date_start=@t_date_start,");
			strSql.Append("t_date_end=@t_date_end,");
			strSql.Append("f_ys_money=@f_ys_money,");
			strSql.Append("v_remark=@v_remark,");
			strSql.Append("t_create_time=@t_create_time,");
			strSql.Append("i_delete=@i_delete,"); 
            strSql.Append("v_jz_user_pk=@v_jz_user_pk,");
            strSql.Append("v_jz_user_name=@v_jz_user_name");
            strSql.Append(" where pk=@pk ");
			SqlParameter[] parameters = {
					new SqlParameter("@v_yszm_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_yszm_name", SqlDbType.VarChar,256),
					new SqlParameter("@t_date_start", SqlDbType.DateTime),
					new SqlParameter("@t_date_end", SqlDbType.DateTime),
					new SqlParameter("@f_ys_money", SqlDbType.Float,8),
					new SqlParameter("@v_remark", SqlDbType.VarChar,256),
					new SqlParameter("@t_create_time", SqlDbType.DateTime),
					new SqlParameter("@i_delete", SqlDbType.Int,4),
                    new SqlParameter("@v_jz_user_pk", SqlDbType.VarChar,256),
                    new SqlParameter("@v_jz_user_name", SqlDbType.VarChar,256),
                    new SqlParameter("@pk", SqlDbType.Int,4)};
			parameters[0].Value = model.v_yszm_no;
			parameters[1].Value = model.v_yszm_name;
			parameters[2].Value = model.t_date_start;
			parameters[3].Value = model.t_date_end;
			parameters[4].Value = model.f_ys_money;
			parameters[5].Value = model.v_remark;
			parameters[6].Value = model.t_create_time;
			parameters[7].Value = model.i_delete; 
            parameters[8].Value = model.v_jz_user_pk;
            parameters[9].Value = model.v_jz_user_name;
            parameters[10].Value = model.pk;

			int rows=SQLServerHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int pk)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from jt_ys_zm ");
			strSql.Append(" where pk=@pk ");
			SqlParameter[] parameters = {
					new SqlParameter("@pk", SqlDbType.Int,4)			};
			parameters[0].Value = pk;

			int rows=SQLServerHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string pklist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from jt_ys_zm ");
			strSql.Append(" where pk in ("+pklist + ")  ");
			int rows=SQLServerHelper.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HomeAccountingSystem.Model.jt_ys_zm GetModel(int pk)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pk,v_yszm_no,v_yszm_name,t_date_start,t_date_end,f_ys_money,v_remark,t_create_time,i_delete,v_jz_user_pk,v_jz_user_name from jt_ys_zm ");
			strSql.Append(" where pk=@pk ");
			SqlParameter[] parameters = {
					new SqlParameter("@pk", SqlDbType.Int,4)			};
			parameters[0].Value = pk;

			HomeAccountingSystem.Model.jt_ys_zm model=new HomeAccountingSystem.Model.jt_ys_zm();
			DataSet ds=SQLServerHelper.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HomeAccountingSystem.Model.jt_ys_zm DataRowToModel(DataRow row)
		{
			HomeAccountingSystem.Model.jt_ys_zm model=new HomeAccountingSystem.Model.jt_ys_zm();
			if (row != null)
			{
				if(row["pk"]!=null && row["pk"].ToString()!="")
				{
					model.pk=int.Parse(row["pk"].ToString());
				}
				if(row["v_yszm_no"]!=null)
				{
					model.v_yszm_no=row["v_yszm_no"].ToString();
				}
				if(row["v_yszm_name"]!=null)
				{
					model.v_yszm_name=row["v_yszm_name"].ToString();
				}
				if(row["t_date_start"]!=null && row["t_date_start"].ToString()!="")
				{
					model.t_date_start=DateTime.Parse(row["t_date_start"].ToString());
				}
				if(row["t_date_end"]!=null && row["t_date_end"].ToString()!="")
				{
					model.t_date_end=DateTime.Parse(row["t_date_end"].ToString());
				}
				if(row["f_ys_money"]!=null && row["f_ys_money"].ToString()!="")
				{
					model.f_ys_money=decimal.Parse(row["f_ys_money"].ToString());
				}
				if(row["v_remark"]!=null)
				{
					model.v_remark=row["v_remark"].ToString();
				}
				if(row["t_create_time"]!=null && row["t_create_time"].ToString()!="")
				{
					model.t_create_time=DateTime.Parse(row["t_create_time"].ToString());
				}
				if(row["i_delete"]!=null && row["i_delete"].ToString()!="")
				{
					model.i_delete=int.Parse(row["i_delete"].ToString());
                }    
                if (row["v_jz_user_pk"] != null)
                {
                    model.v_jz_user_pk = row["v_jz_user_pk"].ToString();
                }
                if (row["v_jz_user_name"] != null)
                {
                    model.v_jz_user_name = row["v_jz_user_name"].ToString();
                }
            }
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select pk,v_yszm_no,v_yszm_name,t_date_start,t_date_end,f_ys_money,v_remark,t_create_time,i_delete,v_jz_user_pk,v_jz_user_name ");
			strSql.Append(" FROM jt_ys_zm ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLServerHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" pk,v_yszm_no,v_yszm_name,t_date_start,t_date_end,f_ys_money,v_remark,t_create_time,i_delete,v_jz_user_pk,v_jz_user_name ");
			strSql.Append(" FROM jt_ys_zm ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return SQLServerHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM jt_ys_zm ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = SQLServerHelper.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.pk desc");
			}
			strSql.Append(")AS Row, T.*  from jt_ys_zm T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return SQLServerHelper.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "jt_ys_zm";
			parameters[1].Value = "pk";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return SQLServerHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

