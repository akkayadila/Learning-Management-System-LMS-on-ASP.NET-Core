using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Elev8_Final.Data;
using Elev8_Final.Models;

namespace Elev8_Final.Controllers
{
    public class Enrollment2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Enrollment2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enrollment2
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Enrollments2.Include(e => e.Course);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Enrollment2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Enrollments2 == null)
            {
                return NotFound();
            }

            var enrollment2 = await _context.Enrollments2
                .Include(e => e.Course)
                .FirstOrDefaultAsync(m => m.EnrollmentID == id);
            if (enrollment2 == null)
            {
                return NotFound();
            }

            return View(enrollment2);
        }

        // GET: Enrollment2/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID");
            return View();
        }

        // POST: Enrollment2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnrollmentID,Id,CourseID,EnrollmentDate")] Enrollment2 enrollment2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrollment2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID", enrollment2.CourseID);
            return View(enrollment2);
        }

        // GET: Enrollment2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Enrollments2 == null)
            {
                return NotFound();
            }

            var enrollment2 = await _context.Enrollments2.FindAsync(id);
            if (enrollment2 == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID", enrollment2.CourseID);
            return View(enrollment2);
        }

        // POST: Enrollment2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnrollmentID,Id,CourseID,EnrollmentDate")] Enrollment2 enrollment2)
        {
            if (id != enrollment2.EnrollmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrollment2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Enrollment2Exists(enrollment2.EnrollmentID))
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID", enrollment2.CourseID);
            return View(enrollment2);
        }

        // GET: Enrollment2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Enrollments2 == null)
            {
                return NotFound();
            }

            var enrollment2 = await _context.Enrollments2
                .Include(e => e.Course)
                .FirstOrDefaultAsync(m => m.EnrollmentID == id);
            if (enrollment2 == null)
            {
                return NotFound();
            }

            return View(enrollment2);
        }

        // POST: Enrollment2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Enrollments2 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Enrollments2'  is null.");
            }
            var enrollment2 = await _context.Enrollments2.FindAsync(id);
            if (enrollment2 != null)
            {
                _context.Enrollments2.Remove(enrollment2);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Enrollment2Exists(int id)
        {
          return (_context.Enrollments2?.Any(e => e.EnrollmentID == id)).GetValueOrDefault();
        }
    }
}
