using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RestSharp;
using VDrive.Model;
using static System.Net.Mime.MediaTypeNames;

namespace VDrive.Services
{
    public class FoodBankApi
    {
       static string baseUrl = "https://www.givefood.org.uk/api/2/";

        
        public static List<Foodbank> GetFoodBanksByLocation(string location) 
        {

            try
            {
                using (var client = new RestClient(baseUrl + @"foodbanks/search/"))
                {
                    //12 Millbank, Westminster, London SW1P 4QE
                    //https://www.givefood.org.uk/api/2/search/?address=12MillbankWestminsterLondonSW1P4QE
                    //https://www.givefood.org.uk/api/2/foodbanks/search/?address=12MillbankWestminsterLondonSW1P4QE
                    var location2 =  Regex.Replace(location, @"\s+", "");
                    var location3 = location2.Replace(",","");
                   // var location3 =  location2.Replace(@"\", @"\\");

                    var request = new RestRequest();
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
                    request.AddQueryParameter("address", location);
                    var response = client.Execute(request);
                    Console.WriteLine(response.Content);

                    var fbdata = JsonSerializer.Deserialize<Foodbank[]>(response.Content).ToList();
                    
                    return fbdata;

                }
            }
            catch (Exception)
            {
                return new List<Foodbank>();
                throw;
            }


        }
    }
}
