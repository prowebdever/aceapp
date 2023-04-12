using AceApp.Data;
using AceApp.Models;
using AceApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace AceApp.Controllers
{
    [Authorize]
    public class ClaimsController : Controller
    {
        private readonly IBlobStorageService _blobStorageService;
        private readonly IUserService _userService;
        private readonly IClaimsService _claimsService;
        private readonly UserManager<IdentityUser> _userManager;

        public ClaimsController(
            UserManager<IdentityUser> userManager,
            IBlobStorageService blobStorageService,
            IUserService userService,
            IClaimsService claimsService
        )
        {
            _userManager = userManager;
            _blobStorageService = blobStorageService;
            _userService = userService;
            _claimsService = claimsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("auto")]
        public async Task<IActionResult> AutoSubmission()
        {
            AutoClaimDto dto = new AutoClaimDto();
            dto.IsPermittedGatherMoreInfo = true;
            dto.IsReachAgreement = true;
            dto.LossTypes = Constant.LossTypeNames;
            dto.LossType = (int)LossType.None;
            var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
            if (user != null)
            {
                var userDetail = await _userService.GetUserDetail(user != null ? user.Id : "");
                if (userDetail != null)
                {
                    dto.CompanyName = userDetail.CompanyName;
                    dto.Office = userDetail.Office;
                    dto.WorkPhone = userDetail.PhoneNumber;
                    dto.Email = userDetail.Email;
                    dto.FaxNumber = userDetail.FaxNumber;
                    dto.Extension = userDetail.Extension;
                    dto.SubmittedBy = userDetail.Name;
                    dto.AceNo = userDetail.Id.ToString();
                }

            }

            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAutoSubmission(AutoClaimDto claimDto, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                var claim = await _claimsService.UpsertAutoClaim(claimDto, user != null ? user.Id : null);

                if (form.Files.Count > 0)
                {
                    foreach(var file in form.Files)
                    {
                        string fileName = DateTime.Now.Ticks + "_" + file.FileName;
                        string imgSrc = await _blobStorageService.UploadAvatarAsync(file, fileName);
                        AttachedImage dto = new AttachedImage
                        {
                            ImageSrc = imgSrc,
                            ClaimId = claim.Id,
                            ClaimType = (int)ClaimType.AUTO
                        };
                        await _claimsService.InsertAttachedImage(dto);
                    }

                }
                return Content("<div class='alert alert-success alert-dismissible' style='background-color: #2ebc9b;' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'></button><strong>Success!</strong> You submitted auto claim successfully. You can submit another one.</div>");

            }
            return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Something went wrong. Please provide valid information.</div>");
        }

        [Route("subrogation")]
        public async Task<IActionResult> SubrogationSubmission()
        {
            SubrogationClaimDto dto = new SubrogationClaimDto();
            dto.IsPermittedGatherMoreInfo = true;
            dto.IsReachAgreement = true;
            dto.LossTypes = Constant.LossTypeNames;
            dto.LossType = (int)LossType.None;
            dto.LiabilityPercent = 100;

            var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
            if (user != null)
            {
                var userDetail = await _userService.GetUserDetail(user != null ? user.Id : "");
                if (userDetail != null)
                {
                    dto.CompanyName = userDetail.CompanyName;
                    dto.Office = userDetail.Office;
                    dto.WorkPhone = userDetail.PhoneNumber;
                    dto.Email = userDetail.Email;
                    dto.FaxNumber = userDetail.FaxNumber;
                    dto.Extension = userDetail.Extension;
                    dto.SubmittedBy = userDetail.Name;
                    dto.AceNo = userDetail.Id.ToString();
                }
            }
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> SaveSubrogationSubmission(SubrogationClaimDto claimDto, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                var claim = await _claimsService.UpsertSubrogationClaim(claimDto, user != null ? user.Id : null);

                if (form.Files.Count > 0)
                {
                    foreach (var file in form.Files)
                    {
                        string fileName = DateTime.Now.Ticks + "_" + file.FileName;
                        string imgSrc = await _blobStorageService.UploadAvatarAsync(file, fileName);
                        AttachedImage dto = new AttachedImage
                        {
                            ImageSrc = imgSrc,
                            ClaimId = claim.Id,
                            ClaimType = (int)ClaimType.SUBROGATION
                        };
                        await _claimsService.InsertAttachedImage(dto);
                    }

                }
                return Content("<div class='alert alert-success alert-dismissible' style='background-color: #2ebc9b;' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'></button><strong>Success!</strong> You submitted auto claim successfully. You can submit another one.</div>");

            }
            return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Something went wrong. Please provide valid information.</div>");
        }


        [Route("specialty")]
        public async Task<IActionResult> SpecialtySubmission()
        {
            SpecialtyClaimDto dto = new SpecialtyClaimDto();
            dto.IsPermittedGatherMoreInfo = true;
            dto.IsReachAgreement = true;
            dto.LossTypes = Constant.LossTypeNames;
            dto.LossType = (int)LossType.None;

            var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
            if (user != null)
            {
                var userDetail = await _userService.GetUserDetail(user != null ? user.Id : "");
                if (userDetail != null)
                {
                    dto.CompanyName = userDetail.CompanyName;
                    dto.Office = userDetail.Office;
                    dto.WorkPhone = userDetail.PhoneNumber;
                    dto.Email = userDetail.Email;
                    dto.FaxNumber = userDetail.FaxNumber;
                    dto.Extension = userDetail.Extension;
                    dto.SubmittedBy = userDetail.Name;
                    dto.AceNo = userDetail.Id.ToString();
                }

            }
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> SaveSpecialtySubmission(SpecialtyClaimDto claimDto, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                var claim = await _claimsService.UpsertSpecialtyClaim(claimDto, user != null ? user.Id : null);

                if (form.Files.Count > 0)
                {
                    foreach (var file in form.Files)
                    {
                        string fileName = DateTime.Now.Ticks + "_" + file.FileName;
                        string imgSrc = await _blobStorageService.UploadAvatarAsync(file, fileName);
                        AttachedImage dto = new AttachedImage
                        {
                            ImageSrc = imgSrc,
                            ClaimId = claim.Id,
                            ClaimType = (int)ClaimType.SPECIALTY
                        };
                        await _claimsService.InsertAttachedImage(dto);
                    }

                }
                return Content("<div class='alert alert-success alert-dismissible' style='background-color: #2ebc9b;' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'></button><strong>Success!</strong> You submitted auto claim successfully. You can submit another one.</div>");

            }
            return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Something went wrong. Please provide valid information.</div>");
        }


        [Route("property")]
        public async Task<IActionResult> PropertySubmission()
        {
            PropertyClaimDto dto = new PropertyClaimDto();
            dto.IsPermittedGatherMoreInfo = true;
            dto.IsReachAgreement = true;
            dto.PolicyTypes = Constant.PolicyTypeNames;
            dto.PolicyType = (int)PolicyType.ReplacementCost;

            dto.StateNames = Constant.StateNames;
            dto.StateValues = Constant.StateValues;

            var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
            if (user != null)
            {
                var userDetail = await _userService.GetUserDetail(user != null ? user.Id : "");
                if (userDetail != null)
                {
                    dto.CompanyName = userDetail.CompanyName;
                    dto.Office = userDetail.Office;
                    dto.WorkPhone = userDetail.PhoneNumber;
                    dto.Email = userDetail.Email;
                    dto.FaxNumber = userDetail.FaxNumber;
                    dto.Extension = userDetail.Extension;
                    dto.SubmittedBy = userDetail.Name;
                    dto.AceNo = userDetail.Id.ToString();
                }

            }
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> SavePropertySubmission(PropertyClaimDto claimDto, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                var claim = await _claimsService.UpsertPropertyClaim(claimDto, user != null ? user.Id : null);

                if (form.Files.Count > 0)
                {
                    foreach (var file in form.Files)
                    {
                        string fileName = DateTime.Now.Ticks + "_" + file.FileName;
                        string imgSrc = await _blobStorageService.UploadAvatarAsync(file, fileName);
                        AttachedImage dto = new AttachedImage
                        {
                            ImageSrc = imgSrc,
                            ClaimId = claim.Id,
                            ClaimType = (int)ClaimType.PROPERTY
                        };
                        await _claimsService.InsertAttachedImage(dto);
                    }

                }
                return Content("<div class='alert alert-success alert-dismissible' style='background-color: #2ebc9b;' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'></button><strong>Success!</strong> You submitted auto claim successfully. You can submit another one.</div>");

            }
            return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Something went wrong. Please provide valid information.</div>");
        }

        [Route("photo-quote")]
        public async Task<IActionResult> PhotoQuoteSubmission()
        {
            PhotoQuoteClaimDto dto = new PhotoQuoteClaimDto();
            dto.LossTypes = Constant.LossTypeNames;
            dto.LossType = (int)LossType.None;

            var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
            if (user != null)
            {
                var userDetail = await _userService.GetUserDetail(user != null ? user.Id : "");
                if (userDetail != null)
                {
                    dto.CompanyName = userDetail.CompanyName;
                    dto.Office = userDetail.Office;
                    dto.WorkPhone = userDetail.PhoneNumber;
                    dto.Email = userDetail.Email;
                    dto.FaxNumber = userDetail.FaxNumber;
                    dto.Extension = userDetail.Extension;
                    dto.SubmittedBy = userDetail.Name;
                    dto.AceNo = userDetail.Id.ToString();
                }

            }
            return View(dto);
        }

        public async Task<IActionResult> SavePhotoQuoteSubmission(PhotoQuoteClaimDto claimDto, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                var claim = await _claimsService.UpsertPhotoQuoteClaim(claimDto, user != null ? user.Id : null);

                if (form.Files.Count > 0)
                {
                    foreach (var file in form.Files)
                    {
                        string fileName = DateTime.Now.Ticks + "_" + file.FileName;
                        string imgSrc = await _blobStorageService.UploadAvatarAsync(file, fileName);
                        AttachedImage dto = new AttachedImage
                        {
                            ImageSrc = imgSrc,
                            ClaimId = claim.Id,
                            ClaimType = (int)ClaimType.PHOTOQUOTE
                        };
                        await _claimsService.InsertAttachedImage(dto);
                    }

                }
                return Content("<div class='alert alert-success alert-dismissible' style='background-color: #2ebc9b;' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'></button><strong>Success!</strong> You submitted auto claim successfully. You can submit another one.</div>");

            }
            return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Something went wrong. Please provide valid information.</div>");
        }

        [Route("total-loss")]
        public async Task<IActionResult> TotalLossSubmission()
        {
            TotalLossClaimDto dto = new TotalLossClaimDto();
            dto.PowerOptionList = new List<SelectListItem>();
            foreach(var item in Constant.PowerOptionNames)
            {
                dto.PowerOptionList.Add(new SelectListItem { Text = item, Value=item});
            }
            dto.RadioList = new List<SelectListItem>();
            foreach (var item in Constant.RadioNames)
            {
                dto.RadioList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.SeatsList = new List<SelectListItem>();
            foreach (var item in Constant.SeatsNames)
            {
                dto.SeatsList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.DecorList = new List<SelectListItem>();
            foreach (var item in Constant.DecorNames)
            {
                dto.DecorList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.SafetyList = new List<SelectListItem>();
            foreach (var item in Constant.SafetyNames)
            {
                dto.SafetyList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.WheelsList = new List<SelectListItem>();
            foreach (var item in Constant.WheelsNames)
            {
                dto.WheelsList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.ConvenienceList = new List<SelectListItem>();
            foreach (var item in Constant.ConvenienceNames)
            {
                dto.ConvenienceList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.RoofList = new List<SelectListItem>();
            foreach (var item in Constant.RoofNames)
            {
                dto.RoofList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.PaintList = new List<SelectListItem>();
            foreach (var item in Constant.PaintNames)
            {
                dto.PaintList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.TruckList = new List<SelectListItem>();
            foreach (var item in Constant.TruckNames)
            {
                dto.TruckList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.MotorcycleList = new List<SelectListItem>();
            foreach (var item in Constant.MotorcycleNames)
            {
                dto.MotorcycleList.Add(new SelectListItem { Text = item, Value = item });
            }
            dto.VehicleState = null;
            dto.StateNames = Constant.StateNames;
            dto.StateValues = Constant.StateValues;

            var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
            if (user != null)
            {
                var userDetail = await _userService.GetUserDetail(user != null ? user.Id : "");
                if (userDetail != null)
                {
                    dto.CompanyName = userDetail.CompanyName;
                    dto.Office = userDetail.Office;
                    dto.WorkPhone = userDetail.PhoneNumber;
                    dto.Email = userDetail.Email;
                    dto.FaxNumber = userDetail.FaxNumber;
                    dto.Extension = userDetail.Extension;
                    dto.SubmittedBy = userDetail.Name;
                    dto.AceNo = userDetail.Id.ToString();
                }
            }
            return View(dto);
        }
        public async Task<IActionResult> SaveTotalLossSubmission(TotalLossClaimDto claimDto, IFormCollection form)
        {
            if (ModelState.IsValid)
            {

                var user = User.Identity.IsAuthenticated ? await _userManager.GetUserAsync(HttpContext.User) : null;
                var claim = await _claimsService.UpsertTotalLossClaim(claimDto, user != null ? user.Id : null);

                if (form.Files.Count > 0)
                {
                    foreach (var file in form.Files)
                    {
                        string fileName = DateTime.Now.Ticks + "_" + file.FileName;
                        string imgSrc = await _blobStorageService.UploadAvatarAsync(file, fileName);
                        AttachedImage dto = new AttachedImage
                        {
                            ImageSrc = imgSrc,
                            ClaimId = claim.Id,
                            ClaimType = (int)ClaimType.TOTALLOSS
                        };
                        await _claimsService.InsertAttachedImage(dto);
                    }

                }
                return Content("<div class='alert alert-success alert-dismissible' style='background-color: #2ebc9b;' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'></button><strong>Success!</strong> You submitted auto claim successfully. You can submit another one.</div>");

            }
            return Content("<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><strong>Oops!!!</strong> Something went wrong. Please provide valid information.</div>");
        }

    }
}
