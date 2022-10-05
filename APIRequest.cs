using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WindowsFormsApp2
{
    public class APIRequest
    {
        public static string ETHPrice()
        {

                string url = "https://api.coinlore.net/api/ticker/?id=90,80";

                var client = new RestClient(url);

                var request = new RestRequest();

                var response = client.Get(request);
                string output = response.Content.ToString();


            return output;
        }
    }
}
