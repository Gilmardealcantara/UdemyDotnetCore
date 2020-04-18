using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITDeveloper.Data.ORM;
using ITDeveloper.Domain.Entitites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ITDeveloper.Mvc.Controllers {
    public class PatientController : Controller {
        private readonly ITDeveloperDbContext _context;

        public PatientController(ITDeveloperDbContext context) {
            _context = context;
        }

        // GET: Patient
        public async Task<IActionResult> Index() {
            return View(await _context.Patients.Include(x => x.State).AsNoTracking().ToListAsync());
        }

        // GET: Patient/Details/5
        public async Task<IActionResult> Details(Guid? id) {
            if (id == null) {
                return NotFound();
            }

            var patient = await _context.Patients
                .Include(x => x.State)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null) {
                return NotFound();
            }

            return View(patient);
        }

        // GET: Patient/Create
        public IActionResult Create() {

            ViewBag.PatientState = new SelectList(_context.PatientStates, dataValueField: "Id", dataTextField: "Description");
            return View();
        }

        // POST: Patient/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patient patient) {
            if (ModelState.IsValid) {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Patient/Edit/5
        public async Task<IActionResult> Edit(Guid? id) {
            if (id == null) {
                return NotFound();
            }

            var patient = await _context.Patients
                .Include(x => x.State)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            if (patient == null) {
                return NotFound();
            }

            ViewBag.PatientState = new SelectList(
                _context.PatientStates,
                dataValueField: "Id",
                dataTextField: "Description",
                selectedValue : patient.StateId);
            return View(patient);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Patient patient) {
            if (id != patient.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!PatientExists(patient.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Patient/Delete/5
        public async Task<IActionResult> Delete(Guid? id) {
            if (id == null) {
                return NotFound();
            }

            var patient = await _context.Patients
                .Include(x => x.State)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null) {
                return NotFound();
            }

            return View(patient);
        }

        // POST: Patient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id) {
            var patient = await _context.Patients.FindAsync(id);
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(Guid id) {
            return _context.Patients.Any(e => e.Id == id);
        }
    }
}