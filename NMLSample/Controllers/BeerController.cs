using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NMLSample.Models;
using System.Net;


namespace NMLSample.Controllers
{
    public class BeerController : Controller
    {

        string Baseurl = "http://localhost:51580/api/";

        public async Task<ActionResult> Index(string searchString)
        {
            {
                List<Beer> beerinfo = new List<Beer>();

                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(Baseurl);

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    client.DefaultRequestHeaders.Clear();


                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = new HttpResponseMessage();

                    if (String.IsNullOrEmpty(searchString))
                    {
                        Res = await client.GetAsync("beer");
                    }
                    else
                    {
                        Res = await client.GetAsync($"beer/{searchString}");
                    }

                    if (Res.IsSuccessStatusCode)
                    {
 
                        var beerResponse = Res.Content.ReadAsStringAsync().Result;


                        beerinfo = JsonConvert.DeserializeObject<List<Beer>>(beerResponse);

                    }

                    return View(beerinfo.OrderBy(t=>t.name));
                }
            }
        }
    }
}