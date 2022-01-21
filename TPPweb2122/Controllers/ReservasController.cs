﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TPPweb2122.Data;
using TPPweb2122.Models;

namespace TPPweb2122.Controllers
{
    [Authorize]
    public class ReservasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reservas
        [Authorize(Roles = "Admin,Gestor,Funcionario,Cliente")]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            if (User.IsInRole("Gestor"))
            {
                return View(await _context.Reserva.Include(r => r.Cliente).Include(r => r.Imovel).Where(i => i.Imovel.gestorId == int.Parse(userId)).ToListAsync());
            }
            else 
            {
                return View(await _context.Reserva.Include(r => r.Cliente).Include(r => r.Imovel).Where(c => (c.ClienteId == int.Parse(userId)) && ( c.Confirmacao == false)).ToListAsync());
            }
            
        }
        public async Task<IActionResult> Historico()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(await _context.Reserva.Include(r => r.Cliente).Include(r => r.Imovel).Where(c => (c.ClienteId == int.Parse(userId)) && (c.Confirmacao == true)).ToListAsync());
        }
        // GET: Reservas/Details/5
        [Authorize(Roles = "Admin,Gestor,Funcionario,Cliente")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.Cliente)
                .Include(r => r.Imovel)
                .FirstOrDefaultAsync(m => m.ReservaId == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reservas/Create
        [Authorize(Roles = "Cliente")]

        public IActionResult Create()
        {
            ViewData["ImovelId"] = new SelectList(_context.Imoveis, "ImovelId", "NomeAlojamento");
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Cliente")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservaId,dataEntrada,dataSaida,ImovelId,ClienteId")] Reserva reserva)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {

                reserva.ClienteId = int.Parse(userId);
                reserva.Confirmacao = false;
                // Falta verificação do tempo if(imovel.DataInicio>dataEntrada || dataEntrada>imovel.dataFim)
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Discriminator", reserva.ClienteId);
            ViewData["ImovelId"] = new SelectList(_context.Imoveis, "ImovelId", "ImovelId", reserva.ImovelId);
            return View(reserva);
        }

        // GET: Reservas/Edit/5
        [Authorize(Roles = "Funcionario,Gestor,Cliente")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Discriminator", reserva.ClienteId);
            ViewData["ImovelId"] = new SelectList(_context.Imoveis, "ImovelId", "ImovelId", reserva.ImovelId);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Funcionario,Gestor,Cliente")]

        public async Task<IActionResult> Edit(int id, [Bind("ReservaId,dataEntrada,dataSaida,ImovelId,ClienteId")] Reserva reserva)
        {
            if (id != reserva.ReservaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaExists(reserva.ReservaId))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Discriminator", reserva.ClienteId);
            ViewData["ImovelId"] = new SelectList(_context.Imoveis, "ImovelId", "ImovelId", reserva.ImovelId);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        [Authorize(Roles = "Funcionario,Gestor,Cliente")]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.Cliente)
                .Include(r => r.Imovel)
                .FirstOrDefaultAsync(m => m.ReservaId == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Funcionario,Gestor,Cliente")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.Reserva.FindAsync(id);
            _context.Reserva.Remove(reserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaExists(int id)
        {
            return _context.Reserva.Any(e => e.ReservaId == id);
        }
    }
}
