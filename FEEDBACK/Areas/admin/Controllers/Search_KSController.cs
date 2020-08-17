using FEEDBACK.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace FEEDBACK.Areas.admin.Controllers
{

    public class Search_KSController : Controller
    {
        // GET: admin/Search_KS
        public CSDL_FEEDBACK db = new CSDL_FEEDBACK();
        [HttpGet]
        public ActionResult Search(string searching)
        {

            var danhmuc_ks = db.Danhmuc_KS.Where(n => n.maloai_KS == searching).ToList();
            return View(danhmuc_ks);
        }
    }
}
