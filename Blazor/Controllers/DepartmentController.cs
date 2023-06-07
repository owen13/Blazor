﻿using System.Linq;
using System.Threading.Tasks;
using Data;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Controllers
{
    public class DepartmentController : Controller
    {
        private OrionDbContext context;
        public DepartmentController(OrionDbContext cc)
        {
            context = cc;
        }

        public IActionResult Index()
        {
            return View(context.Department.AsNoTracking());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department dept)
        {
            context.Add(dept);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            Department dept = await context.Department.Where(e => e.Id == id).FirstOrDefaultAsync();
            return View(dept);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Department dept)
        {
            context.Update(dept);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var dept = new Department() { Id = id };
            context.Remove(dept);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
