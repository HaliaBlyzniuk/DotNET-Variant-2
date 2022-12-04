using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Blyzniuk_Lab7.Shared.Models;

namespace Blyzniuk_Lab7.Server.Services {
    public class CityService {
        private PhoneTalkContext Context { get; }
        public CityService(PhoneTalkContext context) {
            Context = context;
        }

        public async Task<List<City>> GetCities() {
            return await Context.Cities.ToListAsync();
        }

        public async Task<City> GetCityById(Guid id) {
            return await Context.Cities.SingleOrDefaultAsync(f => f.Id == id);
        }

        public async Task AddCity(City city) {
            await Context.Cities.AddAsync(city);
            await Context.SaveChangesAsync();
        }

        public async Task EditCity(City city) {
            Context.Cities.Update(city);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteCity(City city) {
            Context.Cities.Remove(city);
            await Context.SaveChangesAsync();
        }
    }
}
