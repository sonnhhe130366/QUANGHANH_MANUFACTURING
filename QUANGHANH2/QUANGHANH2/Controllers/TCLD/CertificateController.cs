﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;using System.Web.Routing;

namespace QUANGHANHCORE.Controllers.TCLD
{
    public class CertificateController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Route("phong-tcld/chung-chi/danh-sach-chung-chi")]
        public ActionResult List()
        {
            ViewBag.nameDepartment = "vld-antoan";
            return View("/Views/TCLD/Certificate/List.cshtml");
        }
        [Route("phong-tcld/chung-chi/danh-sach-nhan-vien-co-chung-chi-kiem-dinh-ky-thuat-an-toan-lao-dong")]
        public ActionResult ListBriefsByCertificate()
        {
            ViewBag.nameDepartment = "vld-antoan";
            return View("/Views/TCLD/Certificate/ListBriefByCertificate.cshtml");
        }
    }
}