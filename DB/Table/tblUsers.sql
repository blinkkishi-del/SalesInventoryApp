CREATE TABLE [dbo].[tblUsers]
(
	[Username] nvarchar(50) null,
	[Password] nvarchar(200) null,
    [Role] nvarchar(50)  null,
    [FullName] nvarchar(100) null,
    [IsActive] bit not null CONSTRAINT DF_tblUsers_IsActive DEFAULT 1
);
Go

CREATE UNIQUE INDEX UX_tblUsers_Username ON [dbo].[tblUsers](Username) WHERE Username IS NOT NULL;
Go
