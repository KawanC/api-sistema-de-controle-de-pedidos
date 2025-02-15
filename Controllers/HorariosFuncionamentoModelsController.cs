using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSistemaControlePedidos.Models;

namespace ApiSistemaControlePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosFuncionamentoModelsController : ControllerBase
    {
        private readonly SistemaContext _context;

        public HorariosFuncionamentoModelsController(SistemaContext context)
        {
            _context = context;
        }

        // GET: api/HorariosFuncionamentoModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HorariosFuncionamentoModel>>> GetHorariosFuncionamentoModel()
        {
            return await _context.HorariosFuncionamentoModel.ToListAsync();
        }

        // GET: api/HorariosFuncionamentoModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HorariosFuncionamentoModel>> GetHorariosFuncionamentoModel(int id)
        {
            var horariosFuncionamentoModel = await _context.HorariosFuncionamentoModel.FindAsync(id);

            if (horariosFuncionamentoModel == null)
            {
                return NotFound();
            }

            return horariosFuncionamentoModel;
        }

        // PUT: api/HorariosFuncionamentoModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHorariosFuncionamentoModel(int id, HorariosFuncionamentoModel horariosFuncionamentoModel)
        {
            if (id != horariosFuncionamentoModel.IdHorarioFuncionamento)
            {
                return BadRequest();
            }

            _context.Entry(horariosFuncionamentoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HorariosFuncionamentoModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HorariosFuncionamentoModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HorariosFuncionamentoModel>> PostHorariosFuncionamentoModel(HorariosFuncionamentoModel horariosFuncionamentoModel)
        {
            _context.HorariosFuncionamentoModel.Add(horariosFuncionamentoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHorariosFuncionamentoModel", new { id = horariosFuncionamentoModel.IdHorarioFuncionamento }, horariosFuncionamentoModel);
        }

        // DELETE: api/HorariosFuncionamentoModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHorariosFuncionamentoModel(int id)
        {
            var horariosFuncionamentoModel = await _context.HorariosFuncionamentoModel.FindAsync(id);
            if (horariosFuncionamentoModel == null)
            {
                return NotFound();
            }

            _context.HorariosFuncionamentoModel.Remove(horariosFuncionamentoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HorariosFuncionamentoModelExists(int id)
        {
            return _context.HorariosFuncionamentoModel.Any(e => e.IdHorarioFuncionamento == id);
        }
    }
}
