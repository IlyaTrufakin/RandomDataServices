using Microsoft.AspNetCore.Mvc;
using RandomDataServices.Models;
using RandomDataServices.Services;
using System.Diagnostics;

namespace RandomDataServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRandomDataService _randomDataService;

        public HomeController(ILogger<HomeController> logger, IRandomDataService randomDataService)
        {
            _logger = logger;
            _randomDataService = randomDataService;
        }

        public IActionResult Index()
        {
            RandomDataServiceModel model = new()
            {
                ConfirmationCode = _randomDataService.GetConfirmationCode(6),
                CryptoSalt = _randomDataService.GetCryptoSalt(32),
                Filename = _randomDataService.GetFilename(16),
                ConfirmationCode—harsCollection = _randomDataService.ConfirmationCodeCharsCollection,
                CryptoSaltCharsCollection = _randomDataService.CryptoSaltCharsCollection,
                FileNameCharsCollection = _randomDataService.FileNameCharsCollection
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult GenerateRandomData()
        {
            var viewModel = new RandomDataServiceModel
            {
                ConfirmationCode = _randomDataService.GetConfirmationCode(6),
                CryptoSalt = _randomDataService.GetCryptoSalt(32),
                Filename = _randomDataService.GetFilename(16),
                ConfirmationCode—harsCollection = _randomDataService.ConfirmationCodeCharsCollection,
                CryptoSaltCharsCollection = _randomDataService.CryptoSaltCharsCollection,
                FileNameCharsCollection = _randomDataService.FileNameCharsCollection
            };

            return View("Index", viewModel);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
