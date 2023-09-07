using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rootobject
    {
        public string? id { get; set; }
        public string? _object { get; set; }
        public int created { get; set; }
        public string? model { get; set; }
        public Choice[]? choices { get; set; }
        public Usage? usage { get; set; }
    }
}
