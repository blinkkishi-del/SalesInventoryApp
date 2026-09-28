CREATE TABLE [dbo].[tblProductDetails]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] VARCHAR(100) NOT NULL,
    [Supplier] VARCHAR(100) NOT NULL,
    [ProductId] VARCHAR(20) NOT NULL,
    [Category] VARCHAR(50) NOT NULL,
   
    FOREIGN KEY ([ProductId]) REFERENCES [dbo].[tblProduct]([ProductId])
);
GO