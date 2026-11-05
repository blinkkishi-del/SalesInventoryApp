CREATE PROCEDURE [dbo].[GetSalesByDate]
    @SalesDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.ProductName,
        sd.Quantity,
        sd.TotalPrice
    FROM tblSales s
    INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
    INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
    WHERE s.SalesDate = @SalesDate;

    SELECT SUM(sd.TotalPrice) AS TotalSales
    FROM tblSales s
    INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
    WHERE s.SalesDate = @SalesDate;
END;
GO
