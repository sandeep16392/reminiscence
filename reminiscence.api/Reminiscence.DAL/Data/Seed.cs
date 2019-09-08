using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Reminiscence.Model.EntityModels;

namespace Reminiscence.DAL.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext dataContext)
        {
            _context = dataContext;
        }

        public void SeedGenreData()
        {
            var data = _context.Genres.ToList();
            if (data.Count <= 0)
            {
                var genres = System.IO.File.ReadAllText("../Reminiscence.DAL/Data/seedData.json");
                var genresData = JsonConvert.DeserializeObject<List<Genre>>(genres);
                _context.Genres.AddRange(genresData);
                _context.SaveChanges();
            }
        }
    }
}
