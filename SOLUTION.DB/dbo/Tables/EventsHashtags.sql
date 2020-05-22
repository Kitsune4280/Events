CREATE TABLE [dbo].[EventsHashtags] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [EventId]   INT NOT NULL,
    [HashtagId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id]),
    FOREIGN KEY ([HashtagId]) REFERENCES [dbo].[HashTags] ([Id])
);

