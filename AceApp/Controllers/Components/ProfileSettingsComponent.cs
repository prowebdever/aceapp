using AceApp.Data;
using AceApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AceApp.Controllers
{
    [ViewComponent(Name = "ProfileSettingsComponent")]
    public class ProfileSettingsComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly UserManager<IdentityUser> _userManager;
        public ProfileSettingsComponent(
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
                var dto = await _userService.GetUserDetail(user.Id);
                return View(dto);
            }
            return View();

        }
    }
}
