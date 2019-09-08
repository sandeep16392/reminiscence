using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Reminiscence.Model.DomainModels;
using Reminiscence.Model.EntityModels;

namespace Reminiscence.DAL.Abstraction
{
    public interface IGenreRepository
    {
        Task<List<Genre>> GetGenres();
    }
}
