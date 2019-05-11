using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeAccountingSystem.Model;

namespace HomeAccountingSystem.BLL
{
    class LoginAccountManager
    {
        #region Instance

        private static LoginAccountManager instance = new LoginAccountManager();
        public static LoginAccountManager Instance
        {
            get { return LoginAccountManager.instance; }
        }

        #endregion

        public jt_yh_zl m_yhzlModel = null;

        /// <summary>
        /// 获得当前登录用户model
        /// </summary>
        /// <returns></returns>
        public jt_yh_zl getLoginUserModel()
        {
            return m_yhzlModel;
        }

    }
}
