CREATE TABLE [dbo].[Review] (
    [id]        INT   IDENTITY (1, 1) NOT NULL,
    [stars]     INT   NOT NULL,
    [author]    NTEXT NOT NULL,
    [body]      NTEXT NOT NULL,
    [productid] INT   NOT NULL,
    CONSTRAINT [pk_Review] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [fk_ReviewProduct] FOREIGN KEY ([productid]) REFERENCES [dbo].[Product] ([id]) ON DELETE CASCADE
);

