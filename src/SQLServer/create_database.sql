CREATE DATABASE [BluePhones]
GO

USE [BluePhones]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Catalog](
	[Code] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ImageUrl] [varchar](100) NULL,
	[Description] [varchar](500) NULL,
	[Price] [smallmoney] NOT NULL,
	[Brand] [varchar](50) NOT NULL,
	[Colour] [varchar](50) NULL,
	[Width] [decimal](6, 2) NULL,
	[Height] [decimal](6, 2) NULL,
	[Thickness] [decimal](6, 2) NULL,
	[Weight] [decimal](6, 2) NULL,
	[Processor] [varchar](50) NULL,
	[Screen] [decimal](6, 2) NULL,
	[FrontCamera] [tinyint] NULL,
	[RearCamera] [tinyint] NULL,
	[Battery] [smallint] NULL,
	[InternalMemory] [smallint] NULL,
	[RamMemory] [smallint] NULL,
	[OperatingSystem] [varchar](50) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identity table (PK)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item price' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item brand' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Brand'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item colour' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Colour'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item width (in centimeters)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Width'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item height (in centimeters)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Height'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item thickness (in centimeters)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Thickness'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item weight (in grams)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Weight'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item processor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Processor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item screen size (in inches)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Screen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item front camera resolution (in megapixels)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'FrontCamera'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item rear camera resolution (in megapixels)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'RearCamera'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item battery (in mAh)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'Battery'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item internal memory (in gigabytes)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'InternalMemory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item RAM memory (in gigabytes)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'RamMemory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item operating system' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog', @level2type=N'COLUMN',@level2name=N'OperatingSystem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Catalog table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catalog'
GO

USE [BluePhones]
GO
SET IDENTITY_INSERT [dbo].[Catalog] ON 

INSERT [dbo].[Catalog] ([Code], [Name], [ImageUrl], [Description], [Price], [Brand], [Colour], [Width], [Height], [Thickness], [Weight], [Processor], [Screen], [FrontCamera], [RearCamera], [Battery], [InternalMemory], [RamMemory], [OperatingSystem]) VALUES (1, N'Honor 8', N'/images/catalog/honor-8.jpg', N'El Honor 8 Lite incorpora una pantalla de 5''2 pulgadas con una resolución de 1920x1080 pixeles.', 159.9900, N'Honor', N'Blanco', CAST(7.29 AS Decimal(6, 2)), CAST(14.72 AS Decimal(6, 2)), CAST(0.76 AS Decimal(6, 2)), CAST(147.00 AS Decimal(6, 2)), N'HiSilicon Kirin 655 8 núcleos', CAST(5.20 AS Decimal(6, 2)), 8, 12, 3000, 16, 3, N'Android Nougat')
INSERT [dbo].[Catalog] ([Code], [Name], [ImageUrl], [Description], [Price], [Brand], [Colour], [Width], [Height], [Thickness], [Weight], [Processor], [Screen], [FrontCamera], [RearCamera], [Battery], [InternalMemory], [RamMemory], [OperatingSystem]) VALUES (2, N'Samsung Galaxy S7', N'/images/catalog/samsung-galaxy-s7.jpg', N'El Samsung Galaxy S7 Negro ofrece diversidad de novedades.', 239.0000, N'Samsung', N'Negro', CAST(6.96 AS Decimal(6, 2)), CAST(14.24 AS Decimal(6, 2)), CAST(0.79 AS Decimal(6, 2)), CAST(152.00 AS Decimal(6, 2)), N'Samsung Exynos 8890 8 núcleos', CAST(5.10 AS Decimal(6, 2)), 5, 12, 3000, 32, 4, N'Android Nougat')
INSERT [dbo].[Catalog] ([Code], [Name], [ImageUrl], [Description], [Price], [Brand], [Colour], [Width], [Height], [Thickness], [Weight], [Processor], [Screen], [FrontCamera], [RearCamera], [Battery], [InternalMemory], [RamMemory], [OperatingSystem]) VALUES (3, N'Xiaomi Redmi Note 6 Pro', N'/images/catalog/xiaomi-redmi-note-6-pro.jpg', N'El Xiaomi Redmi Note 6 Pro tiene una pantalla 2.5D con tecnología IPS de 6,26 pulgadas con resolución FullHD+ y relación de aspecto 19:9.', 215.0000, N'Xiaomi', N'Azul', CAST(7.64 AS Decimal(6, 2)), CAST(15.79 AS Decimal(6, 2)), CAST(0.82 AS Decimal(6, 2)), CAST(182.00 AS Decimal(6, 2)), N'Qualcomm Snapdragon 636 8 núcleos', CAST(6.26 AS Decimal(6, 2)), 12, 20, 4000, 64, 4, N'Android Oreo')
SET IDENTITY_INSERT [dbo].[Catalog] OFF