CREATE TABLE [dbo].[Image] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [full]      NVARCHAR (1000) NULL,
    [thumb]     NVARCHAR (1000) NULL,
    [ProductId] INT             NOT NULL,
    CONSTRAINT [pk_Image] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_ImageProduct] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([id]) ON DELETE CASCADE
);

