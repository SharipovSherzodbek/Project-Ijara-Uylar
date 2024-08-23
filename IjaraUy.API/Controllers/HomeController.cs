//=================================================
// Copyright(c) Coalition of Good-Hearted Engineers
// Free To Use For Your Comfort and Peace !
//=================================================


using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace IjaraUy.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => Ok("The brown fox jumped over the lazy dog");
    }
}
