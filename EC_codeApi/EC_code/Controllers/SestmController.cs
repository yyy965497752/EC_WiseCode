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
    [Route("LXW")]
    [EnableCors("commerce")]
    [ApiController]
    public class SestmController : ControllerBase
    {
        LXWBLL bll = new LXWBLL();
        //显示
        // GET: api/<SestmController>
        [HttpGet("Lxwshow")]
        public IEnumerable<Man> Show(int id)
        {
            return bll.show();
        }
        //反填
        // GET api/<SestmController>/5
        [HttpGet, Route("LxwFill")]
        public Man Fill(int id)
        {
            return bll.Fill(id);
        }

        // POST api/<SestmController>
        //添加
        [HttpPost("Addlxw")]
        public int Add(Man m)
        {
            return bll.Add(m);
        }
        //修改
        // PUT api/<SestmController>/5
        [HttpPost("LxwUpt")]
        public int Upt(Man m, int uid)
        {
            return bll.Upt(m, uid);
        }
        //删除
        // DELETE api/<SestmController>/5
        [HttpDelete("LxwDel")]
        public int Delete(int id)
        {
            return bll.Del(id);
        }
    }
}