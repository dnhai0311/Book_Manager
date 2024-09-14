using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class Author
    {
        public string name { get; set; }
        public Author()
        {
            name = string.Empty;
        }
        public Author(string name)
        {
            this.name = name;
        }
    }

}
