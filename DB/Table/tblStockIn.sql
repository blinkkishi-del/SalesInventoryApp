CREATE TABLE [dbo].[tblStockIn]
(
 [StockInId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 [ReferenceNo] VARCHAR(20) NOT NULL,
 [ProductId] VARCHAR(20) NOT NULL,
 [SupplierId] VARCHAR(20) NOT NULL,
 [Quantity] INT NOT NULL CHECK ([Quantity] > 0),
 [StockInDate] DATETIME NOT NULL DEFAULT GETDATE(),
 [StockInBy] VARCHAR(50) NULL,
 FOREIGN KEY ([ProductId]) REFERENCES [dbo].[tblProduct]([ProductId]),
 FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[tblSupplier]([SupplierId])
);
GO
