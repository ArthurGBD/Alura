﻿using ControleFinanceiroFamilar.API.Repositories;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiroFamilar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly IReceitasRepository _receitasRepository;

        public ReceitasController(IReceitasRepository receitasRepository)
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
        public async Task<ActionResult<Receitas>> GetReceitaById(int id)
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

        public async Task<ActionResult<Receitas>> GetReceitasByDescricaoAndMonth(string descricao, int mes)
        {
            try
            {
                var receitasDescricaoAndMonth = await _receitasRepository.GetReceitasByDescricaoAndMonth(descricao, mes);
                if (receitasDescricaoAndMonth != null)
                {
                    return Ok(receitasDescricaoAndMonth);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Receitas>> CreateReceita([FromBody] Receitas receitas)
        {
            try
            {
                if (receitas == null)
                {
                    return BadRequest();
                }

                var createdReceita = await _receitasRepository.AddReceita(receitas);

                return Ok(createdReceita);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao retornar os daos do banco de dados");
            }
        }


        [HttpPut("{id:}")]
        public async Task<ActionResult<Receitas>> UpadateReceita(int id, Receitas receitas)
        {
            try
            {
                if (id != receitas.Id)
                {
                    return BadRequest($"O Id {id} não confere com a receita a ser atualizada");
                }
                return await _receitasRepository.UpdateReceita(receitas);
            }

            catch (Exception)
            {
                return StatusCode(500, "Erro ao acessar os dados do banco de dados");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Receitas>> DeleteReceita(int id)
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
