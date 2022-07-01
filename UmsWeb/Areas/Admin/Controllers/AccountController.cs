using Microsoft.AspNetCore.Mvc;
using UmsWeb.DataAccess;
using UmsWeb.DataAccess.Repository.IRepository;
using UmsWeb.Models;

namespace UmsWeb.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _context;
        public AccountController(IUnitOfWork context)
        {
            _context = context;
        }
        public IActionResult StudentDetail(int id)
        {
            var student = _context.Students.GetFirstOrDefault(x => x.User.Id == id);
            return View(student);
        }

        //get
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Users user)
        {
            if(ModelState.IsValid)
            {
                var student = _context.Users.GetFirstOrDefault(x => x.Username == user.Username);
                if(student != null && student.Password==user.Password)
                {
                    return RedirectToAction("StudentDetail", new {id=user.Id});
                }
                return Content("invalid username");
            }
            return View(user);
        }
    }
}
