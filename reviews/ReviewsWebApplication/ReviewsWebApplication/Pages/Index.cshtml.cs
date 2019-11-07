using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReviewsDTO.PerformanceDTOs;
using ReviewsWebApplication.DataContexts;

namespace ReviewsWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataContextReview _dataContextReview;

        public IndexModel(DataContextReview dataContextReview)
        {
            _dataContextReview = dataContextReview;
        }

        public IEnumerable<DTOReviewOverview> ReviewOverviews { get; private set; }

        public async Task OnGetAsync()
        {
            ReviewOverviews = await _dataContextReview.GetReviewOverviews();
        }
    }
}