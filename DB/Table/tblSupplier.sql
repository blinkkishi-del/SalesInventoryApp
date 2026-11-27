CREATE TABLE [dbo].[tblSupplier]
(
 [SupplierId] VARCHAR(20) NOT NULL PRIMARY KEY,
 [SupplierName] VARCHAR(100) NOT NULL,
 [Address] VARCHAR(200) NULL,
 [ContactPerson] VARCHAR(100) NULL,
 [PhoneNumber] VARCHAR(20) NULL,
 [EmailAddress] VARCHAR(100) NULL,
 [IsActive] BIT NOT NULL DEFAULT 1
);
GO
