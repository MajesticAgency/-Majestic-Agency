using Core.Entities;
using Core.Entities.ViewModel;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MajesticAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;
        private readonly ISubService _subService;
        private readonly IOrder _order;



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IService service, ISubService subService, IOrder order)
        {
            _logger = logger;
            _service = service;
            _subService = subService;
            _order = order;
        }

        public async Task<IActionResult> Index()
        {
            ViewModels viewModels = new ViewModels();
            viewModels.Services = await _service.GetServices();
            return View(viewModels);
        }

        public async Task<IActionResult> ServiceDetails(int id)
        {
            var service = await _service.GetService(id);
            return View(service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Order order)
        {
            if (ModelState.IsValid)
            {
                await _order.CreateOrder(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
    }
}
