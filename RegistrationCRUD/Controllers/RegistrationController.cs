using Microsoft.AspNetCore.Mvc;
using RegistrationCRUD.Interface;
using RegistrationCRUD.Models;

namespace RegistrationCRUD.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IUserService _userService;

        public RegistrationController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RegistrationViewModel model)
        {

           
            if (ModelState.IsValid)
            {

                int i=_userService.AddRegistration(model);
                if (i>0)
                {
                    return RedirectToAction(nameof(ListRegistration));
                }
            }


            return View(model);
        }


        public IActionResult ListRegistration()
        {
            var result = _userService.GetAllRegistration();
            return View(result);
        }
    }
}
