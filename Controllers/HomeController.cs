using System;
//using QC = System.Data.SqlClient;  // System.Data.dll 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Links.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

                /*using (var connection = new QC.SqlConnection(  
                    //"Server=tcp:ganondorf.database.windows.net,1433;Database=Ganondorf;User ID=YOUR_LOGIN_NAME_HERE;Password=YOUR_PASSWORD_HERE;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"  
                    "Server=tcp:ganondorf.database.windows.net,1433;Initial Catalog=Ganondorf;Persist Security Info=False;User ID=00bd2e6a-c012-4868-841e-91ea619b6e3f;Password=b1gBadpassword;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                    ))  
                {  
                    connection.Open();  
                    Console.WriteLine("Connected successfully.");  

                    Console.WriteLine("Press any key to finish...");  
                    Console.ReadKey(true);  
                } */
            return View();
        }

        public IActionResult Popid()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
