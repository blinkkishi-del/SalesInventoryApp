CREATE PROCEDURE [dbo].[GetTop50Products]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT TOP 50 ProductId, ProductName, Category, Supplier, Quantity, Amount
    FROM [dbo].[tblProduct]
    WHERE IsActive = 1
    ORDER BY ProductId DESC;
END;
GO