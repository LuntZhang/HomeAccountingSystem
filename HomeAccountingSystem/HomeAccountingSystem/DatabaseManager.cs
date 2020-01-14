using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccountingSystem
{
    public class DatabaseManager
    {
        private static string CONST_USER = "sa";
        private static string CONST_PWD = "123456";
        public static string selectedDBName = "jtjz_db";
        public static string connectionString = null;

        public static void initConnect(string sUrl, string database, string user, string pwd)
        {
            // SQLServerHelper.initConnect(sUrl, database, user, pwd);
            if (sUrl.Contains("127.0.0.1") == true)
            {
                sUrl = ".";
            }
          
            connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};PWD={3}", sUrl, database, user, pwd);
            SQLServerHelper.connectionString = connectionString;
            //DatabaseManager.selectedDBName = database;
        }

        /// <summary>
        /// 测试数据库连接是否成功
        /// </summary>
        public static void DatabaseConnection()
        {
            // 初始化连接
            DatabaseManager.initConnect("127.0.0.1", selectedDBName, CONST_USER, CONST_PWD);
            string strConnection = null;
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                //打开连接
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    strConnection = "数据库连接成功！";
                }

            }
            catch (Exception)
            {
                strConnection = "数据库连接失败！";
                MessageBox.Show("数据库连接失败！");
            }
        }



        /// <summary>
        /// 返回当前连接数据库的连接串
        /// </summary>
        /// <returns></returns>
        public static string getConnectString()
        {
            return SQLServerHelper.connectionString;
        }


        /// <summary>
        /// 连接用户选择的数据库
        /// </summary>
        /// <returns></returns>
        public static bool connectUserSelectedDatabase(string connectString)
        {
            SQLServerHelper.connectionString = connectString;
            return true;
        }

        /// <summary>
        /// 判断表是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static bool isExistTable(string tableName)
        {
            if (tableName == null)
            {
                return false;
            }

            string sqlCommand = string.Format("select COUNT(*) from sysobjects where id=object_id(N'{0}') and OBJECTPROPERTY(id,N'IsUserTable')=1", tableName);
            bool bFlag = false;
            try
            {
                DataTable dataTable = SQLServerHelper.GetTable(sqlCommand);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    int count = int.Parse(row.ItemArray[0].ToString());
                    if (count == 1)
                    {
                        bFlag = true;
                    }
                }
            }
            catch (Exception)
            {

                bFlag = false;
            }
            return bFlag;
        }

        /// <summary>
        /// 用户是否创建了数据库
        /// </summary>
        /// <returns></returns>
        public static bool isCreateDatabase()
        {
            string sqlString = "select * from tzx_zf";

            DataTable dataTable = SQLServerHelper.GetTable(sqlString);

            bool isCreate = false;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                isCreate = true;
            }
            return isCreate;
        }


        /// <summary>
        /// 获取用户选择数据库的名字
        /// </summary>
        /// <returns></returns>
        public static string getUserSelectedDatabase()
        {

            string sqlString = "select db_name from tzx_zf where is_use = 1";

            DataTable dataTable = SQLServerHelper.GetTable(sqlString);
            string databaseName = null;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                databaseName = dataTable.Rows[0].ItemArray[0].ToString();
            }

            return databaseName;
        }

    }
}