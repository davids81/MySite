CREATE TABLE [dbo].[PostDetails] (
    [PostDetailId] INT  IDENTITY (1, 1) NOT NULL,
    [PostId]       INT  NOT NULL,
    [Sequence]     INT  NOT NULL,
    [PostText]     TEXT NULL,
    PRIMARY KEY CLUSTERED ([PostDetailId] ASC),
    CONSTRAINT [PostId_Fk] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([PostId])
);

