using System.Collections.Generic;
using Reminiscence.Model.DomainModels;
using Reminiscence.Model.EntityModels;

namespace Reminiscence.Business.Abstractions
{
    public interface IGenreMapper
    {
        List<GenreDm> ConvertEmToDm(List<Genre> genreEm);
        List<Genre> ConvertDmToEm(GenreDm genreDm);
    }
}
