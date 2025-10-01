using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromBody]Loginreq req)
        {
            var res = new Loginres();

            if(req.Email=="admin@gmail.com" && req.Password == "Admin@123")
            {
                res.Statuscode = 1;
                res.msg = " Login Success";
            }
            else
            {
                res.Statuscode = -1;
                res.msg = " Login failed";
            }
            return Json(res);
        }
        public IActionResult Signup()
        {
            return View();
        }
    }
}
