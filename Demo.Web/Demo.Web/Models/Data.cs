using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Web.Models
{
    public class Data
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
    public class DataResponse
    {
        public string Name { get; set; }
        public string NumberName { get; set; }
        public bool success { get; set; }

    }
}