using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Week5Part1.Models;

namespace Week5Part1.Controllers
{
    public class TodoItemsController : Controller
    {
        private ApplicationDbContext _context;

        public TodoItemsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: TodoItems
        public IActionResult Index()
        {
            return View(_context.TodoItems.ToList());
        }

        // GET: TodoItems/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TodoItems todoItems = _context.TodoItems.Single(m => m.Id == id);
            if (todoItems == null)
            {
                return HttpNotFound();
            }

            return View(todoItems);
        }

        // GET: TodoItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TodoItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TodoItems todoItems)
        {
            if (ModelState.IsValid)
            {
                _context.TodoItems.Add(todoItems);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todoItems);
        }

        // GET: TodoItems/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TodoItems todoItems = _context.TodoItems.Single(m => m.Id == id);
            if (todoItems == null)
            {
                return HttpNotFound();
            }
            return View(todoItems);
        }

        // POST: TodoItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TodoItems todoItems)
        {
            if (ModelState.IsValid)
            {
                _context.Update(todoItems);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todoItems);
        }

        // GET: TodoItems/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TodoItems todoItems = _context.TodoItems.Single(m => m.Id == id);
            if (todoItems == null)
            {
                return HttpNotFound();
            }

            return View(todoItems);
        }

        // POST: TodoItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            TodoItems todoItems = _context.TodoItems.Single(m => m.Id == id);
            _context.TodoItems.Remove(todoItems);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
