using _9_het.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyBoat.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public ActionResult M1()
        {
            HajosContext context = new HajosContext();
            var kérdések = from x in context.Questions select x.Question1;

            return new JsonResult(kérdések);
        }
    }
}
