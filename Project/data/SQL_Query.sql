USE master
GO

CREATE DATABASE BC_STUDENTS
GO

USE BC_STUDENTS;

CREATE TABLE Courses
(
	ModCode char(6) PRIMARY KEY NOT NULL,
	ModName varchar(50),
	ModDesc varchar(200),
);

GO

CREATE Table Students
(
	StudentNumber int PRIMARY KEY NOT NULL,
	FirstName varchar(40),
	LastName varchar(80),
	Gender varchar(14),
	StudentDOB DATE,
	Phone varchar(10),
	HomeAddress varchar(100),
	Picture IMAGE
);

GO

CREATE TABLE StudentCourses
(
	StudentNumber int NOT NULL FOREIGN KEY REFERENCES Students(StudentNumber) ON DELETE CASCADE,
	ModCode char(6) NOT NULL FOREIGN KEY REFERENCES Courses(ModCode) ON DELETE CASCADE, 
	PRIMARY KEY (StudentNumber, Modcode)
);

GO

CREATE TABLE Resources
(
	ResourceID int NOT NULL PRIMARY KEY,
	Link nvarchar(255),
	Module char(6) FOREIGN KEY REFERENCES Courses(ModCode) ON DELETE CASCADE
);

GO

Insert Into Courses(ModCode, ModName, ModDesc) VALUES 
('PRG282', 'Programming 282', 'Learning of File modification in c#.')
Insert Into Courses(ModCode, ModName, ModDesc) VALUES 
('PRG281', 'Programming 281', 'Learning of Object Oriented Programming.')
Insert Into Courses(ModCode, ModName, ModDesc) VALUES 
('WPR281', 'Web-Programming 281', 'Learning of HTML scripts and adding them via Javascripts.')
Insert Into Courses(ModCode, ModName, ModDesc) VALUES 
('DBD281', 'Database Development 281', 'Learning of SQL server and database development.')
Insert Into Courses(ModCode, ModName, ModDesc) VALUES 
('PMM281', 'Project Management 281', 'Learn how to effectively manage a project')
Insert Into Courses(ModCode, ModName, ModDesc) VALUES 
('MAT281', 'Mathematics 281', 'Learn the basics of Differential and Intgral Calculus')
Insert Into Courses(ModCode, ModName, ModDesc) VALUES 
('STA281', 'Statistics 281', 'Learn the basics of inferential statistics')
GO

Insert Into Resources(ResourceID, Link, Module) VALUES
(1, 'https://www.c-sharpcorner.com/blogs/c-sharp-database-connection', 'PRG282');
Insert Into Resources(ResourceID, Link, Module) VALUES
(2, 'https://www.w3schools.com/cs/cs_oop.php', 'PRG281');
Insert Into Resources(ResourceID, Link, Module) VALUES
(3, 'https://www.javatpoint.com/how-to-add-javascript-to-html', 'WPR281');
Insert Into Resources(ResourceID, Link, Module) VALUES
(4, 'https://www.w3schools.com/sql/', 'DBD281');
Insert Into Resources(ResourceID, Link, Module) VALUES
(5, 'https://www.wrike.com/project-management-guide/faq/what-is-pert-in-project-management/', 'PMM281');
Insert Into Resources(ResourceID, Link, Module) VALUES
(6, 'https://www.cuemath.com/calculus/', 'MAT281');
Insert Into Resources(ResourceID, Link, Module) VALUES
(7, 'https://corporatefinanceinstitute.com/resources/economics/laspeyres-price-index/', 'STA281');
GO

Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 1, 'Jake', 'Adams','Male','09-10-2000' , '0711112222','10 Plat Str, Johannesburg', BulkColumn
		from Openrowset (Bulk 'Student Images\JakeAdams.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 2, 'John', 'Doe','Male','04-12-2002' , '0715612782','8 Sims Street, Pretoria', BulkColumn
		from Openrowset (Bulk 'Student Images\JohnDoe.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 3, 'Jane', 'Adams','Female','1999-10-30', '0614112822','2 Alder Lane, Mooinooi', BulkColumn
		from Openrowset (Bulk 'Student Images\JaneAdams.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 4, 'Sam', 'Smith','Male','04-03-2000' , '0721816922','10 Kraai Street, Mooinooi', BulkColumn
		from Openrowset (Bulk 'Student Images\SamSmith.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 5, 'Maya', 'Bee','Female','07-05-2001' , '0851692247','10 Vink Street, Pretoria', BulkColumn
		from Openrowset (Bulk 'Student Images\MayaBee.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 6, 'Flynn', 'Ryder','Male','09-01-1998' , '0761145822','1 Link Street, Kosmos', BulkColumn
		from Openrowset (Bulk 'Student Images\FlynnRyder.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 7, 'Meridith', 'Grey','Female','2000-10-17' , '0726892687','9 Aler Lane, Alexandria', BulkColumn
		from Openrowset (Bulk 'Student Images\MeridithGrey.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 8, 'Andrew', 'Deluca','Male','2002-02-25' , '0785742522','10 Alder Lane, BitTown', BulkColumn
		from Openrowset (Bulk 'Student Images\AndrewDeluca.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 9, 'Derek', 'Shephard','Male','1998-06-26' , '0725152252','17 Berg Lane, Brits', BulkColumn
		from Openrowset (Bulk 'Student Images\DerekShephard.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 10, 'Mark', 'Sloan','Male','08-12-2000' , '0715816927','10 Process Lane, Harties', BulkColumn
		from Openrowset (Bulk 'Student Images\MarkSloan.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName,Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 11, 'Christina', 'Yang','Female','12-05-2000' , '0769512692','4 Epson Road, Alexandria', BulkColumn
		from Openrowset (Bulk 'Student Images\ChristinaYang.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture) 
	SELECT 12, 'Lexie', 'Grey','Female','2000-12-21' , '0736515622','10 Aler Lane, Alexandria', BulkColumn
		from Openrowset (Bulk 'Student Images\LexieGrey.jpg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 13, 'Arizona', 'Robbins','Female','09-10-2000' , '0760472036','1 Easter Road, Pretoria', BulkColumn
		from Openrowset (Bulk 'Student Images\ArizonaRobbins.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture) 
	SELECT 14, 'Alex', 'Karev','Male','2000-10-17' , '0726102322','10 Long Str, Johannesburg', BulkColumn
		from Openrowset (Bulk 'Student Images\AlexKarev.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture) 
	SELECT 15, 'Callie', 'Torez','Female','09-04-2002' , '0715142327','6 Short Str, Harties', BulkColumn
		from Openrowset (Bulk 'Student Images\CallieTorez.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 16, 'Izzie', 'Stevens','Female','07-07-2000' , '0713612982','5 Chruch Str, Pretoria East', BulkColumn
		from Openrowset (Bulk 'Student Images\IzzieStevens.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 17, 'Amilia', 'Shepard','Female','08-11-2000' , '0733368222','9 Chalet Str, Brits', BulkColumn
		from Openrowset (Bulk 'Student Images\AmiliaShepard.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 18, 'Maggie', 'Peers','Female','09-10-2000' , '0711112222','3 Platter Str, Roodepoort', BulkColumn
		from Openrowset (Bulk 'Student Images\MaggiePeers.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 19, 'Miranda', 'Baily','Female','09-01-2000' , '0723156222','6 Hills Str, Pretoria', BulkColumn
		from Openrowset (Bulk 'Student Images\MirandaBaily.jpeg', Single_Blob) as Image;
Insert Into Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture)
	SELECT 20, 'Richard', 'Webber','Male','2000-12-29' , '0712815927','10 Mountain Str, Johannesburg', BulkColumn
		from Openrowset (Bulk 'Student Images\RichardWebber.jpeg', Single_Blob) as Image;

GO

Insert Into StudentCourses(StudentNumber,ModCode) VALUES (1, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (2, 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (3, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (4, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (5, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (6, 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (7, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (8, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (9, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (10, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (11, 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (12, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (13, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (14, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (15, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (16, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (17, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (18, 'PMM281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (19, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (20, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (20, 'STA281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (5, 'MAT281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (8, 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (6, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (1, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (7, 'STA281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (11, 'MAT281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (12, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (13, 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (14, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (15, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (16, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (17, 'WPR281');

GO

CREATE PROC spGetModCodes
AS
BEGIN
	SELECT ModCode FROM Courses;
END
GO
