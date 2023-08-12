CREATE PROCEDURE [dbo].[spTransactions_BetweenDates]
  @startDate DATE,
  @endDate DATE
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
    TransactionDateTime >= @startDate
    AND TransactionDateTime < @endDate;
END
