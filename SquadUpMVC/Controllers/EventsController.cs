using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SquadUpMVC.Data;
using SquadUpMVC.Models;

namespace SquadUpMVC.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var uri = "https://edmtrain.com/api/events?locationIds=370&client=b75f3751-421f-40ce-992e-be13390c6864";
            var client = new HttpClient();

            // Set request header to accept JSON
            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStreamAsync();
                var EventData = await JsonSerializer.DeserializeAsync<Response>(json);

                if(EventData.Data == null)
                {
                    return RedirectToAction(nameof(ErrorLoading));
                }
                else
                {
                return View(EventData);

                }
            }
            else
            {
                return RedirectToAction(nameof(ErrorLoading));
            }

            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult ErrorLoading()
        {
            return View();
        }

    }
}