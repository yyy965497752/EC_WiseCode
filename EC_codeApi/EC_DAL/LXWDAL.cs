using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_DAL
{
    public class LXWDAL
    {
        DBHelper DBHelper = new DBHelper();
        //显示列表
        public List<Man> show()
        {
            return DBHelper.GetToList<Man>
                ("select * from Man join Depart on Man.Did=Depart.Did");
        }
        //下拉
        public List<Deapart> xiala()
        {
            return DBHelper.GetToList<Deapart>
                ("select * from Depart");
        }
        //添加列表
        public int Add(Man m)
        {
            return DBHelper.ExecuteNonQuery
                (string.Format("insert into  Man values ('{0}','{1}','{2}','{3}','{4}')", m.Mname, m.Modile, m.Did, m.Mstate, m.Mnotes));
        }
        //删除列表
        public int Del(int id)
        {
            return DBHelper.ExecuteNonQuery
                (string.Format("delete  Man where Mid=" + id));
        }
        //修改列表
        public int Upt(Man m, int id)
        {
            return DBHelper.ExecuteNonQuery
               (string.Format("update Man set Mname='{0}',Modile='{1}',Did='{2}',Mstate='{3}',Mnotes='{4}'where mid='{5}'", m.Mname, m.Modile, m.Did, m.Mstate, m.Mnotes, id));
        }
        //反填
        public Man Fill(int id)
        {
            return DBHelper.GetToList<Man>
                (string.Format("select * from Depart join Man on Depart.Did=Man.Mid where Mid={0}", id))[0];
        }
    }
}
