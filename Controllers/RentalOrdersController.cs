using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRentalProject.Data;
using CarRentalProject.Models;

namespace CarRentalProject.Controllers
{
    public class RentalOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentalOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.RentalOrder.ToListAsync());
        }

        // GET: RentalOrders/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalOrder = await _context.RentalOrder
                .FirstOrDefaultAsync(m => m.CarType == id);
            if (rentalOrder == null)
            {
                return NotFound();
            }

            return View(rentalOrder);
        }

        // GET: RentalOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RentalOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarType,PickUpDate,ReturnDate,Odometer,FuelLevel,ReturnLocation")] RentalOrder rentalOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentalOrder);
        }

        // GET: RentalOrders/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalOrder = await _context.RentalOrder.FindAsync(id);
            if (rentalOrder == null)
            {
                return NotFound();
            }
            return View(rentalOrder);
        }

        // POST: RentalOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CarType,PickUpDate,ReturnDate,Odometer,FuelLevel,ReturnLocation")] RentalOrder rentalOrder)
        {
            if (id != rentalOrder.CarType)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalOrderExists(rentalOrder.CarType))
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
            return View(rentalOrder);
        }

        // GET: RentalOrders/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalOrder = await _context.RentalOrder
                .FirstOrDefaultAsync(m => m.CarType == id);
            if (rentalOrder == null)
            {
                return NotFound();
            }

            return View(rentalOrder);
        }

        // POST: RentalOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var rentalOrder = await _context.RentalOrder.FindAsync(id);
            _context.RentalOrder.Remove(rentalOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalOrderExists(string id)
        {
            return _context.RentalOrder.Any(e => e.CarType == id);
        }
    }
}
