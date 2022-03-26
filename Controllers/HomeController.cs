
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace Pokemon_API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //create the request to the API
            WebRequest request= WebRequest.Create("https://pokeapi.co/api/v2/pokemon/1");
            //Send that request off
            WebResponse response= request.GetResponse();
            //Getb back the response stream
            Stream stream = response.GetResponseStream();
            // make it accessible
            StreamReader reader = new StreamReader(stream);
            //Put into string which is JSON formatted
            string responseFromServer = reader.ReadToEnd();
            return View();
        }

        
    }
}