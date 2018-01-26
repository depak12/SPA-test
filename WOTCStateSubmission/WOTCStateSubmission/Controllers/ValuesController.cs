//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using Dapper;
//using System.Data.SqlClient;

//namespace WOTCStateSubmission.Controllers
//{
//    [Route("api/[controller]")]
//    public class ValuesController : Controller
//    {
//        private readonly IConfiguration configuration;
//        public ValuesController(IConfiguration config)
//        {
//            this.configuration = config;

//        }

//       //GET/POST/PUT/DELETE/PATCH
//        // GET api/values
//        [HttpPut]
//        public ActionResult  SaveEmployee(List<Employee>  emps)
//        {
//            var context = new WOTCContext();

//            // return context.Test.ToList();
//            //return new string[] { "value1", "value2" };
//            return Ok();//200
//        }

//        [HttpPut]
//        public string  SaveEmployee(string s)
//        {
//            var context = new WOTCContext();
//            // return context.Test.ToList();
//            return "sdfsfds";
//            //return new string[] { "value1", "value2" };
//        }


//        // GET api/values/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/values
//        //[HttpPost]
//        //public void Post([FromBody]string value)
//        //{
//        //}

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//        //[FromBody]WOTCStateSubmission.Classes.WOTCStateSubmission submission)
//      //  [HttpPost]
//       // [Route("/state/{stateAbbreviation}/submit")]
//        //public IActionResult Post([FromBody]WOTCStateSubmission.Employer submission)
//        //{
//        //    string connStr = configuration.GetConnectionString("TestConnection");
//        //    try
//        //    {
//        //        string sql = "SELECT * FROM Employer";
//        //        List<Employer> data;
//        //        try
//        //        {
//        //            using (var connection = new SqlConnection(connStr))
//        //                data = connection.Query<Employer>(sql).ToList();
//        //            if (data.Count > 0) return Ok(data);
//        //            else return NotFound();
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            return BadRequest();
//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        return BadRequest();
//        //    }










//            //try
//            //{
//            //    return Ok();
//            //}
//            //catch
//            //{
//            //    return BadRequest();
//            //}
//        }
//    }


