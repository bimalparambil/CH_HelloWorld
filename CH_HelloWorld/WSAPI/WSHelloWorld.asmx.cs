using CH_HelloWorld;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSAPI
{
    /// <summary>
    /// Summary description for WSHelloWorld
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSHelloWorld : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetHello()
        {
            return HelloWorldBase.GetHelloWorld();
        }

        [WebMethod]
        public string WriteFile()
        {
            return HelloWorldChild.GetHelloWorld(ConfigurationManager.AppSettings["FilePath"], "Hello.txt");
        }
    }
}
