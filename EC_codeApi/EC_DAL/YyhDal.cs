using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_DAL
{
    public class YyhDal
    {
        DBHelper db = new DBHelper();
        //显示
        public List<Orders> OrdersShow()
        {
            string sql = string.Format("select * from Orders o join Goods g on o.GoodsId=g.Id join Consignee c on o.consigneeId=c.ConsigneeId");
            return db.GetToList<Orders>(sql);
        }
        //状态查询显示
        public List<Orders> StatesShow1()
        {
            string sql = string.Format("select * from Orders o join Goods g on o.GoodsId=g.Id join Consignee c on o.consigneeId=c.ConsigneeId where States=1");
            return db.GetToList<Orders>(sql);
        }
        public List<Orders> StatesShow2()
        {
            string sql = string.Format("select * from Orders o join Goods g on o.GoodsId=g.Id join Consignee c on o.consigneeId=c.ConsigneeId where States=2");
            return db.GetToList<Orders>(sql);
        }
        public List<Orders> StatesShow3()
        {
            string sql = string.Format("select * from Orders o join Goods g on o.GoodsId=g.Id join Consignee c on o.consigneeId=c.ConsigneeId where States=3");
            return db.GetToList<Orders>(sql);
        }
        public List<Orders> StatesShow4()
        {
            string sql = string.Format("select * from Orders o join Goods g on o.GoodsId=g.Id join Consignee c on o.consigneeId=c.ConsigneeId where States=4");
            return db.GetToList<Orders>(sql);
        }
        //获取订单的id
        public Orders Find(int id)
        {
            string sql = string.Format("select * from Orders where OrdersId='{0}'", id);
            return db.GetToList<Orders>(sql)[0];
        }
        //获取收货地址的id
        public Consignee FindId(int id)
        {
            string sql = string.Format("select * from Consignee where ConsigneeId='{0}'", id);
            return db.GetToList<Consignee>(sql)[0];
        }
        //修改收货地址
        public int Upt(Consignee m)
        {
            string sql = string.Format("Update Consignee set ConName='{0}',ConMobile='{1}',Consite='{2}',postcode='{3}' where ConsigneeId='{4}'", m.ConName, m.ConMobile, m.Consite, m.postcode, m.ConsigneeId);
            return db.ExecuteNonQuery(sql);
        }
    }
}
