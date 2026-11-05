CREATE TABLE [dbo].[tblSalesDetail] (
    [SalesDetailId] INT IDENTITY(1,1) PRIMARY KEY,
    [SalesId] INT NOT NULL,
    [ProductId] VARCHAR(20) NOT NULL,
    [Quantity] INT NOT NULL,
    [TotalPrice] DECIMAL(15,2) NOT NULL,
    FOREIGN KEY ([SalesId]) REFERENCES [tblSales]([SalesId]),
    FOREIGN KEY ([ProductId]) REFERENCES [tblProduct]([ProductId])
);