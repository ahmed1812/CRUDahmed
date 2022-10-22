using CRUDahm.Data;
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
    }
}
