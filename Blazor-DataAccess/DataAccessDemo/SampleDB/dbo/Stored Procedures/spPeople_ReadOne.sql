CREATE PROCEDURE [dbo].[spPeople_ReadOne]
	@Id int
AS
BEGIN
	SELECT [Id], [FirstName], [LastName], [DateOfBirth]
	FROM dbo.People
	WHERE Id = @Id;
END