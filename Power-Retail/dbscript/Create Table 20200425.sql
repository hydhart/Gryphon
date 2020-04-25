USE [Power Retail 0.1]
GO

/****** Object:  Table [dbo].[ApplicationMenu]    Script Date: 4/25/2020 4:13:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ApplicationMenu](
	[MenuID] [nvarchar](20) NULL,
	[Caption] [nvarchar](50) NULL,
	[Indentation] [int] NULL,
	[ParentID] [nvarchar](20) NULL,
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Item]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Item](
	[No] [nvarchar](20) NULL,
	[Description] [nvarchar](100) NULL,
	[SearchDescription] [nvarchar](100) NULL,
	[ItemCategoryID] [nvarchar](10) NULL,
	[UnitPrice] [decimal](18, 0) NULL,
	[Type] [int] NULL,
	[VATProductGroupID] [nvarchar](10) NULL,
	[Blocked] [bit] NULL,
	[DefaultSalesUoMID] [nvarchar](10) NULL,
	[BaseUoMID] [nvarchar](10) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ItemCategory]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ItemCategory](
	[ID] [nvarchar](10) NULL,
	[ParentID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ItemUoM]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ItemUoM](
	[ItemNo] [nvarchar](20) NULL,
	[UnitOfMeasureID] [nvarchar](10) NULL,
	[QuantityPer] [decimal](18, 0) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Terminal]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Terminal](
	[ID] [nvarchar](10) NULL,
	[StoreID] [nvarchar](10) NULL,
	[Name] [nvarchar](50) NULL,
	[LastReceiptNo] [nvarchar](10) NULL,
	[TerminalType] [int] NULL,
	[AutoLogoffAfter] [int] NULL,
	[MenuProfileID] [nvarchar](10) NULL,
	[InterfaceProfileID] [nvarchar](10) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[PriceGroup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PriceGroup](
	[ID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AppSetup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AppSetup](
	[ID] [uniqueidentifier] NULL,
	[LocalStoreID] [nvarchar](10) NULL,
	[Logo] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[SalesPrice]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SalesPrice](
	[ItemNo] [nvarchar](20) NULL,
	[PriceGroupID] [nvarchar](10) NULL,
	[StartingDate] [date] NULL,
	[UnitPrice] [decimal](18, 0) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Staff]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Staff](
	[ID] [nvarchar](10) NULL,
	[Name] [nvarchar](100) NULL,
	[DisplayName] [nvarchar](20) NULL,
	[DefaultStoreID] [nvarchar](10) NULL,
	[DefaultPOSTerminalID] [nvarchar](10) NULL,
	[Password] [nvarchar](100) NULL,
	[GroupID] [nvarchar](10) NULL,
	[ActiveUntil] [date] NULL,
	[Blocked] [bit] NULL,
	[ChangePassword] [bit] NULL,
	[LastLoginDate] [date] NULL,
	[LastLoginTime] [time](7) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[StaffGroup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StaffGroup](
	[ID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL,
	[IsManager] [bit] NULL,
	[AllowCreateTransaction] [bit] NULL,
	[AllowChangePrice] [bit] NULL,
	[AllowChangeDiscount] [bit] NULL,
	[AllowVoidLine] [bit] NULL,
	[AllowVoidTransaction] [bit] NULL,
	[AllowSuspendTransaction] [bit] NULL,
	[AllowRefundTransaction] [bit] NULL,
	[AllowQtyNegative] [bit] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Store]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Store](
	[ID] [nvarchar](10) NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](30) NULL,
	[PostCode] [nvarchar](5) NULL,
	[PhoneNo] [nvarchar](20) NULL,
	[FaxNo] [nvarchar](20) NULL,
	[StoreGroupdID] [nvarchar](10) NULL,
	[VATBusGroupID] [nvarchar](10) NULL,
	[MenuProfileID] [nvarchar](10) NULL,
	[InterfaceProfileID] [nvarchar](10) NULL,
	[StatementMethod] [int] NULL,
	[StoreType] [int] NULL,
	[StoreClosingMethod] [int] NULL,
	[LastStatementNo] [int] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[StoreGroup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StoreGroup](
	[ID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[StorePriceGroup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StorePriceGroup](
	[StoreID] [nvarchar](10) NULL,
	[PriceGroupID] [nvarchar](10) NULL,
	[Priority] [int] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[StoreTender]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StoreTender](
	[StoreID] [nvarchar](10) NULL,
	[TenderID] [nvarchar](10) NULL,
	[ChangeTenderID] [nvarchar](10) NULL,
	[MinAmountAllowed] [decimal](18, 0) NULL,
	[MaxAmountAllowed] [decimal](18, 0) NULL,
	[OverTenderAllowed] [bit] NULL,
	[OverTenderMaxAmount] [decimal](18, 0) NULL,
	[UnderTenderAllowed] [bit] NULL,
	[InputMinusAllowed] [bit] NULL,
	[OpenDrawer] [bit] NULL,
	[CountingRequired] [bit] NULL,
	[CountByDenomination] [bit] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[TenderDenomination]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TenderDenomination](
	[TenderID] [nvarchar](10) NULL,
	[Denomination] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL,
	[Type] [int] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[TenderType]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TenderType](
	[ID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL,
	[IsCard] [bit] NULL,
	[IsCoupon] [bit] NULL,
	[IsFloat/Remove] [bit] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[UnitOfMeasure]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UnitOfMeasure](
	[ID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[User]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[UserID] [nvarchar](20) NULL,
	[Name] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[VATBussinessGroup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VATBussinessGroup](
	[ID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[VATProductGroup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VATProductGroup](
	[ID] [nvarchar](10) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[VATSetup]    Script Date: 4/25/2020 4:13:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VATSetup](
	[VATBussinessGroupID] [nvarchar](10) NULL,
	[VATProductGroupID] [nvarchar](10) NULL,
	[VATCode] [nvarchar](10) NULL,
	[VATPercentage] [int] NULL
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0-Inventory,1-NonInventory' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Item', @level2type=N'COLUMN',@level2name=N'Type'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Item'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0-POS Terminal,1-MobilePOS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Terminal', @level2type=N'COLUMN',@level2name=N'TerminalType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'in minutes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Terminal', @level2type=N'COLUMN',@level2name=N'AutoLogoffAfter'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Terminal'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0-Staff,1-Terminal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StatementMethod'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0-Permanent,1-Event' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0-Date&Time,1-Shift' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreClosingMethod'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0-Coin,1-Note' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TenderDenomination', @level2type=N'COLUMN',@level2name=N'Type'
GO


