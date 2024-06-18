using Microsoft.AspNetCore.Mvc;
using ClassesGerenciador.Modelos;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciadorDePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public IActionResult Get()
        {
            ModeloUsuario usuarios = new ModeloUsuario();
            List<Dictionary<string, object>> ListarUsuarios = usuarios.ListarTodosUsuarios();

            string jsonResult = JsonConvert.SerializeObject(ListarUsuarios, Formatting.Indented);

            return Content(jsonResult, "application/json");
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ModeloUsuario usuarios = new ModeloUsuario();
            List<Dictionary<string, object>> Usuario = usuarios.ListarUsuario(id);

            string jsonResult = JsonConvert.SerializeObject(Usuario, Formatting.Indented);

            return Content(jsonResult, "application/json");

        }

        [HttpPost]
        public void Post([FromBody] ModeloUsuario usuario)
        {
            usuario.InserirUsuario(usuario.Nome, usuario.Perfil, usuario.Status);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ModeloUsuario usuario)
        {
            usuario.EditarUsuario(id, usuario.Nome, usuario.Perfil, usuario.Status);
        }
    }
}
