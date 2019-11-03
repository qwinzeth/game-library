use game_library;

INSERT INTO games(title, description) VALUES ('The Legend of Zelda', 'A top-down 2D adventure game with an iconic overworld theme.');
DECLARE @game_id_zelda BIGINT;
SELECT @game_id_zelda = SCOPE_IDENTITY();
INSERT INTO games(title, description) VALUES ('Super Mario Bros.', 'A 2D sidescroller where a plumber shoots fireballs at plants, turtles, and sentient mushrooms. Non-sentient mushrooms are used to powerup the plumber.');
DECLARE @game_id_mario BIGINT;
SELECT @game_id_mario = SCOPE_IDENTITY();

INSERT INTO reviewers(name) VALUES ('IGN');
DECLARE @review_id_ign BIGINT;
SELECT @review_id_ign = SCOPE_IDENTITY();
INSERT INTO reviewers(name) VALUES ('Metacritic');
DECLARE @review_id_metacritic BIGINT;
SELECT @review_id_metacritic = SCOPE_IDENTITY();

INSERT INTO reviews(reviewer_id, game_id, rating_of_100, review_text)
	VALUES (@review_id_ign, @game_id_mario, 100, 'A fun glitch in this game is world -1');
INSERT INTO reviews(reviewer_id, game_id, rating_of_100, review_text)
	VALUES (@review_id_ign, @game_id_zelda, 100, 'It''s dangerous to go alone!');
INSERT INTO reviews(reviewer_id, game_id, rating_of_100, review_text)
	VALUES (@review_id_metacritic, @game_id_mario, 95, 'Classic and difficult.');