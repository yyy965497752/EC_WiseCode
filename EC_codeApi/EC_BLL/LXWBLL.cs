using EC_DAL;
using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_BLL
{
    public class LXWBLL
    {
        LXWDAL dal = new LXWDAL();
        public List<Man> show()
        {
            return dal.show();
        }
        public List<Deapart> xiala()
        {
            return dal.xiala();
        }
        public int Add(Man m)
        {
            return dal.Add(m);
        }
        public int Del(int id)
        {
            return dal.Del(id);
        }
        public int Upt(Man m, int id)
        {
            return dal.Upt(m, id);
        }
        public Man Fill(int id)
        {

            return dal.Fill(id);
        }
    }
}
