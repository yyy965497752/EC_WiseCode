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
    public class OrdersController : ControllerBase
    {
        YyhBLL bll = new YyhBLL();
        //显示
        [HttpGet]
        public List<Orders> OrdersShow()
        {
            return bll.OrdersShow();
        }
        //状态查询显示
        [HttpGet]
        public List<Orders> StatesShow1()
        {
            return bll.StatesShow1();
        } //状态查询显示
        [HttpGet]
        public List<Orders> StatesShow2()
        {
            return bll.StatesShow2();
        } //状态查询显示
        [HttpGet]
        public List<Orders> StatesShow3()
        {
            return bll.StatesShow3();
        } //状态查询显示
        [HttpGet]
        public List<Orders> StatesShow4()
        {
            return bll.StatesShow4();
        }
        //获取订单的id
        [HttpGet]
        public Orders Find(int id)
        {
            return bll.Find(id);
        }
        //获取收货地址的id
        [HttpGet]
        public Consignee FindId(int id)
        {
            return bll.FindId(id);
        }
        //修改收货地址
        [HttpPost]
        public int Upt(Consignee m)
        {
            return bll.Upt(m);
        }
    }
}