USE game_library;

DROP TABLE IF EXISTS reviews;
CREATE TABLE reviews(
   review_id BIGINT NOT NULL IDENTITY,
   reviewer_id BIGINT NOT NULL,
   game_id BIGINT NOT NULL,
   rating_of_100 TINYINT,
   review_text varchar(max),
   PRIMARY KEY(review_id),
   FOREIGN KEY(reviewer_id) REFERENCES reviewers(reviewer_id),
   FOREIGN KEY(game_id) REFERENCES games(game_id)
);