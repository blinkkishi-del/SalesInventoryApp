CREATE PROCEDURE [dbo].[UpProduct]
	@ProductId VARCHAR(20),
	@ProductName VARCHAR(100) = NULL,
	@Category VARCHAR(50) = NULL,
	@Supplier VARCHAR(100) = NULL,
	@Quantity INT = NULL,
	@Amount DECIMAL(15, 2) = NULL
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tblProduct]
	SET ProductName = ISNULL(@ProductName, ProductName),
		Category = ISNULL(@Category, Category),
		Supplier = ISNULL(@Supplier, Supplier),
		Quantity = ISNULL(@Quantity, Quantity),
		Amount = ISNULL(@Amount, Amount)
	WHERE ProductId = @ProductId;

END;
GO