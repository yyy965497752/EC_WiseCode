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
    public class GoodsSendController : ControllerBase
    {
        SYBLL bll = new SYBLL();
        // GET: api/GoodsSend
        [HttpGet]
        public IEnumerable<GoodsSend> Get()
        {
            return bll.BandSend();
        }
    }
}