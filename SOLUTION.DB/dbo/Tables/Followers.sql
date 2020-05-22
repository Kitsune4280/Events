CREATE TABLE [dbo].[Followers] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [MemberId]         INT NOT NULL,
    [FollowedMemberId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([FollowedMemberId]) REFERENCES [dbo].[Members] ([Id]),
    FOREIGN KEY ([MemberId]) REFERENCES [dbo].[Members] ([Id])
);



