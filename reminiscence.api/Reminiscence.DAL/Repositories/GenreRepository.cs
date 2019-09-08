using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reminiscence.DAL.Abstraction;
using Reminiscence.DAL.Data;
using Reminiscence.Model.DomainModels;
using Reminiscence.Model.EntityModels;

namespace Reminiscence.DAL.Repositories
{
    public class GenreRepository : BaseRepository, IGenreRepository
    {
        public GenreRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<Genre>> GetGenres()
        {
            var genres = await Context.Genres.Include(x => x.Features).Include(x => x.Photos).ToListAsync();

            return genres;
        }
    }
}
