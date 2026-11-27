CREATE TABLE [dbo].[tblStockAdjustment]
(
 [AdjustmentId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 [ReferenceNo] VARCHAR(20) NOT NULL,
 [ProductId] VARCHAR(20) NOT NULL,
 [Action] VARCHAR(10) NOT NULL CHECK ([Action] IN ('Add', 'Remove')),
 [Quantity] INT NOT NULL CHECK ([Quantity] > 0),
 [Reason] VARCHAR(50) NOT NULL,
 [Remarks] VARCHAR(200) NULL,
 [AdjustmentDate] DATETIME NOT NULL DEFAULT GETDATE(),
 [AdjustedBy] VARCHAR(50) NULL,
 FOREIGN KEY ([ProductId]) REFERENCES [dbo].[tblProduct]([ProductId])
);
GO
