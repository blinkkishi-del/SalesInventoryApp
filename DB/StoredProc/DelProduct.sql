CREATE PROCEDURE [dbo].[DelProduct]
    @ProductId VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[tblProduct]
    SET IsActive = 0
    WHERE ProductId = @ProductId;
END;
GO