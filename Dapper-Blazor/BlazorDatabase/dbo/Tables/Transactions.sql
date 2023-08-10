CREATE TABLE [dbo].[Transactions]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Location] VARCHAR(100) NOT NULL,
  [State] VARCHAR(2) NOT NULL,
  [TransactionDateTime] DATETIME2 NOT NULL,
  [TransactionAmount] MONEY NOT NULL,
  [ActiveLocation] BIT NOT NULL
)
