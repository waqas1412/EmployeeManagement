﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
    {
        new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@pragimtech.com" },
        new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@pragimtech.com" },
        new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@pragimtech.com" },
    };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
        if(employee!=null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeechanges)
        {

            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeechanges.Id);
            if (employee != null)
            {
                employee.Name = employeechanges.Name;
                employee.Email = employeechanges.Email;
                employee.Department = employeechanges.Department;
            }
            return employee;
        }
    }

}
