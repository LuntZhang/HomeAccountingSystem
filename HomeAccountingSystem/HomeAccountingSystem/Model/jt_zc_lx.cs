/** 
* jt_zc_lx.cs
*
* 功 能： N/A
* 类 名： jt_zc_lx
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:40   N/A    初版 
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 支出类型表
	/// </summary>
	[Serializable]
	public partial class jt_zc_lx
	{
		public jt_zc_lx()
		{}
		#region Model
		private int _pk;
		private string _v_zc_no;
		private string _v_zclx_name;
		private DateTime? _t_create_time= DateTime.Now;
		private int? _i_delete;
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
		public string v_zc_no
		{
			set{ _v_zc_no=value;}
			get{return _v_zc_no;}
		}
		/// <summary>
		/// 类型名
		/// </summary>
		public string v_zclx_name
		{
			set{ _v_zclx_name=value;}
			get{return _v_zclx_name;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? t_create_time
		{
			set{ _t_create_time=value;}
			get{return _t_create_time;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? i_delete
		{
			set{ _i_delete=value;}
			get{return _i_delete;}
		}
		#endregion Model

	}
}

