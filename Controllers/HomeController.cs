using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET.Core.MVC.Models;

namespace ASP.NET.Core.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult MyWorks()
        {
            /*
            List<WorksModel> works = new List<WorksModel>();
            works.Add(new WorksModel
            {
                Work = "RELOD Tools",
                ShortDescription = "Программа с пользовательским интерфейсом, объединяющая в себе создание прайс-листа, парсеры сайтов, генерирование кодов и программу для сравнения авторов",
                Url = "https://github.com/Bezumk1n/RELOD-Tools"
            });
            works.Add(new WorksModel
            {
                Work = "AutoPrice",
                ShortDescription = "Программа, запускаемая раз в сутки (через планировщик заданий Windows) для актуализации прайс-листа",
                Url = "https://github.com/Bezumk1n/AutoPrice"
            });
            works.Add(new WorksModel
            {
                Work = "Rezume",
                ShortDescription = "Ссылка на репозиторий этого сайта",
                Url = "https://github.com/Bezumk1n/Rezume"
            });
            return View(works);

            */
            List<WorksModel> work = new List<WorksModel> ();
            work.Add(new WorksModel
            {
                Work = "RELOD Tools",
                ShortDescription = "Программа с пользовательским интерфейсом, объединяющая в себе создание прайс-листа, парсеры сайтов, генерирование кодов и программу для сравнения авторов",
                Url = "https://github.com/Bezumk1n/RELOD-Tools"
            });
            work.Add(new WorksModel
            {
                Work = "AutoPrice",
                ShortDescription = "Программа, запускаемая раз в сутки (через планировщик заданий Windows) для актуализации прайс-листа",
                Url = "https://github.com/Bezumk1n/AutoPrice"
            });
            work.Add(new WorksModel
            {
                Work = "Rezume",
                ShortDescription = "Ссылка на репозиторий этого сайта",
                Url = "https://github.com/Bezumk1n/Rezume"
            });
            return View(work);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
