-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8mb3 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`category`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`category` (
  `Category_id` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Category_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`book`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`book` (
  `Book_id` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(45) NOT NULL,
  `Author` VARCHAR(45) NOT NULL,
  `Publisher` VARCHAR(45) NULL DEFAULT NULL,
  `Publication` VARCHAR(45) NULL DEFAULT NULL,
  `ISBN` INT NOT NULL,
  `Description` VARCHAR(45) NULL DEFAULT NULL,
  `Pages` INT NULL DEFAULT NULL,
  `Price` INT NOT NULL,
  `Category` INT NULL DEFAULT NULL,
  `Status` TINYINT NULL DEFAULT 1 COMMENT '1表示True,可借\n',
  PRIMARY KEY (`Book_id`),
  INDEX `Catagory_idx` (`Category` ASC) VISIBLE,
  INDEX `Title_idx` (`Title` ASC) VISIBLE,
  CONSTRAINT `Catagory`
    FOREIGN KEY (`Category`)
    REFERENCES `mydb`.`category` (`Category_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`user`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`user` (
  `User_id` INT NOT NULL,
  `Username` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `PhoneNumber` INT NULL DEFAULT NULL,
  `Type` INT NOT NULL DEFAULT 1 COMMENT '1表示普通用户,2表示管理员\n',
  PRIMARY KEY (`User_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`borrowlimit`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`borrowlimit` (
  `User_id` INT NOT NULL,
  `Limit` INT NULL DEFAULT 5,
  PRIMARY KEY (`User_id`),
  CONSTRAINT `User_id1`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`user` (`User_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`borrowrecord`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`borrowrecord` (
  `Record_id` INT NOT NULL AUTO_INCREMENT,
  `Book_id` INT NOT NULL,
  `User_id` INT NOT NULL,
  `BorrowDate` DATETIME NULL DEFAULT NULL,
  `ReturnDate` DATETIME NULL DEFAULT NULL,
  `FineAmount` INT NULL DEFAULT NULL,
  PRIMARY KEY (`Record_id`),
  INDEX `Book_id_idx` USING BTREE (`Book_id`) INVISIBLE,
  INDEX `User_id_idx` USING BTREE (`User_id`) INVISIBLE,
  CONSTRAINT `Book_id2`
    FOREIGN KEY (`Book_id`)
    REFERENCES `mydb`.`book` (`Book_id`),
  CONSTRAINT `User_id2`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`user` (`User_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`language`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`language` (
  `langguage` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`langguage`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
