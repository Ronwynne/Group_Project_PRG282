USE master
GO

CREATE DATABASE BC_STUDENTS
GO

CREATE TABLE Courses
(
	ModCode varchar(10) PRIMARY KEY NOT NULL,
	ModName varchar(50),
	ModDesc varchar(200),
	Link varchar(200)
);
CREATE Table Students
(
	StudentNumber int PRIMARY KEY NOT NULL,
	NameSurname varchar(80),
	Gender varchar(5),
	StudentDOB varchar(20),
	Phone varchar(10),
	HomeAddress varchar(100),
	ImgPath varchar(100)
);
CREATE TABLE StudentCourses
(
	StudentNumber int FOREIGN KEY REFERENCES Students(StudentNumber),
	ModCode varchar(10) FOREIGN KEY REFERENCES Courses(ModCode),
	PRIMARY KEY (StudentNumber, Modcode)
);

Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('PRG282', 'Programming 282', 'Learning of File modification in c#.','https://www.c-sharpcorner.com/blogs/c-sharp-database-connection')
Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('PRG281', 'Programming 281', 'Learning of Object Oriented Programming.','https://www.w3schools.com/cs/cs_oop.php')
Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('WPR281', 'Web-Programming 281', 'Learning of HTML scripts and adding them via Javascripts.','https://www.javatpoint.com/how-to-add-javascript-to-html')
Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('DBD281', 'Database Development 281', 'Learning of SQL server and database development.','https://www.w3schools.com/sql/')

Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(1, 'Jake Adams','Male','09-10-2000' , '0711112222','10 Plat Str, Johannesburg','JakeAdams.png');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(2, 'John Doe','Male','04-12-2002' , '0715612782','8 Sims Street, Pretoria','Student Images\JohnDoe.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(3, 'Jane Adams','Female','30-10-1999' , '0614112822','2 Alder Lane, Mooinooi','Student Images\JaneDoe.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(4, 'Sam Smith','Male','04-03-2000' , '0721816922','10 Kraai Street, Mooinooi','Student Images\SamSmith.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(5, 'Maya Bee','Female','07-05-2001' , '0851692247','10 Vink Street, Pretoria','Student Images\MayaBee.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(6, 'Flynn Rider','Male','09-01-1998' , '0761145822','1 Link Street, Kosmos','Student Images\FlynnRider.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(7, 'Meridith Grey','Female','17-10-2000' , '0726892687','9 Aler Lane, Alexandria','Student Images\MeridithGrey.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(8, 'Andrew Deluca','Male','25-02-2002' , '0785742522','10 Alder Lane, BitTown','Student Images\AndrewDeluca.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(9, 'Derek Shephard','Male','26-06-1998' , '0725152252','17 Berg Lane, Brits','Student Images\DekekShephard.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(10, 'Mark Sloan','Male','08-12-2000' , '0715816927','10 Process Lane, Harties','Student Images\MarkSloan.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(11, 'Christina Yang','Female','12-05-2000' , '0769512692','4 Epson Road, Alexandria','Student Images\ChristinaYang.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(12, 'Lexie Grey','Female','21-12-2000' , '0736515622','10 Aler Lane, Alexandria','Student Images\LexieGrey.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(13, 'Arizona Robins','Female','09-10-2000' , '0760472036','1 Easter Road, Pretoria','Student Images\ArizonaRobins.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(14, 'Alex Karev','Male','17-10-2000' , '0726102322','10 Long Str, Johannesburg','Student Images\AlexKarev.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(15, 'Callie Torros','Female','09-04-2002' , '0715142327','6 Short Str, Harties','Student Images\CallieTorez.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(16, 'Izzie Stevens','Female','07-07-2000' , '0713612982','5 Chruch Str, Pretoria East','Student Images\IzzieStevens.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(17, 'Amilia Shephard','Female','08-11-2000' , '0733368222','9 Chalet Str, Brits','Student Images\AmiliaShephard.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(18, 'Maggie Peers','Female','09-10-2000' , '0711112222','3 Platter Str, Roodepoort','Student Images\MaggiePeers.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(19, 'Maranda Bailey','Female','09-01-2000' , '0723156222','6 Hills Str, Pretoria','Student Images\MarandaBaily.jpg');
Insert Into Students(StudentNumber, NameSurname,Gender, StudentDOB, Phone, HomeAddress,ImgPath) Values
(20, 'Richard Webber','Male','29-12-2000' , '0712815927','10 Mountain Str, Johannesburg','Student Images\RichardWebber.jpg');

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
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (18, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (19, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (20, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (20, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (5, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (8, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (6, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (1, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (7, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (11, 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (12, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (13, 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (14, 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (15, 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (16, 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES (17, 'WPR281');
GO
