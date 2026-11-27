CREATE TABLE [dbo].[tblSales] (
    [SalesId] INT IDENTITY(1,1) PRIMARY KEY,
    [SalesDate] DATE NOT NULL,
    [TotalAmount] DECIMAL(15,2) NOT NULL,
    [CashierUsername] VARCHAR(50) NULL,
    [ReceiptNo] VARCHAR(20) NULL,
    [OrderDiscountPercent] DECIMAL(5,2) NOT NULL CONSTRAINT DF_tblSales_OrderDiscountPercent DEFAULT 0,
    [OrderDiscountAmount] DECIMAL(15,2) NOT NULL CONSTRAINT DF_tblSales_OrderDiscountAmount DEFAULT 0
)
