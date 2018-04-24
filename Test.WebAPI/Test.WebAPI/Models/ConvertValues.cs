using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.WebAPI.Models
{
    public class Request
    {
        public string Name { get; set; }
        public Double Number { get; set; }
    }

    public class Response
       {
        public string Name { get; set; }
        public string NumberName { get; set; }
        public bool success { get; set; }
    }
}