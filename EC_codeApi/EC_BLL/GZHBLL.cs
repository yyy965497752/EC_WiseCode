using EC_DAL;
using EC_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC_BLL
{
    public class GZHBLL
    {
        GZHDAL dal = new GZHDAL();
        //登录
        public UserInfo Login(UserInfo m)
        {
            return dal.Login(m);
        }
        //注册
        public int LoginAdd(UserInfo m)
        {
            return dal.LoginAdd(m);
        }
        /// <summary>
        ///邮箱验证码
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public string QQMailMessage(string Email)
        {
            return dal.QQMailMessage(Email);
        }
        //忘记密码
        public UserInfo UserInfoFill(int id)
        {
            return dal.UserInfoFill(id);
        }
        //获取每个用户的id
        public UserInfo UserInfoNameById(string Uname)
        {
            return dal.UserInfoNameById(Uname);
        }
        //修改用户的密码
        public int UserInfoPassUpt(UserInfo m)
        {
            return dal.UserInfoPassUpt(m);
        }
        //查询出每个用户真实姓名
        //public List<UserInfo> GetRealName(string RealName)
        //{
        //    return dal.GetRealName(RealName);
        //}
        //反填用户的信息
        public UserInfo UserMessageFill(int id)
        {
            return dal.UserMessageFill(id);
        }
        //修改用户信息
        public int UserMessageUpt(UserInfo m)
        {
            return dal.UserMessageUpt(m);
        }

    }
}
