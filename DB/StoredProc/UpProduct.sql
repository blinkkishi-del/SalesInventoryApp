CREATE PROCEDURE [dbo].[UpProduct]
	@ProductId VARCHAR(20),
	@ProductName VARCHAR(100) = NULL,
	@Model VARCHAR(50) = NULL,
	@Brand VARCHAR(50) = NULL,
	@Category VARCHAR(50) = NULL,
	@Supplier VARCHAR(100) = NULL,
	@Quantity INT = NULL,
	@Amount DECIMAL(15, 2) = NULL
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[tblProduct]
	SET ProductName = ISNULL(@ProductName, ProductName),
		Model = ISNULL(@Model, Model),
		Brand = ISNULL(@Brand, Brand),
		Category = ISNULL(@Category, Category),
		Supplier = ISNULL(@Supplier, Supplier),
		Quantity = ISNULL(@Quantity, Quantity),
		Amount = ISNULL(@Amount, Amount)
	WHERE ProductId = @ProductId
	  AND IsActive = 1;
END;
GO
