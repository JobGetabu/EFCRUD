CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [AdminNo] INT NOT NULL, 
    [StudentName] NVARCHAR(50) NOT NULL, 
    [Class] INT NOT NULL, 
    [Form] NVARCHAR(50) NULL, 
    [Gender] BIT NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Name',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'StudentName'