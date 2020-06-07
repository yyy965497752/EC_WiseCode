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
    public class UserInfoAddController : ControllerBase
    {
        GZHBLL bll = new GZHBLL();
        //注册
        [HttpPost]
        public int LoginAdd(UserInfo m)
        {
            return bll.LoginAdd(m);
        }
        /// <summary>
        ///邮箱验证码
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        [HttpGet]
        public string QQMailMessage(string Email)
        {
            return bll.QQMailMessage(Email);
        }
        //获取每个用户的id
        [HttpGet]
        public UserInfo UserInfoNameById(string Uname)
        {
            return bll.UserInfoNameById(Uname);
        }
        //修改用户的密码
        [HttpPost]
        public int UserInfoPassUpt(UserInfo m)
        {
            return bll.UserInfoPassUpt(m);
        }
        //查询出每个用户真实姓名
        //[HttpGet]
        //public ActionResult<IEnumerable<UserInfo>> GetRealName(string RealName)
        //{
        //    return bll.GetRealName(RealName);
        //}
        //反填用户的信息
        [HttpGet]
        public UserInfo UserMessageFill(int id)
        {
            return bll.UserMessageFill(id);
        }
        //修改用户信息
        [HttpPost]
        public int UserMessageUpt(UserInfo m)
        {
            return bll.UserMessageUpt(m);
        }
    }
}