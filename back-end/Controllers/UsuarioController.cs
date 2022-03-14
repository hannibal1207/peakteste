using Microsoft.AspNetCore.Mvc;
using usuario.model;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> Usuarios()
        {
            return new List<Usuario>
            {
                new Usuario{ Id = 1, Nome = "João" },
                new Usuario{ Id = 2, Nome = "Maria" },
                new Usuario{ Id = 3, Nome = "Ana" }
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios());
        }

          [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
        }
    }
}