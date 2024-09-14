using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    public class PublisherContext
    {
        public List<Publisher> Publishers { get; set; }
        public PublisherContext()
        {
            Publishers = new List<Publisher>();
        }
        public void Add(Publisher Publisher)
        {
            Publishers.Add(Publisher);
        }

        public List<string> GetPublisherNames()
        {
            List<string> publisherNames = new List<string>();

            foreach (var publisher in Publishers)
            {
                if (!string.IsNullOrEmpty(publisher.name))
                {
                    publisherNames.Add(publisher.name);
                }
            }

            return publisherNames;
        }

        public bool ContainsName(string name)
        {
            return Publishers.Any(publisher => publisher.name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
