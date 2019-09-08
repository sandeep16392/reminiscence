using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Reminiscence.Business.Abstractions;
using Reminiscence.Business.AutoMapper;
using Reminiscence.DAL.Abstraction;
using Reminiscence.Model.DomainModels;

namespace Reminiscence.Business.Services
{
    public class GalleryService : IGalleryService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GalleryService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }
        public async Task<List<GenreDm>> GetGenres()
        {
            var genres = await _genreRepository.GetGenres();
            var result = _mapper.Map<List<GenreDm>>(genres);
            //var result = genres.Select(x => _mapper.Map<GenreDm>(x)).ToList();
            return result;
        }
    }
}
