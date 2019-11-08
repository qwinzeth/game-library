using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReviewsDTO;
using ReviewsWebApplication.DataContexts;

namespace ReviewsWebApplication.Pages.Reviewers
{
    public class CreateModel : PageModel
    {
        private readonly ReviewsWebApplication.DataContexts.DataContextReviewer _context;

        public CreateModel(ReviewsWebApplication.DataContexts.DataContextReviewer context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DTOReviewer DTOReviewer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DTOReviewer.Add(DTOReviewer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}