CREATE TABLE	[dbo].[Contact] (
    [Id]        UNIQUEIDENTIFIER	NOT NULL,
    [Name]      VARCHAR (100)		NOT NULL,
	[Email]      VARCHAR (100)		NOT NULL
    PRIMARY KEY CLUSTERED ([Id] ASC))