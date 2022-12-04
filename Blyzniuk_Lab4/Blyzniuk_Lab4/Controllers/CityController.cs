using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blyzniuk_Lab4.Models;
using Blyzniuk_Lab4.Services;

namespace Blyzniuk_Lab4.Controllers
{
    public class CityController : Controller
    {
        private CityService Service { get; }
        public CityController(CityService service) =>       
            Service = service;

        public async Task<IActionResult> Index()
        {
            return View(await Service.GetCities());
        }

        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(City city)
        {
            await Service.AddCity(city);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(Guid id) =>
            View(await Service.GetCityById(id));
        [HttpPost]
        public async Task<IActionResult> Edit(City city)
        {
            await Service.EditCity(city);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id) =>
            View(await Service.GetCityById(id));
        [HttpPost]
        public async Task<IActionResult> Delete(City city)
        {
            await Service.DeleteCity(city);
            return RedirectToAction("Index");
        }

    }
}
