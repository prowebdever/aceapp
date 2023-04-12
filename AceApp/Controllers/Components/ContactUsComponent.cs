using AceApp.Data;
using AceApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AceApp.Controllers
{
    [ViewComponent(Name = "ContactUsComponent")]
    public class ContactUsComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly UserManager<IdentityUser> _userManager;
        public ContactUsComponent(
            UserManager<IdentityUser> userManager,
            IUserService userService
        )
        {
            _userManager = userManager;
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
            if (user != null)
            {
                var userDetail = await _userService.GetUserDetail(user.Id);
                ContactUsDto dto = new ContactUsDto
                {
                    FirstName = userDetail.FirstName,
                    LastName = userDetail.LastName,
                    Email = userDetail.Email,
                };
                return View(dto);
            }
            return View();
        }
    }
}
