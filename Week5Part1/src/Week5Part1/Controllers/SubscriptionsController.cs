using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Week5Part1.Models;

namespace Week5Part1.Controllers
{
    public class SubscriptionsController : Controller
    {
        private ApplicationDbContext _context;

        public SubscriptionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Subscriptions
        public IActionResult Index()
        {
            return View(_context.Subscription.ToList());
        }

        // GET: Subscriptions/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Subscription subscription = _context.Subscription.Single(m => m.Id == id);
            if (subscription == null)
            {
                return HttpNotFound();
            }

            return View(subscription);
        }

        // GET: Subscriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subscriptions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Subscription.Add(subscription);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subscription);
        }

        // GET: Subscriptions/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Subscription subscription = _context.Subscription.Single(m => m.Id == id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(subscription);
        }

        // POST: Subscriptions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Update(subscription);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subscription);
        }

        // GET: Subscriptions/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Subscription subscription = _context.Subscription.Single(m => m.Id == id);
            if (subscription == null)
            {
                return HttpNotFound();
            }

            return View(subscription);
        }

        // POST: Subscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Subscription subscription = _context.Subscription.Single(m => m.Id == id);
            _context.Subscription.Remove(subscription);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
