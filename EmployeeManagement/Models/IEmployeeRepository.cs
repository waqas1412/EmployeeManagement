﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployees();

        Employee Add(Employee employee);
        Employee Update(Employee employeechanges);
        Employee Delete(int id);
    }
}
