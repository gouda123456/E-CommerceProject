using E_CommerceProject.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;


        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult SignIn()
        {
            ViewData["Layout"] = null;
            return View("SignIn");
        }

        [HttpPost]
        public async Task<IActionResult> SaveSignIn(SignInViewModel siginViewModel)
        {
            if (ModelState.IsValid == true)
            {
                User applicationUsers = new User();
                applicationUsers.UserName = siginViewModel.FullName;
                applicationUsers.FullName = siginViewModel.FullName;

                applicationUsers.Email = siginViewModel.Email;
                applicationUsers.PasswordHash = siginViewModel.Password;
                applicationUsers.PhoneNumber = siginViewModel.PhoneNumber;

                IdentityResult result = await _userManager.CreateAsync(applicationUsers, siginViewModel.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(applicationUsers, false);
                    return RedirectToAction("LogIn", "Account");

                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }


            }
            return View("SignIn", siginViewModel);

        }



        public IActionResult Register()
        {

            return View();
        }

        public async Task<IActionResult> SaveRegister(RegisterViewModel userLogInViewModel)
        {
            if (ModelState.IsValid == true)
            {
                User users = await _userManager.FindByEmailAsync(userLogInViewModel.Email);
                if (users != null)
                {
                    bool Check = await _userManager.CheckPasswordAsync(users, userLogInViewModel.Password);
                    if (Check == true)
                    {
                        await _signInManager.SignInAsync(users, userLogInViewModel.RememberMe);
                        return RedirectToAction("Index", "Home");

                    }
                }
            }
            ModelState.AddModelError("", "Email Or Password is Wrong");
            return View("Register", userLogInViewModel);

        }



        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return View("SignIn");
        }

    }
}
