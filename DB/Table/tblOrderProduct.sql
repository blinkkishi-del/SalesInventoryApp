CREATE TABLE [dbo].[tblOrderProduct]
(
    OrderId INT IDENTITY(100,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) NOT NULL CHECK (UnitPrice > 0),
    DiscountPercent DECIMAL(5,2) NOT NULL DEFAULT 0 CHECK (DiscountPercent BETWEEN 0 AND 100),
    TotalPrice AS (ROUND(Quantity * UnitPrice * (100 - DiscountPercent) / 100, 2)) PERSISTED,
    CashierUsername NVARCHAR(50) NULL
)
