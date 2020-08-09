using FEEDBACK.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace FEEDBACK.Controllers
{
    public class loginController : Controller
    {
        CSDL_FEEDBACK db = new CSDL_FEEDBACK();
        // GET: /login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.err = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(Nguoidung user)
        {
            //check ten_dn da ton tai chua
            var checkaccount = db.Nguoidungs.Any(x => x.ten_dn == user.ten_dn &&
                x.matkhau == user.matkhau);

            var checkadmin = db.Nguoidungs.Any(x => x.ten_dn == user.ten_dn &&
                    x.ten_dn == "admin" &&
                    x.matkhau == user.matkhau);

            if (checkaccount)
            {
                ViewBag.err = "";

                Session["ten_dn"] = user.ten_dn;

                FormsAuthentication.SetAuthCookie(user.ten_dn, false);
                if (checkadmin)
                {

                    return Redirect("~/admin/Admin/Index");


                    /* return RedirectToAction("Danhsach_KS","Home"); */
                }
                else
                {
                    return Redirect("/");
                }
            }

            else
            {
                Session["user"] = null;
                ViewBag.err = "Tài khoản hoặc mật khẩu không đúng";
                //  ModelState.AddModelError("Account", "Tài khoản hoặc mật khẩu không đúng...!");
                return  View();
            }

        }

         public ActionResult DangXuat()
        {
            //Đăng xuất khỏi ứng dụng
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            //Về trang chủ
            return Redirect("/");
        }
    }
}