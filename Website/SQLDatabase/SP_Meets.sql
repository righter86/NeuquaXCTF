
CREATE PROCEDURE [dbo].[SP_Meets]
    @Action VARCHAR (50) NOT NULL,
    @MeetId INT NULL,
	@Date DATE NULL,
	@Name VARCHAR(50) NULL,
	@CourseId INT = NULL,
    ----------
    @DateStart DATE = NULL,
    @DateEnd Date = NULL
AS 
BEGIN 
SET NOCOUNT ON 
     IF @Action = 'ADD'
         INSERT INTO [dbo].[Meets]
               ([Date]
               ,[Name]
               ,[CourseId])
         VALUES
               (@Date
               ,@Name
               ,@CourseId)
    ELSE IF @Action = 'UPDATE'
         UPDATE [dbo].[Meets]
         SET Date = @Date, Name = @Name, CourseId = @CourseId
         WHERE @MeetId = MeetId
    ELSE IF @Action = 'DELETE'
         DELETE FROM [dbo].[Meets]
         WHERE @MeetId = MeetId
    ELSE IF @Action = 'SELECT'
         SELECT * FROM [dbo].[Meets]
         WHERE  (@MeetId IS NULL OR MeetId = @MeetId) AND -- meet match
                (@Date IS NULL OR date = @Date) AND -- date match
                (@DateStart IS NULL OR @DateEnd IS NULL OR @DateStart <= date AND @DateEnd >= date) AND -- date match
                (@Name IS NULL OR name = @Name) AND -- name match
                (@CourseId IS NULL OR CourseId = @CourseId) -- meets that use this course
END 

GO