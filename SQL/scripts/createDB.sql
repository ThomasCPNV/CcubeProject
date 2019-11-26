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

-- Création de la table CcubeProject. USERS
CREATE TABLE IF NOT EXISTS `USERS` (
  `id` int(15) UNSIGNED NOT NULL AUTO_INCREMENT,
  `email` varchar(30) NOT NULL,
  `password` varchar(255) NOT NULL,
  `type` int(15) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`)
);