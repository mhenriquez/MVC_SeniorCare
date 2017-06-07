using SeniorCare.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SeniorCare.Web.Controllers
{
    public class FacilitiesController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<FacilityModel> Get()
        {
            using (var context = new SeniorCareEntities())
            {
                var sql = "SELECT * FROM Facilities";
                var facilities = context.Database.SqlQuery<FacilityModel>(sql).ToList();

                return facilities;
            }
        }

        // GET api/<controller>/5
        [HttpGet]
        [ResponseType(typeof(FacilityModel))]
        public IHttpActionResult Get(int id)
        {
            using (var context = new SeniorCareEntities())
            {
                var sql = "SELECT * FROM Facilities WHERE ID = @ID";
                FacilityModel model = context.Database.SqlQuery<FacilityModel>(sql, new SqlParameter("ID", id)).SingleOrDefault();
                //Facility model = db.Facilities.Find(id);

                if (model == null)
                {
                    return NotFound();
                }

                return Ok(model);
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
