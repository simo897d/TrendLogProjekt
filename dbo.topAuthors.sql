CREATE TABLE [dbo].[topAuthors] (
    [AuthorId]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Occupation]    NVARCHAR (MAX) NULL,
    [Location]      NVARCHAR (MAX) NULL,
    [Status]        NVARCHAR (MAX) NULL,
    [Money]         INT            NOT NULL,
    [ImageLocation] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_topAuthors] PRIMARY KEY CLUSTERED ([AuthorId] ASC)
);

