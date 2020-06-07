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
    public class GoodsController : ControllerBase
    {
        SYBLL bll = new SYBLL();
        // GET: api/Goods
        [HttpGet]
        public PageInfo Get(string goodsName = "", int currentPage = 1, int pageSize = 3)
        {
            var list = bll.ShowGoods();
            if (!string.IsNullOrEmpty(goodsName))
            {
                list = list.Where(s => s.GoodsName.Contains(goodsName)).ToList();
            }
            //实例化分页类
            var p = new PageInfo();
            //总记录数
            p.totalCount = list.Count();
            //计算总页数
            if (p.totalCount == 0)
            {
                p.totalPage = 1;
            }
            else if (p.totalCount % pageSize == 0)
            {
                p.totalPage = p.totalCount / pageSize;
            }
            else
            {
                p.totalPage = (p.totalCount / pageSize) + 1;
            }
            //纠正当前页不正确的值
            if (currentPage < 1)
            {
                currentPage = 1;
            }
            if (currentPage > p.totalPage)
            {
                currentPage = p.totalPage;
            }
            p.goods = list.Skip(pageSize * (currentPage - 1)).Take(pageSize).ToList();
            p.currentPage = currentPage;
            return p;
        }


        // GET: api/Goods/5
        public Goods Get1(int id)
        {
            return bll.FillGoods(id);
        }

        // POST: api/Goods
        [HttpPost]
        public int Post([FromBody]Goods s)
        {
            return bll.AddGoods(s);
        }

        // PUT: api/Goods/5
        [HttpPut]
        public int Put([FromBody]Goods s)
        {
            return bll.UptGoods(s);
        }

        // DELETE: api/Goods/5
        [HttpDelete]
        public int Delete(int id)
        {
            return bll.DelGoods(id);
        }
    }
}