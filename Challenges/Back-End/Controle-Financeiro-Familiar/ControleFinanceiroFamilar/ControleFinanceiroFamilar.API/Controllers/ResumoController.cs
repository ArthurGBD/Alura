using ControleFinanceiroFamilar.API.Service;
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

        [HttpGet]
        public async Task<IActionResult> GetResumoData(int ano, int mes)
        {
            try
            {
                var result = await _resumoService.GetResumoData(ano, mes);
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

    }
}
