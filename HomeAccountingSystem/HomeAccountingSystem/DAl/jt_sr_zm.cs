/**  版本信息模板在安装目录下，可自行修改。
* jt_sr_zm.cs
*
* 功 能： N/A
* 类 名： jt_sr_zm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 21:15:54   N/A    初版                
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;                       
namespace HomeAccountingSystem.DAL
{
	/// <summary>
	/// 数据访问类:jt_sr_zm
	/// </summary>
	public partial class jt_sr_zm
	{
		public jt_sr_zm()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SQLServerHelper.GetMaxID("pk", "jt_sr_zm"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from jt_sr_zm");
			strSql.Append(" where pk=@pk ");
			SqlParameter[] parameters = {
					new SqlParameter("@pk", SqlDbType.Int,4)			};
			parameters[0].Value = pk;

			return SQLServerHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HomeAccountingSystem.Model.jt_sr_zm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into jt_sr_zm(");
			strSql.Append("v_srzm_no,v_srzm_name,t_xf_time,v_srlx_no,v_srlx_name,v_remark,v_jz_user_pk,v_jz_user_name,t_create_time,i_delete,f_sr_money,v_zffs_no,v_zffs_name,v_who)");
			strSql.Append(" values (");
			strSql.Append("@v_srzm_no,@v_srzm_name,@t_xf_time,@v_srlx_no,@v_srlx_name,@v_remark,@v_jz_user_pk,@v_jz_user_name,@t_create_time,@i_delete,@f_sr_money,@v_zffs_no,@v_zffs_name,@v_who)");
			SqlParameter[] parameters = {
					new SqlParameter("@pk", SqlDbType.Int,4),
					new SqlParameter("@v_srzm_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_srzm_name", SqlDbType.VarChar,256),
					new SqlParameter("@t_xf_time", SqlDbType.DateTime),
					new SqlParameter("@v_srlx_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_srlx_name", SqlDbType.VarChar,256),
					new SqlParameter("@v_remark", SqlDbType.VarChar,256),
					new SqlParameter("@v_jz_user_pk", SqlDbType.VarChar,4000),
					new SqlParameter("@v_jz_user_name", SqlDbType.VarChar,256),
					new SqlParameter("@t_create_time", SqlDbType.DateTime),
					new SqlParameter("@i_delete", SqlDbType.Int,4),
					new SqlParameter("@f_sr_money", SqlDbType.Float,8),
					new SqlParameter("@v_zffs_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_zffs_name", SqlDbType.VarChar,256),
                    new SqlParameter("@v_who", SqlDbType.VarChar,256),

            };
			parameters[0].Value = model.pk;
			parameters[1].Value = model.v_srzm_no;
			parameters[2].Value = model.v_srzm_name;
			parameters[3].Value = model.t_xf_time;
			parameters[4].Value = model.v_srlx_no;
			parameters[5].Value = model.v_srlx_name;
			parameters[6].Value = model.v_remark;
			parameters[7].Value = model.v_jz_user_pk;
			parameters[8].Value = model.v_jz_user_name;
			parameters[9].Value = model.t_create_time;
			parameters[10].Value = model.i_delete;
			parameters[11].Value = model.f_sr_money;
			parameters[12].Value = model.v_zffs_no;
			parameters[13].Value = model.v_zffs_name; 
            parameters[14].Value = model.v_who;
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
		public bool Update(HomeAccountingSystem.Model.jt_sr_zm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update jt_sr_zm set ");
			strSql.Append("v_srzm_no=@v_srzm_no,");
			strSql.Append("v_srzm_name=@v_srzm_name,");
			strSql.Append("t_xf_time=@t_xf_time,");
			strSql.Append("v_srlx_no=@v_srlx_no,");
			strSql.Append("v_srlx_name=@v_srlx_name,");
			strSql.Append("v_remark=@v_remark,");
			strSql.Append("v_jz_user_pk=@v_jz_user_pk,");
			strSql.Append("v_jz_user_name=@v_jz_user_name,");
			strSql.Append("t_create_time=@t_create_time,");
			strSql.Append("i_delete=@i_delete,");
			strSql.Append("f_sr_money=@f_sr_money,");
			strSql.Append("v_zffs_no=@v_zffs_no,");
			strSql.Append("v_zffs_name=@v_zffs_name,");
            strSql.Append("v_who=@v_who");
            strSql.Append(" where pk=@pk ");
			SqlParameter[] parameters = {
					new SqlParameter("@v_srzm_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_srzm_name", SqlDbType.VarChar,256),
					new SqlParameter("@t_xf_time", SqlDbType.DateTime),
					new SqlParameter("@v_srlx_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_srlx_name", SqlDbType.VarChar,256),
					new SqlParameter("@v_remark", SqlDbType.VarChar,256),
					new SqlParameter("@v_jz_user_pk", SqlDbType.VarChar,4000),
					new SqlParameter("@v_jz_user_name", SqlDbType.VarChar,256),
					new SqlParameter("@t_create_time", SqlDbType.DateTime),
					new SqlParameter("@i_delete", SqlDbType.Int,4),
					new SqlParameter("@f_sr_money", SqlDbType.Float,8),
					new SqlParameter("@v_zffs_no", SqlDbType.VarChar,256),
					new SqlParameter("@v_zffs_name", SqlDbType.VarChar,256),
                    new SqlParameter("@v_who", SqlDbType.VarChar,256),
                    new SqlParameter("@pk", SqlDbType.Int,4)};
			parameters[0].Value = model.v_srzm_no;
			parameters[1].Value = model.v_srzm_name;
			parameters[2].Value = model.t_xf_time;
			parameters[3].Value = model.v_srlx_no;
			parameters[4].Value = model.v_srlx_name;
			parameters[5].Value = model.v_remark;
			parameters[6].Value = model.v_jz_user_pk;
			parameters[7].Value = model.v_jz_user_name;
			parameters[8].Value = model.t_create_time;
			parameters[9].Value = model.i_delete;
			parameters[10].Value = model.f_sr_money;
			parameters[11].Value = model.v_zffs_no;
			parameters[12].Value = model.v_zffs_name; 
            parameters[13].Value = model.v_who;
            parameters[14].Value = model.pk;

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
			strSql.Append("delete from jt_sr_zm ");
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
			strSql.Append("delete from jt_sr_zm ");
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
		public HomeAccountingSystem.Model.jt_sr_zm GetModel(int pk)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pk,v_srzm_no,v_srzm_name,t_xf_time,v_srlx_no,v_srlx_name,v_remark,v_jz_user_pk,v_jz_user_name,t_create_time,i_delete,f_sr_money,v_zffs_no,v_zffs_name,v_who from jt_sr_zm ");
			strSql.Append(" where pk=@pk ");
			SqlParameter[] parameters = {
					new SqlParameter("@pk", SqlDbType.Int,4)			};
			parameters[0].Value = pk;

			HomeAccountingSystem.Model.jt_sr_zm model=new HomeAccountingSystem.Model.jt_sr_zm();
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
		public HomeAccountingSystem.Model.jt_sr_zm DataRowToModel(DataRow row)
		{
			HomeAccountingSystem.Model.jt_sr_zm model=new HomeAccountingSystem.Model.jt_sr_zm();
			if (row != null)
			{
				if(row["pk"]!=null && row["pk"].ToString()!="")
				{
					model.pk=int.Parse(row["pk"].ToString());
				}
				if(row["v_srzm_no"]!=null)
				{
					model.v_srzm_no=row["v_srzm_no"].ToString();
				}
				if(row["v_srzm_name"]!=null)
				{
					model.v_srzm_name=row["v_srzm_name"].ToString();
				}
				if(row["t_xf_time"]!=null && row["t_xf_time"].ToString()!="")
				{
					model.t_xf_time=DateTime.Parse(row["t_xf_time"].ToString());
				}
				if(row["v_srlx_no"]!=null)
				{
					model.v_srlx_no=row["v_srlx_no"].ToString();
				}
				if(row["v_srlx_name"]!=null)
				{
					model.v_srlx_name=row["v_srlx_name"].ToString();
				}
				if(row["v_remark"]!=null)
				{
					model.v_remark=row["v_remark"].ToString();
				}
				if(row["v_jz_user_pk"]!=null)
				{
					model.v_jz_user_pk=row["v_jz_user_pk"].ToString();
				}
				if(row["v_jz_user_name"]!=null)
				{
					model.v_jz_user_name=row["v_jz_user_name"].ToString();
				}
				if(row["t_create_time"]!=null && row["t_create_time"].ToString()!="")
				{
					model.t_create_time=DateTime.Parse(row["t_create_time"].ToString());
				}
				if(row["i_delete"]!=null && row["i_delete"].ToString()!="")
				{
					model.i_delete=int.Parse(row["i_delete"].ToString());
				}
				if(row["f_sr_money"]!=null && row["f_sr_money"].ToString()!="")
				{
					model.f_sr_money=decimal.Parse(row["f_sr_money"].ToString());
				}
				if(row["v_zffs_no"]!=null)
				{
					model.v_zffs_no=row["v_zffs_no"].ToString();
				}
				if(row["v_zffs_name"]!=null)
				{
					model.v_zffs_name=row["v_zffs_name"].ToString();
                }
                if (row["v_who"] != null)
                {
                    model.v_who = row["v_who"].ToString();
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
			strSql.Append("select pk,v_srzm_no,v_srzm_name,t_xf_time,v_srlx_no,v_srlx_name,v_remark,v_jz_user_pk,v_jz_user_name,t_create_time,i_delete,f_sr_money,v_zffs_no,v_zffs_name,v_who ");
			strSql.Append(" FROM jt_sr_zm ");
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
			strSql.Append(" pk,v_srzm_no,v_srzm_name,t_xf_time,v_srlx_no,v_srlx_name,v_remark,v_jz_user_pk,v_jz_user_name,t_create_time,i_delete,f_sr_money,v_zffs_no,v_zffs_name,v_who ");
			strSql.Append(" FROM jt_sr_zm ");
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
			strSql.Append("select count(1) FROM jt_sr_zm ");
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
			strSql.Append(")AS Row, T.*  from jt_sr_zm T ");
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
			parameters[0].Value = "jt_sr_zm";
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

