-- MySQL Script generated by MySQL Workbench
-- Fri Mar 29 08:27:27 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Agencia_turismo
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Agencia_turismo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Agencia_turismo` DEFAULT CHARACTER SET utf8 ;
USE `Agencia_turismo` ;

-- -----------------------------------------------------
-- Table `Agencia_turismo`.`Cidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`Cidade` (
  `idCidade` INT NOT NULL AUTO_INCREMENT,
  `nomeCidade` VARCHAR(45) NULL,
  `ufCidade` VARCHAR(2) NULL,
  `populacaoCidade` INT NULL,
  PRIMARY KEY (`idCidade`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Agencia_turismo`.`Hotel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`Hotel` (
  `idHotel` INT NOT NULL AUTO_INCREMENT,
  `nomeHotel` VARCHAR(45) NULL,
  `cepHotel` INT NULL,
  `numHotel` INT NULL,
  `complementoHotel` VARCHAR(45) NULL,
  `categoriaHotel` INT NULL,
  `Cidade_idCidade` INT NOT NULL,
  PRIMARY KEY (`idHotel`, `Cidade_idCidade`),
  INDEX `fk_Hotel_Cidade1_idx` (`Cidade_idCidade` ASC),
  CONSTRAINT `fk_Hotel_Cidade1`
    FOREIGN KEY (`Cidade_idCidade`)
    REFERENCES `Agencia_turismo`.`Cidade` (`idCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Agencia_turismo`.`QuartoHotel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`QuartoHotel` (
  `idQuartoHotel` INT NOT NULL AUTO_INCREMENT,
  `tipoQuartoHotel` INT NULL,
  `numQuartoHotel` INT NULL,
  `valorQuartoHotel` DOUBLE NULL,
  PRIMARY KEY (`idQuartoHotel`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Agencia_turismo`.`Restaurante`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`Restaurante` (
  `idRestaurante` INT NOT NULL AUTO_INCREMENT,
  `nomeRestaurante` VARCHAR(45) NULL,
  `cepRestaurante` INT NULL,
  `numRestaurante` INT NULL,
  `complementoRestaurante` VARCHAR(45) NULL,
  `categoriaRestaurante` INT NULL,
  `Cidade_idCidade` INT NOT NULL,
  `Hotel_idHotel` INT NULL,
  PRIMARY KEY (`idRestaurante`, `Cidade_idCidade`),
  INDEX `fk_Restaurante_Cidade1_idx` (`Cidade_idCidade` ASC),
  INDEX `fk_Restaurante_Hotel1_idx` (`Hotel_idHotel` ASC),
  CONSTRAINT `fk_Restaurante_Cidade1`
    FOREIGN KEY (`Cidade_idCidade`)
    REFERENCES `Agencia_turismo`.`Cidade` (`idCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Restaurante_Hotel1`
    FOREIGN KEY (`Hotel_idHotel`)
    REFERENCES `Agencia_turismo`.`Hotel` (`idHotel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Agencia_turismo`.`Igreja`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`Igreja` (
  `idIgreja` INT NOT NULL auto_increment,
  `descricaoIgreja` VARCHAR(45) NULL,
  `cepIgreja` INT  NULL,
  `numIgreja` INT NULL,
  `complementoIgreja` VARCHAR(45) NULL,
  `dataIgreja` DATE NULL,
  `estiloIgreja` VARCHAR(45) NULL,
  `Cidade_idCidade` INT NOT NULL,
  PRIMARY KEY (`idIgreja`, `Cidade_idCidade`),
  INDEX `fk_Igreja_Cidade1_idx` (`Cidade_idCidade` ASC),
  CONSTRAINT `fk_Igreja_Cidade1`
    FOREIGN KEY (`Cidade_idCidade`)
    REFERENCES `Agencia_turismo`.`Cidade` (`idCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Agencia_turismo`.`CasaShow`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`CasaShow` (
  `idShow` INT NOT NULL auto_increment COMMENT 'Show',
  `descricaoShow` VARCHAR(45) NULL,
  `cepShow` INT NULL,
  `numShow` INT NULL,
  `complementoShow` VARCHAR(45) NULL,
  `dataShow` DATETIME NULL,
  `fechamentoShow` INT NULL,
  `Cidade_idCidade` INT NOT NULL,
  PRIMARY KEY (`idShow`, `Cidade_idCidade`),
  INDEX `fk_CasaShow_Cidade1_idx` (`Cidade_idCidade` ASC),
  CONSTRAINT `fk_CasaShow_Cidade1`
    FOREIGN KEY (`Cidade_idCidade`)
    REFERENCES `Agencia_turismo`.`Cidade` (`idCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Agencia_turismo`.`Museu`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`Museu` (
  `idMuseu` INT NOT NULL auto_increment,
  `descricaoMuseu` VARCHAR(45) NULL,
  `cepMuseu` INT NULL,
  `numMuseu` INT NULL,
  `complementoMuseu` VARCHAR(45) NULL,
  `dataMuseu` DATE NULL,
  `salasMuseu` INT NULL,
  `Cidade_idCidade` INT NOT NULL,
  PRIMARY KEY (`idMuseu`, `Cidade_idCidade`),
  INDEX `fk_Museu_Cidade1_idx` (`Cidade_idCidade` ASC),
  CONSTRAINT `fk_Museu_Cidade1`
    FOREIGN KEY (`Cidade_idCidade`)
    REFERENCES `Agencia_turismo`.`Cidade` (`idCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Agencia_turismo`.`QuartoHotel_has_Hotel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Agencia_turismo`.`QuartoHotel_has_Hotel` (
  `QuartoHotel_idQuartoHotel` INT NOT NULL,
  `Hotel_idHotel` INT NOT NULL,
  `Hotel_Cidade_idCidade` INT NOT NULL,
  PRIMARY KEY (`QuartoHotel_idQuartoHotel`, `Hotel_idHotel`, `Hotel_Cidade_idCidade`),
  INDEX `fk_QuartoHotel_has_Hotel_Hotel1_idx` (`Hotel_idHotel` ASC, `Hotel_Cidade_idCidade` ASC),
  INDEX `fk_QuartoHotel_has_Hotel_QuartoHotel1_idx` (`QuartoHotel_idQuartoHotel` ASC),
  CONSTRAINT `fk_QuartoHotel_has_Hotel_QuartoHotel1`
    FOREIGN KEY (`QuartoHotel_idQuartoHotel`)
    REFERENCES `Agencia_turismo`.`QuartoHotel` (`idQuartoHotel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_QuartoHotel_has_Hotel_Hotel1`
    FOREIGN KEY (`Hotel_idHotel` , `Hotel_Cidade_idCidade`)
    REFERENCES `Agencia_turismo`.`Hotel` (`idHotel` , `Cidade_idCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
