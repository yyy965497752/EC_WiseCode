using System;
using System.Collections.Generic;
using System.Text;

namespace EC_Models
{
    public class Goods
    {
        public int Id { get; set; }
        public string GoodsName { get; set; }
        public int GoodssType { get; set; }
        public string TypeName { get; set; }
        public decimal GoodsPrice { get; set; }
        public int GoodsSalesvolume { get; set; }
        public bool GoodsOnStatus { get; set; }
        public int GoodsAuditStatus { get; set; }
        public string GoodsAuditStatuss { get; set; }
        public int GoodsStock { get; set; }

        public int GoodsSum { get; set; }
        public int GoodsKind { get; set; }
        public string KindName { get; set; }
        public string GoodsTitle { get; set; }
        public string GoodsIIImg { get; set; }
        public bool GoodsSize { get; set; }
        public int GoodsJifen { get; set; }
        public string GoodsIntroductory { get; set; }
        public int GoodsSend { get; set; }
        public string SendName { get; set; }
        public bool GoodsSale { get; set; }
        public bool GoodsBuyStock { get; set; }
        public int GodsOnTimes { get; set; }
    }
    public class Orders
    {
        public int OrdersId { get; set; }
        public int numberId { get; set; }
        public int GoodsId { get; set; }
        public int consigneeId { get; set; }
        public int UsersId { get; set; }
        public int States { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Payment { get; set; }
        public int logistics { get; set; }
        public string GoodsName { get; set; }
        public string ConName { get; set; }
        public string ConMobile { get; set; }

        public string GoodsIIImg { get; set; }
        public int GoodsSum { get; set; }
        public decimal GoodsPrice { get; set; }
    }
    //收货地址表
    public class Consignee
    {
        public int ConsigneeId { get; set; }
        public string ConName { get; set; }
        public string ConMobile { get; set; }
        public string Consite { get; set; }
        public string postcode { get; set; }
    }
}
