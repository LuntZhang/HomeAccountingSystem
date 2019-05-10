/**  
* jt_zffs.cs
*
* 功 能： N/A
* 类 名： jt_zffs
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:41   N/A    初版     
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 支付方式表
	/// </summary>
	[Serializable]
	public partial class jt_zffs
	{
		public jt_zffs()
		{}
		#region Model
		private int _pk;
		private string _v_zffs_no;
		private string _v_zffs_name;
		private DateTime? _t_create_time= DateTime.Now;
		private int? _i_delete;
		private int? _i_zffs_lx=0;
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
		public string v_zffs_no
		{
			set{ _v_zffs_no=value;}
			get{return _v_zffs_no;}
		}
		/// <summary>
		/// 类型名
		/// </summary>
		public string v_zffs_name
		{
			set{ _v_zffs_name=value;}
			get{return _v_zffs_name;}
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
		/// <summary>
		/// 支付类型 枚举：0：现金；1：微信；2：支付宝；3：银行卡
		/// </summary>
		public int? i_zffs_lx
		{
			set{ _i_zffs_lx=value;}
			get{return _i_zffs_lx;}
		}
		#endregion Model

	}
}

