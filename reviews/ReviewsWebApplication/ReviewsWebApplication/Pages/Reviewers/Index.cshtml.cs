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
    public class IndexModel : PageModel
    {
        private readonly ReviewsWebApplication.DataContexts.DataContextReviewer _context;

        public IndexModel(ReviewsWebApplication.DataContexts.DataContextReviewer context)
        {
            _context = context;
        }

        public IList<DTOReviewer> DTOReviewer { get;set; }

        public async Task OnGetAsync()
        {
            DTOReviewer = await _context.DTOReviewer.ToListAsync();
        }
    }
}
