using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminBSB.Area.Manage.Controllers
{
    public class MenuList
    {

        public int ID { get; set; }
        public int Name { get; set; }
    }


    public class MenuListController : Controller
    {
        // GET: MenuList
        public ActionResult Index()
        {

            List<MenuList> list = new List<MenuList>();
            list.Add(new MenuList { ID = 1, Name = 22 });



            return View();
        }
    }
}