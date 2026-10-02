CREATE PROCEDURE [dbo].[ss_SearchProducts]
    @Keyword NVARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        ProductId,
        ProductName,
        Category,
        Supplier,
        Quantity,
        Amount
    FROM tblProduct
    WHERE ProductName LIKE '%' + ISNULL(@Keyword, '') + '%'
       OR Category    LIKE '%' + ISNULL(@Keyword, '') + '%'
       OR Supplier    LIKE '%' + ISNULL(@Keyword, '') + '%'
    ORDER BY ProductName ASC;
END;
GO