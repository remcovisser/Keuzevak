using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Week5Part1.Models;

namespace Week5Part1.Controllers
{
    public class GroupsController : Controller
    {
        private ApplicationDbContext _context;

        public GroupsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Groups
        public IActionResult Index()
        {
            return View(_context.Groups.ToList());
        }

        // GET: Groups/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Groups groups = _context.Groups.Single(m => m.Id == id);
            if (groups == null)
            {
                return HttpNotFound();
            }

            return View(groups);
        }

        // GET: Groups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Groups/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Groups groups)
        {
            if (ModelState.IsValid)
            {
                _context.Groups.Add(groups);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groups);
        }

        // GET: Groups/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Groups groups = _context.Groups.Single(m => m.Id == id);
            if (groups == null)
            {
                return HttpNotFound();
            }
            return View(groups);
        }

        // POST: Groups/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Groups groups)
        {
            if (ModelState.IsValid)
            {
                _context.Update(groups);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groups);
        }

        // GET: Groups/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Groups groups = _context.Groups.Single(m => m.Id == id);
            if (groups == null)
            {
                return HttpNotFound();
            }

            return View(groups);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Groups groups = _context.Groups.Single(m => m.Id == id);
            _context.Groups.Remove(groups);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
