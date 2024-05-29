using Microsoft.AspNetCore.Mvc;
using ClassesGerenciador.Modelos;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciadorDePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        // GET: api/<PedidosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PedidosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
