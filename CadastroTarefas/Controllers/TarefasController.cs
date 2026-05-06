using CadastroTarefas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TarefasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Salvar")]
        public IActionResult Salvar([FromBody] Tarefas tarefa)
        {
            try
            {
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                return Ok("Tarefa salva com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao salvar: " + ex.Message);
            }

        }

        [HttpDelete("Excluir")]
        public IActionResult Excluir(int IdTarefas)
        {
            try
            {
                TarefasRepository tarefasRepo = new TarefasRepository(_context);
                bool excluido = tarefasRepo.Excluir(IdTarefas);

                if (!excluido)
                    return NotFound("Tarefa não encontrada");

                return Ok("Tarefa Excluida com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao excluir: " + ex.Message);
            }

        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            try
            {
                TarefasRepository tarefasRepo = new TarefasRepository(_context);
                return Ok(tarefasRepo.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao listar: " + ex.Message);
            }
        }

        [HttpPut("Alterar")]
        public IActionResult Alterar([FromBody] Tarefas tarefa)
        {
            try
            {
               TarefasRepository tarefasRepo = new TarefasRepository(_context);
               bool alterado = tarefasRepo.Alterar(tarefa);

                if (!alterado)
                    return NotFound("Tarefa não encontrada!");

                return Ok("Tarefa alterada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao alterar: " + ex.Message);
            }

        }

    }
}
