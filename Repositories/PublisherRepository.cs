using Book_Manager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        PublisherContext publisherContext { get; set; }
        public PublisherRepository(PublisherContext publisherContext)
        {
            this.publisherContext = publisherContext;
        }
        public void AddPublisher(Publisher publisher)
        {
            this.publisherContext.Add(publisher);

            string query = "INSERT INTO publishers (name) VALUES (@name)";
            Database.Open();

            using (MySqlCommand command = new MySqlCommand(query, Database.con))
            {
                command.Parameters.AddWithValue("@name", publisher.name);

                command.ExecuteNonQuery();
            }

            Database.Close();
        }
        public List<Publisher> GetAllPublishers()
        {
            var publishers = new List<Publisher>();

            Database.Open();
            try
            {
                using (var cmd = new MySqlCommand("SELECT * FROM publishers", Database.con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var publisher = new Publisher
                            {
                                name = reader.GetString("name")
                            };
                            publishers.Add(publisher);
                        }
                    }
                }
            }
            finally
            {
                Database.Close();
            }

            return publishers;
        }

        public void UpdateRepositoryWithAllPublishers()
        {
            var publishersFromDb = GetAllPublishers();

            publisherContext.Publishers.Clear();
            publisherContext.Publishers.AddRange(publishersFromDb);
        }
    }
}
