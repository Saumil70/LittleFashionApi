using LittleFashionApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LittleFashionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LittleFashionController : ControllerBase
    {
        private readonly LittlefashionEntites _db;

        public LittleFashionController(LittlefashionEntites db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Cards()
        {
            var cardsData = _db.Cards.ToList();
            return Ok(cardsData);
        }
    }
}
