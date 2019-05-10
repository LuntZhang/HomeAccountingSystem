/**  
* jt_jc_sz.cs
*
* 功 能： N/A
* 类 名： jt_jc_sz
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:35   N/A    初版
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 基础设置表
	/// </summary>
	[Serializable]
	public partial class jt_jc_sz
	{
		public jt_jc_sz()
		{}
		#region Model
		private int _pk;
		private string _v_key;
		private string _v_value;
		private string _v_mac_address;
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
		/// 键
		/// </summary>
		public string v_key
		{
			set{ _v_key=value;}
			get{return _v_key;}
		}
		/// <summary>
		/// 值
		/// </summary>
		public string v_value
		{
			set{ _v_value=value;}
			get{return _v_value;}
		}
		/// <summary>
		/// mac地址
		/// </summary>
		public string v_mac_address
		{
			set{ _v_mac_address=value;}
			get{return _v_mac_address;}
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

