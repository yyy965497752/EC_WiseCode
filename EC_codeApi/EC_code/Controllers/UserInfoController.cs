using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC_BLL;
using EC_Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EC_code.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("commerce")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        GZHBLL bll = new GZHBLL();
        //登录日志
        private readonly ILogger<UserInfo> _logger;

        public UserInfoController(ILogger<UserInfo> logger)

        {

            _logger = logger;

        }
        // GET: api/UserInfo
        [HttpGet]
        public IEnumerable<UserInfo> Get()
        {
            return null;
        }

        // GET: api/UserInfo/5
        [HttpGet("{id}", Name = "Get")]
        public UserInfo Get(int id)
        {
            return bll.UserInfoFill(id);
        }

        // POST: api/UserInfo
        [HttpPost]
        public UserInfo Post([FromBody]UserInfo m)   //登录
        {
            _logger.LogInformation("登录信息已录入");
            return bll.Login(m);
        }


        // PUT: api/UserInfo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}