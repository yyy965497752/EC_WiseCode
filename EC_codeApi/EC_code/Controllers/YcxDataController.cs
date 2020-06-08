using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EC_Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EC_code.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("commerce")]
    [ApiController]
    public class YcxDataController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public int dataFree { get; set; }
        public YcxDataController(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = "Data Source=.;Initial Catalog=E_commerce;Integrated Security=True";

        }

        [HttpGet("user")]
        public ActionResult<IEnumerable<UserInfo>> ten()
        {

            var Rather = new List<UserInfo>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from UserInfo", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<UserInfo>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }

        [HttpGet("aiz")]
        public ActionResult<IEnumerable<UserInfo>> userhouse()
        {

            var Rather = new List<UserInfo>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from UserInfo where sex='男'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<UserInfo>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }

        #region 商品相关

        [HttpGet("shopOne")]
        public ActionResult<IEnumerable<UserInfo>> shopOne()
        {

            var Rather = new List<UserInfo>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from UserInfo where sex='女'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<UserInfo>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }


        [HttpGet("shopTow")]
        public ActionResult<IEnumerable<Goods>> shopTow()
        {

            var Rather = new List<Goods>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from Goods a join GoodsType b on a.Id=b.TypeParentid where b.TypeName='男装'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<Goods>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }

        [HttpGet("shopThree")]
        public ActionResult<IEnumerable<Goods>> shopThree()
        {

            var Rather = new List<Goods>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from Goods a join GoodsType b on a.Id=b.TypeParentid where b.TypeName='女装'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<Goods>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }


        [HttpGet("shopfore")]
        public ActionResult<IEnumerable<Goods>> shopfore()
        {

            var Rather = new List<Goods>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from Goods a join GoodsType b on a.Id=b.TypeParentid where b.TypeName='童装'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<Goods>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }


        #endregion


        #region 其他


        [HttpGet("userone")]
        public ActionResult<IEnumerable<Orders>> userone()
        {

            var Rather = new List<Orders>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from Orders", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<Orders>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }
        [HttpGet("usertwo")]
        public ActionResult<IEnumerable<Man>> usertwo()
        {

            var Rather = new List<Man>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from Man", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<Man>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }
        [HttpGet("userthree")]
        public ActionResult<IEnumerable<Deapart>> userthree()
        {

            var Rather = new List<Deapart>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from Depart", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<Deapart>(reader));
                }

            }
            dataFree = Rather.Count();
            return Ok(dataFree);

        }
        #endregion



    }
   



}