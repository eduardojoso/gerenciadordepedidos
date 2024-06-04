using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;

namespace ClassesGerenciador.Modelos
{
    public class DBConnection
    {
        public MySqlConnection DbConnection(string query)
        {
            string connectionString = "Server=localhost;Database=GerenciadorDePedidos;Uid=root;Pwd=123456;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
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
                return conn;
            }
        }

        public void ListQuery(MySqlConnection conn)
        {
                try
                {
                string? campo;
                    conn.Open();

                    string query = "SELECT * FROM Etapas";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["Etapa"].ToString());
                                // Substitua "ColumnName" pelo nome da coluna que você deseja acessar
                                 campo = reader["Etapa"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
        }
    }
    
}
