using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReviewsDTO;
using ReviewsWebApplication.DataContexts;

namespace ReviewsWebApplication.Pages.Reviewers
{
    public class EditModel : PageModel
    {
        private readonly ReviewsWebApplication.DataContexts.DataContextReviewer _context;

        public EditModel(ReviewsWebApplication.DataContexts.DataContextReviewer context)
        {
            _context = context;
        }

        [BindProperty]
        public DTOReviewer DTOReviewer { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DTOReviewer = await _context.DTOReviewer.FirstOrDefaultAsync(m => m.ReviewerID == id);

            if (DTOReviewer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DTOReviewer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DTOReviewerExists(DTOReviewer.ReviewerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DTOReviewerExists(long id)
        {
            return _context.DTOReviewer.Any(e => e.ReviewerID == id);
        }
    }
}
