using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Reminiscence.Business.Abstractions;
using Reminiscence.Model.DomainModels;
using Reminiscence.Model.EntityModels;

namespace Reminiscence.Business.AutoMapper
{
    public class GenreMapper : Profile
    {
        public GenreMapper()
        {
            //CreateMap<GenreDm, Genre>();
            CreateEmToDmMap();
            CreateDmToEmMap();
        }

        private void CreateEmToDmMap()
        {
            CreateMap<Genre, GenreDm>()
                .ForMember(x => x.DefaultPhoto,
                    opt => { opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsDefault).Url); })
                .ForMember(x => x.Features, opt => { opt.MapFrom(src => src.Features.Select(x => x.Description)); });
        }

        private void CreateDmToEmMap()
        {
            
        }
    }
}
