-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema CxEletronico
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema CxEletronico
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `CxEletronico` DEFAULT CHARACTER SET utf8 ;
USE `CxEletronico` ;

-- -----------------------------------------------------
-- Table `CxEletronico`.`Tb_Banco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CxEletronico`.`Tb_Banco` (
  `idBanco` INT NOT NULL AUTO_INCREMENT,
  `nr_banco` VARCHAR(3) NOT NULL,
  `nmBanco` VARCHAR(50) NULL,
  PRIMARY KEY (`idBanco`),
  UNIQUE INDEX `nmBanco_UNIQUE` (`nmBanco` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CxEletronico`.`Tb_Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CxEletronico`.`Tb_Cliente` (
  `idTb_Cliente` INT NOT NULL AUTO_INCREMENT,
  `nm_cliente` VARCHAR(60) NULL,
  `nr_cpf` VARCHAR(11) NULL,
  `nr_rg` VARCHAR(15) NULL,
  PRIMARY KEY (`idTb_Cliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CxEletronico`.`Tb_conta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CxEletronico`.`Tb_conta` (
  `idTb_conta` INT NOT NULL AUTO_INCREMENT,
  `nr_senha` VARCHAR(45) NOT NULL,
  `nr_conta` INT NOT NULL,
  `vl_saldo` DOUBLE NULL,
  `cd_status` INT NOT NULL,
  `Tb_Banco_idBanco` INT NOT NULL,
  `Tb_Cliente_idTb_Cliente` INT NOT NULL,
  PRIMARY KEY (`idTb_conta`),
  INDEX `fk_Tb_conta_Tb_Banco1_idx` (`Tb_Banco_idBanco` ASC),
  INDEX `fk_Tb_conta_Tb_Cliente1_idx` (`Tb_Cliente_idTb_Cliente` ASC),
  CONSTRAINT `fk_Tb_conta_Tb_Banco1`
    FOREIGN KEY (`Tb_Banco_idBanco`)
    REFERENCES `CxEletronico`.`Tb_Banco` (`idBanco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tb_conta_Tb_Cliente1`
    FOREIGN KEY (`Tb_Cliente_idTb_Cliente`)
    REFERENCES `CxEletronico`.`Tb_Cliente` (`idTb_Cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CxEletronico`.`tb_CaixaEletronico`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CxEletronico`.`tb_CaixaEletronico` (
  `idtb_CaixaEletronico` INT NOT NULL AUTO_INCREMENT,
  `qt_disponivel` DOUBLE NULL,
  `Tb_Banco_idBanco` INT NOT NULL,
  PRIMARY KEY (`idtb_CaixaEletronico`),
  INDEX `fk_tb_CaixaEletronico_Tb_Banco1_idx` (`Tb_Banco_idBanco` ASC),
  CONSTRAINT `fk_tb_CaixaEletronico_Tb_Banco1`
    FOREIGN KEY (`Tb_Banco_idBanco`)
    REFERENCES `CxEletronico`.`Tb_Banco` (`idBanco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
