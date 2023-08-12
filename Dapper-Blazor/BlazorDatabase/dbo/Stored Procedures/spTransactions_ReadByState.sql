CREATE PROCEDURE [dbo].[spTransactions_ReadByState]
  @state VARCHAR(2)
AS
BEGIN
  SELECT
    [Id], 
    [Location], 
    [State], 
    [TransactionDateTime], 
    [TransactionAmount], 
    [ActiveLocation]
  FROM 
    dbo.Transactions
  WHERE
    [State] = @state;
END
