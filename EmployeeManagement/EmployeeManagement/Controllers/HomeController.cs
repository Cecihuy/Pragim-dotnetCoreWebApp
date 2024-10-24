﻿using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeManagement.Controllers {
    public class HomeController : Controller {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        public ViewResult Index() {
            IEnumerable<Employee> model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public ViewResult Details(int id) {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                EmployeeVM = _employeeRepository.GetEmployee(id),
                PageTitleVM = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}
