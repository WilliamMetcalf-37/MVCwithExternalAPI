using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SquadUpMVC.Data;
using SquadUpMVC.Models;

namespace SquadUpMVC.Controllers
{
    public class SquadsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SquadsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        // GET: Squad
        public ActionResult Index()
        {
            return View();
        }

        // GET: Squad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }      

        // GET: Squad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Squad/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Squad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Squad/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}