﻿using MySql.Data.MySqlClient;

namespace Book_Manager.Repositories
{
    public class Database
    {
        public static MySqlConnection con = new MySqlConnection();
        public static bool open()
        {
            try
            {
                con = new MySqlConnection("Server=localhost;Database=book_manager;Uid=root;Pwd=;");
                con.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool close()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
