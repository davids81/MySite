CREATE TABLE [dbo].[Users] (
    [UserId]      INT            IDENTITY (1, 1) NOT NULL,
    [UserName]    NVARCHAR (50)  NOT NULL,
    [UserEmail]   NVARCHAR (150) NOT NULL,
    [CreatedDate] DATETIME       NOT NULL,
    [Active]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

