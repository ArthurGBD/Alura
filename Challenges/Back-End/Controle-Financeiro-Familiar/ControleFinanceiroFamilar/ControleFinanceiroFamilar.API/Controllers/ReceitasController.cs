using ControleFinanceiroFamilar.API.Service;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiroFamilar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly IReceitasService _receitasRepository;

        public ReceitasController(IReceitasService receitasRepository)
        {
            _receitasRepository = receitasRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetReceitas()
        {
            try
            {
                var result = await _receitasRepository.GetReceitas();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Receita>> GetReceitaById(int id)
        {
            try
            {
                var result = await _receitasRepository.GetReceitaById(id);
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

        public async Task<ActionResult> GetReceitasByMonth(string descricao, int mes, int ano)
        {
            try
            {
                var receitasDescricaoAndMonth = await _receitasRepository.GetReceitasByMonth(descricao, mes, ano);
                if (receitasDescricaoAndMonth == null)
                {
                    return NotFound($"Informação não localizada!");
                }
                return Ok(receitasDescricaoAndMonth);

            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Receita>> CreateReceita([FromBody]Receita receitas)
        {
            try
            {

                if (receitas == null)
                {
                    return BadRequest();
                }

                var createdReceita = await _receitasRepository.AddReceita(receitas);

                if (createdReceita == null)
                {
                    return BadRequest($"O item {receitas.Descricao} não pode ser adicionado pois já existe na data {receitas.Data.Month}/{receitas.Data.Year}");
                }

                return Ok(createdReceita);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao retornar os daos do banco de dados");
            }
        }

        [HttpPut("{id:}")]
        public async Task<ActionResult<Receita>> UpadateReceita(int id, Receita receitas)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }

                if (receitas == null)
                {
                    return BadRequest();
                }

                if (id != receitas.Id)
                {
                    return BadRequest($"O Id {id} não confere com a receita a ser atualizada");
                }
                return await _receitasRepository.UpdateReceita(id, receitas);
            }

            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Receita>> DeleteReceita(int id)
        {
            try
            {
                var receitaToDelete = await _receitasRepository.GetReceitaById(id);

                if (receitaToDelete == null)
                {
                    return NotFound($"Receita com id = {id} não encontrada");
                }

                return await _receitasRepository.DeleteReceita(id);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }
    }
}
