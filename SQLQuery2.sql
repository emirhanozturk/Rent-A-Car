CREATE TABLE [dbo].[Users] (
    [Id]  INT  IDENTITY (1, 1) NOT NULL,
    [FirstName] varchar(50) NULL,
    [LastName] varchar(50) NULL,
    [Email] varchar(50) NULL,
    [Password] varchar(50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Customers] (
    [UserId]  INT  IDENTITY (1, 1) NOT NULL,
    [CompanyName] varchar(50) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);