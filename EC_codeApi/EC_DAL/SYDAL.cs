using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_DAL
{
    public class SYDAL
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 商品
        /// </summary>
        /// <returns></returns>
        //显示
        public List<Goods> ShowGoods()
        {
            var sql = "select *,case GoodsAuditStatus when 1 then '审核通过'when 2 then '审核未通过' when 3 then '待审核' end GoodsAuditStatuss from Goods	join GoodsType on Goods.GoodssType = GoodsType.Id";
            return db.GetToList<Goods>(sql);
        }
        //添加
        public int AddGoods(Goods s)
        {
            var sql = string.Format("insert into Goods values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')",
                s.GoodsName, s.GoodssType, s.GoodsPrice, s.GoodsSalesvolume = 0, s.GoodsOnStatus = true, s.GoodsAuditStatus = 3, s.GoodsStock, s.GoodsSum = 1, s.GoodsKind, s.GoodsTitle, s.GoodsSize, s.GoodsJifen, s.GoodsIntroductory, s.GoodsSend, s.GoodsSale, s.GoodsBuyStock, s.GodsOnTimes);
            return db.ExecuteNonQuery(sql);
        }
        //反填修改
        public Goods FillGoods(int id)
        {
            var sql = "select * from  Goods where Id = " + id;
            return db.GetToList<Goods>(sql)[0];
        }
        public int UptGoods(Goods s)
        {
            var sql = string.Format("update Goods set GoodsName='{0}',GoodssType='{1}',GoodsPrice='{2}',GoodsSalesvolume='{3}',GoodsOnStatus='{4}',GoodsAuditStatus='{5}',GoodsStock='{6}',GoodsSum='{7}',GoodsKind='{8}',GoodsTitle='{9}',GoodsIIImg='{10}',GoodsSize='{11}',GoodsJifen='{12}',GoodsIntroductory='{13}',GoodsSend='{14}',GoodsSale='{15}',GoodsBuyStock='{16}',GodsOnTimes='{17}' where Id='{18}'",
                s.GoodsName, s.GoodssType, s.GoodsPrice, s.GoodsSalesvolume, s.GoodsOnStatus, s.GoodsAuditStatus, s.GoodsStock, s.GoodsSum, s.GoodsKind, s.GoodsTitle, s.GoodsIIImg, s.GoodsSize, s.GoodsJifen, s.GoodsIntroductory, s.GoodsSend, s.GoodsSale, s.GoodsBuyStock, s.GodsOnTimes, s.Id);
            return db.ExecuteNonQuery(sql);
        }
        //修改状态   上架/下架
        public int UptGoodsStatus(Goods s)
        {
            var sql = string.Format("update Goods set GoodsOnStatus=GoodsOnStatus - 1 where Id='{0}'", s.Id);
            return db.ExecuteNonQuery(sql);
        }
        //删除
        public int DelGoods(int id)
        {
            var sql = "delete from Goods where Id=" + id;
            return db.ExecuteNonQuery(sql);
        }
        //绑定分类Type的下拉 
        public List<GoodsType> BandType()
        {
            var sql = "select * from GoodsType";
            return db.GetToList<GoodsType>(sql);
        }
        //绑定类型Kind的下拉 
        public List<GoodsKind> BandKind()
        {
            var sql = "select * from GoodsKind";
            return db.GetToList<GoodsKind>(sql);
        }
        //绑定快递Send的下拉 
        public List<GoodsSend> BandSend()
        {
            var sql = "select * from GoodsSend";
            return db.GetToList<GoodsSend>(sql);
        }

        /// <summary>
        /// 类型
        /// </summary>
        /// <returns></returns>
        //显示
        public List<GoodsType> ShowType()
        {
            var sql = "select * from GoodsType ";
            return db.GetToList<GoodsType>(sql);
        }
        //添加
        public int AddType(GoodsType t)
        {
            var sql = string.Format("insert into GoodsType values('{0}')", t.TypeName);
            return db.ExecuteNonQuery(sql);
        }
        //删除
        public int DelType(int id)
        {
            var sql = "delete from  GoodsType where Id=" + id;
            return db.ExecuteNonQuery(sql);
        }
    }
}
