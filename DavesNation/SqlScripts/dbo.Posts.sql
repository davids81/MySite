CREATE TABLE [dbo].[Posts] (
    [PostId]    INT            IDENTITY (1, 1) NOT NULL,
    [PostTitle] NVARCHAR (100) NOT NULL,
    [PostDate]  DATETIME       NOT NULL,
    [Deleted]   INT            NOT NULL,
    [OwnerId]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [FK_Post_User_Id] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Users] ([UserId])
);

