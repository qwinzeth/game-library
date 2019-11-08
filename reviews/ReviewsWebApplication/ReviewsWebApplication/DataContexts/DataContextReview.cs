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
        public DbSet<DTOReviewer> Reviewers { get; set; }

        public DataContextReview(DbContextOptions<DataContextReview> options) : base(options)
        {

        }

        public async Task<IEnumerable<DTOReviewOverview>> GetReviewOverviews(/* TODO: Pagination */)
        {
            return await Reviews.Join(Games, review => review.GameID, game => game.GameID, (review, game) => new {
                Review = review,
                Game = game
            }).Join(Reviewers, reviewWithGames => reviewWithGames.Review.ReviewerID, reviewer => reviewer.ReviewerID, (reviewWithGames, reviewer) => 
            new DTOReviewOverview {
                ReviewID = reviewWithGames.Review.ReviewID,
                GameID = reviewWithGames.Game.GameID,
                ReviewerID = reviewer.ReviewerID,
                Title = reviewWithGames.Game.Title,
                RatingOf100 = reviewWithGames.Review.RatingOf100,
                ReviewerName = reviewer.Name
            }).ToListAsync();
        }
    }
}
