CREATE TABLE `users` (
  `id` INT PRIMARY KEY AUTO_INCREMENT,
  `games` INT NOT NULL,
  `points` INT NOT NULL,
  `username` VARCHAR(255) NOT NULL
);

USE `hackdb`;

INSERT INTO `users` (username, games, points) VALUES ('user1', 4, 27);

SELECT * FROM users;

DROP TABLE `users`;

