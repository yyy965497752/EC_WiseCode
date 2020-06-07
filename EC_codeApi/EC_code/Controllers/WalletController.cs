using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC_BLL;
using EC_Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EC_code.Controllers
{
    [Route("api/[controller]/[action]")]
    [EnableCors("commerce")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        WalletBll dal = new WalletBll();
        public List<WalletModel> ShowWallet()
        {
            return dal.ShowWallet(); ;
        }

        public WalletModel EditId(int id)
        {
            return dal.EditId(id);
        }
        //提现
        public int EditMoney(decimal moneys, int id)
        {
            return dal.EditMoney(moneys, id);
        }
        /// <summary>
        /// 提现记录
        /// </summary>
        /// <returns></returns>
        public List<TixianModel> ShowTixian()
        {
            return dal.ShowTixian();
        }
    }
}