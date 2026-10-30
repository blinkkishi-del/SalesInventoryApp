CREATE PROCEDURE [dbo].[DelProduct]
	@ProductId VARCHAR(20)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [tblProduct] WHERE ProductId = @ProductId;
END;
GO
