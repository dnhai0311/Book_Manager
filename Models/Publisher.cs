using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class Publisher
    {
        public string name { get; set; }
        public Publisher()
        {
            name = string.Empty;
        }
        public Publisher(string name)
        {
            this.name = name;
        }

    }
}

