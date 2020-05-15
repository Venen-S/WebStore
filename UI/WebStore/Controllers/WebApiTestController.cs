using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Interfaces.Api;

namespace WebStore.Controllers
{
    public class WebApiTestController : Controller
    {
        private readonly IValueServices _valueServices;
        public WebApiTestController(IValueServices ValuesServices) => _valueServices = ValuesServices;
        
        public IActionResult Index()
        {
            return View(_valueServices.Get());
        }
    }
}