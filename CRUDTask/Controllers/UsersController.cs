using CRUDTask.Data;
using CRUDTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDTask.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var user = context.Users.ToList();
            return View("Index", user);
        }
        public IActionResult Create()
        {
            return View("Create", new User());
        }
        public IActionResult Store(User Request)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(Request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", Request);
        }
        public IActionResult Details(int id)
        {
            var user = context.Users.Find(id);
            return View("Details", user);
        }
        public IActionResult Edit(int id) {
            var user = context.Users.Find(id); 
            return View("Edit", user);
        }
        public IActionResult Update(User Request)
        {
            if (ModelState.IsValid)
            {
                context.Users.Update(Request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", Request);
        }
        public IActionResult Delete(int id)
        {
            var user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
