using Microsoft.AspNetCore.Mvc;
using ClassesGerenciador.Modelos;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciadorDePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        // GET: api/<PedidosController>
        [HttpGet]
        public IActionResult Get()
        {
            ModeloPedido pedidos = new ModeloPedido();
            List<Dictionary<string, object>> ListPedidos = pedidos.ListarTodosPedidos();

            string jsonResult = JsonConvert.SerializeObject(ListPedidos, Formatting.Indented);

            return Content(jsonResult, "application/json");
        }

        // GET api/<PedidosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ModeloPedido pedidos = new ModeloPedido();
            List<Dictionary<string, object>> Pedido = pedidos.ListarPedido(id);

            string jsonResult = JsonConvert.SerializeObject(Pedido, Formatting.Indented);

            return Content(jsonResult, "application/json");

        }

        // POST api/<PedidosController>
        [HttpPost]
        public void Post([FromBody] ModeloPedido pedido)
        {
            pedido.InserirPedido(pedido.IdUser, pedido.Descricao, pedido.Valor, pedido.Cliente, pedido.Status, pedido.Data);
        }

        // PUT api/<PedidosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ModeloPedido pedido)
        {
            pedido.EditarPedido(id, pedido.IdUser, pedido.Descricao, pedido.Valor, pedido.Cliente, pedido.Status);
        }

    }
}
