ALTER TABLE [CHITIETHOADON] DROP CONSTRAINT [FK_CHITIETHOADON_NHANVIEN_EmployeeId];

GO

ALTER TABLE [CHITIETHOADON] DROP CONSTRAINT [PK_CHITIETHOADON];

GO

DROP INDEX [IX_CHITIETHOADON_EmployeeId] ON [CHITIETHOADON];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[CHITIETHOADON]') AND [c].[name] = N'EmployeeId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [CHITIETHOADON] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [CHITIETHOADON] DROP COLUMN [EmployeeId];

GO

ALTER TABLE [CHITIETHOADON] ADD [ProductID] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [CHITIETHOADON] ADD [Total] money NOT NULL DEFAULT 0.0;

GO

ALTER TABLE [CHITIETHOADON] ADD CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY ([SaleId], [ProductID]);

GO

CREATE INDEX [IX_CHITIETHOADON_ProductID] ON [CHITIETHOADON] ([ProductID]);

GO

ALTER TABLE [CHITIETHOADON] ADD CONSTRAINT [FK_CHITIETHOADON_SANPHAM_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [SANPHAM] ([ProductID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210609082016_WorkShop_V11', N'3.1.14');

GO

CREATE TABLE [KHACHANG] (
    [CustomerID] int NOT NULL IDENTITY,
    [TENKHACHHANG] ntext NOT NULL,
    CONSTRAINT [PK_KHACHANG] PRIMARY KEY ([CustomerID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210611034435_WorkShop_V12', N'3.1.14');

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SANPHAM]') AND [c].[name] = N'ProductName');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [SANPHAM] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [SANPHAM] ALTER COLUMN [ProductName] nvarchar(max) NULL;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SANPHAM]') AND [c].[name] = N'Price');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [SANPHAM] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [SANPHAM] ALTER COLUMN [Price] decimal(18,2) NOT NULL;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SANPHAM]') AND [c].[name] = N'Image');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [SANPHAM] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [SANPHAM] ALTER COLUMN [Image] varbinary(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210611043711_WorkShopV13', N'3.1.14');

GO

