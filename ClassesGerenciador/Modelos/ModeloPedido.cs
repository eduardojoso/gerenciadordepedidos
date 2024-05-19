using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGerenciador.Modelos
{
    public class ModeloPedido
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Descricao { get; set; }
        public string Cliente { get; set; }
        public bool Status { get; set; }

    }
}
