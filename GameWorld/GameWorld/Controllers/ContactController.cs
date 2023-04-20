using GameWorld.Data;
using GameWorld.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GameWorld.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Submit(Contact contact)
        {

            contact.SubmittedAt = DateTime.Now;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("ThankYou");
        }

        public ActionResult ThankYou()
        {
            return View();
        }

        [Authorize(Roles ="Administrator")]
        public ActionResult Messages()
        {
            //a list of all the messages in the database
            var messages = _context.Contacts.ToList();
            return View(messages);
        }
    }
}
