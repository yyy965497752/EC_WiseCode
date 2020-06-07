using EC_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EC_DAL
{
    public class WalletDal
    {
        DBHelper db = new DBHelper();
        public List<WalletModel> ShowWallet()
        {
            string sql = string.Format("select s.Id,s.yueMoney,s.dayMoney,s.dayModeryZc,s.leijishouru,s.leijizhichu from Wallet s");
            return db.GetToList<WalletModel>(sql);
        }
        //提现Id
        public WalletModel EditId(int id)
        {
            string sql = string.Format("select * from Wallet where Id='{0}' ", id);
            return db.GetToList<WalletModel>(sql).FirstOrDefault();
        }
        //提现
        public int EditMoney(decimal moneys, int id)
        {
            int i = 0;
            string sql = string.Format("update Wallet set yueMoney=(yueMoney-'{0}') where Id='{1}'", moneys, id);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                var sss = DateTime.Now;
                string sqlq = string.Format("insert into TiXian values('{0}','{1}','已提现') ", sss, moneys);

                i = db.ExecuteNonQuery(sqlq);
            }
            else
            {
                i = 0;
            }
            return i;
        }
    }

}
