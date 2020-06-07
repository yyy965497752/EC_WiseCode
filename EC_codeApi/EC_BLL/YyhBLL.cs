using EC_DAL;
using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_BLL
{
    public class YyhBLL
    {
        YyhDal dal = new YyhDal();
        //显示
        public List<Orders> OrdersShow()
        {
            return dal.OrdersShow();
        }
        //状态查询显示
        public List<Orders> StatesShow1()
        {
            return dal.StatesShow1();
        }
        //状态查询显示
        public List<Orders> StatesShow2()
        {
            return dal.StatesShow2();
        }
        //状态查询显示
        public List<Orders> StatesShow3()
        {
            return dal.StatesShow3();
        }
        //状态查询显示
        public List<Orders> StatesShow4()
        {
            return dal.StatesShow4();
        }
        //获取订单的id
        public Orders Find(int id)
        {
            return dal.Find(id);
        }
        //获取收货地址的id
        public Consignee FindId(int id)
        {
            return dal.FindId(id);
        }
        //修改收货地址
        public int Upt(Consignee m)
        {
            return dal.Upt(m);
        }
    }
}
