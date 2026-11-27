CREATE PROCEDURE [dbo].[AddProduct]
	@ProductName VARCHAR(100),
	@Model VARCHAR(50),
	@Brand VARCHAR(50),
	@Category VARCHAR(50),
	@Supplier VARCHAR(100),
	@Quantity INT,
	@Amount DECIMAL(15,2)
AS
	BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRANSACTION;

	DECLARE @ProductId VARCHAR(20) = (
		SELECT ProductId FROM [dbo].[tblProduct]
		WHERE ProductName = @ProductName
		  AND ISNULL(Model, '') = ISNULL(@Model, '')
		  AND IsActive = 1
	);

	IF @ProductId IS NOT NULL
	BEGIN
		UPDATE [dbo].[tblProduct]
		SET Quantity = Quantity + @Quantity,
			Brand = @Brand,
			Supplier = @Supplier,
			Amount = @Amount
		WHERE ProductId = @ProductId;
	END
	ELSE
	BEGIN
		DECLARE @Next INT = 1 + ISNULL((
			SELECT MAX(TRY_CAST(SUBSTRING(ProductId, 5, 16) AS INT))
			FROM [dbo].[tblProduct] WITH (UPDLOCK, HOLDLOCK)
			WHERE ProductId LIKE 'APP-%'
		), 0);
		SET @ProductId = 'APP-' + FORMAT(@Next, '000');

		INSERT INTO [dbo].[tblProduct] (ProductId, ProductName, Model, Brand, Category, Supplier, Quantity, Amount)
		VALUES (@ProductId, @ProductName, @Model, @Brand, @Category, @Supplier, @Quantity, @Amount);
	END

	COMMIT TRANSACTION;

	SELECT @ProductId AS ProductId;
	END;
	GO
