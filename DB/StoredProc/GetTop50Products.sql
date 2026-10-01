CREATE PROCEDURE [dbo].[GetTop50Products]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 50 ProductId, ProductName, Category, Supplier, Quantity, Amount
    FROM [dbo].[tblProduct]
    ORDER BY ProductId DESC;
END;
GO