using Microsoft.AspNetCore.Mvc;
using ClassesGerenciador.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciadorDePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //// GET: api/<UsuarioController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<UsuarioController>/5
        //[HttpGet]
        //public List<string> Get()
        //{
        //}

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
