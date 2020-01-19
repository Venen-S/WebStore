using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Димон",
                SurName = "Удав",
                Patronymic = "Вадимович",
                Age = 30
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Николай",
                SurName = "Прохоров",
                Patronymic = "Игоревич",
                Age = 28
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            var employee = _employees.FirstOrDefault(x => x.Id == id);

            //Если такого не существует
            if (employee == null)
                return NotFound(); 

            return View(employee);
        }

    }
}
