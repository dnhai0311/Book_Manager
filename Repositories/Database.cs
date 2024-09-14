using MySql.Data.MySqlClient;

namespace Book_Manager.Repositories
{
    public class Database
    {
        public static MySqlConnection con = new MySqlConnection();
        public static bool Open()
        {
            try
            {
                con = new MySqlConnection("Server=localhost;Database=book_manager;Uid=root;Pwd=;");
                con.Open();
            }
            catch (Exception) 
            {
                MessageBox.Show($"Không thể kết nối với database");
                return false;
            }
            return true;
        }

        public static bool Close()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show($"Không thể kết nối với database");
                return false;
            }
            return true;
        }
    }
}
