using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Chat
    {
        public string? model { get; set; }

        public List<Message> messages { get; set; }

        public float temperature { get; set; }  
    }
}
