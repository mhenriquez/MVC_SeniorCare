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
    public class OptionTypeController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<OptionTypeModel> Get()
        {
            using (var context = new SeniorCareEntities())
            {
                var sql = "SELECT * FROM FacilityOptionTypes";
                var types = context.Database.SqlQuery<OptionTypeModel>(sql).ToList();

                return types;
            }
        }

        // GET api/<controller>/5
        [HttpGet]
        [ResponseType(typeof(OptionTypeModel))]
        public IHttpActionResult Get(int id)
        {
            using (var context = new SeniorCareEntities())
            {
                var sql = "SELECT * FROM FacilityOptionTypes WHERE ID = @ID";
                OptionTypeModel model = context.Database.SqlQuery<OptionTypeModel>(sql, new SqlParameter("ID", id)).SingleOrDefault();

                if (model == null)
                {
                    return NotFound();
                }

                return Ok(model);
            }
        }
    }
}
