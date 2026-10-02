CREATE TABLE [dbo].[tblProduct]
(
 [ProductId] VARCHAR(20) NOT NULL PRIMARY KEY,
 [ProductName] VARCHAR(100) NULL,
 [Category] VARCHAR(30) NULL,
 [Supplier] VARCHAR(50) NULL,
 [Quantity] INT NULL,
 [Amount] DECIMAL(15,2) NULL
);
GO
