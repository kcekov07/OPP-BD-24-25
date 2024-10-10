CREATE DATABASE KRIS123

USE KRIS123
GO
CREATE TABLE CarManufacturers
(
  Id INT PRIMARY KEY,
  Name NVARCHAR(32) NOT NULL,
  Email NVARCHAR(128) NOT NULL UNIQUE,
  Adress NVARCHAR(128) NOT NULL

)
GO
CREATE TABLE Cars
(
  Id INT PRIMARY KEY IDENTITY,
  Model NVARCHAR(64)  NOT NULL,
  Description  NVARCHAR(256),
  Price DECIMAL(8,2) CONSTRAINT Valid_Price CHECK (Price>=0) NOT NULL,
  HorsePower INT NOT NULL,
  EngineType NVARCHAR,
  CarManufacturerId INT CONSTRAINT FK_Cars_CarManufacturers
  FOREIGN KEY REFERENCES  CarManufacturers(Id) NOT NULL

)
GO

INSERT INTO CarManufacturers(Id, Name, Email,Adress) VALUES







