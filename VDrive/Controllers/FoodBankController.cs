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

        //[HttpGet("GetLocation")]
        //public string GetNearestFoodBankLocation(string id)
        //{
        //    return id;
        //}

        [HttpGet("GetNearestFoodBankLocation")]
        public IActionResult GetNearestFoodBankLocation(string location)
        {
            var data = FoodBankApi.GetFoodBanksByLocation(location);
            if (data.Count == 0)
                return NotFound();

            return Json(data);
        }



    }
}
