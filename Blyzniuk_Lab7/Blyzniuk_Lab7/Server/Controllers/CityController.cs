using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blyzniuk_Lab7.Shared.Models;
using Blyzniuk_Lab7.Server.Services;

namespace Blyzniuk_Lab7.Server.Controllers {
    [Route("api/[controller]")][ApiController]
    public class CityController : ControllerBase {
        private CityService Service { get; }
        public CityController(CityService service) =>
            Service = service;

        [HttpGet]
        public async Task<List<City>> Get() {
            return await Service.GetCities();
        }

        [HttpGet("{id}")]
        public async Task<City> GetById(Guid id) {
            return await Service.GetCityById(id);
        }

        [HttpPost]
        public async Task Post(City city) {
            await Service.AddCity(city);
        }

        [HttpPut]
        public async Task Put(City city) {
            await Service.EditCity(city);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            City city = await Service.GetCityById(id);
            await Service.DeleteCity(city);
        }
    }
}
