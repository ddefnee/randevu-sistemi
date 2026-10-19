using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Randevu_Sistemi.Data;
using Randevu_Sistemi.Models;

namespace Randevu_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RandevuController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RandevuController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/randevu
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var randevular = await _context.Randevular.ToListAsync();
            return Ok(randevular);
        }

        // POST: api/randevu
        [HttpPost]
        public async Task<IActionResult> Create(Randevu randevu)
        {
            _context.Randevular.Add(randevu);
            await _context.SaveChangesAsync();
            return Ok(randevu);
        }

        // PUT: api/randevu/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Randevu randevu)
        {
            var data = await _context.Randevular.FindAsync(id);
            if (data == null)
                return NotFound();

            data.AdSoyad = randevu.AdSoyad;
            data.Tarih = randevu.Tarih;
            data.Aciklama = randevu.Aciklama;

            await _context.SaveChangesAsync();
            return Ok(data);
        }

        // DELETE: api/randevu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _context.Randevular.FindAsync(id);
            if (data == null)
                return NotFound();

            _context.Randevular.Remove(data);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
