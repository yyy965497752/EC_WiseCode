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
    public class UptGoodsStatusController : ControllerBase
    {
        SYBLL bll = new SYBLL();
        // PUT: api/UptGoodsStatus/5
        [HttpPut]
        public int Put([FromBody]Goods s)
        {
            return bll.UptGoodsStatus(s);
        }
    }
}