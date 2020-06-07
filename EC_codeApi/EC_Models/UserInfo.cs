using System;
using System.Collections.Generic;
using System.Text;

namespace EC_Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Uname { get; set; }   //账号
        public string RealName { get; set; }  //真实姓名
        public string Pass { get; set; }   //密码
        public string Email { get; set; }    //邮箱
        public string Phone { get; set; }   //手机号
    }
}
