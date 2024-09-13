using Book_Manager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Book_Manager.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private AuthorContext authorContext;

        public AuthorRepository(AuthorContext authorContext)
        {
            this.authorContext = authorContext;
        }

        public void AddAuthor(Author author)
        {
            this.authorContext.add(author);

            string query = "INSERT INTO authors (name) VALUES (@name)";
            Database.Open();

            using (MySqlCommand command = new MySqlCommand(query, Database.con))
            {
                command.Parameters.AddWithValue("@name", author.name);
                command.ExecuteNonQuery();
            }

            Database.Close();
        }

        public List<Author> GetAllAuthors()
        {
            var authors = new List<Author>();

            Database.Open();
            try
            {
                using (var cmd = new MySqlCommand("SELECT * FROM authors", Database.con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var author = new Author
                            {
                                name = reader.GetString("name")
                            };
                            authors.Add(author);
                        }
                    }
                }
            }
            finally
            {
                Database.Close();
            }

            return authors;
        }

        public void UpdateRepositoryWithAllAuthors()
        {
            var authorsFromDb = GetAllAuthors();

            authorContext.Authors.Clear();
            authorContext.Authors.AddRange(authorsFromDb);
        }
    }
}
