/**  版本信息模板在安装目录下，可自行修改。
* jt_sr_lx.cs
*
* 功 能： N/A
* 类 名： jt_sr_lx
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:37   N/A    初版 
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 收入类型表
	/// </summary>
	[Serializable]
	public partial class jt_sr_lx
	{
		public jt_sr_lx()
		{}
		#region Model
		private int _pk;
		private string _v_sr_no;
		private string _v_srlx_name;
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
		public string v_sr_no
		{
			set{ _v_sr_no=value;}
			get{return _v_sr_no;}
		}
		/// <summary>
		/// 类型名
		/// </summary>
		public string v_srlx_name
		{
			set{ _v_srlx_name=value;}
			get{return _v_srlx_name;}
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

