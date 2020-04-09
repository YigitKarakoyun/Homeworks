using ProjectPagedList.Entity;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace ProjectPagedList.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMeyvelerEntities db = Tools.GetMeyvelerEntities();
        public ActionResult Index(int sayfa = 1)
        {
            var temp = db.TBL_MEYVELER.ToList().ToPagedList(sayfa,3);
            return View(temp);
        }
    }
}