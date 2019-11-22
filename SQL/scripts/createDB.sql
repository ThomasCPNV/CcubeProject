-- --------------------------------------------------------
-- Hôte :                        127.0.0.1
-- Version du serveur:           8.0.14 - MySQL Community Server - GPL
-- SE du serveur:                Win64
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

-- Création de la base de données CcubeProject
DROP DATABASE IF EXISTS `CcubeProject`;
CREATE DATABASE `CcubeProject`;
USE `CcubeProject`;

-- Création de la table CcubeProject. CARS
CREATE TABLE IF NOT EXISTS `CARS` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `model` varchar(30) NOT NULL,
  `release` date NOT NULL,
  `price` float UNSIGNED NOT NULL,
  `power (kW)` float UNSIGNED unsigned NOT NULL,
  `weight` float UNSIGNED NOT NULL DEFAULT,
  `CO2/km` float UNSIGNED NOT NULL,
  `l/100` float UNSIGNED NOT NULL,
  `idBRANDS` int (15) UNSIGNED NOT NULL,
  `idTYPES` int (15) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `model` (`model`)
);

-- Insertion des données dans la table CcubeProject. CARS
INSERT INTO `CARS` (`id`, `model`, `release`, `price`, `power (kW)`, `weight`, `CO2/km`, `l/100`, `idBRANDS`, `idTYPES`) VALUES
	(1, 'B101', 'Burton', 'Custom', 160, 22, 'La board la plus fiable de tous les temps, la solution snowboard pour tous les terrains. (Homme)', 29, 'view/content/images/B101_small.jpg', 1),
	(2, 'B126', 'Burton', 'Free Thinker', 165, 2, 'Élargissez votre vision grâce son interprétation du ride tout terrain dynamique sur la poudreuse. (Homme)', 45, 'view/content/images/B126_small.jpg', 1),
	(3, 'B327', 'Burton', 'Day Trader', 155, 6, 'Flottabilité sans effort et un contrôle qui renforce la confiance en soi. (Femme)', 25, 'view/content/images/B327_small.jpg', 0),
	(4, 'K266', 'K2', 'Wildheart', 152, 2, 'Keeping in versatile style (Femme)', 29, 'view/content/images/K266_small.jpg', 1),
	(5, 'N100', 'Nidecker', 'Tracer', 164, 11, 'Une expérience de carve hors du commun. Idéal pour carver comme jamais (Homme et femme)', 39, 'view/content/images/N100_small.jpg', 1),
	(6, 'N754', 'Nidecker', 'Ultralight', 166, 26, 'A la pointe de la technologie. Idéal pour le freeride sur les faces engagées (Homme et femme)', 59, 'view/content/images/N754_small.jpg', 1),
	(7, 'P067', 'Prior', 'Brandwine 153', 154, 9, 'High performance, directional Freeride board, draws a smooth, stable and fast line through all snow conditions. (Femme)', 49, 'view/content/images/P067_small.jpg', 1),
	(8, 'P165', 'Prior', 'BC Split 161', 169, 1, 'Sa forme directionnelle Freeride offre une ride plutôt douce et stable dans une variété de conditions', 35, 'view/content/images/P165_small.jpg', 1),
	(9, 'K409', 'K2', 'Lime Lite', 149, 15, 'Best For Freestyle Evolution with a Focus on Fun (Femme)', 55, 'view/content/images/K409_small.jpg', 1);

-- Création de la table CcubeProject. USERS
CREATE TABLE IF NOT EXISTS `USERS` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `email` varchar(30) NOT NULL,
  `password` varchar(255) NOT NULL,
  `type` int(15) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`)
);

-- Création de la table CcubeProject. BRANDS
CREATE TABLE IF NOT EXISTS `BRANDS` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(30) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`)
  UNIQUE KEY `name` (`name`)
);

-- Insertion des données dans la table CcubeProject. BRANDS
INSERT INTO `BRANDS` (`id`, `name`) VALUES
	(1, 'B101');

-- Création de la table CcubeProject. TYPES
CREATE TABLE IF NOT EXISTS `TYPES` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(30) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`)
  UNIQUE KEY `name` (`name`)
);

-- Insertion des données dans la table CcubeProject. TYPES
INSERT INTO `TYPES` (`id`, `name`) VALUES
	(1, 'B101');
	
-- Création de la table CcubeProject. FUELS
CREATE TABLE IF NOT EXISTS `FUELS` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(30) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`)
  UNIQUE KEY `name` (`name`)
);

-- Insertion des données dans la table CcubeProject. FUELS
INSERT INTO `FUELS` (`id`, `name`) VALUES
	(1, 'B101');
	
-- Création de la table CcubeProject. TAXES
CREATE TABLE IF NOT EXISTS `TAXES` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `canton` varchar(30) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`)
  UNIQUE KEY `canton` (`canton`)
);

-- Insertion des données dans la table CcubeProject. TAXES
INSERT INTO `TAXES` (`id`, `canton`) VALUES
	(1, 'VAUD');

-- Création de la table CcubeProject. CARS_FUELS
CREATE TABLE IF NOT EXISTS `CARS_FUELS` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idCARS` int(15) UNSIGNED NOT NULL,
  `idFUELS` int(15) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`)
);

-- Création de la table CcubeProject. CARS_TAXES
CREATE TABLE IF NOT EXISTS `CARS_TAXES` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `idCARS` int(15) UNSIGNED NOT NULL,
  `idTAXES` int(15) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`)
);


-- Ajoute les clés étrangères dans les tables
Alter TABLE `CARS`
Add foreign key (`idBRANDS`) REFERENCES `BRANDS`(`id`);

Alter TABLE `CARS`
Add foreign key (`idTYPES`) REFERENCES `TYPES`(`id`);

Alter TABLE `CARS_FUELS`
Add foreign key (`idCARS`) REFERENCES `CARS`(`id`);

Alter TABLE `CARS_FUELS`
Add foreign key (`idFUELS`) REFERENCES `FUELS`(`id`);

Alter TABLE `CARS_TAXES`
Add foreign key (`idTAXES`) REFERENCES `TAXES`(`id`);

SET GLOBAL FOREIGN_KEY_CHECKS=0;