CREATE TABLE [dbo].[Events] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Place]       NVARCHAR (100) NOT NULL,
    [CategoryId]  INT            NOT NULL,
    [StartDate]   DATETIME       NOT NULL,
    [EndDate]     DATETIME       NOT NULL,
    [Description] NVARCHAR (500) NOT NULL,
    [ImageLink]   NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Description]<>''),
    CHECK ([Name]<>''),
    CHECK ([Place]<>''),
    CHECK (CONVERT([date],[StartDate])>=CONVERT([date],getdate())),
    CONSTRAINT [Date_Check] CHECK ([EndDate]>=[StartDate]),
    FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);



