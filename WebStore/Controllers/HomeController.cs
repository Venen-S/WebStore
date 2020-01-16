using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                id=1,
                FirstName="Дима",
                SurName="Удав",
                Patronymic="Вадимович",
                Age=30,
                Position="Дружище"
            },
            new EmployeeView
            {
                id=2,
                FirstName="Николай",
                SurName="Прохоров",
                Patronymic="Игоревич",
                Age=28,
                Position="Просто царь xD"
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
            //return Content("Hello from controller");
        }

        public IActionResult Details(int id)
        {
            var employee = _employees.FirstOrDefault(x => x.id == id);
            if (employee == null)
                return NotFound();
            return View(employee);
        }
    }
}