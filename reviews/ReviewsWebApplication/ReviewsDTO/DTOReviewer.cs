using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ReviewsDTO
{
    public class DTOReviewer
    {
        [Key]
        [Column("reviewer_id")]
        public long ReviewerID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
    }
}
