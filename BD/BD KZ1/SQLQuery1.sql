CREATE DATABASE SchoolDB 
GO
USE SchoolDB 
GO
CREATE TABLE Specialites
(
  Id INT PRIMARY KEY,
  Name NVARCHAR(64) NOT NULL,
  Description NVARCHAR(1024),
  GraduatesTitle NVARCHAR(32) NOT NULL UNIQUE,
  StartGrade INT CONSTRAINT StartGrade_range CHECK (StartGrade BETWEEN 1 AND 12) NOT NULL,
  EndGrade INT CONSTRAINT EndGrade_range CHECK (EndGrade BETWEEN 1 AND 12) NOT NULL 
)
GO

CREATE TABLE Classes
(
  Id INT PRIMARY KEY,
  Grade INT CONSTRAINT Grade_range CHECK (Grade BETWEEN 1 AND 12) NOT NULL,
  GradeLetter NVARCHAR(1) NOT NULL,
  SpecialityId INT CONSTRAINT FK_Classes_Specialites
  FOREIGN KEY REFERENCES Specialites(Id) NOT NULL
)
GO 

CREATE TABLE Students
(
  Id INT PRIMARY KEY IDENTITY,
  FirstName NVARCHAR(16) NOT NULL,
  SurName NVARCHAR(16) NOT NULL,
  LastName NVARCHAR(16) NOT NULL,
  GSM NVARCHAR(16) NOT NULL,
  Email NVARCHAR(32) NOT NULL UNIQUE,
  Address NVARCHAR(64) NOT NULL,
  Age INT CONSTRAINT Age_range CHECK (Age BETWEEN 8 AND 20) NOT NULL,
  Gender BIT NOT NULL,
  ClassID INT CONSTRAINT FK_Students_Classes
  FOREIGN KEY REFERENCES Classes(Id) NOT NULL
)
GO

CREATE TABLE Teachers
(
  Id INT PRIMARY KEY,
  FirstName NVARCHAR(16) NOT NULL,
  LastName NVARCHAR(16) NOT NULL,
  Gender BIT NOT NULL,
  Email NVARCHAR(32) NOT NULL UNIQUE,
  Subjects NVARCHAR(64),
  ManagedClassID INT CONSTRAINT FK_Teachers_Classes
  FOREIGN KEY REFERENCES Classes(Id)
)
GO

INSERT INTO Specialites(Id, Name, Description, GraduatesTitle, StartGrade, EndGrade) VALUES
(1, 'Applied Programming', 'The process of creating software that solves specific user tasks or problems', 'Applied Programmer', 8, 12),
(2, 'Automotive Mechatronics', 'This specialization is aimed at acquiring knowledge and practical skills for modern vehicles, where all cutting-edge achievements from perfect mechanics to onboard computers are combined', 'Transport Technician', 8, 12),
(3, 'Computer Technology and Techniques', 'This specialization focuses on acquiring knowledge and practical skills for modern microprocessors and computer systems, peripheral devices, and various computer components', 'Computer Systems Technician', 8, 12),
(4, 'Electrical Equipment for Production', 'Fundamentals of electrical engineering, electrical machines and devices, power supply, and electrical equipment for industrial enterprises are studied',  'Electrician', 8, 12)
GO

INSERT INTO Classes (Id, Grade, GradeLetter, SpecialityID) VALUES
(1, 9, 'A', 4),
(2, 10, 'B', 2),
(3, 11, 'A', 1),
(4, 8, 'C', 1)
GO

INSERT INTO Teachers (Id, FirstName, LastName, Gender, Email, Subjects, ManagedClassID)
VALUES
(1, 'Nikola', 'Hristov', 1, 'n.hristov@pgmett.com', 'OOP', 2),
(2, 'Nedyalka', 'Yordanova', 0, 'n.yordanova@pgmett.com', 'Software Development', 1),
(3, 'Tatyana', 'Boyarova', 0, 't.boyarova@pgmett.com', 'Electrical Engineering', NULL),
(4, 'Detelina', 'Antonova',0 , 'dantonova@pgmett.com', 'English',4),
(5, 'Anton', 'Bazelkov',1 , 'abazelkov@pgmett.com', 'PE',3)


GO

INSERT INTO Students (FirstName, SurName, LastName, GSM, Email, Address, Age, Gender, ClassID)
VALUES
('Nikola', 'Dobrinoff', 'Nikolov', '088 569 4584', 'nnikolov@pgmett.com', 'Makak, Bulgaria', 17, 1, 3),
('Petkan', 'Ivanov', 'Ivanov', '089 124 4564', 'pivanov@pgmett.com', 'Shumen, Bulgaria', 15, 1, 4),
('Dragan', 'Petkov', 'Georgiev', '089 547 6177', 'Dgeorgiev@pgmett.com', 'Salmanovo, Bulgaria', 16, 1, 1),
('Ivana', 'Stratsimirova', 'Stoyanova', '088 486 1786', 'istoqnova@pgmett.com', 'Shumen, Bulgaria', 18, 0, 2),
('Nikolay', 'Danielov', 'Kolev', '089 562 3485', 'nkolev@pgmett.com', 'Mutnica, Bulgaria', 15, 1, 3),
('Stoyan', 'Slavov', 'Dimitrov', '088 569 4584', 'sdimitrov@pgmett.com', 'Shumen, Bulgaria', 17, 1, 4),
('Daniel', 'Slavov', 'Obretenov', '088 569 4584', 'dobretenov@pgmett.com', 'Madara, Bulgaria', 18, 1, 1),
('Gergana', 'Krasenova', 'Ivanova', '088 569 4584', 'givanova@pgmett.com', 'Shumen, Bulgaria', 16, 0, 2),
('Kristiyan', 'Dimitrov', 'Dermejiev', '088 569 4584', 'kdermenjiev@pgmett.com', 'Shumen, Bulgaria', 14, 1, 3),
('Vladislav', 'Genadiev', 'Stratimirov', '088 569 4584', 'vstratimirov@pgmett.com', 'Kaspichan, Bulgaria', 16, 1, 2)

-- ALTER TABLE Speciality ALTER COLUMN Name VARCHAR(64) NOT NULL; 

SELECT * FROM Specialites
SELECT * FROM Classes
SELECT * FROM Students
SELECT * FROM Teachers
 