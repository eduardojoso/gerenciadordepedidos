using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGerenciador.Modelos
{
    public class ModeloUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Perfil { get; set; }
        public string Status { get; set; }

        public void InserirUsuario(string nome, string perfil, string status)
        {
            DBConnection connection = new DBConnection();
            connection.DbConnection($"INSERT INTO Usuario (Nome, Perfil, Status) VALUES ('{nome}', '{perfil}', '{status}');");
        }

        public void EditarUsuario(int id, string nome, string perfil, string status)
        {
            DBConnection connection = new DBConnection();
            connection.DbConnection($"UPDATE Usuario SET Nome='{nome}', Perfil='{perfil}', Status='{status}' WHERE idUsuario={id};");
        }
    }
}
