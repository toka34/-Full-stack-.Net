use ExamSystem
-- Branch table
--Branch(branch_id,branch_name,
create table Branch(
  BranchID INT primary key IDENTITY(1,1),
  BranchName VARCHAR(50) NOT NULL
  );
--Account(Account_id,username,password  
--Account table
create table Account(
  AccountID INT primary key IDENTITY(1,1),
  Username VARCHAR(50) NOT NULL UNIQUE,
  Password varchar(50) Not Null -->>was mised 
  );
--Manager(ManagerID,ManagerName,AccountID,BranchID
--Manager table
create table Manager(
   ManagerID INT PRIMARY KEY IDENTITY(1,1),
   ManagerName VARCHAR(50) NOT NULL,
   AccountID INT NOT NULL UNIQUE, 
   BranchID INT FOREIGN KEY REFERENCES Branch(BranchID) -->>inserted new
  );
  --Intake(IntakeID,BranchID,
--Intake table
create table Intake(
  IntakeID INT PRIMARY KEY IDENTITY(1,1),
  
  BranchID INT NOT NULL FOREIGN KEY REFERENCES Branch(BranchID) 
);
--Track(TrackID,TrackName,IntakeID
--Track table
create table Track(
  TrackID INT PRIMARY key IDENTITY(1,1),
  TrackName VARCHAR(50) not null ,
  IntakeID INT NOT NULL FOREIGN KEY REFERENCES Intake(IntakeID)
  );
--Instructor(InstructorID,InstructorName,AccountID,
--Instructor table
create table Instructor(
  InstructorID INT primary key  IDENTITY(1,1),
  InstructorName VARCHAR(80),
  AccountID INT NOT NULL foreign key REFERENCES Account(AccountID) 
  );
--Class(ClassID,ClassName,Year, InstructorId  
 --Class table
 create table Class(
   ClassID INT primary key  IDENTITY(1,1),
   ClassName VARCHAR(50) NOT NULL,
   Year INT NOT NULL CHECK (Year >= 2020 AND Year <= YEAR(GETDATE())),      -->> the check constraint why
   InstructorId INT NOT NULL FOREIGN KEY REFERENCES Instructor(InstructorID)
   );
--Student(StudentID,StudentName,ManagerID,AccountID,TrackID,ClassID   
 --Student table 
 CREATE TABLE Student (
    StudentID INT PRIMARY KEY IDENTITY(1,1), 
    StudentName VARCHAR(80) NOT NULL,
    ManagerID INT NOT NULL FOREIGN KEY REFERENCES Manager(ManagerID), 
    AccountID INT NOT NULL UNIQUE FOREIGN KEY REFERENCES Account(AccountID), 
    TrackID INT NOT NULL FOREIGN KEY REFERENCES Track(TrackID),
    ClassID INT NOT NULL FOREIGN KEY REFERENCES Class(ClassID)
);
--Course(CourseID,CourseName,MaxDegree,MinDegree,Description
--Course table 
CREATE TABLE Course (
    CourseID INT PRIMARY KEY IDENTITY(1,1), 
    CourseName VARCHAR(100) NOT NULL,
    MaxDegree INT NOT NULL,
    MinDegree AS CAST(0.6 * MaxDegree AS INT) PERSISTED,
    Description VARCHAR(500) NULL
);
--Exam(ExamID,Type,AllowanceOption,StartTime,EndTime,InstructorID,IntakeID,BranchID,TrackID
--Exam table 10
CREATE TABLE Exam (
    ExamID INT PRIMARY KEY IDENTITY(1,1),
    Ty_Q VARCHAR(50) NOT NULL CHECK (Type IN ('exam', 'corrective')) , 
    AllowanceOption Varchar(100),                         
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    TotalTime AS DATEDIFF(MINUTE, StartTime, EndTime) PERSISTED, --Type
    IntakeID INT NOT NULL FOREIGN KEY REFERENCES Intake(IntakeID),
    BranchID INT NOT NULL FOREIGN KEY REFERENCES Branch(BranchID),
    TrackID INT NOT NULL FOREIGN KEY REFERENCES Track(TrackID),
    InstructorID INT NOT NULL FOREIGN KEY REFERENCES Instructor(InstructorID),
    ClassID int not null foreign key REFERENCES Class(ClassID)
);
--QuestionPool(QuestionID,QuestionText,Type,CorrectAnswer,
--Question Pool table 
CREATE TABLE QuestionPool (
    QuestionID INT PRIMARY KEY IDENTITY(1,1),
    QuestionText VARCHAR(MAX) NOT NULL,
    Type VARCHAR(50) NOT NULL CHECK (Type IN ('True & False', 'Multiple Choice', 'Text')),
    CorrectAnswer VARCHAR(MAX) NOT NULL
);
--Question_answer(QuestionID,OptionID,AnswerText
--	Question Answer table 
CREATE TABLE QuestionAnswer (
    QuestionID INT NOT NULL FOREIGN KEY REFERENCES QuestionPool(QuestionID),
    OptionID INT  IDENTITY(1,1),                       -->>removed primary key constraint from here
    AnswerText VARCHAR(MAX) NOT NULL,
    primary key(QuestionID,OptionID)                   --set the primary key composite
);
--CourseExam(CourseID,ExamID
--Course Exam table 
CREATE TABLE CourseExam (
    CourseID INT NOT NULL FOREIGN KEY REFERENCES Course(CourseID),
    ExamID INT NOT NULL FOREIGN KEY REFERENCES Exam(ExamID),
    PRIMARY KEY (CourseID, ExamID)
);
--ExamQuestion(ExamID,QuestionID,Degree
--Exam Question table
CREATE TABLE ExamQuestion (
    ExamID INT NOT NULL FOREIGN KEY REFERENCES Exam(ExamID),
    QuestionID INT NOT NULL FOREIGN KEY REFERENCES QuestionPool(QuestionID),
    Degree INT NOT NULL,
    PRIMARY KEY (ExamID, QuestionID)
);
--StudentExam(StudentID,ExamID,QuestionID,StudentAnswer,IsCorrect,DegreeEarned
--Student exam table
 CREATE TABLE StudentExam (              
    StudentID INT NOT NULL FOREIGN KEY REFERENCES Student(StudentID),
    ExamID INT NOT NULL FOREIGN KEY REFERENCES Exam(ExamID),
    QuestionID INT NOT NULL FOREIGN KEY REFERENCES QuestionPool(QuestionID),
    StudentAnswer VARCHAR(MAX),
    IsCorrect BIT NULL,  
    DegreeEarned INT NULL,  
    PRIMARY KEY (StudentID, ExamID, QuestionID)
);
--TrackCourse(TrackID,CourseID,
--Track course table 
CREATE TABLE TrackCourse (
    TrackID INT NOT NULL FOREIGN KEY REFERENCES Track(TrackID), 
    CourseID INT NOT NULL FOREIGN KEY REFERENCES Course(CourseID), 
    PRIMARY KEY (TrackID, CourseID)
);
--ClassCourse(CourseID,ClassID, 
--Class Course table
CREATE TABLE ClassCourse (
    CourseID INT NOT NULL FOREIGN KEY REFERENCES Course(CourseID), 
    ClassID INT NOT NULL FOREIGN KEY REFERENCES Class(ClassID),
    PRIMARY KEY (CourseID, ClassID)
);
--BranchManager(ManagerID,BranchID,
--Branch Manager Table 
CREATE TABLE BranchManager (
    ManagerID INT NOT NULL FOREIGN KEY REFERENCES Manager(managerid)  ,  
    BranchID INT NOT NULL FOREIGN KEY REFERENCES Branch(branchid) ,  
    PRIMARY KEY (ManagerID, BranchID)
);
--AuditLog(AuditID,LogMessage,LogDate)
 CREATE TABLE AuditLog (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    LogMessage VARCHAR(MAX) NOT NULL,
    LogDate DATETIME NOT NULL
);
--ExamAuditLog(AuditID,ActionType,LogMessage,LogDate)
CREATE TABLE ExamAuditLog (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    ActionType VARCHAR(50) NOT NULL,
    LogMessage VARCHAR(MAX) NOT NULL,
    LogDate DATETIME NOT NULL
);

--add branch s_p
alter PROCEDURE AddBranch
    @BranchName VARCHAR(50)
AS
BEGIN
    INSERT INTO Manager_schema.Branch (BranchName) VALUES (@BranchName);
    PRINT 'Branch added successfully.';
END;



go
--add account s_p------------------
alter  PROCEDURE RegisterAccount
    @Username VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Manager_schema.Account WHERE Username = @Username)
    BEGIN
        PRINT 'Username already exists.';
    END
    ELSE
    BEGIN
        INSERT INTO Manager_schema.Account (Username, Password) VALUES (@Username, @Password);
        PRINT 'Account created successfully.';
    END
END;
go
--RegisterAccount  'UserName51','PassWord51'
--select * from Manager_schema.Account
-----------------------------------

alter PROCEDURE RegisterStudent --add try and catch here
    @StudentName VARCHAR(80),
    @ManagerID INT,
   @UserName varchar(50),
   @Password varchar(50),
    @TrackID INT,
    @ClassID INT
AS
BEGIN
BEGIN TRY 
	insert into Manager_schema.Account(Username,Password) values(@UserName,@Password);
	DECLARE @AccountID INT;
        SELECT @AccountID = AccountID 
        FROM Manager_schema.Account
        WHERE Username = @UserName
        ORDER BY AccountID DESC;
		INSERT INTO Student_schema.Student (StudentName, ManagerID, AccountID, TrackID, ClassID) 
    VALUES (@StudentName, @ManagerID, @AccountID, @TrackID, @ClassID);
    PRINT 'Student registered successfully.';
END TRY 
BEGIN catch
select 'Enter valid input';
END catch   
END;
go
--select * from Student_schema.Student
--RegisterStudent 'mohamed' ,10,'mohamed1','1234',2,5
--------------------------------

 alter  PROCEDURE CreateExam
    @Type VARCHAR(50),
    @AllowanceOption VARCHAR(100),
    @StartTime DATETIME,
    @EndTime DATETIME,
    @IntakeID INT,
    @BranchID INT,
    @TrackID INT,
    @InstructorID INT,
    @ClassID int
AS
BEGIN
BEGIN TRY
    INSERT INTO Instructor_schema.Exam (Ty_Q, AllowanceOption, StartTime, EndTime, IntakeID, BranchID, TrackID, InstructorID,ClassID)
    VALUES (@Type, @AllowanceOption, @StartTime, @EndTime, @IntakeID, @BranchID, @TrackID, @InstructorID,@ClassID);
    select 'Exam created successfully.';
END TRY
BEGIN CATCH 
SELECT 'enter valid input';
END CATCH    
END;
go
-- Test data for the procedure
--DECLARE @Type VARCHAR(50) = 'exam';
--DECLARE @AllowanceOption VARCHAR(100) = 'open book';
--DECLARE @StartTime DATETIME = '2024-12-10 09:00:00'; -- Example start time
--DECLARE @EndTime DATETIME = '2024-12-10 11:00:00'; -- Example end time
--DECLARE @IntakeID INT = 1; -- Example intake ID
--DECLARE @BranchID INT = 4; -- Example branch ID
--DECLARE @TrackID INT = 2; -- Example track ID
--DECLARE @InstructorID INT = 10; -- Example instructor ID
--DECLARE @ClassID INT = 8; -- Example class ID

---- Execute the stored procedure with the test data
--EXEC CreateExam
--    @Type = @Type,
--    @AllowanceOption = @AllowanceOption,
--    @StartTime = @StartTime,
--    @EndTime = @EndTime,
--    @IntakeID = @IntakeID,
--    @BranchID = @BranchID,
--    @TrackID = @TrackID,
--    @InstructorID = @InstructorID,
--    @ClassID = @ClassID;
---------------------------------
alter PROCEDURE AddExamQuestion
@ExamID int ,
@QuestionID int,
@Degree int
 AS
 BEGIN
 INSERT INTO Instructor_schema.ExamQuestion(ExamID,QuestionID,Degree) VALUES
 (@ExamID,@QuestionID,@Degree)
 END;
go
--AddExamQuestion 31,6,3
--------------------------------------

alter PROCEDURE SubmitStudentAnswer 
    @StudentID INT,
    @ExamID INT,
    @QuestionID INT,
    @StudentAnswer VARCHAR(MAX)
AS
BEGIN
    -- Check if the student's answer is correct
    DECLARE @CorrectAnswer VARCHAR(MAX);
    DECLARE @Degree INT;
    
    SELECT @CorrectAnswer = CorrectAnswer FROM Instructor_schema.QuestionPool WHERE QuestionID = @QuestionID;
    SELECT @Degree = Degree FROM Instructor_schema.ExamQuestion WHERE QuestionID = @QuestionID AND ExamID = @ExamID;

    INSERT INTO Student_schema.StudentExam (StudentID, ExamID, QuestionID, StudentAnswer, IsCorrect, DegreeEarned)
    VALUES (@StudentID, @ExamID, @QuestionID, @StudentAnswer, 
            CASE WHEN @StudentAnswer = @CorrectAnswer THEN 1 ELSE 0 END,
            CASE WHEN @StudentAnswer = @CorrectAnswer THEN @Degree ELSE 0 END);

    PRINT 'Answer submitted successfully.';
END;
--SubmitStudentAnswer 26,36,4,'c#'
-----------------------------------85587588578
-- get student data
alter proc sp_GetStudentData @Id int
with encryption as
select s.* ,c.ClassName ,TrackName from Student_schema.Student s
inner join Manager_schema.Track t on s.TrackID=t.TrackID
inner join  Student_schema.Class c on s.ClassID=c.ClassID where @Id =s.StudentID 
--sp_GetStudentData 7
-------------|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
-------------------here ma4325542395235823095823-5af|||||||||

create proc sp_GetStudentExamResults
with encryption as 
SELECT 
    se.StudentID, 
    se.ExamID, 
    SUM(se.DegreeEarned) AS TotalScore
FROM StudentExam se
GROUP BY se.StudentID, se.ExamID;
------------------------------------------------

alter PROCEDURE sp_AvailableExams 
    @id INT, 
    @date DATETIME  -- Default to the current date and time
AS
BEGIN 
    SELECT 
        e.ExamID, 
        e.Ty_Q AS ExamType, 
        e.StartTime, 
        e.EndTime, 
        t.TrackName, 
        i.InstructorName
    FROM Instructor_schema.Exam e
    JOIN Manager_schema.Track t ON e.TrackID = t.TrackID
    JOIN Instructor_schema.Instructor i ON e.InstructorID = i.InstructorID 
    WHERE i.InstructorID = @id 
      AND @date< e.StartTime 
END;
--sp_AvailableExams 2,'2024-12-01 11:00:00.000'

-------------------------------------------------
alter proc sp_GetStudentDegreeInOneExam @st_id int ,@exam_id int
with encryption as 
begin
if exists (select 1 from Student_schema.Student
 inner join Student_schema.Class on Student.ClassID= Class.ClassID 
 inner join Instructor_schema.Exam on Exam.ClassID =Class.ClassID where Student.StudentID=@st_id)	
BEGIN
         SELECT 
            SUM(DegreeEarned) AS TotalDegreeEarned
        FROM 
            Student_schema.StudentExam
        WHERE 
            StudentID = @st_id AND ExamID = @exam_id;
    END
	else 
	begin 
    select 'student not allowed to take this exam'
	end
	end;
	--sp_GetStudentDegreeInOneExam 26,33
    ---------
    alter Procedure Student_Search_44   --done

    @Var_Student_id int
AS
Begin

select s.StudentID,s.StudentName,A.Username,M.ManagerName,T.TrackName,C.ClassName 
from Student_schema.Student as S join Manager_schema.Account as A
on S.AccountID=A.AccountID
join Manager_schema.Manager  as M
on m.ManagerID=S.ManagerID
join Manager_schema.Track as T
on S.TrackID = T.TrackID
join Student_schema.Class as C
on C.ClassID=S.ClassID
where StudentID=@Var_Student_id;
End;
EXEC Student_Search_44 @Var_Student_id = 7;
------------------------------------------------
go
alter Procedure Instructor_Search22 --done
    @Var_Instructor_Name varchar(50)
	AS
	Begin
	select InstructorName, Username, ClassName,CourseName,TrackName 
	from Instructor_schema.Instructor I join Manager_schema.Account A
	on I.AccountID=A.AccountID
	join Student_schema.Class C
	on c.InstructorId=i.InstructorID
	join Student_schema.ClassCourse CC
	on CC.ClassID=C.ClassID
	join Instructor_schema.Course co
	on co.CourseID=cc.CourseID
	join Manager_schema.TrackCourse tc
	on tc.CourseID=co.CourseID
	join Manager_schema.Track t
	on t.TrackID=tc.TrackID
	where I.InstructorName like '%' + @Var_Instructor_Name +'%';

	End;
	EXEC Instructor_Search22 @Var_Instructor_Name = 'Instructor13';
	go
	--------------
	go
	alter Procedure Instructor_Search11   --done
        @Var_Instructor_ID INT
		AS
	Begin
	select InstructorName, Username, ClassName,CourseName,TrackName 
	from Instructor_schema.Instructor I join Manager_schema.Account A
	on I.AccountID=A.AccountID
	join Student_schema.Class C
	on c.InstructorId=i.InstructorID
	join student_schema.ClassCourse CC
	on CC.ClassID=C.ClassID
	join Instructor_schema.Course co
	on co.CourseID=cc.CourseID
	join Manager_schema.TrackCourse tc
	on tc.CourseID=co.CourseID
	join Manager_schema.Track t
	on t.TrackID=tc.TrackID
	where I.InstructorID=@Var_Instructor_ID;

	End;
	EXEC Instructor_Search11 @Var_Instructor_ID = 12;

	go
	--------------
	go
	alter Procedure Manager_Search11  --done
	@name varchar(50)
	   AS
	   Begin
	   select ManagerID ,ManagerName, BranchName
	   from Manager_schema.Manager M join Manager_schema.Branch B
	   on M.BranchID=B.BranchID
	   where ManagerName like '%'+@name+'%';
	   End;
	   EXEC Manager_Search11 @name = 'manager 20';

    go
	--------------
	alter Procedure Student_TakeCourse_Search12  --done
	@course varchar(50) 
	AS
	Begin
	select S.StudentID, S.StudentName from Student_schema.Student S join Student_schema.Class C
	on S.ClassID=C.ClassID
	join Student_schema.ClassCourse cc
	on cc.ClassID=C.ClassID
	join Instructor_schema.Course
	on cc.CourseID=C.ClassID
	where CourseName like '%'+@course+'%';

	End;
	EXEC Student_TakeCourse_Search12 @course = 'Introduction to Computer Science';


	-------------
	go
	alter PROCEDURE course_track11  --done
    @course VARCHAR(50)
AS
BEGIN
    SELECT  
        c.CourseName, 
        t.TrackName 
    FROM 
        Instructor_schema.Course c 
    JOIN 
        Manager_schema.TrackCourse tc ON c.CourseID = tc.CourseID
    JOIN 
        Manager_schema.Track t ON t.TrackID = tc.TrackID
    WHERE  
        c.CourseName LIKE '%' + @course + '%';
END;
GO
EXEC course_track11 @course = 'Introduction to Computer Science'; -- Replace 'Math' with any part of the course name


------------------------------
alter PROC sp_StudentHasCorrective  --done
    @st_id INT,
    @exam_id INT
WITH ENCRYPTION
AS 
BEGIN
    IF EXISTS (SELECT 1 
               FROM Student_schema.Student
               INNER JOIN Student_schema.Class ON Student.ClassID = Class.ClassID 
               INNER JOIN Instructor_schema.Exam ON Exam.ClassID = Class.ClassID 
               WHERE Student.StudentID = @st_id)	
    BEGIN
        DECLARE @StDegree INT;
        SELECT @StDegree = SUM(DegreeEarned)
        FROM Student_schema.StudentExam
        WHERE StudentID = @st_id AND ExamID = @exam_id;

        DECLARE @ExamDegree INT;    
        SELECT @ExamDegree = SUM(Degree)
        FROM Instructor_schema.ExamQuestion
        WHERE ExamID = @exam_id;

        IF @StDegree < 0.6 * @ExamDegree
            SELECT 'student has corrective exam'
        ELSE
            SELECT 'student succeeded in the exam'
    END
    ELSE 
    BEGIN 
        SELECT 'this exam is not for the student'
    END
END;

EXEC sp_StudentHasCorrective @st_id = 26, @exam_id = 33;
-----------------


--chat add or update course ===========
alter PROCEDURE AddOrUpdateCourse  -- done
    @CourseID INT,
    @CourseName NVARCHAR(100),
    @Description NVARCHAR(255),
    @MaxDegree INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Instructor_schema.Course WHERE CourseID = @CourseID)
    BEGIN
        UPDATE Instructor_schema.Course
        SET CourseName = @CourseName,
            Description = @Description,
            MaxDegree = @MaxDegree
        WHERE CourseID = @CourseID;
    END
    ELSE
    BEGIN
        INSERT INTO Instructor_schema.Course (CourseName, Description, MaxDegree)
        VALUES (@CourseName, @Description, @MaxDegree);
    END;
END;

EXEC AddOrUpdateCourse 
    @CourseID = 1,    -- Replace with an existing CourseID
    @CourseName = 'Introduction to Computer Science', 
    @Description = 'An advanced course on Introduction to Computer Science.',
    @MaxDegree = 100;

	EXEC AddOrUpdateCourse 
    @CourseID = 24,    -- Replace with a non-existing CourseID
    @CourseName = 'Object-Oriented Programming', 
    @Description = 'An introductory course on Object-Oriented Programming concepts using Java or C++.',
    @MaxDegree = 150;
    --------------------------non cluster indexes
    create nonclustered index User_Name_Index 
on manager_schema.Account (UserName);

create nonclustered index Manager_Name_Index 
on manager_schema.Manager ( ManagerName);


create nonclustered index Instructor_Name_Index 
on Instructor_schema.Instructor ( InstructorName);


create nonclustered index Class_Name_Index 
on Student_schema.Class ( ClassName);


create nonclustered index Student_Name_Index 
on Student_schema.Student ( StudentName);


create nonclustered index Course_Name_Index 
on Instructor_schema.Course( CourseName);


create nonclustered index  Description_Index 
on Instructor_schema.Course(  Description);

---
create nonclustered index  QuestionText_Index 
on Instructor_schema.QuestionPool (QuestionText);
-----------------triggers-----------
--hashPassword
--create trigger hashPassword
--on Manager_Schema.Account 
--After Insert , UPDATE
--AS
--begin 
--update a set a.password= Convert(VARCHAR(100), HASHBYTES('SHA1',i.Password), 2)--converts the binary hash into a readable hexadecimal string for storage
--from Account a inner join inserted i
--on a.AccountID=i.AccountID
--END;
-------------------
go
----------------------
ALTER TABLE Manager_Schema.Account 
ALTER COLUMN Password VARCHAR(40) NOT NULL;
-------------------
go
----------------------
UPDATE Manager_schema.Account
SET Password = 'Student123' -----------here||||||||||||||||||||||||||||||||||
WHERE AccountID = 3;
--RestrictExamDuration
select * from Manager_schema.Account
-------------------
go
----------------------
create TRIGGER RestrictExamDuration
ON Instructor_Schema.Exam
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM INSERTED WHERE DATEDIFF(MINUTE, StartTime, EndTime) > 180)
    BEGIN
        RAISERROR ('Exams cannot exceed 4 hours in duration.', 16, 1);
        ROLLBACK;
    END
END;
-------------------
go
----------------------
INSERT INTO Instructor_Schema.Exam (Ty_Q, AllowanceOption, StartTime, EndTime, IntakeID, BranchID, TrackID, InstructorID,ClassID)
VALUES 
('exam', 'Open Book', '2024-12-03 10:00:00', '2024-12-03 11:00:00', 1, 1, 2, 1,5);
INSERT INTO Instructor_Schema.Exam (Ty_Q, AllowanceOption, StartTime, EndTime, IntakeID, BranchID, TrackID, InstructorID,ClassID)
VALUES 
('exam', 'Open Book', '2024-12-03 10:00:00', '2024-12-03 11:00:00', 1, 1, 2, 1,5);
 -------------------
go
----------------------
--ValidateStudentAnswer
CREATE TRIGGER ValidateStudentAnswer
ON Student_Schema.StudentExam
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE se
    SET se.IsCorrect = CASE 
                           WHEN se.StudentAnswer = qp.CorrectAnswer THEN 1
                           ELSE 0
                       END,
        se.DegreeEarned = CASE 
                              WHEN se.StudentAnswer = qp.CorrectAnswer THEN eq.Degree
                              ELSE 0
                          END
    FROM StudentExam se
    INNER JOIN 	Instructor_Schema.QuestionPool qp ON se.QuestionID = qp.QuestionID
    INNER JOIN Instructor_Schema.ExamQuestion eq ON se.ExamID = eq.ExamID AND se.QuestionID = eq.QuestionID
    INNER JOIN inserted i ON se.StudentID = i.StudentID AND se.ExamID = i.ExamID AND se.QuestionID = i.QuestionID;
END

-------------------
go
----------------------

 INSERT INTO Student_Schema.StudentExam (StudentID, ExamID, QuestionID, StudentAnswer)
VALUES 
(7, 31, 2,'True');
select * from Student_Schema.StudentExam 
INSERT INTO Student_Schema.StudentExam (StudentID, ExamID, QuestionID, StudentAnswer)
VALUES 
(26, 31, 3, 'False');
select * from Student_Schema.StudentExam
-------------------
go
----------------------

update Student_schema. StudentExam  set StudentAnswer='VARCHAR' where StudentID=3 and QuestionID=1;

 select * from StudentExam
 select * from Student
 -------------------
go
----------------------
 -------------max degree cant be less than 60---------------
create trigger CheckMaxDegree
on Instructor_Schema.Course
AFTER update , Insert 
AS
BEGIN
if Exists(Select 1 from inserted where maxdegree<60)
BEGIN
RaisError ('MaxDegree must be at least 60',16, 1);--16:This is a user-defined error indicating error is related to invalid user input or business logic.
ROLLBACK Transaction
END
END
 -------------------
go
----------------------

INSERT INTO Instructor_Schema.Course (CourseName, MaxDegree, Description)
VALUES 
('OOP',60, 'Advanced OPP');
 -------------------
go
----------------------
 ---------log examstudent submited----------
create trigger LogsStudentExam
ON Student_Schema.StudentExam
After Insert
AS
begin 
Insert into Instructor_Schema.ExamAuditLog (actiontype , logmessage,logdate)
select 'Student Exam' , Concat('Student_id ',studentid,' submitted ExamID ', ExamID, ' for QuestionID ', QuestionID),GetDate() from Inserted
END;
-------------------
go
----------------------
INSERT INTO Student_Schema.StudentExam (StudentID, ExamID, QuestionID, StudentAnswer)
VALUES 
(7, 31, 3,'Post');
-------------------
go
----------------------
select * from Instructor_Schema.ExamAuditLog;
-------------------
go
----------------------
--LOG accounts
Create TRIGGER LogAccountUpdates
on Manager_Schema.Account 
AFTER UPDATE 
AS
BEGIN
Insert into AuditLog (LogMessage, LogDate)
select Concat('AccountID',accountid,'Updated') , GetDate() from Inserted;
END;
-------------------

update  Manager_Schema.Account  set UserName='Student112' where AccountID=4;-- here 
-------------------
go
----------------------
------|||||||||||||||||||||||||||||||||||||||
create trigger hashPassword
on Manager_Schema.Account 
After Insert , UPDATE
AS
begin 
update a set a.password= Convert(VARCHAR(100), HASHBYTES('SHA1',i.Password), 2)--converts the binary hash into a readable hexadecimal string for storage
from Account a inner join inserted i
on a.AccountID=i.AccountID
Insert into AuditLog (LogMessage, LogDate)
select Concat('AccountID',accountid,'Updated') , GetDate() from Inserted;
END;
--
--Create TRIGGER LogAccountUpdates
--on Manager_Schema.Account 
--AFTER UPDATE 
--AS
--BEGIN
--Insert into AuditLog (LogMessage, LogDate)
--select Concat('AccountID',accountid,'Updated') , GetDate() from Inserted;
--END;

DISABLE TRIGGER Manager_Schema.hashPassword ON Manager_Schema.Account;
DISABLE TRIGGER Manager_Schema.LogAccountUpdates ON Manager_Schema.Account;
----------------|||||||||||||||||||||||||||||||||||||||||||||||||||||||||
CREATE TRIGGER hashPasswordAndAddLog
ON Manager_Schema.Account
AFTER INSERT, UPDATE
AS
BEGIN
    -- Update the password to its hashed form
    UPDATE a 
    SET a.password = CONVERT(VARCHAR(100), HASHBYTES('SHA1', i.Password), 2) -- Convert the binary hash to a readable hex string
    FROM Account a
    INNER JOIN INSERTED i
    ON a.AccountID = i.AccountID;

    -- Check if the operation was an INSERT or UPDATE
    IF NOT EXISTS (SELECT 1 FROM DELETED)
    BEGIN
        -- It's an INSERT operation
        INSERT INTO AuditLog (LogMessage, LogDate)
        SELECT CONCAT('AccountID ', AccountID, ' Inserted'), GETDATE()
        FROM INSERTED;
    END
    ELSE
    BEGIN
        -- It's an UPDATE operation
        INSERT INTO AuditLog (LogMessage, LogDate)
        SELECT CONCAT('AccountID ', AccountID, ' Updated'), GETDATE()
        FROM INSERTED;
    END
END;
GO






