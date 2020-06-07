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
    public class GoodsTypeController : ControllerBase
    {
        SYBLL bll = new SYBLL();
        // GET: api/GoodsType
        [HttpGet]
        public IEnumerable<GoodsType> Get()
        {
            return bll.ShowType();
        }

        // POST: api/GoodsType
        [HttpPost]
        public int Post([FromBody] GoodsType t)
        {
            return bll.AddType(t);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public int Delete(int id)
        {
            return bll.DelType(id);
        }
    }
}