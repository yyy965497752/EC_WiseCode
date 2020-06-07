using EC_DAL;
using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_BLL
{
    public class SYBLL
    {
        SYDAL dal = new SYDAL();
        /// <summary>
        /// 商品
        /// </summary>
        /// <returns></returns>
        //显示
        public List<Goods> ShowGoods()
        {
            return dal.ShowGoods();
        }
        //添加
        public int AddGoods(Goods s)
        {
            return dal.AddGoods(s);
        }
        //反填修改
        public Goods FillGoods(int id)
        {
            return dal.FillGoods(id);
        }
        public int UptGoods(Goods s)
        {
            return dal.UptGoods(s);
        }
        //修改状态   上架/下架
        public int UptGoodsStatus(Goods s)
        {
            return dal.UptGoodsStatus(s);
        }
        //删除
        public int DelGoods(int id)
        {
            return dal.DelGoods(id);
        }
        //绑定分类Type的下拉 
        public List<GoodsType> BandType()
        {
            return dal.BandType();
        }
        //绑定类型Kind的下拉 
        public List<GoodsKind> BandKind()
        {
            return dal.BandKind();
        }
        //绑定快递Send的下拉 
        public List<GoodsSend> BandSend()
        {
            return dal.BandSend();
        }

        /// <summary>
        /// 类型
        /// </summary>
        /// <returns></returns>
        //显示
        public List<GoodsType> ShowType()
        {
            return dal.ShowType();
        }
        //添加
        public int AddType(GoodsType t)
        {
            return dal.AddType(t);
        }
        //删除
        public int DelType(int id)
        {
            return dal.DelType(id);
        }
    }
}
