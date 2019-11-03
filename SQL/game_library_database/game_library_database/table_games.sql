USE game_library;

DROP TABLE IF EXISTS games;
CREATE TABLE games(
	game_id BIGINT NOT NULL IDENTITY,
	title VARCHAR(50) NOT NULL,
	description varchar(max),
	PRIMARY KEY(game_id)
);
