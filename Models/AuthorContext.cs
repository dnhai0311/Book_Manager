using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class AuthorContext
    {
        public List<Author> Authors { get; set; }
        public AuthorContext()
        {
            Authors = new List<Author>();
        }
        public void add(Author author)
        {
            Authors.Add(author);
        }
        public List<string> GetAuthorNames()
        {
            List<string> authorNames = new List<string>();

            foreach (var author in Authors)
            {
                if (!string.IsNullOrEmpty(author.name))
                {
                    authorNames.Add(author.name);
                }
            }

            return authorNames;
        }

        public bool ContainsName(string name)
        {
            return Authors.Any(author => author.name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }
}
