using KT0720_63136967.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace KT0720_63136967.Controllers
{
    public class NguyenTuanTu0720_63135967Controller : Controller
    {
        private Model_63135967Entities db = new Model_63135967Entities(); 

        // Action để hiển thị danh sách sinh viên
        public ActionResult Index()
        {
            //var sinhViens = db.SINHVIEN.ToList();
            //return View(sinhViens);
            return View();
        }

        // Action để hiển thị thông tin chi tiết của một sinh viên
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    SINHVIEN sinhVien = db.SINHVIEN.Find(id);

        //    if (sinhVien == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(sinhVien);
        //}

        // Các action khác (Thêm mới, cập nhật, xóa) có thể được thêm vào controller tương ứng.
    }
}
