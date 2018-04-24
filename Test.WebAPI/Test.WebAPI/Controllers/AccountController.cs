using System;
using System.Web.Http;
using Test.WebAPI.Models;
using Test.WebAPI.Utilities;

namespace Test.WebAPI.Controllers
{
    
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {      
        public AccountController()
        {
        }
        /// <summary>
        /// convert number into place value
        /// </summary>
        /// <param name="Name">Name</param>
        /// <param name="Number">Number</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetConvertedData")]
        public Response ConvertData(string Name,float Number)
        {
            var response = new Response()
            {
                Name = Name,
                NumberName = GenericUtilities.ConvertNumberToWords(Number),
                success = true

            };
            return response;
        }
    }
}
