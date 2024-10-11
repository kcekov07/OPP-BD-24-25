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
  EngineType NVARCHAR(128),
  CarManufacturerId INT CONSTRAINT FK_Cars_CarManufacturers
  FOREIGN KEY REFERENCES  CarManufacturers(Id) NOT NULL

)
GO

INSERT INTO CarManufacturers(Id, Name, Email,Adress) VALUES
(1,'Audi','audiofficial@gmail.com','Berlin  9 September street'),
(2,'BMW','BMWofficial@abv.ge','Frankfurt Reinriver street'),
(3,'Mercedes','mercedesbenz@yahoo.com',' Sofia Georgi Rakovski street'),
(4,'Dachia','dachiaofficial.abv.re','Bucurest Strada Maria street')

GO
INSERT INTO Cars(CarManufacturerId,Model, Description,Price,HorsePower,EngineType) VALUES
(1,'Audi RSQ8','2022 model super moshten i iconomichen model',185000.00,'560','V8'),
(3,'Mercedes CLS','2023 model moshten,semeen avtomobil',145000.00,'457','3,0 – 6,2 benzin'),
(4,'Dachia Duster','2020 model super semeen iconomichen model',56000.00,'225','V6'),
(2,'BMW M5','2022 model super moshten,burz i krasiv',250000.00,'650','V8')

SELECT* FROM CarManufacturers

SELECT* FROM Cars

DROP TABLE Cars








