using MySql.Data.MySqlClient;


namespace ClassesGerenciador.Modelos
{
    public class DBConnection
    {
        public string connectionString = "Server=localhost;Database=GerenciadorDePedidos;Uid=root;Pwd=123456;";
        List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void ExecQuery(string query) 
        {

            MySqlConnection conn = GetConnection();


            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {

                conn.Close();

            }

        }

        public List<Dictionary<string, object>> ListQuery(string query)
        {
            MySqlConnection conn = GetConnection();
            conn.Open();
            try
            {
                //string query = "SELECT * FROM Etapas";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }

                            results.Add(row);
                            //string test = reader["Etapa"].ToString();
                            ////Console.WriteLine(reader["Etapa"].ToString());

                          
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

            return results;
        }
    }
}
