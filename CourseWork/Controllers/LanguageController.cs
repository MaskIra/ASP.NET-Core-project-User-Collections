using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CourseWork.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index(string language)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language)), new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMonths(1) });
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
