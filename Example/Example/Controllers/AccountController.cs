using Example.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(HttpPostedFileBase Avatar, RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Lấy tên tệp ảnh
                    string postedFileName = Path.GetFileName(Avatar.FileName);
                    // Lưu hình đại diện về Server
                    var path = Server.MapPath("/Images/" + postedFileName);
                    Avatar.SaveAs(path);
                    string fSave = Server.MapPath("/App_Data/register.txt");
                    string[] emInfo = { model.Name, model.PhoneNumber, model.Email, model.Password, "/Images/" + postedFileName };
                    // Lưu thông tin đăng ký vào tệp tin
                    System.IO.File.WriteAllLines(fSave, emInfo);

                    // Ghi nhận các thông tin đăng ký để hiển thị trên View Confirm
                    ViewBag.Name = emInfo[0];
                    ViewBag.PhoneNumber = emInfo[1];
                    ViewBag.Email = emInfo[2];
                    ViewBag.Password = emInfo[3];
                    ViewBag.Avatar = emInfo[4];
                    return View("Confirm");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Lỗi khi xử lý đăng ký: " + ex.Message);
                }
            }

            return View(model);
        }

        public ActionResult Confirm()
        {
            return View();
        }
    }
}