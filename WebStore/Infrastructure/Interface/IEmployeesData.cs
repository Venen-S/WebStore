﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Infrastructure.Interface
{
    public interface IEmployeesData
    {
        //получение списка сотрудников
        IEnumerable<EmployeeViewModel> GetAll();
        //получение сотрудника по id
        EmployeeViewModel GetById(int id);

        //сохранить
        void Commit();
        //добавить
        void AddNew(EmployeeViewModel model);
        //удалить
        void Delete(int id);
    }
}
