using System;
using Data;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Controllers
{
    public class HomeController : Controller
    {
        private OrionDbContext context;
        public HomeController(OrionDbContext cc)
        {
            context = cc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateDepartment()
        {
            var dept = new Department()
            {
                Name = "Designing"
            };
            context.Entry(dept).State = EntityState.Added;
            context.SaveChanges();

            return View();
        }

        public IActionResult CreateInformation()
        {
            var info = new Information()
            {
                Name = "YogiHosting",
                License = "XXYY",
                Revenue = 1000,
                Establshied = Convert.ToDateTime("2014/06/24")
            };
            context.Entry(info).State = EntityState.Added;
            context.SaveChanges();

            return View();
        }

    }
}