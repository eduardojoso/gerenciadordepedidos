using Microsoft.AspNetCore.Mvc;
using ClassesGerenciador.Modelos;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciadorDePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtapasController : ControllerBase
    {
        // GET: api/<EtapasController>
        [HttpGet]
        public IActionResult Get()
        {
            ModeloEtapas etapas = new ModeloEtapas();
            List<Dictionary<string, object>> ListEtapas = etapas.ListarTodasEtapas();

            string jsonResult = JsonConvert.SerializeObject(ListEtapas, Formatting.Indented);

            return Content(jsonResult, "application/json");
        }

        // GET api/<EtapasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ModeloEtapas etapas = new ModeloEtapas();
            List<Dictionary<string, object>> Etapa = etapas.ListarEtapa(id);

            string jsonResult = JsonConvert.SerializeObject(Etapa, Formatting.Indented);

            return Content(jsonResult, "application/json");
         
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
