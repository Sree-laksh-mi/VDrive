using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VDrive.Services;

namespace VDrive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodBankController : Controller
    {
        //// GET: FoodBankController
        //[HttpGet(Name = "GetFood")]
        //public int GetFood()
        //{
        //    return 10;
        //}

        [HttpGet("GetLocation")]
        public string GetNearestFoodBankLocation(string id)
        {
            return id;
        }

        [HttpGet("GetSomeValue")]
        public IActionResult GetSomeValue(string location)
        {
           

            var data = FoodBankApi.GetFoodBanksByLocation(location);

            return Json(data);
        }



    }
}
