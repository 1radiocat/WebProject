CREATE TABLE [dbo].[EnumExecutorTypes]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Type] NVARCHAR(500) NOT NULL, 
    [Description] NVARCHAR(500) NULL
)
