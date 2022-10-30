using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using VDrive.Model;
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
        [EnableCors]
        [HttpGet("GetNearestFoodBankLocation")]
        public IActionResult GetNearestFoodBankLocation(string location)
        {
            var fbs = new List<FBdto>();
            var data = FoodBankApi.GetFoodBanksByLocation(location);
            if (data.Count == 0)
                return NotFound();

            foreach(Foodbank fb in data)
            {
                var toadd = new FBdto() { name = fb.name, location = fb.lat_lng };
                fbs.Add(toadd);

            }

            return Json(fbs);
        }



    }
}
