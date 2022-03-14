using Microsoft.AspNetCore.Mvc;
using usuario.model;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ControllerBase
    {
        private static List<Currency> Cunrrencies()
        {
            return new List<Currency>
            {
                new Currency{ Id = 1, Valor = "2", Parcela = "5" },
                new Currency{ Id = 2, Valor = "2", Parcela = "5" },
            };
        }
        
        [HttpGet]
         public IActionResult Get()
        {
            return Ok(Cunrrencies());
        }
    }
}