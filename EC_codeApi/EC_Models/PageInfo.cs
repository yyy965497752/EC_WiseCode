using System;
using System.Collections.Generic;
using System.Text;

namespace EC_Models
{
    public class PageInfo
    {
        public List<Goods> goods { get; set; }
        public List<GoodsType> goodsTypes { get; set; }
        public List<GoodsKind> goodsKinds { get; set; }
        public List<GoodsSend> goodsSends { get; set; }
        public int totalCount { get; set; }
        public int totalPage { get; set; }
        public int currentPage { get; set; }
        public int pageSize { get; set; }
    }
}
