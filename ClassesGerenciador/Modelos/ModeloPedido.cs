using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassesGerenciador.Modelos
{
    public class ModeloPedido
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Cliente { get; set; }
        public string Status { get; set; }
        public DateOnly Data { get; set; }



        public void InserirPedido(int idUser, string descricao, decimal valor, string cliente, string status, DateOnly data)
        {
            string dateOnly = data.ToString("yyyy-MM-dd");
            DBConnection connection = new DBConnection();
            connection.ExecQuery($"INSERT INTO Pedidos (id_Usuario, Descricao, Valor, Cliente, Status, Data) VALUES ('{idUser}', '{descricao}', '{valor}', '{cliente}', '{status}', '{dateOnly}');");
        }

        public void EditarPedido(int id, int idUser, string descricao, decimal valor, string cliente, string status)
        {
            DBConnection connection = new DBConnection();
            connection.ExecQuery($"UPDATE Pedidos SET id_Usuario='{idUser}', Descricao='{descricao}', Valor='{valor}', Cliente='{cliente}', Status='{status}' WHERE idPedidos={id};");
        }
    }
}
