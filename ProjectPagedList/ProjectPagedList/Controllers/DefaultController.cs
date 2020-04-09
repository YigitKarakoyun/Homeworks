using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using ProjectPagedList.Entity;

namespace ProjectPagedList.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Model1 db = Tools.GetMeyveler();
        public ActionResult Index(int sayfa = 1)
        {
            var temp = db.TBL_MEYVELER.ToList().ToPagedList(sayfa,3);
            return View(temp);
        }
    }
}