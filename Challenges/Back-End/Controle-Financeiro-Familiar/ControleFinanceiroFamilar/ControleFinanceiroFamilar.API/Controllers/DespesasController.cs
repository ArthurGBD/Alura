using ControleFinanceiroFamilar.API.Service;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiroFamilar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        private readonly IDespesasService _despesasRepository;

        public DespesasController(IDespesasService despesasRepository)
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
        public async Task<ActionResult<Despesa>> GetDespesaById(int id)
        {
            try
            {
                var result = await _despesasRepository.GetDespesaById(id);
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

        [HttpGet("{descricao}/{mes}")]
        public async Task<ActionResult> GetDespesaByMonth(string descricao, int mes, int ano)
        {
            try
            {
                var despesaDescricaoAndMonth = await _despesasRepository.GetDespesasByMonth(descricao, mes, ano);
                if (despesaDescricaoAndMonth == null)
                {
                    return NotFound($"Informação não localizada!");
                }
                return Ok(despesaDescricaoAndMonth);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Despesa>> CreateReceita(Despesa despesa)
        {
            try
            {
                if (despesa == null)
                {
                    return BadRequest();
                }

                var createdDespesa = await _despesasRepository.AddDespesa(despesa);

                if (createdDespesa == null)
                {
                    return BadRequest($"O item {despesa.Descricao} não pode ser adicionado pois já existe na data {despesa.Data.Month}/{despesa.Data.Year}");
                }

                return Ok(createdDespesa);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao retornar os daos do banco de dados");
            }
        }


        [HttpPut("{id:}")]
        public async Task<ActionResult<Despesa>> UpadateDespesa(int id, Despesa despesa)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }

                if (despesa == null)
                {
                    return BadRequest();
                }

                if (id != despesa.Id)
                {
                    return BadRequest($"O Id {id} não confere com a despesa a ser atualizada");
                }
                return await _despesasRepository.UpdateDespesa(id, despesa);
            }

            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Despesa>> DeleteDespesa(int id)
        {
            try
            {
                var despesaToDelete = await _despesasRepository.GetDespesaById(id);

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
