/**  版本信息模板在安装目录下，可自行修改。
* jt_yh_zl.cs
*
* 功 能： N/A
* 类 名： jt_yh_zl
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019-05-10 20:55:39   N/A    初版
*/
using System;
namespace HomeAccountingSystem.Model
{
	/// <summary>
	/// 用户资料表
	/// </summary>
	[Serializable]
	public partial class jt_yh_zl
	{
		public jt_yh_zl()
		{}
		#region Model
		private int _pk;
		private string _v_yh_no;
		private string _v_yh_name;
		private string _v_yh_pwd;
		private int? _i_yh_type=1;
		private string _v_phone;
		private DateTime? _t_birthday_gregorian= DateTime.Now;
		private string _t_birthday_lunar= "getdate";
		private DateTime? _t_create_time;
		private int? _i_delete;
		private string _v_photo;
		private string _v_age;
		/// <summary>
		/// 
		/// </summary>
		public int pk
		{
			set{ _pk=value;}
			get{return _pk;}
		}
		/// <summary>
		/// 用户账号
		/// </summary>
		public string v_yh_no
		{
			set{ _v_yh_no=value;}
			get{return _v_yh_no;}
		}
		/// <summary>
		/// 用户名称
		/// </summary>
		public string v_yh_name
		{
			set{ _v_yh_name=value;}
			get{return _v_yh_name;}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
		public string v_yh_pwd
		{
			set{ _v_yh_pwd=value;}
			get{return _v_yh_pwd;}
		}
		/// <summary>
		/// 用户类型 0：管理员；1：用户；2：游客
		/// </summary>
		public int? i_yh_type
		{
			set{ _i_yh_type=value;}
			get{return _i_yh_type;}
		}
		/// <summary>
		/// 电话号码
		/// </summary>
		public string v_phone
		{
			set{ _v_phone=value;}
			get{return _v_phone;}
		}
		/// <summary>
		/// 阳历
		/// </summary>
		public DateTime? t_birthday_gregorian
		{
			set{ _t_birthday_gregorian=value;}
			get{return _t_birthday_gregorian;}
		}
		/// <summary>
		/// 农历
		/// </summary>
		public string t_birthday_lunar
		{
			set{ _t_birthday_lunar=value;}
			get{return _t_birthday_lunar;}
		}
		/// <summary>
		/// 创建日期
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
		/// 头像
		/// </summary>
		public string v_photo
		{
			set{ _v_photo=value;}
			get{return _v_photo;}
		}
		/// <summary>
		/// 年龄
		/// </summary>
		public string v_age
		{
			set{ _v_age=value;}
			get{return _v_age;}
		}
		#endregion Model

	}
}

