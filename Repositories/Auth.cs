using MySql.Data.MySqlClient;

namespace Book_Manager.Repositories
{
    public class Auth
    {
        public bool AuthenticateUser(string name, string password)
        {
            bool isLoggedIn = false;

            string query = "SELECT COUNT(1) FROM USERS WHERE users.name = @name AND users.password = @password";
            if (!Database.Open()) return false;

            using (MySqlCommand command = new MySqlCommand(query, Database.con))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);

                
                int userCount = Convert.ToInt32(command.ExecuteScalar());

                if (userCount == 1)
                {
                    isLoggedIn = true;
                }

                Database.Close();
            }
            return isLoggedIn;
        }
    }
}
