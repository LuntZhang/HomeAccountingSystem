/**  版本信息模板在安装目录下，可自行修改。
* jt_ys_zm.cs
*
* 功 能： N/A
* 类 名： jt_ys_zm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:39   N/A    初版
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 预算账目表
	/// </summary>
	[Serializable]
	public partial class jt_ys_zm
	{
		public jt_ys_zm()
		{}
		#region Model
		private int _pk;
		private string _v_yszm_no;
		private string _v_yszm_name;
		private DateTime _t_date_start= DateTime.Now;
		private DateTime _t_date_end= DateTime.Now;
		private decimal _f_ys_money;
		private string _v_remark;
		private DateTime _t_create_time= DateTime.Now;
		private int _i_delete;
        private string _v_jz_user_pk;
        private string _v_jz_user_name;

        /// <summary>
		/// 记账人pk
		/// </summary>
		public string v_jz_user_pk
        {
            set { _v_jz_user_pk = value; }
            get { return _v_jz_user_pk; }
        }
        /// <summary>
		///  记账人
		/// </summary>
		public string v_jz_user_name
        {
            set { _v_jz_user_name = value; }
            get { return _v_jz_user_name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int pk
		{
			set{ _pk=value;}
			get{return _pk;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string v_yszm_no
		{
			set{ _v_yszm_no=value;}
			get{return _v_yszm_no;}
		}
		/// <summary>
		/// 类型名
		/// </summary>
		public string v_yszm_name
		{
			set{ _v_yszm_name=value;}
			get{return _v_yszm_name;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime t_date_start
		{
			set{ _t_date_start=value;}
			get{return _t_date_start;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime t_date_end
		{
			set{ _t_date_end=value;}
			get{return _t_date_end;}
		}
		/// <summary>
		/// 预算金额
		/// </summary>
		public decimal f_ys_money
		{
			set{ _f_ys_money=value;}
			get{return _f_ys_money;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string v_remark
		{
			set{ _v_remark=value;}
			get{return _v_remark;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime t_create_time
		{
			set{ _t_create_time=value;}
			get{return _t_create_time;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int i_delete
		{
			set{ _i_delete=value;}
			get{return _i_delete;}
		}
		#endregion Model

	}
}

