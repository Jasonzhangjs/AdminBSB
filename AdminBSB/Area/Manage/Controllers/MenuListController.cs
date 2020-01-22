using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminBSB.Area.Manage.Controllers
{
    public class MenuLists
    {
        public List<Menu> Menus { get; set; }
    }
    public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public int? ParentID { get; set; }
        public string userID { get; set; }
        public string Area { get; set; }
        public int sort { get; set; }
        public string Role { get; set; }
    }


    public class MenuListController : Controller
    {
        // GET: MenuList
        public ActionResult Index()
        {
            //假的登陆人
            string UserID = "haoyue.yang";

            //假的list
            List<Menu> list = new List<Menu>();
            list.Add(new Menu { ID = 0, Name = "One", Controller = "", ParentID = null, userID = "haoyue.yang", Role = "First Person", Area = "AdminBSB", sort = 0 });
            list.Add(new Menu { ID = 4, Name = "One-Two", Controller = "OneTwo", ParentID = 0, userID = "haoyue.yang", Role = "First Person", Area = "AdminBSB", sort = 2 });
            list.Add(new Menu { ID = 1, Name = "One-One", Controller = "OneOne", ParentID = 0, userID = "haoyue.yang", Role = "First Person", Area = "AdminBSB", sort = 1 });
            list.Add(new Menu { ID = 2, Name = "Two", Controller = "", ParentID = null, userID = "haoyue.yang", Role = "Second Person", Area = "AdminBSB", sort = 0 });
            list.Add(new Menu { ID = 3, Name = "Two-One", Controller = "TwoOne", ParentID = 2, userID = "haoyue.yang", Role = "Second Person", Area = "AdminBSB", sort = 1 });

            //返回有权限的list
            List<Menu> haslist = list.Where(p => p.userID == UserID).OrderBy(i => i.sort).OrderBy(i => i.Role).ToList();
            //ViewBag.menulist = haslist;
            return PartialView(new MenuLists { Menus = haslist });
            //return PartialView(haslist);
            //return View();
        }
    }
}