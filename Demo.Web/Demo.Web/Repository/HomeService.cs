using Demo.Web.Generic_Utilities;
using Demo.Web.Models;
using Demo.Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Web.Repository
{
    public class HomeService : ServiceBAse
    {
        string serviceUrl = string.Empty;
        string apiUrl = string.Empty;
        public HomeService()
        {
             serviceUrl = Util.GetConfigData("servicebaseurl");
             apiUrl = Util.GetConfigData("dataapiurl");
        }
        public DataResponse GetApiData(Data data)
        {
            var url = serviceUrl + string.Format(apiUrl, data.Name, data.Number);
            var apiResponse = base.Get<DataResponse>(url);
            if (apiResponse != null && apiResponse.success)
            {
                return apiResponse;
            }
            return new DataResponse();
        }
    }
}