CREATE TABLE [dbo].[Results]
(
	[ResultId] INT NOT NULL PRIMARY KEY,
	[MeetId] INT NOT NULL,
	[CourseId] INT NOT NULL,
	[Level] VARCHAR (50) NOT NULL,
	[Class] VARCHAR (50) NULL,
	[Name] VARCHAR (250) NOT NULL,
	[Place] INT NULL,
	[Time] TIME NULL
)
