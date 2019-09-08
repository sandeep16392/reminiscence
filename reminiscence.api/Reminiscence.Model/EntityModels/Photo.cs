using System;

namespace Reminiscence.Model.EntityModels
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDefault { get; set; }
        //public string PublicId { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
