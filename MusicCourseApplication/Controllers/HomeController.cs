using Microsoft.AspNetCore.Mvc;
using MusicCourseApplication.Dtos;
using MusicCourseApplication.Models;
using System.Diagnostics;

namespace MusicCourseApplication.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Method(int? id, string? name)
        {
            return Ok($"Id: {id}; name:{name}");
        }

        [HttpGet]
        public IActionResult Coupon() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Coupon(CouponDto couponDto)
        {
            return Ok($"Post Succses! '{couponDto.CouponString}'");
        }



        public IActionResult Index()
        {
            return View();
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
