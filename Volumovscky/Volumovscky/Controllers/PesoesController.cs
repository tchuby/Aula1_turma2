using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Volumovscky.Model;

namespace Volumovscky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesoesController : ControllerBase
    {
        private readonly PesoleibiContext _context;

        public PesoesController(PesoleibiContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Pesovscky")]
        public Object Get(double volume, double densidade)
        {
            //Temos nossa regra de negocio calculando o imc
            var peso1 = volume*densidade*9.807;
            //Aqui temos o retorno do texto de acordo com a solicitação da questão
            return peso1;
        }

        // GET: api/Pesoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Peso>>> GetPesos()
        {
            return await _context.Pesos.ToListAsync();
        }

        // GET: api/Pesoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Peso>> GetPeso(int id)
        {
            var peso = await _context.Pesos.FindAsync(id);

            if (peso == null)
            {
                return NotFound();
            }

            return peso;
        }

        // PUT: api/Pesoes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeso(int id, Peso peso)
        {
            if (id != peso.Id)
            {
                return BadRequest();
            }

            _context.Entry(peso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PesoExists(id))
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

        // POST: api/Pesoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Peso>> PostPeso(Peso peso)
        {
            _context.Pesos.Add(peso);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPeso), new { id = peso.Id }, peso);
        }

        // DELETE: api/Pesoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Peso>> DeletePeso(int id)
        {
            var peso = await _context.Pesos.FindAsync(id);
            if (peso == null)
            {
                return NotFound();
            }

            _context.Pesos.Remove(peso);
            await _context.SaveChangesAsync();

            return peso;
        }

        private bool PesoExists(int id)
        {
            return _context.Pesos.Any(e => e.Id == id);
        }
    }
}
