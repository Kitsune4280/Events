﻿CREATE TABLE [dbo].[Roles] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Name]<>''),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

