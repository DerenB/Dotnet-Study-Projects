CREATE PROCEDURE [dbo].[spTransactions_ReadAll]

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
    dbo.Transactions;
END
