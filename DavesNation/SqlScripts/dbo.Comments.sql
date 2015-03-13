CREATE TABLE [dbo].[Comments] (
    [CommentId]   INT      IDENTITY (1, 1) NOT NULL,
    [Comment]     TEXT     NOT NULL,
    [CommenterId] INT      NOT NULL,
    [CommentDate] DATETIME NOT NULL,
    [Deleted]     INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([CommentId] ASC),
    CONSTRAINT [FK_Comment_UserId] FOREIGN KEY ([CommenterId]) REFERENCES [dbo].[Users] ([UserId])
);

