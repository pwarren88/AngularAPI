CREATE TABLE [dbo].[Product] (
    [id]          INT             IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (1000) NOT NULL,
    [price]       MONEY           NOT NULL,
    [description] NTEXT           NOT NULL,
    [soldOut]     BIT             NOT NULL,
    [canPurchase] BIT             NOT NULL,
    [salePrice] MONEY NULL, 
    CONSTRAINT [pk_Product] PRIMARY KEY CLUSTERED ([id] ASC)
);

