CREATE TABLE [dbo].[Members] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Username]  NVARCHAR (100) NOT NULL,
    [Password]  NVARCHAR (100) NOT NULL,
    [FirstName] NVARCHAR (100) NOT NULL,
    [LastName]  NVARCHAR (100) NOT NULL,
    [Suspended] BIT            CONSTRAINT [DF__Members__Suspend__6E01572D] DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([FirstName]<>''),
    CHECK ([LastName]<>''),
    CHECK ([Password]<>''),
    CHECK ([Username]<>''),
    UNIQUE NONCLUSTERED ([Username] ASC)
);







