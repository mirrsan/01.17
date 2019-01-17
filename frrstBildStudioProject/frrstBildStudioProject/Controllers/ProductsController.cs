using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace frrstBildStudioProject.Controllers
{
    /// <summary>
    /// this is testing
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly Dictionary<int, string> proizvodi = new Dictionary<int, string>
        {
            [1] = "Monitor",
            [2] = "Mis"
        };

        [HttpGet]
        public string Details(int id)
        {
            if (!proizvodi.ContainsKey(id))
            {
                throw new Exception("Nemamo taj proizvod");
            }

            return proizvodi[id];
        }

        [HttpGet]
        public string Index()
        {
            return "cao cao";
        }
    }
}
