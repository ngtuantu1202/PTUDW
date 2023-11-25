using MyClass.DAO;
using MyClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace BanHang.Controllers
{
    public class ModuleController : Controller
    {
        MenusDAO menusDAO = new MenusDAO();
        ///////////////////////////////////////////////////////////////////
        //GET: MainMenu
        public ActionResult MainMenu()
        {
            List<Menus> list = menusDAO.getListByParentId(0);
            //return View(menusDAO.getListByParentId(0));
            return View("MainMenu",list);
        }
    }
}