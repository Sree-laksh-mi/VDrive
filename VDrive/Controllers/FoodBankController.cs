using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet(Name = "GetLocation")]
        public int GetLocation(int id)
        {
            return id;
        }

       

        //[HttpGet]
        //public int GetFBName(int id)
        //{
        //    return 3;
        //}

    }
}
