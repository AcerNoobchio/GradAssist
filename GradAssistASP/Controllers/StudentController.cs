using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradAssistASP.Controllers
{
    public class StudentController : Controller
    {
        private GradAssistContext db = new GradAssistContext();

        // GET: Student
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
    }
}