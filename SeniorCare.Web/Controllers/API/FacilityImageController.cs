using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SeniorCare.Web.Models;
using System.Data.SqlClient;
using System.Web.Http.Description;
using System.IO;
using System.Net.Http.Headers;

namespace SeniorCare.Web.Controllers
{
    public class FacilityImageController : ApiController
    {
        [HttpGet]
        [TypeConverter(typeof(FacilityModel))]
        public async Task<HttpResponseMessage> Get(string ID)
        {
            using (var context = new SeniorCareEntities())
            {
                string sql = "SELECT ID, Image FROM Facilities WHERE ID = @ID";

                FacilityModel facility = await context.Database.SqlQuery<FacilityModel>(sql, new SqlParameter("@ID", ID)).FirstOrDefaultAsync();

                if (facility.Image == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
                else
                {
                    byte[] data = facility.Image;
                    var stream = new MemoryStream(data);
                    var httpResponse = new HttpResponseMessage(HttpStatusCode.OK);
                    httpResponse.Content = new ByteArrayContent(stream.ToArray());
                    httpResponse.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                    return httpResponse;
                }
            }
        }
    }
}
