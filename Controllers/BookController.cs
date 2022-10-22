using CRUDahm.Data;
using CRUDahm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUDahm.Controllers
{
    public class BookController : Controller
    {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.BookList.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookList item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                _context.SaveChanges();
            }
            return View(item);
        }
        public IActionResult Edit(int id)
        {
            var book = _context.BookList.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BookList item)
        {
            if (ModelState.IsValid)
            {
                _context.Update(item);
                _context.SaveChanges();
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var book = _context.BookList.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(BookList item)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(item);
                _context.SaveChanges();
            }
            return View(item);
        }
    }
}
