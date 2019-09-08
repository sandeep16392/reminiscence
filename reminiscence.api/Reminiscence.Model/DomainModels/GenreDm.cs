using System;
using System.Collections.Generic;
using System.Text;

namespace Reminiscence.Model.DomainModels
{
    public class GenreDm
    {
        public string Name { get; set; }
        public List<string> Features { get; set; }
        public string DefaultPhoto { get; set; }
    }
}
