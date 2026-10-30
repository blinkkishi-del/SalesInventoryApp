CREATE TABLE [dbo].[tblOrderProduct]
(
    OrderId INT IDENTITY(100,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) NOT NULL CHECK (UnitPrice > 0),
    TotalPrice AS (Quantity * UnitPrice) PERSISTED
)
