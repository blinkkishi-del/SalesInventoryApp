CREATE PROCEDURE [dbo].[AddProduct]
	@ProductName VARCHAR(100),
	@Category VARCHAR(50),
	@Supplier VARCHAR(100),
	@Quantity INT,
	@Amount DECIMAL(15,2)
AS
	BEGIN
	SET NOCOUNT ON;
	DECLARE @ProductId VArchar(6) = LEFT (NEWID(), 6);

	INSERT INTO [dbo].[tblProduct] (ProductId, ProductName, Category, Supplier, Quantity, Amount)
	VALUES (@ProductId, @ProductName, @Category, @Supplier, @Quantity, @Amount);
	
	END;
	GO
