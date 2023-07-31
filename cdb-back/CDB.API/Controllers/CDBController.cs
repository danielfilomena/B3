using CDB.Application.DTOs;
using CDB.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CDBController : ControllerBase
    {

        private ICalcularCDBService calcularCDBService;

        public CDBController(ICalcularCDBService calcular)
        {
            
            calcularCDBService = calcular;

        }

        [HttpPost("calcular-CDB")]
        public async Task<IActionResult> CalcularCDB([FromBody] CalculoCDBDto calculo)
        {
            var result = await calcularCDBService.CalcularCDB(calculo);
            return Ok(result);

        }


    }
}
