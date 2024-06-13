using MySql.Data.MySqlClient;

namespace ClassesGerenciador.Modelos
{
    public class DBConnection
    {
        public string connectionString = "Server=localhost;Database=GerenciadorDePedidos;Uid=root;Pwd=123456;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void ListQuery()
        {
            MySqlConnection conn = GetConnection();
            conn.Open();
            try
            {
                string query = "SELECT * FROM Etapas";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string test = reader["Etapa"].ToString();
                            //Console.WriteLine(reader["Etapa"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
