﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGerenciador.Modelos
{
    public class ModeloEtapas
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public string Etapa { get; set; }


        public void InserirEtapa(int idPedido, int idUsuario, string etapa)
        {
            DBConnection connection = new DBConnection();
            connection.ExecQuery($"INSERT INTO Etapas (id_Pedido, id_Usuario, Etapa) VALUES ('{idPedido}', '{idUsuario}', '{etapa}');");
        }

        public void EditarEtapa(int id, int idPedido, int idUsuario, string etapa)
        {
            DBConnection connection = new DBConnection();
            connection.ExecQuery($"UPDATE Etapas SET id_Pedido='{idPedido}', id_Usuario='{idUsuario}', Etapa='{etapa}' WHERE idEtapas={id};");
        }

        public List<Dictionary<string, object>> ListarTodasEtapas()
        {
            DBConnection connection = new DBConnection();
            return connection.ListQuery("SELECT * FROM Etapas");


        }

        public List<Dictionary<string, object>> ListarEtapa(int id)
        {
            DBConnection connection = new DBConnection();
            return connection.ListQuery($"SELECT * FROM Etapas where idEtapas = {id}");
        }
    }


}
