using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReviewsDTO;

namespace ReviewsWebApplication.DataContexts
{
    public class DataContextReviewer : DbContext
    {
        public DataContextReviewer (DbContextOptions<DataContextReviewer> options)
            : base(options)
        {
        }

        public DbSet<ReviewsDTO.DTOReviewer> DTOReviewer { get; set; }
    }
}
