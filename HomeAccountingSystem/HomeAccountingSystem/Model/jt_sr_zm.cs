/**  版本信息模板在安装目录下，可自行修改。
* jt_sr_zm.cs
*
* 功 能： N/A
* 类 名： jt_sr_zm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:38   N/A    初版　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 收入账目表
	/// </summary>
	[Serializable]
	public partial class jt_sr_zm
	{
		public jt_sr_zm()
		{}
		#region Model
		private int _pk;
		private string _v_srzm_no;
		private string _v_srzm_name;
		private DateTime _t_xf_time= DateTime.Now;
		private string _v_srlx_no;
		private string _v_srlx_name;
		private string _v_remark;
		private string _v_jz_user_pk;
		private string _v_jz_user_name;
		private DateTime _t_create_time= DateTime.Now;
		private int _i_delete;
		private decimal _f_sr_money;
		private string _v_zffs_no;
		private string _v_zffs_name;
        private string _v_who;

        /// <summary>
		/// 谁收入的
		/// </summary>
		public string v_who
        {
            set { _v_who = value; }
            get { return _v_who; }
        }
        /// <summary>
        /// pk
        /// </summary>
        public int pk
		{
			set{ _pk=value;}
			get{return _pk;}
		}
		/// <summary>
		/// 账目编码
		/// </summary>
		public string v_srzm_no
		{
			set{ _v_srzm_no=value;}
			get{return _v_srzm_no;}
		}
		/// <summary>
		/// 账目名称
		/// </summary>
		public string v_srzm_name
		{
			set{ _v_srzm_name=value;}
			get{return _v_srzm_name;}
		}
		/// <summary>
		/// 消费时间
		/// </summary>
		public DateTime t_xf_time
		{
			set{ _t_xf_time=value;}
			get{return _t_xf_time;}
		}
		/// <summary>
		/// 账目类型编码
		/// </summary>
		public string v_srlx_no
		{
			set{ _v_srlx_no=value;}
			get{return _v_srlx_no;}
		}
		/// <summary>
		/// 账目类型名称
		/// </summary>
		public string v_srlx_name
		{
			set{ _v_srlx_name=value;}
			get{return _v_srlx_name;}
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
		/// 记账人pk
		/// </summary>
		public string v_jz_user_pk
		{
			set{ _v_jz_user_pk=value;}
			get{return _v_jz_user_pk;}
		}
		/// <summary>
		/// 记账人名称
		/// </summary>
		public string v_jz_user_name
		{
			set{ _v_jz_user_name=value;}
			get{return _v_jz_user_name;}
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
		/// <summary>
		/// 支出金额
		/// </summary>
		public decimal f_sr_money
		{
			set{ _f_sr_money=value;}
			get{return _f_sr_money;}
		}
		/// <summary>
		/// 支付方式编号
		/// </summary>
		public string v_zffs_no
		{
			set{ _v_zffs_no=value;}
			get{return _v_zffs_no;}
		}
		/// <summary>
		/// 支付方式名
		/// </summary>
		public string v_zffs_name
		{
			set{ _v_zffs_name=value;}
			get{return _v_zffs_name;}
		}
		#endregion Model

	}
}

