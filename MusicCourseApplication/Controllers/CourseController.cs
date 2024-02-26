using Microsoft.AspNetCore.Mvc;
using MusicCourseApplication.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MusicCourseApplication.Controllers
{
    public class CourseController : Controller
    {

        //Course/Cards?id=123
        public IActionResult Cards(int id)
        {
            var cardProfileJson = System.IO.File.ReadAllText("Assets/cards.json");
            var jsonOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };
            var cards = JsonSerializer.Deserialize<IEnumerable<CourseCard>>(cardProfileJson, jsonOptions);
            var card = cards?.FirstOrDefault(p => p.Id == id);


            return View(card);
        }
    }
}
