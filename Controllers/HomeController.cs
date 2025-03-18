using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNETCore_Localization.Models;
using Microsoft.Extensions.Localization;

namespace ASPNETCore_Localization.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    private readonly IStringLocalizer<HomeController> _localizer;


    public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
    {
        _logger = logger;
        _localizer = localizer;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        //ViewData["Title"] = _localizer["PrivacyPolicy"];
        ViewData["Title"] = _localizer.GetString("PrivacyPolicy");

        return View();
    }


    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ContactSave(ContactFormViewModel viewModel)
    {
        return View("Contact", viewModel);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
