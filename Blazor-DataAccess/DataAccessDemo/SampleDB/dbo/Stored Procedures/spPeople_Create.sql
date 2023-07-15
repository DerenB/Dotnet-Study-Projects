CREATE PROCEDURE [dbo].[spPeople_Create]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@DateOfBirth datetime2(7)
AS

BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.People(FirstName, LastName, DateOfBirth)
	VALUES (@FirstName, @LastName, @DateOfBirth);
END
