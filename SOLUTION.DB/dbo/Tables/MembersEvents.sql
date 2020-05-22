CREATE TABLE [dbo].[MembersEvents] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [MemberId] INT NOT NULL,
    [EventId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id]),
    FOREIGN KEY ([MemberId]) REFERENCES [dbo].[Members] ([Id])
);

