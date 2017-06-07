using SeniorCare.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace SeniorCare.Web.Controllers
{
    public class FacilityController : Controller
    {
        // GET: Facility
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        [OutputCache(Duration = 60, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult List()
        {
            ViewBag.Title = "Facility Listing";

            using (var context = new SeniorCareEntities())
            {
                string sql = "SELECT * FROM Facilities";
                var facilities = context.Database.SqlQuery<FacilityModel>(sql).ToList();

                return View(facilities);
            }
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            using (var context = new SeniorCareEntities())
            {
                string sql = "SELECT * FROM Facilities WHERE ID = @ID";
                var facility = context.Database.SqlQuery<FacilityModel>(sql, new SqlParameter("ID", id)).SingleOrDefault();

                if (facility == null)
                {
                    return HttpNotFound();
                }

                return View(facility);
            }
        }

        public PartialViewResult OptionTypes(int? id)
        {
            using (var context = new SeniorCareEntities())
            {
                string sql = "SELECT * FROM FacilityOptionTypes";
                var optiontypes = context.Database.SqlQuery<OptionTypeModel>(sql, new SqlParameter("ID", id)).SingleOrDefault();

                return PartialView(optiontypes);
            }
        }
    }
}