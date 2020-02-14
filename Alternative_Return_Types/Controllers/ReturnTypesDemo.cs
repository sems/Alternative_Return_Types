using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Alternative_Return_Types.Controllers
{
    [Route("api/returntypesdemo")]
    //[Produces(MediaTypeNames.Application.Json)]
    public class ReturnTypesDemo : Controller
    {

        [HttpGet("specific-type")]
        public string Get()
        {
            return "Simple string";
        }

        [HttpGet("json")]
        public JsonResult Get(string input)
        {
            return Json(new { key1 = "value1", key2 = "value2" });
        }

        [HttpGet("content-result")]
        public ContentResult Get(string input, string data)
        {
            return Content("This is a teststring", "text/html", new UTF8Encoding());
        }
    }
}
