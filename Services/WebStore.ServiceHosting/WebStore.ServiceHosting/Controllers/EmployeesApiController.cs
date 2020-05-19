using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain;
using WebStore.Domain.Models;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{
    [Route(WebAPI.Employees)]
    [ApiController]
    public class EmployeesApiController : ControllerBase,IEmployeesData
    {
        private readonly IEmployeesData _EmployeesData;
        public EmployeesApiController(IEmployeesData EmployeesData)
            => _EmployeesData = EmployeesData;
        [HttpPost]
        public void Add([FromBody] Employee Employee)
        {
            _EmployeesData.Add(Employee);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _EmployeesData.Delete(id);
        }
        [HttpPut("{id}")]
        public void Edit(int id, [FromBody] Employee Employee)
        {
            _EmployeesData.Edit(id, Employee);
        }
        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return _EmployeesData.GetAll();
        }
        [HttpGet("{id}")]
        public Employee GetById(int id)
        {
            return _EmployeesData.GetById(id);
        }
        [NonAction]
        public void SaveChanges()
        {
            _EmployeesData.SaveChanges();
        }
    }
}