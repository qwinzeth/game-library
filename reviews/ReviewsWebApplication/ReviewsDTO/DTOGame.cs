using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewsDTO
{
    [Table("games")]
    public class DTOGame
    {
        [Key]
        [Column("game_id")]
        public long GameID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
