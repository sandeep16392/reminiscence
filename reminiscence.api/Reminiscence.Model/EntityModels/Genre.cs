using System.Collections.Generic;

namespace Reminiscence.Model.EntityModels
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Feature> Features { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
