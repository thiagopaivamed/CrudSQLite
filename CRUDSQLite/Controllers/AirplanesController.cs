using CRUDSQLite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDSQLite.Controllers
{
    public class AirplanesController : Controller
    {
        private readonly Context _context;

        public AirplanesController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Airplanes.ToListAsync());
        }

        [HttpGet]
        public IActionResult AddAirplane()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAirplane(Airplane airplane)
        {
            await _context.Airplanes.AddAsync(airplane);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAirplane(int id)
        {
            Airplane airplane = await _context.Airplanes.FindAsync(id);
            return View(airplane);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAirplane(Airplane airplane)
        {
            _context.Airplanes.Update(airplane);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAirplane(int id)
        {
            Airplane airplane = await _context.Airplanes.FindAsync(id);
            _context.Airplanes.Remove(airplane);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
