using Microsoft.AspNetCore.Mvc;
namespace ABCKENNELS
{
    public class HomeController : Controller
    {
        //Requests
        //localhot:5000/
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        //localhost:5000/hello
        [Route("hello")]
        [HttpGet] 
        public ViewResult Hello()
        {
            return View();
        }
        [Route("great")]
        [HttpGet] 
        public ViewResult Great()
        {
            return View();
        }
        [Route("york")]
        [HttpGet] 
        public ViewResult York()
        {
            return View();
        }
        [Route("gdpups")]
        [HttpGet] 
        public ViewResult Gdpups()
        {
            return View();
        }
        [Route("ypups")]
        [HttpGet] 
        public ViewResult Ypups()
        {
            return View();
        }
        [Route("buy")]
        [HttpGet] 
        public ViewResult Buy()
        {
            return View();
        }
    }

}