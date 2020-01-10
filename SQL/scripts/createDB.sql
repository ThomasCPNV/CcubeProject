-- --------------------------------------------------------
-- Hôte :                        127.0.0.1
-- Version du serveur:           8.0.14 - MySQL Community Server - GPL
-- SE du serveur:                Win64
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

-- Création de la base de données CarCostCalculator
DROP DATABASE IF EXISTS `CarCostCalculator`;
CREATE DATABASE `CarCostCalculator`;
USE `CarCostCalculator`;

-- Création de la table CarCostCalculator. USER
CREATE TABLE IF NOT EXISTS `USER` (
  `ID` INT(30) UNSIGNED NOT NULL AUTO_INCREMENT,
  `EMAIL` VARCHAR(254) NOT NULL,
  `PASSWORD` VARCHAR(80) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `EMAIL` (`EMAIL`)
);

-- Création de la table CarCostCalculator. INITIAL-PRICE
CREATE TABLE IF NOT EXISTS `INITIAL-PRICE` (
  `ID` INT(30) UNSIGNED NOT NULL AUTO_INCREMENT,
  `IDUSER` INT(30) UNSIGNED NOT NULL DEFAULT 0,
  `PURCHASE-PRICE` FLOAT NOT NULL,
  `LIFETIME` FLOAT NOT NULL,
  `COST/YEAR` FLOAT,
  PRIMARY KEY (`ID`)
);

-- Création de la table CarCostCalculator. ESSENTIAL-MAINTAIN
CREATE TABLE IF NOT EXISTS `ESSENTIAL-MAINTAIN` (
  `ID` INT(30) UNSIGNED NOT NULL AUTO_INCREMENT,
  `IDUSER` INT(30) UNSIGNED NOT NULL DEFAULT 0,
  `INSURANCE/YEAR` FLOAT NOT NULL,
  `TIRES/YEAR` FLOAT NOT NULL,
  `REVISION/YEAR` FLOAT NOT NULL,
  `COST/YEAR` FLOAT,
  PRIMARY KEY (`ID`)
);

-- Création de la table CarCostCalculator. CONSOMMATION
CREATE TABLE IF NOT EXISTS `CONSOMMATION` (
  `ID` INT(30) UNSIGNED NOT NULL AUTO_INCREMENT,
  `IDUSER` INT(30) UNSIGNED NOT NULL DEFAULT 0,
  `FUEL` VARCHAR(55) NOT NULL,
  `CONSOMMATION/100km` FLOAT NOT NULL,
  `DISTANCE/MONTH` FLOAT NOT NULL,
  `COST/YEAR` FLOAT,
  PRIMARY KEY (`ID`)
);

-- Création de la table CarCostCalculator. LICENSE-PLATE
CREATE TABLE IF NOT EXISTS `LICENSE-PLATE` (
  `ID` INT(30) UNSIGNED NOT NULL AUTO_INCREMENT,
  `IDUSER` INT(30) UNSIGNED NOT NULL DEFAULT 0,
  `CANTON` VARCHAR(55) NOT NULL,
  `POWER` FLOAT NOT NULL,
  `WEIGHT` FLOAT NOT NULL,
  `CO2-EMISSION` FLOAT NOT NULL,
  `COST/YEAR` FLOAT,
  PRIMARY KEY (`ID`)
);

-- Add foreign keys in table
Alter TABLE `INITIAL-PRICE`
Add foreign KEY (`IDUSER`) REFERENCES `USER`(`ID`);

Alter TABLE `ESSENTIAL-MAINTAIN`
Add foreign key (`IDUSER`) REFERENCES `USER`(`ID`);

Alter TABLE `CONSOMMATION`
Add foreign key (`IDUSER`) REFERENCES `USER`(`ID`);

Alter TABLE `LICENSE-PLATE`
Add foreign key (`IDUSER`) REFERENCES `USER`(`ID`);

SET GLOBAL FOREIGN_KEY_CHECKS=0;