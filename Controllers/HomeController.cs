
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
            return View();
        }

        
    }
}