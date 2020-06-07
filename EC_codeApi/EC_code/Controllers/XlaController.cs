using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EC_BLL;
using EC_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EC_code.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XlaController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public XlaController(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = "Data Source=.;Initial Catalog=E_commerce;Integrated Security=True";
        }
        LXWBLL bll = new LXWBLL();
        // GET: api/<XlaController>
        [HttpGet]
        public IEnumerable<Deapart> Get()
        {
            return bll.xiala();
        }

        // GET api/<XlaController>/5


        // POST api/<XlaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<XlaController>/5
        [HttpPost("{id}")]
        public void Put(int id, string value)
        {

        }

        // DELETE api/<XlaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("try")]
        public ActionResult<IEnumerable<Man>> tool()
        {

            var Rather = new List<Man>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"select * from Man join Depart on Man.Did=Depart.Did", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rather.Add(HelperOper.ADONetToClass<Man>(reader));
                }

            }

            return Ok(Rather);

        }

        [HttpGet("try1")]
        public ActionResult<IEnumerable<Deapart>> selectto()
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

            return Ok(Rather);

        }
    }
    public class HelperOper
    {
        public static T ADONetToClass<T>(SqlDataReader reader) where T : new()
        {
            var entity = new T();
            var type = typeof(T);
            var properties = type.GetProperties();
            foreach (var item in properties)
            {
                if (item.Name == "ID")
                {
                    item.SetValue(entity, Guid.Parse(reader[item.Name].ToString()));

                }
                else
                {
                    item.SetValue(entity, Convert.ChangeType(reader[item.Name], item.PropertyType));
                }
            }

            return entity;
        }

    }
}