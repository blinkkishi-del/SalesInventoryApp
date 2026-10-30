CREATE TABLE [dbo].[tblSales] (
    [SalesId] INT IDENTITY(1,1) PRIMARY KEY,
    [SalesDate] DATE NOT NULL,
    [TotalAmount] DECIMAL(15,2) NOT NULL
)