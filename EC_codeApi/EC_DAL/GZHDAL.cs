using EC_Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace EC_DAL
{
    public class GZHDAL
    {
        DBHelper db = new DBHelper();
        public UserInfo Login(UserInfo m)
        {
           
            string sql = string.Format("select * from UserInfo where Uname='{0}' and Pass='{1}'", m.Uname, m.Pass);
            var r = db.GetToList<UserInfo>(sql);
            if (r.Count > 0)
            {
                return r[0];
            }
            return null;
        }
        //注册
        public int LoginAdd(UserInfo m)
        {
            string sql = string.Format("insert into UserInfo values('{0}','{1}','{2}','{3}','{4}')", m.Uname, m.RealName, m.Pass, m.Email, m.Phone);
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        ///邮箱验证码
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public string QQMailMessage(string Email)
        {
            int randNum;
            char code;
            string randomCode = String.Empty;//随机验证码

            //生成一定长度的随机验证码       
            for (int i = 0; i < 6; i++)
            {
                //利用GUID生成6位随机数      
                byte[] buffer = Guid.NewGuid().ToByteArray();//生成字节数组
                int seed = BitConverter.ToInt32(buffer, 0);//利用BitConvert方法把字节数组转换为整数
                Random random = new Random(seed);//以生成的整数作为随机种子
                randNum = random.Next();

                code = (char)('0' + (char)(randNum % 10));//随机数字

                randomCode += code.ToString();
            }
            //string code = CreateRandomMailCode();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("1427865035@qq.com", "【阿里云电商】");//发件人邮箱地址
            mail.To.Add(new MailAddress(Email));//收件人邮箱地址
            mail.Subject = "欢迎您注册【阿里云电商】";//邮件标题
            mail.SubjectEncoding = Encoding.UTF8;//标题编码
            mail.Body = "【阿里云电商】官方发送。\r\n\r\n您的验证码为：" + randomCode;
            mail.BodyEncoding = Encoding.UTF8;//正文编码
            mail.Priority = MailPriority.High;//优先级

            SmtpClient client = new SmtpClient();//qq邮箱:smtp.qq.com；126邮箱:smtp.126.com              
            client.Host = "smtp.qq.com";
            //client.Host = "smtp.163.com";
            //client.Host = "smtp.163.com";
            client.Port = 587;//SMTP端口465或587
            client.EnableSsl = true;//使用安全加密SSL连接  
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("1427865035@qq.com", "hmifozrizqgrghhi");//验证发件人身份(发件人邮箱，邮箱授权码);          
            try
            {
                client.Send(mail);
            }
            catch (Exception)
            {
                throw;
            }
            return randomCode;
        }
        //忘记密码
        public UserInfo UserInfoFill(int id)
        {
            string sql = "select * from UserInfo where Id=" + id;
            return db.GetToList<UserInfo>(sql)[0];
        }
        //获取每个用户的id
        public UserInfo UserInfoNameById(string Uname)
        {
            string sql = string.Format("select Id from UserInfo where Uname='{0}'", Uname);
            return db.GetToList<UserInfo>(sql)[0];
        }
        //修改用户的密码
        public int UserInfoPassUpt(UserInfo m)
        {
            string sql = string.Format("update UserInfo set Pass = '{0}' where Id='{1}'", m.Pass, m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //反填用户的信息
        public UserInfo UserMessageFill(int id)
        {
            string sql = "select * from UserInfo where Id=" + id;
            return db.GetToList<UserInfo>(sql)[0];
        }

        //修改用户信息
        public int UserMessageUpt(UserInfo m)
        {
            string sql = string.Format("update UserInfo set Uname='{0}',RealName='{1}',Pass='{2}',Email='{3}',Phone='{4}' where Id='{5}'", m.Uname, m.RealName, m.Pass, m.Email, m.Phone, m.Id);
            return db.ExecuteNonQuery(sql);
        }
    }
}
