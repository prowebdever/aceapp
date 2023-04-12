using AceApp.Data;
using AceApp.Models;
using AceApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AceApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IEmailSender _emailSender;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IEmailSender emailSender,
            IUserService userService
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _emailSender = emailSender;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("/login")]
        public async Task<IActionResult> Login(string ReturnUrl = "")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MemberSignIn(LoginUserDto loginDto)
        {
            string returnUrl = "/";
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserID);

                if (user == null)
                    return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong>This UserID Is Not Exists! Please Try with another one!!</div>");
                
                int countLock = await _userManager.GetAccessFailedCountAsync(user);
                int count = 4 - countLock;
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(loginDto.UserID, loginDto.Password, true, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    return Content("<div class='alert alert-success alert-dismissible' role='alert' style='background-color:#59ca7c;'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Success!!!</strong> Please wait, redirecting to dashboard. If not redirected in 5 sec. <a class='text-white' id='dasboardURL' href='" + returnUrl + "'>Tap here.</a></div>");
                }
                
                if (result.IsLockedOut)
                {
                    return Content("<div class='alert alert-danger alert-dismissible' role='alert' ><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Your account has been locked. Please contact to support Or Try After Sometime!!<a id='dasboardURL'></a></div>");
                }
                else
                {
                    return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Invalid Credentials." + count + " Attempts Remaining!Please try again.<a id='dasboardURL'></a></div>");
                }
            }
            return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Something went wrong. Please provide valid information.<a id='dasboardURL'></a></div>");
        }

        [AllowAnonymous]
        [Route("/register")]
        public async Task<IActionResult> Register()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MemberSignUp(RegisterUserDto userDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    #region Register User Directly

                    var user = new IdentityUser { UserName = userDto.Name, Email = userDto.Email, EmailConfirmed = true };
                    var result = await _userManager.CreateAsync(user, userDto.Password);
                    if (result.Succeeded)
                    {
                        UserDetailDto userDetail = new UserDetailDto();
                        
                        userDetail.Email = userDto.Email;
                        userDetail.PhoneNumber = userDto.PhoneNumber;
                        userDetail.FaxNumber = userDto.FaxNumber;
                        userDetail.Extension = !string.IsNullOrEmpty(userDto.Extension) ? userDto.Extension : "";
                        userDetail.UserId = user.Id;
                        userDetail.Name = userDto.Name;
                        userDetail.CompanyName = userDto.CompanyName;
                        userDetail.Office = userDto.Office;
                        userDetail.FirstName = userDto.FirstName;
                        userDetail.LastName = userDto.LastName;

                        // save userDetail
                        await _userService.AddEditUserDetail(userDetail);
                        
                        var loginResult = await _signInManager.PasswordSignInAsync(userDto.Name, userDto.Password, true, lockoutOnFailure: true);
                        
                        return Content("<div class='alert alert-success alert-dismissible' style='background:#3fa95f' role='alert'><strong>Congrats!</strong> Your account has been created successfully.</div>");

                    }
                    else
                    {
                        return Content("<div class='alert alert-danger alert-dismissible' role='alert' style='background: #e52424;'><strong>Sorry!!!</strong>The status is:" + result.ToString() + "</div>");
                    }
                    #endregion

                }
            }
            catch (Exception ex)
            {
                return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> " + ex.Message + "</div>");
            }


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserDetailDto userDto)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userDto.UserId);

                user.Email = userDto.Email;
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);

                if (userDto.Password != null)
                {
                    await _userManager.RemovePasswordAsync(user);
                    await _userManager.AddPasswordAsync(user, userDto.Password);
                }
                userDto.FirstName = userDto.Name.Split(" ")[0];
                userDto.LastName = userDto.Name.Replace(userDto.FirstName, "");
                await _userService.AddEditUserDetail(userDto);

                return Content("<div class='alert alert-success alert-dismissible' style='background:#3fa95f' role='alert'><strong>Congrats!</strong> Your account has been updated successfully.</div>");
            }
            catch (Exception ex)
            {
                return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> " + ex.Message + "</div>");
            }

        }

        [HttpPost]
        public async Task<IActionResult> ContactUs(ContactUsDto dto)
        {
            try
            {
                string emailSubject = dto.FirstName + "" + dto.LastName + " (" + dto.Email + ") sent some issue";
                string emailBody = dto.Description;
                await _emailSender.SendEmailAsync(null, emailSubject, emailBody);
                return Content("<div class='alert alert-success alert-dismissible' style='background:#3fa95f' role='alert'><strong>Congrats!</strong> You sent email successfully.</div>");
            }
            catch (Exception ex)
            {
                return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> " + ex.Message + "</div>");
            }

        }

        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> IsAlreadySigned(string Email)
        {
            var user = await _userManager.FindByEmailAsync(Email);
            if (user != null)
            {
                var currentUser = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                if (currentUser == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json(currentUser.Email == Email ? true : false);
                }
            }
            else
            {
                return Json(true);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> IsAlreadyNameSigned(string Name)
        {
            var user = await _userManager.FindByNameAsync(Name);
            if (user != null)
            {
                var currentUser = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                if (currentUser == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json(currentUser.UserName == Name ? true : false);
                }
            }
            else
            {
                return Json(true);
            }
        }
    }
}
