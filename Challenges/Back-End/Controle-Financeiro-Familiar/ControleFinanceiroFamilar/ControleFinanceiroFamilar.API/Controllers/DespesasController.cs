using ControleFinanceiroFamilar.API.Repositories;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiroFamilar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        private readonly IDespesasRepository _despesasRepository;

        public DespesasController(IDespesasRepository despesasRepository)
        {
            _despesasRepository = despesasRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetDespesas()
        {
            try
            {
                var result = await _despesasRepository.GetDespesas();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Despesas>> GetDespesa(int id)
        {
            try
            {
                var result = await _despesasRepository.GetDespesa(id);
                if (result == null)
                {
                    return NotFound($"Informação não localizada!");
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Despesas>> CreateReceita([FromBody] Despesas despesa)
        {
            try
            {
                if (despesa == null)
                {
                    return BadRequest();
                }

                var createdDespesa = await _despesasRepository.AddDespesa(despesa);

                return Ok(createdDespesa);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao retornar os daos do banco de dados");
            }
        }


        [HttpPut("{id:}")]
        public async Task<ActionResult<Despesas>> UpadateDespesa(int id, Despesas despesa)
        {
            try
            {
                if (id != despesa.Id)
                {
                    return BadRequest($"O Id {id} não confere com a despesa a ser atualizada");
                }
                return await _despesasRepository.UpdateDespesa(despesa);
            }

            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Despesas>> DeleteDespesa(int id)
        {
            try
            {
                var despesaToDelete = await _despesasRepository.GetDespesa(id);

                if (despesaToDelete == null)
                {
                    return NotFound($"Despesa com id = {id} não encontrada");
                }

                return await _despesasRepository.DeleteDespesa(id);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }
    }
}
