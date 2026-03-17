using Microsoft.AspNetCore.Mvc;
using DemoMVC.Data;
using DemoMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace DemoMVC.Controllers
{

    public class StudentController(ApplicationDbContext context) : Controller
    {
        public IActionResult Index()
        private readonly ApplicationDbContext _context = context;

        {
            var students = await _context.Students.ToListAsync();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {

            _context.Students.Add(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(string id)
        {
            var student = await _context.Students.FindAsync(id);
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student std)
        {
            _context.Students.Update(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}