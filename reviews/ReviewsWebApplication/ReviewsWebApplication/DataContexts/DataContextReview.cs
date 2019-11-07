using Microsoft.EntityFrameworkCore;
using ReviewsDTO;
using ReviewsDTO.PerformanceDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsWebApplication.DataContexts
{
    public class DataContextReview : DbContext
    {
        public DbSet<DTOGame> Games { get; set; }
        public DbSet<DTOReview> Reviews { get; set; }

        public DataContextReview(DbContextOptions<DataContextReview> options) : base(options)
        {

        }

        public async Task<IEnumerable<DTOReviewOverview>> GetReviewOverviews(/* TODO: Pagination */)
        {
            var gamesWithReviews = await Games.GroupJoin(Reviews, game => game.GameID, review => review.GameID, (game, reviews) => 
                new {
                    Game = game,
                    Reviews = reviews
                }).ToListAsync();

            List<DTOReviewOverview> reviewOverviews = new List<DTOReviewOverview>();

            foreach(var gameWithReviews in gamesWithReviews)
            {
                foreach (var review in gameWithReviews.Reviews)
                {
                    reviewOverviews.Add(new DTOReviewOverview()
                    {
                        GameID = gameWithReviews.Game.GameID,
                        ReviewID = review.ReviewID,
                        ReviewerID = review.ReviewerID,
                        Title = gameWithReviews.Game.Title,
                        RatingOf100 = review.RatingOf100
                    });
                }
            }

            return reviewOverviews;
        }
    }
}
