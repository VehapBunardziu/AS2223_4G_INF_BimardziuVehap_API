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


        [HttpGet("factorial")]
        public JsonResult Factorial(int n)
        {
            if(n >= 0)
            {
                int output = n; 
                for(int i = n; i > 1; i--)
                {
                    output = output + (output * i-1);
                }
                return Json(new { output = new { number = n, factorial = output}, status = "OK" });
            }
            else
            {
                return Json(new { output = new { number = n, message = "Number is negative" }, status = "KO" });
            }

        }

        [HttpGet("Income-basedtaxes")]
        public JsonResult Incomebasedtaxes(int income)
        {
            if(income < 35000)
            {
                int temp = (income / 100) * 12;
                return Json(new { output = new { income = income, taxes = temp}, status = "OK" });
            }
            else
            {      
                int temp = (35000/ 100) * 12;
                temp = temp + (((income - 35000) / 100) * 28);
                return Json(new { output = new { income = income, taxes = temp }, status = "OK" });
            }
        }
    }
}
