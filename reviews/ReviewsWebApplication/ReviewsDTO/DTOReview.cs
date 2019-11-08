using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ReviewsDTO
{
    [Table("reviews")]
    public class DTOReview
    {
        [Key]
        [Column("review_id")]
        public long ReviewID { get; set; }
        [Column("reviewer_id")]
        public long ReviewerID { get; set; }
        [Column("game_id")]
        public long GameID { get; set; }
        [Column("rating_of_100", TypeName = "tinyint")]
        public int RatingOf100 { get; set; }
        [Column("review_text")]
        public string ReviewText { get; set; }
    }
}
