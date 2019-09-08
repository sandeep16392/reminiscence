using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Reminiscence.Model.DomainModels;

namespace Reminiscence.Business.Abstractions
{
    public interface IGalleryService
    {
        Task<List<GenreDm>> GetGenres();
    }
}
