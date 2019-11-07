using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewsDTO.PerformanceDTOs
{
    public class DTOReviewOverview
    {
        public long ReviewID { get; set; }
        public long ReviewerID { get; set; }
        public long GameID { get; set; }
        public int RatingOf100 { get; set; }
        public string Title { get; set; }
    }
}
