CREATE TABLE [dbo].[Comments] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [MemberId] INT            NOT NULL,
    [EventId]  INT            NOT NULL,
    [PostedAt] DATETIME       NOT NULL,
    [Content]  NVARCHAR (500) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Content]<>''),
    FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id]),
    FOREIGN KEY ([MemberId]) REFERENCES [dbo].[Members] ([Id])
);

