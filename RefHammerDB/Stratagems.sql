CREATE TABLE [dbo].[Stratagems]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [faction_id] NCHAR(10) NULL, 
    [name] NVARCHAR(50) NULL, 
    [type] NVARCHAR(10), 
    [cp_cost] INT NULL, 
    [legend] NVARCHAR(MAX) NULL, 
    [source_id] NVARCHAR(MAX) NULL, 
    [subfaction_id] NCHAR(10) NULL, 
    [description] NVARCHAR(MAX) NULL
)
