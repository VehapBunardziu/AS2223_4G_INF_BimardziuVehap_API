using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_BimardziuVehap_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/")]
    public class MathController : Controller
    {
        [HttpGet("evenorodd")]
        public JsonResult Evenorodd(int n)
        {
            if (n % 2 == 0)
            { 
                return Json(new { output = new {number = n, message = "even"}, status = "OK" });

            }else if (n % 2 == 1)
            {
                return Json(new { output = new { number = n, message = "odd" }, status = "OK" });
            }
            else
            {
                return Json(new { output = new { number = n, message = "" }, status = "KO" });
            }
           
        }
    }
}
