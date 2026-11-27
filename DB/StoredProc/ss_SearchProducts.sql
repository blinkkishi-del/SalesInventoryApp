CREATE PROCEDURE [dbo].[ss_SearchProducts]
    @Keyword NVARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT
        ProductId,
        ProductName,
        Model,
        Brand,
        Category,
        Supplier,
        Quantity,
        Amount
    FROM tblProduct
    WHERE IsActive = 1
      AND (
          ProductName LIKE '%' + ISNULL(@Keyword, '') + '%'
          OR Model       LIKE '%' + ISNULL(@Keyword, '') + '%'
          OR Brand       LIKE '%' + ISNULL(@Keyword, '') + '%'
          OR Category    LIKE '%' + ISNULL(@Keyword, '') + '%'
          OR Supplier    LIKE '%' + ISNULL(@Keyword, '') + '%'
      )
    ORDER BY ProductName ASC;
END;
GO