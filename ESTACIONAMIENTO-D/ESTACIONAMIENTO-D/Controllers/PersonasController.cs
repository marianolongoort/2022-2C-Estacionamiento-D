using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ESTACIONAMIENTO_D.Data;
using ESTACIONAMIENTO_D.Models;

namespace ESTACIONAMIENTO_D.Controllers
{
    public class PersonasController : Controller
    {
        private readonly EstacionamientoContext _estacionamientoContext;

        public PersonasController(EstacionamientoContext context)
        {
            _estacionamientoContext = context;
        }

        // GET: Personas
        public IActionResult Index()
        {


              return View(_estacionamientoContext.Personas.ToList());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _estacionamientoContext.Personas == null)
            {
                return NotFound();
            }

            var persona = await _estacionamientoContext.Personas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Email,FechaNacimiento,Dni")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                _estacionamientoContext.Add(persona);
                await _estacionamientoContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _estacionamientoContext.Personas == null)
            {
                return NotFound();
            }

            var persona = await _estacionamientoContext.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Email,FechaNacimiento")] Persona persona)
        {
            if (id != persona.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _estacionamientoContext.Update(persona);
                    await _estacionamientoContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _estacionamientoContext.Personas == null)
            {
                return NotFound();
            }

            var persona = await _estacionamientoContext.Personas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_estacionamientoContext.Personas == null)
            {
                return Problem("Entity set 'EstacionamientoContext.Personas'  is null.");
            }
            var persona = await _estacionamientoContext.Personas.FindAsync(id);
            if (persona != null)
            {
                _estacionamientoContext.Personas.Remove(persona);
            }
            
            await _estacionamientoContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
          return _estacionamientoContext.Personas.Any(e => e.Id == id);
        }
    }
}
