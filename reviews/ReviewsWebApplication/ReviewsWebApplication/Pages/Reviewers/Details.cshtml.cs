using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ReviewsDTO;
using ReviewsWebApplication.DataContexts;

namespace ReviewsWebApplication.Pages.Reviewers
{
    public class DetailsModel : PageModel
    {
        private readonly ReviewsWebApplication.DataContexts.DataContextReviewer _context;

        public DetailsModel(ReviewsWebApplication.DataContexts.DataContextReviewer context)
        {
            _context = context;
        }

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
    }
}
