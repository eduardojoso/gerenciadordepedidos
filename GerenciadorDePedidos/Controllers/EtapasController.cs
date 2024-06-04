using Microsoft.AspNetCore.Mvc;
using ClassesGerenciador.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciadorDePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtapasController : ControllerBase
    {
        // GET: api/<EtapasController>
        [HttpGet]
        public void Get()
        {
            DBConnection conection = new DBConnection();
            conection.ListQuery(conection.DbConnection($"SELECT * FROM Etapas;"));
        }

        // GET api/<EtapasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EtapasController>
        [HttpPost]
        public void Post([FromBody] ModeloEtapas etapas)
        {
            etapas.InserirEtapa(etapas.IdPedido, etapas.IdUsuario, etapas.Etapa);
        }

        // PUT api/<EtapasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ModeloEtapas etapas)
        {
            etapas.EditarEtapa(id, etapas.IdPedido, etapas.IdUsuario, etapas.Etapa);
        }

       
    }
}
