using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace ExamplesWebApi.Controllers
{

    [Route("api/[controller]")]
    public class AboutController : Controller
    {
        private readonly IStringLocalizer<AboutController> _localizer;

        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public AboutController(IStringLocalizer<AboutController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        [HttpGet]
        public string Get()
        {
            return $"{ _localizer["About Title"] } - { _sharedLocalizer["Culture"] } - { DateTime.Now.ToLongDateString() }";
        }
    }
}
