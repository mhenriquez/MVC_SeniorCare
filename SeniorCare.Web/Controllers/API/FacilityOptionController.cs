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
    public class FacilityOptionController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<OptionModel> Get()
        {
            using (var context = new SeniorCareEntities())
            {
                var sql = "SELECT * FROM FacilityOptions";
                var options = context.Database.SqlQuery<OptionModel>(sql).ToList();

                return options;
            }
        }

        // GET api/<controller>/5
        [HttpGet]
        [ResponseType(typeof(OptionModel))]
        public IHttpActionResult Get(int id)
        {
            using (var context = new SeniorCareEntities())
            {
                var sql = "SELECT * FROM FacilityOptions WHERE ID = @ID";
                OptionModel model = context.Database.SqlQuery<OptionModel>(sql, new SqlParameter("ID", id)).SingleOrDefault();

                if (model == null)
                {
                    return NotFound();
                }

                return Ok(model);
            }
        }
    }
}
