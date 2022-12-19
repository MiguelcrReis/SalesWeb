using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listDepartments = new List<Department>();
            listDepartments.Add(new Department { Id = 1, Name = "TI" });
            listDepartments.Add(new Department { Id = 2, Name = "Design" });

            return View(listDepartments);
        }
    }
}
