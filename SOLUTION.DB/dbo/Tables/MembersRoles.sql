CREATE TABLE [dbo].[MembersRoles] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [MemberId] INT NOT NULL,
    [RoleId]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__MembersRo__Membe__29221CFB] FOREIGN KEY ([MemberId]) REFERENCES [dbo].[Members] ([Id]),
    CONSTRAINT [FK__MembersRo__RoleI__2A164134] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id])
);



