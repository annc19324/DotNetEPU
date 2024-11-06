CREATE TABLE [dbo].[Products] (
    [ProductID]   INT             IDENTITY (1, 1) NOT NULL,
    [ProductName] NVARCHAR (100)  NOT NULL,
    [Description] NVARCHAR (255)  NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Quantity]    INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC)
);

