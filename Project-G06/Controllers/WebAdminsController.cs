using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_G06.Data;
using Project_G06.Models;

namespace Project_G06.Controllers
{
    //[Authorize(Roles ="sales")]
    public class WebAdminsController : Controller
    {
        private readonly WebAdminDbContext _context;

        public WebAdminsController(WebAdminDbContext context)
        {
            _context = context;
        }

        // GET: WebAdmins
     

        // GET: WebAdmins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.WebAdmins == null)
            {
                return NotFound();
            }

            var webAdmin = await _context.WebAdmins
                .FirstOrDefaultAsync(m => m.W_ID == id);
            if (webAdmin == null)
            {
                return NotFound();
            }

            return View(webAdmin);
        }

        // GET: WebAdmins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebAdmins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("W_ID,W_Email,W_Password")] WebAdmin webAdmin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(webAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(webAdmin);
        }


       
        // GET: WebAdmins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.WebAdmins == null)
            {
                return NotFound();
            }

            var webAdmin = await _context.WebAdmins.FindAsync(id);
            if (webAdmin == null)
            {
                return NotFound();
            }
            return View(webAdmin);
        }

        // POST: WebAdmins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("W_ID,W_Email,W_Password")] WebAdmin webAdmin)
        {
            if (id != webAdmin.W_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(webAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebAdminExists(webAdmin.W_ID))
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
            return View(webAdmin);
        }

        // GET: WebAdmins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.WebAdmins == null)
            {
                return NotFound();
            }

            var webAdmin = await _context.WebAdmins
                .FirstOrDefaultAsync(m => m.W_ID == id);
            if (webAdmin == null)
            {
                return NotFound();
            }

            return View(webAdmin);
        }

        // POST: WebAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.WebAdmins == null)
            {
                return Problem("Entity set 'WebAdminDbContext.WebAdmins'  is null.");
            }
            var webAdmin = await _context.WebAdmins.FindAsync(id);
            if (webAdmin != null)
            {
                _context.WebAdmins.Remove(webAdmin);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebAdminExists(int id)
        {
          return _context.WebAdmins.Any(e => e.W_ID == id);
        }
    }
}
