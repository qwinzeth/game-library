USE game_library;

DROP TABLE IF EXISTS reviewers;
CREATE TABLE reviewers(
	reviewer_id BIGINT NOT NULL IDENTITY,
	name VARCHAR(50) NOT NULL,
	PRIMARY KEY(reviewer_id)
);