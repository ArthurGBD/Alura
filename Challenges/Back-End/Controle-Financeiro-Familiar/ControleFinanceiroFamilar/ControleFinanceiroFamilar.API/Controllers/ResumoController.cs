using ControleFinanceiroFamilar.API.Service;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiroFamilar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumoController : ControllerBase
    {

        private readonly IResumoService _resumoService;

        public ResumoController(IResumoService resumoService)
        {
            _resumoService = resumoService;
        }

        [HttpGet("{mes}/{ano}")]
        public async Task<IActionResult> GetResumoData(int mes, int ano)
        {
            try
            {
                var result = await _resumoService.GetResumoData(mes, ano);
                if (result == null)
                {
                    return NotFound($"Informação não localizada");
                }

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Resumo>> AddResumo(Resumo resumo)
        {
            try
            {
                if (resumo == null)
                {
                    return BadRequest();
                }
                
                var criarResumo = await _resumoService.AddResumo(resumo);

                if (criarResumo == null) return BadRequest();

                //return CreatedAtAction(nameof(criarResumo), new { Ano = criarResumo.Ano, Mes = criarResumo.Mes }, criarResumo);
                return Ok(criarResumo);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao retornar os daos do banco de dados");
            }
        }

    }
}
