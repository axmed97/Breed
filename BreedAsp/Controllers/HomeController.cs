using BreedAsp.Data;
using BreedAsp.Models;
using BreedAsp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BreedAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Header header = _context.Headers.First();
            AboutSection about = _context.AboutSections.First();
            List<Service> service = _context.Services.ToList();
            var testimonial = _context.Testimonials.ToList();
            var blog = _context.Blogs.ToList();
            List<Brands> brand = _context.Brands.ToList();
            HomeVM homeVM = new HomeVM()
            {
                Header = header,
                AboutSection = about,
                Services = service,
                Testimonials = testimonial,
                Blogs = blog,
                Brands = brand
            };
            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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
