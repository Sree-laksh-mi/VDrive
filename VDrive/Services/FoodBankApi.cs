using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using VDrive.Model;

namespace VDrive.Services
{
    public class FoodBankApi
    {
        string baseUrl = "https://www.givefood.org.uk/api/2/";

        public FB GetFoodBanksByLocation(string location) 
        {
            throw new NotImplementedException();   
        }
    }
}
