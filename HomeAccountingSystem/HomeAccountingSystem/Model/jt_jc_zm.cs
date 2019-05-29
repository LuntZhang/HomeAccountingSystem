/**  
* jt_jc_zm.cs
*
* 功 能： N/A
* 类 名： jt_jc_zm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:36   N/A    初版 
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 借出账目表
	/// </summary>
	[Serializable]
	public partial class jt_jc_zm
	{
		public jt_jc_zm()
		{}
		#region Model
		private int _pk;
		private string _v_jczm_no;
		private string _v_jczm_name;
		private DateTime _t_jc_time= DateTime.Now;
		private string _v_jc_who;
		private decimal _f_jc_money;
		private decimal _f_accrual;
		private string _v_jc_name;
		private DateTime _t_gh_time= DateTime.Now;
		private int _i_gh_flag=0;
		private decimal _f_gh_how_money;
		private string _v_remark;
		private string _v_jz_user_pk;
		private string _v_jz_user_name;
		private DateTime _t_create_time= DateTime.Now;
		private int _i_delete;
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
		public string v_jczm_no
		{
			set{ _v_jczm_no=value;}
			get{return _v_jczm_no;}
		}
		/// <summary>
		/// 账目名称
		/// </summary>
		public string v_jczm_name
		{
			set{ _v_jczm_name=value;}
			get{return _v_jczm_name;}
		}
		/// <summary>
		/// 借入时间
		/// </summary>
		public DateTime t_jc_time
		{
			set{ _t_jc_time=value;}
			get{return _t_jc_time;}
		}
		/// <summary>
		/// 借给谁
		/// </summary>
		public string v_jc_who
		{
			set{ _v_jc_who=value;}
			get{return _v_jc_who;}
		}
		/// <summary>
		/// 借出多少
		/// </summary>
		public decimal f_jc_money
		{
			set{ _f_jc_money=value;}
			get{return _f_jc_money;}
		}
		/// <summary>
		/// 利息
		/// </summary>
		public decimal f_accrual
		{
			set{ _f_accrual=value;}
			get{return _f_accrual;}
		}
		/// <summary>
		/// 谁借出的
		/// </summary>
		public string v_jc_name
		{
			set{ _v_jc_name=value;}
			get{return _v_jc_name;}
		}
		/// <summary>
		/// 归还时间
		/// </summary>
		public DateTime t_gh_time
		{
			set{ _t_gh_time=value;}
			get{return _t_gh_time;}
		}
		/// <summary>
		/// 是否归还 0：未归还；1：已归还
		/// </summary>
		public int i_gh_flag
		{
			set{ _i_gh_flag=value;}
			get{return _i_gh_flag;}
		}
		/// <summary>
		/// 到目前该归还多少
		/// </summary>
		public decimal f_gh_how_money
		{
			set{ _f_gh_how_money=value;}
			get{return _f_gh_how_money;}
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
		#endregion Model

	}
}

