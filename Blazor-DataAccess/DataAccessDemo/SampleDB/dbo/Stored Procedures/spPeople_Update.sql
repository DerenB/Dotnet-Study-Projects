CREATE PROCEDURE [dbo].[spPeople_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@DateOfBirth datetime2(7)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.People
	SET 
		FirstName = @FirstName,
		LastName = @LastName,
		DateOfBirth = @DateOfBirth
	WHERE
		Id = @Id;
END
