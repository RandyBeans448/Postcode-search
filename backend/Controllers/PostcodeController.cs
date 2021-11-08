using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web.Http.Cors;


namespace C__Cook_API.Controllers

{
    [ApiController]
    [Route("[controller]")]
   
    public class PostcodeController : ControllerBase
    {

     
        [HttpGet]
        
        public string[] Get([FromQuery(Name = "postcode")] string postcode)
        {
            
            PostcodeService postcodeService = new PostcodeService();

            return postcodeService.GetValidDeliveryOptions(postcode);
        }   
    }
}