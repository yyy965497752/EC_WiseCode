using EC_DAL;
using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_BLL
{
    public class WalletBll
    {
        WalletDal dal = new WalletDal();
        public List<WalletModel> ShowWallet()
        {
            return dal.ShowWallet(); ;
        }
        //提现Id
        public WalletModel EditId(int id)
        {
            return dal.EditId(id);
        }
        //提现
        //提现
        public int EditMoney(decimal moneys, int id)
        {
            return dal.EditMoney(moneys, id);
        }
        /// <summary>
        /// 提现记录
        /// </summary>
        /// <returns></returns>
        //public List<TixianModel> ShowTixian()
        //{
        //    return dal.ShowTixian();
        //}
    }
}
