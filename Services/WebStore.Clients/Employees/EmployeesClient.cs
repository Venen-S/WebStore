using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebStore.Clients.Base;
using WebStore.Domain;
using WebStore.Domain.Models;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Employees
{
    public class EmployeesClient : BaseClient,IEmployeesData
    {
        public EmployeesClient(IConfiguration Configuration) : base(Configuration, WebAPI.Employees) { }

        void IEmployeesData.Add(Employee Employee) => Post(_ServiceAddress, Employee);

        bool IEmployeesData.Delete(int id) => Delete($"{_ServiceAddress}/{id}").IsSuccessStatusCode;

        void IEmployeesData.Edit(int id, Employee Employee) => Put($"{_ServiceAddress}/{id}", Employee);

        IEnumerable<Employee> IEmployeesData.GetAll() => Get<List<Employee>>(_ServiceAddress);

        Employee IEmployeesData.GetById(int id) => Get<Employee>($"{_ServiceAddress}/{id}");

        void IEmployeesData.SaveChanges() { }
    }
    
}
