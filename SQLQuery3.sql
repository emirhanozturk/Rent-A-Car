CREATE TABLE [dbo].[Rental] (
    [Id]  INT   IDENTITY (1, 1) NOT NULL,
    [CarId] INT  NOT NULL,
    [CustomerId]  INT NOT NULL,
    [RentDate] DateTime NOT NULL,
    [ReturnDate] DateTime NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);