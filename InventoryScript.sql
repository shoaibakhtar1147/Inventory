USE [master]
GO
/****** Object:  Database [CashCarry]    Script Date: 9/3/2020 12:52:57 PM ******/
CREATE DATABASE [CashCarry]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CashCarry', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CashCarry.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CashCarry_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CashCarry_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CashCarry] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CashCarry].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CashCarry] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CashCarry] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CashCarry] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CashCarry] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CashCarry] SET ARITHABORT OFF 
GO
ALTER DATABASE [CashCarry] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CashCarry] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CashCarry] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CashCarry] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CashCarry] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CashCarry] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CashCarry] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CashCarry] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CashCarry] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CashCarry] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CashCarry] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CashCarry] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CashCarry] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CashCarry] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CashCarry] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CashCarry] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CashCarry] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CashCarry] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CashCarry] SET  MULTI_USER 
GO
ALTER DATABASE [CashCarry] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CashCarry] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CashCarry] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CashCarry] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CashCarry] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CashCarry]
GO
/****** Object:  Table [dbo].[tbl_Category]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Company]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Company](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](100) NULL,
	[Email] [varchar](30) NULL,
	[Contact] [varchar](20) NULL,
	[Address] [varchar](200) NULL,
	[DuePayment] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[CusTypeID] [int] NULL,
	[Address] [varchar](100) NULL,
	[Contact] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[ZoneID] [int] NULL,
	[DuePayment] [decimal](18, 2) NULL,
	[SubRouteId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_CustomerTypes]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_CustomerTypes](
	[CusTypeID] [int] IDENTITY(1,1) NOT NULL,
	[CusType] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CusTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_employee]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Fname] [varchar](30) NULL,
	[Username] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
	[Qualifiction] [varchar](10) NULL,
	[DOB] [varchar](10) NULL,
	[Cnic] [varchar](20) NULL,
	[Contact] [varchar](20) NULL,
	[Designation] [varchar](15) NULL,
	[Gender] [bit] NULL,
	[Address] [varchar](100) NULL,
	[Salary] [decimal](18, 2) NULL,
	[AsignDate] [datetime] NULL,
	[LoginTypeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Employee_Salary]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Employee_Salary](
	[SalaryID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[Salary] [decimal](18, 2) NULL,
	[Status] [bit] NULL,
	[ResginDate] [datetime] NULL,
	[SalaryDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalaryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Expense]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Expense](
	[ExId] [int] IDENTITY(1,1) NOT NULL,
	[ExType] [varchar](max) NULL,
	[ExName] [varchar](max) NULL,
	[Description] [varchar](max) NULL,
	[Date] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ExId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Login_Type]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Login_Type](
	[LoginTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LoginType] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[LoginTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Product]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](30) NULL,
	[weight] [varchar](20) NULL,
	[CategoryID] [int] NULL,
	[CompanyID] [int] NULL,
	[Quantity] [int] NULL CONSTRAINT [DF_tblProduct_Quantity]  DEFAULT ((0)),
	[Ctn] [decimal](18, 0) NULL,
	[PiecePerCtn] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProductPrice]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ProductPrice](
	[ProductPriceId] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[BuyerPrice] [decimal](18, 2) NULL,
	[SellerPrice] [decimal](18, 2) NULL,
	[IsActive] [bit] NULL,
	[AddedDate] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[ProductPriceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_PurchaseDetail]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PurchaseDetail](
	[PDetailID] [int] IDENTITY(1,1) NOT NULL,
	[PInvoice] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[Ctn] [decimal](18, 2) NULL,
	[frieght] [decimal](18, 2) NULL,
	[PurchasePrice] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[PDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_PurchaseMaster]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PurchaseMaster](
	[PInvoice] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NULL,
	[PurchaseDate] [datetime] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Payment] [decimal](18, 2) NULL,
	[DuePayment] [decimal](18, 2) NULL,
	[FurDiscount] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[PInvoice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PurchaseRemain]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PurchaseRemain](
	[PRemainID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NULL,
	[PReturnID] [int] NULL,
	[ReturnCash] [decimal](18, 2) NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PRemainID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_PurchaseReturn_Detail]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PurchaseReturn_Detail](
	[PReturnDetailID] [int] IDENTITY(1,1) NOT NULL,
	[PReturnID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[Ctn] [decimal](18, 2) NULL,
	[PurchasePrice] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[PReturnDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_PurchaseReturn_Master]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PurchaseReturn_Master](
	[PReturnID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NULL,
	[ReturnDate] [datetime] NULL,
	[ReturnCash] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[ReturnDue] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[PInvoice] [int] NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[FurDiscount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[PReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_PurTransaction]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_PurTransaction](
	[PTId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NULL,
	[PInvoice] [int] NULL,
	[PRemainID] [int] NULL,
	[Credit] [decimal](18, 2) NULL,
	[Debit] [decimal](18, 2) NULL,
	[Date] [datetime] NULL,
	[Balance] [decimal](18, 2) NULL,
	[Description] [varchar](max) NULL,
	[PReturnID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PTId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_ReturnSaleDetail]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ReturnSaleDetail](
	[RDetailID] [int] IDENTITY(1,1) NOT NULL,
	[RInvoice] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[Discount] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Ctn] [decimal](18, 2) NULL,
	[RetailPrice] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[RDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_ReturnSaleMaster]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ReturnSaleMaster](
	[RInvoice] [int] IDENTITY(1,1) NOT NULL,
	[Invoice#] [int] NULL,
	[ReturnAmount] [decimal](18, 2) NULL,
	[ReturnDate] [datetime] NULL,
	[ReturnCash] [decimal](18, 2) NULL,
	[TotalBill] [decimal](18, 2) NULL,
	[CustomerID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RInvoice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Saledetail]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Saledetail](
	[SDetailID] [int] IDENTITY(1,1) NOT NULL,
	[Invoice#] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[Discount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[Ctn] [decimal](18, 2) NULL,
	[ProfitLoss] [decimal](18, 2) NULL,
	[RetailPrice] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[SDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_SaleMAster]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_SaleMAster](
	[Invoice#] [int] IDENTITY(1,1) NOT NULL,
	[TotalAmount] [decimal](18, 0) NULL,
	[SaleDate] [datetime] NULL,
	[CustomerID] [int] NULL,
	[Payment] [decimal](18, 2) NULL,
	[DuePayment] [decimal](18, 2) NULL,
	[OrderBy] [varchar](50) NULL,
	[ProfitLoss] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Invoice#] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_SaleRecovery]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_SaleRecovery](
	[SRecoveryID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[RInvoice] [int] NULL,
	[ReturnCash] [decimal](18, 2) NULL,
	[RecoveryDate] [datetime] NULL,
	[RecoveryBatchNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SRecoveryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_SaleTransaction]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_SaleTransaction](
	[STId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[Invoice#] [int] NULL,
	[SRecoveryID] [int] NULL,
	[Credit] [decimal](18, 2) NULL,
	[Debit] [decimal](18, 2) NULL,
	[Date] [datetime] NULL,
	[Balance] [decimal](18, 2) NULL,
	[Description] [varchar](max) NULL,
	[RInvoice] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[STId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_SubZone]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_SubZone](
	[SubRouteId] [int] IDENTITY(1,1) NOT NULL,
	[SubRouteName] [varchar](max) NULL,
	[ZoneID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubRouteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Zone]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Zone](
	[ZoneID] [int] IDENTITY(1,1) NOT NULL,
	[ZoneName] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ZoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_DetailPurchase]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_DetailPurchase]
AS
SELECT        dbo.Tbl_PurchaseDetail.PDetailID AS Sr#, dbo.Tbl_PurchaseMaster.PInvoice AS InvoiceNo, dbo.tbl_Company.CompanyID, dbo.tbl_Company.CompanyName, dbo.tbl_Company.Contact, 
                         dbo.Tbl_PurchaseMaster.PurchaseDate AS Date, dbo.Tbl_PurchaseDetail.ProductID, dbo.tbl_Product.ProductName, dbo.Tbl_PurchaseDetail.PurchasePrice AS TP, dbo.Tbl_PurchaseDetail.Ctn, dbo.Tbl_PurchaseDetail.Quantity, 
                         dbo.Tbl_PurchaseDetail.frieght, dbo.Tbl_PurchaseDetail.TotalAmount AS Amount, dbo.Tbl_PurchaseMaster.Discount AS [Distribution Margin], dbo.Tbl_PurchaseMaster.TotalAmount, dbo.Tbl_PurchaseMaster.FurDiscount, 
                         dbo.Tbl_PurchaseMaster.GrandTotal, dbo.Tbl_PurchaseMaster.Payment, dbo.Tbl_PurchaseMaster.DuePayment AS Balance, dbo.tbl_Company.DuePayment AS [New Balance]
FROM            dbo.tbl_Product RIGHT OUTER JOIN
                         dbo.Tbl_PurchaseDetail LEFT OUTER JOIN
                         dbo.Tbl_PurchaseMaster ON dbo.Tbl_PurchaseDetail.PInvoice = dbo.Tbl_PurchaseMaster.PInvoice LEFT OUTER JOIN
                         dbo.tbl_Company ON dbo.Tbl_PurchaseMaster.CompanyID = dbo.tbl_Company.CompanyID ON dbo.tbl_Product.ProductID = dbo.Tbl_PurchaseDetail.ProductID

GO
/****** Object:  View [dbo].[View_DetailSale]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_DetailSale]
AS
SELECT        dbo.tbl_Saledetail.Invoice# AS InvoiceNo, dbo.tbl_Customer.Name AS CustomerName, dbo.tbl_SaleMAster.SaleDate AS Date, dbo.tbl_Product.ProductName, dbo.tbl_Saledetail.RetailPrice AS RP, dbo.tbl_Saledetail.Ctn, 
                         dbo.tbl_Saledetail.Quantity AS Unit, dbo.tbl_Saledetail.Discount AS Disc, dbo.tbl_Saledetail.TotalAmount AS Amount, dbo.tbl_SaleMAster.TotalAmount AS GrandTotal, dbo.tbl_SaleMAster.Payment, 
                         dbo.tbl_SaleMAster.DuePayment AS Balance, dbo.tbl_Customer.DuePayment AS [Total Balance], dbo.tbl_SaleMAster.OrderBy, dbo.tbl_Saledetail.ProductID AS Code, dbo.tbl_Customer.CustomerID, 
                         dbo.tbl_SaleMAster.ProfitLoss
FROM            dbo.tbl_SaleMAster INNER JOIN
                         dbo.tbl_Saledetail ON dbo.tbl_SaleMAster.Invoice# = dbo.tbl_Saledetail.Invoice# INNER JOIN
                         dbo.tbl_Customer ON dbo.tbl_SaleMAster.CustomerID = dbo.tbl_Customer.CustomerID INNER JOIN
                         dbo.tbl_Product ON dbo.tbl_Saledetail.ProductID = dbo.tbl_Product.ProductID

GO
/****** Object:  View [dbo].[View_Employee]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Employee]
AS
SELECT        dbo.tbl_employee.Name, dbo.tbl_employee.Fname, dbo.tbl_employee.Qualifiction AS Qualification, dbo.tbl_employee.DOB, dbo.tbl_employee.Cnic, dbo.tbl_employee.Contact, dbo.tbl_employee.Gender, 
                         dbo.tbl_employee.Address, dbo.tbl_employee.Designation, dbo.tbl_Employee_Salary.SalaryDate, dbo.tbl_Employee_Salary.EmployeeID, dbo.tbl_Employee_Salary.Salary, dbo.tbl_Employee_Salary.Status, 
                         dbo.tbl_Employee_Salary.SalaryID, dbo.tbl_employee.AsignDate, dbo.tbl_Employee_Salary.ResginDate AS ResignDate
FROM            dbo.tbl_employee LEFT OUTER JOIN
                         dbo.tbl_Employee_Salary ON dbo.tbl_employee.EmployeeID = dbo.tbl_Employee_Salary.EmployeeID

GO
/****** Object:  View [dbo].[View_Employee_Login]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Employee_Login]
AS
SELECT        dbo.tbl_employee.EmployeeID, dbo.tbl_employee.Name, dbo.tbl_employee.Fname, dbo.tbl_employee.Username, dbo.tbl_employee.Password, dbo.tbl_employee.Qualifiction, dbo.tbl_employee.DOB, dbo.tbl_employee.Cnic, 
                         dbo.tbl_employee.Contact, dbo.tbl_employee.Designation, dbo.tbl_employee.Gender, dbo.tbl_employee.Address, dbo.tbl_employee.Salary, dbo.tbl_employee.AsignDate, dbo.tbl_Login_Type.LoginType
FROM            dbo.tbl_employee LEFT OUTER JOIN
                         dbo.tbl_Login_Type ON dbo.tbl_employee.LoginTypeID = dbo.tbl_Login_Type.LoginTypeID

GO
/****** Object:  View [dbo].[View_ProductPrice]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ProductPrice]
AS
SELECT        dbo.tbl_ProductPrice.ProductPriceId, dbo.tbl_Product.ProductName, dbo.tbl_ProductPrice.BuyerPrice, dbo.tbl_ProductPrice.SellerPrice, dbo.tbl_ProductPrice.IsActive, dbo.tbl_ProductPrice.AddedDate, 
                         dbo.tbl_ProductPrice.ProductID
FROM            dbo.tbl_Product INNER JOIN
                         dbo.tbl_ProductPrice ON dbo.tbl_Product.ProductID = dbo.tbl_ProductPrice.ProductID

GO
/****** Object:  View [dbo].[View_Pur_Remain]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Pur_Remain]
AS
SELECT        dbo.tbl_PurchaseRemain.PRemainID AS RemainID, dbo.tbl_PurchaseRemain.CompanyID, dbo.tbl_Company.CompanyName, dbo.tbl_Company.Contact, dbo.tbl_PurchaseRemain.PReturnID, 
                         dbo.tbl_PurchaseRemain.ReturnCash, dbo.tbl_PurchaseRemain.Date, dbo.Tbl_PurchaseReturn_Master.ReturnDate, dbo.Tbl_PurchaseReturn_Master.ReturnDue, dbo.tbl_Company.DuePayment
FROM            dbo.tbl_PurchaseRemain LEFT OUTER JOIN
                         dbo.tbl_Company ON dbo.tbl_PurchaseRemain.CompanyID = dbo.tbl_Company.CompanyID LEFT OUTER JOIN
                         dbo.Tbl_PurchaseReturn_Master ON dbo.tbl_PurchaseRemain.PReturnID = dbo.Tbl_PurchaseReturn_Master.PReturnID

GO
/****** Object:  View [dbo].[View_PurLedger]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_PurLedger]
AS
SELECT        dbo.Tbl_PurTransaction.PTId, dbo.Tbl_PurTransaction.CompanyID, dbo.tbl_Company.CompanyName, dbo.tbl_Company.Contact, dbo.Tbl_PurTransaction.PInvoice, dbo.Tbl_PurTransaction.PRemainID, 
                         dbo.Tbl_PurTransaction.PReturnID, dbo.Tbl_PurTransaction.Credit, dbo.Tbl_PurTransaction.Debit, dbo.Tbl_PurTransaction.Date, dbo.Tbl_PurTransaction.Balance, dbo.Tbl_PurTransaction.Description
FROM            dbo.Tbl_PurTransaction INNER JOIN
                         dbo.tbl_Company ON dbo.Tbl_PurTransaction.CompanyID = dbo.tbl_Company.CompanyID

GO
/****** Object:  View [dbo].[View_PurReturn]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_PurReturn]
AS
SELECT        dbo.Tbl_PurchaseReturn_Master.CompanyID, dbo.Tbl_PurchaseReturn_Master.ReturnDate, dbo.Tbl_PurchaseReturn_Master.ReturnCash, dbo.Tbl_PurchaseReturn_Master.TotalAmount, 
                         dbo.Tbl_PurchaseReturn_Master.ReturnDue, dbo.Tbl_PurchaseReturn_Master.Discount, dbo.Tbl_PurchaseReturn_Detail.ProductID, dbo.Tbl_PurchaseReturn_Detail.PurchasePrice AS TP, 
                         dbo.Tbl_PurchaseReturn_Detail.Quantity, dbo.Tbl_PurchaseReturn_Detail.Ctn, dbo.Tbl_PurchaseReturn_Detail.Amount, dbo.tbl_Company.CompanyName, dbo.tbl_Company.Contact, dbo.tbl_Company.DuePayment, 
                         dbo.Tbl_PurchaseMaster.PInvoice, dbo.tbl_Product.ProductName, dbo.Tbl_PurchaseReturn_Detail.PReturnID AS ReturnInvoiceNo, dbo.Tbl_PurchaseReturn_Master.GrandTotal, 
                         dbo.Tbl_PurchaseReturn_Master.FurDiscount
FROM            dbo.Tbl_PurchaseReturn_Master INNER JOIN
                         dbo.Tbl_PurchaseReturn_Detail ON dbo.Tbl_PurchaseReturn_Master.PReturnID = dbo.Tbl_PurchaseReturn_Detail.PReturnID INNER JOIN
                         dbo.tbl_Company ON dbo.Tbl_PurchaseReturn_Master.CompanyID = dbo.tbl_Company.CompanyID INNER JOIN
                         dbo.Tbl_PurchaseMaster ON dbo.Tbl_PurchaseReturn_Master.PInvoice = dbo.Tbl_PurchaseMaster.PInvoice INNER JOIN
                         dbo.tbl_Product ON dbo.Tbl_PurchaseReturn_Detail.ProductID = dbo.tbl_Product.ProductID

GO
/****** Object:  View [dbo].[View_Sale_Recovery]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Sale_Recovery]
AS
SELECT        dbo.tbl_Customer.CustomerID, dbo.tbl_Customer.Name, dbo.tbl_Customer.Contact, dbo.Tbl_SaleRecovery.SRecoveryID AS RecoveryID, dbo.Tbl_SaleRecovery.ReturnCash, dbo.Tbl_SaleRecovery.RecoveryDate, 
                         dbo.tbl_Customer.DuePayment, dbo.Tbl_ReturnSaleMaster.ReturnAmount, dbo.Tbl_ReturnSaleMaster.ReturnDate, dbo.Tbl_SaleRecovery.RInvoice
FROM            dbo.tbl_Customer LEFT OUTER JOIN
                         dbo.Tbl_ReturnSaleMaster ON dbo.tbl_Customer.CustomerID = dbo.Tbl_ReturnSaleMaster.CustomerID LEFT OUTER JOIN
                         dbo.Tbl_SaleRecovery ON dbo.tbl_Customer.CustomerID = dbo.Tbl_SaleRecovery.CustomerID

GO
/****** Object:  View [dbo].[View_SaleLedger]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SaleLedger]
AS
SELECT        dbo.Tbl_SaleTransaction.STId, dbo.Tbl_SaleTransaction.CustomerID, dbo.tbl_Customer.Name, dbo.tbl_Customer.Contact, dbo.Tbl_SubZone.SubRouteName, dbo.Tbl_SaleTransaction.Invoice# AS InvoiceNo, 
                         dbo.Tbl_SaleTransaction.SRecoveryID AS RecoveryId, dbo.Tbl_SaleTransaction.RInvoice, dbo.Tbl_SaleTransaction.Credit, dbo.Tbl_SaleTransaction.Debit, dbo.Tbl_SaleTransaction.Date, dbo.Tbl_SaleTransaction.Balance, 
                         dbo.Tbl_SaleTransaction.Description
FROM            dbo.Tbl_SaleTransaction LEFT OUTER JOIN
                         dbo.tbl_Customer ON dbo.Tbl_SaleTransaction.CustomerID = dbo.tbl_Customer.CustomerID LEFT OUTER JOIN
                         dbo.Tbl_SubZone ON dbo.tbl_Customer.SubRouteId = dbo.Tbl_SubZone.SubRouteId

GO
/****** Object:  View [dbo].[View_SaleMaster]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SaleMaster]
AS
SELECT        dbo.tbl_SaleMAster.Invoice#, dbo.tbl_Customer.CustomerID, dbo.tbl_Customer.Name, dbo.tbl_Customer.Contact, dbo.tbl_SaleMAster.SaleDate, dbo.tbl_SaleMAster.TotalAmount AS GrandTotal
FROM            dbo.tbl_SaleMAster INNER JOIN
                         dbo.tbl_Customer ON dbo.tbl_SaleMAster.CustomerID = dbo.tbl_Customer.CustomerID

GO
/****** Object:  View [dbo].[View_SaleReturn]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SaleReturn]
AS
SELECT        dbo.Tbl_ReturnSaleMaster.RInvoice AS [Return Invoice], dbo.Tbl_ReturnSaleMaster.Invoice#, dbo.tbl_SaleMAster.CustomerID, dbo.tbl_Customer.Name, dbo.Tbl_ReturnSaleMaster.ReturnDate, 
                         dbo.Tbl_ReturnSaleMaster.ReturnAmount AS [Return Due], dbo.Tbl_ReturnSaleMaster.ReturnCash, dbo.Tbl_ReturnSaleMaster.TotalBill AS GrandTotal, dbo.tbl_Customer.DuePayment, dbo.Tbl_ReturnSaleDetail.Quantity, 
                         dbo.Tbl_ReturnSaleDetail.Discount, dbo.Tbl_ReturnSaleDetail.Amount, dbo.tbl_Product.ProductID, dbo.tbl_Product.ProductName, dbo.Tbl_ReturnSaleDetail.RetailPrice AS RP, dbo.Tbl_ReturnSaleDetail.Ctn
FROM            dbo.Tbl_ReturnSaleMaster INNER JOIN
                         dbo.tbl_SaleMAster ON dbo.Tbl_ReturnSaleMaster.Invoice# = dbo.tbl_SaleMAster.Invoice# INNER JOIN
                         dbo.tbl_Customer ON dbo.tbl_SaleMAster.CustomerID = dbo.tbl_Customer.CustomerID INNER JOIN
                         dbo.Tbl_ReturnSaleDetail ON dbo.Tbl_ReturnSaleMaster.RInvoice = dbo.Tbl_ReturnSaleDetail.RInvoice INNER JOIN
                         dbo.tbl_Product ON dbo.Tbl_ReturnSaleDetail.ProductID = dbo.tbl_Product.ProductID

GO
/****** Object:  View [dbo].[View_SubZone]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SubZone]
AS
SELECT        dbo.Tbl_SubZone.SubRouteId, dbo.Tbl_SubZone.SubRouteName, dbo.Tbl_SubZone.ZoneID, dbo.tbl_Zone.ZoneName
FROM            dbo.Tbl_SubZone INNER JOIN
                         dbo.tbl_Zone ON dbo.Tbl_SubZone.ZoneID = dbo.tbl_Zone.ZoneID

GO
/****** Object:  View [dbo].[View_tbl_Customer]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_tbl_Customer]
AS
SELECT        dbo.tbl_Customer.CustomerID, dbo.tbl_Customer.Name, dbo.tbl_CustomerTypes.CusType, dbo.tbl_Customer.Address, dbo.tbl_Customer.Contact, dbo.tbl_Customer.Email, dbo.tbl_Customer.ZoneID, 
                         dbo.tbl_Zone.ZoneName AS Route, dbo.Tbl_SubZone.SubRouteName, dbo.tbl_Customer.DuePayment
FROM            dbo.tbl_Customer LEFT OUTER JOIN
                         dbo.tbl_CustomerTypes ON dbo.tbl_Customer.CusTypeID = dbo.tbl_CustomerTypes.CusTypeID INNER JOIN
                         dbo.tbl_Zone ON dbo.tbl_Customer.ZoneID = dbo.tbl_Zone.ZoneID LEFT OUTER JOIN
                         dbo.Tbl_SubZone ON dbo.tbl_Customer.SubRouteId = dbo.Tbl_SubZone.SubRouteId

GO
/****** Object:  View [dbo].[View_tbl_Product]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_tbl_Product]
AS
SELECT        dbo.tbl_Product.ProductID, dbo.tbl_Product.ProductName, dbo.tbl_Category.CategoryName AS Category, dbo.tbl_Company.CompanyName AS Company, dbo.tbl_Product.weight, dbo.tbl_Product.PiecePerCtn, dbo.tbl_Product.Ctn, 
                         dbo.tbl_Product.Quantity AS Piece, ISNULL(pr.BuyerPrice, 0) AS PurchasePrice, ISNULL(pr.SellerPrice, 0) AS RetailPrice
FROM            dbo.tbl_Product INNER JOIN
                         dbo.tbl_Company ON dbo.tbl_Product.CompanyID = dbo.tbl_Company.CompanyID INNER JOIN
                         dbo.tbl_Category ON dbo.tbl_Product.CategoryID = dbo.tbl_Category.CategoryID LEFT OUTER JOIN
                         dbo.tbl_ProductPrice AS pr ON dbo.tbl_Product.ProductID = pr.ProductID AND pr.IsActive = 1

GO
/****** Object:  View [dbo].[ViewSales]    Script Date: 9/3/2020 12:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewSales]
AS
SELECT        dbo.tbl_SaleMAster.Invoice#, dbo.tbl_Customer.Name, dbo.tbl_Product.ProductName, dbo.tbl_Product.RetailPrice, dbo.tbl_Saledetail.Quantity, dbo.tbl_SaleMAster.SaleDate, dbo.tbl_SaleMAster.Discount, 
                         dbo.tbl_Saledetail.TotalAmount
FROM            dbo.tbl_Product INNER JOIN
                         dbo.tbl_Saledetail ON dbo.tbl_Product.ProductID = dbo.tbl_Saledetail.ProductID INNER JOIN
                         dbo.tbl_SaleMAster ON dbo.tbl_Saledetail.Invoice# = dbo.tbl_SaleMAster.Invoice# INNER JOIN
                         dbo.tbl_Customer ON dbo.tbl_SaleMAster.CustomerID = dbo.tbl_Customer.CustomerID

GO
SET IDENTITY_INSERT [dbo].[tbl_Category] ON 

INSERT [dbo].[tbl_Category] ([CategoryID], [CategoryName]) VALUES (3, N'Garment')
INSERT [dbo].[tbl_Category] ([CategoryID], [CategoryName]) VALUES (5, N'Shampoo')
INSERT [dbo].[tbl_Category] ([CategoryID], [CategoryName]) VALUES (6, N'Grocery')
INSERT [dbo].[tbl_Category] ([CategoryID], [CategoryName]) VALUES (7, N'Soap')
INSERT [dbo].[tbl_Category] ([CategoryID], [CategoryName]) VALUES (8, N'Cosmatic')
INSERT [dbo].[tbl_Category] ([CategoryID], [CategoryName]) VALUES (9, N'Snacks')
SET IDENTITY_INSERT [dbo].[tbl_Category] OFF
SET IDENTITY_INSERT [dbo].[tbl_Company] ON 

INSERT [dbo].[tbl_Company] ([CompanyID], [CompanyName], [Email], [Contact], [Address], [DuePayment]) VALUES (4, N'Unilever', N'unileverpk@gmail.com', N'0346-7976136', N'Karachi', CAST(10625.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_Company] ([CompanyID], [CompanyName], [Email], [Contact], [Address], [DuePayment]) VALUES (5, N'Kravers Foods', N'xxxxx', N'0333-2221515', N'XXXX', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_Company] ([CompanyID], [CompanyName], [Email], [Contact], [Address], [DuePayment]) VALUES (8, N'D&K', N'adad', N'0316-4646146', N'asdaf', CAST(10000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[tbl_Company] OFF
SET IDENTITY_INSERT [dbo].[tbl_Customer] ON 

INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (2, N'Arif', 1, N'Islambad Near D-Watson', N'0346-6879667', N'arfi@gmai.com', 1, CAST(1510.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (3, N'Niaz Muhammad', 1, N'Islambad', N'0346-5798764', N'niaz@gmail.com', 1, CAST(1725.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (4, N'Owais Khan', 1, N'Islamabad', N'0346-7951251', N'owias@gmail.com', 1, CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (5, N'Rizwan Khan', 2, N'Islamabad', N'0331-4567456', N'rizwan@gmail.com', 4, CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (6, N'Noman', 1, N'Islamabad', N'0346-7974669', N'', 4, CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (8, N'Rizwan Khan', 1, N'Islamabad', N'0346-7976464', N'', 1, CAST(1000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (9, N'Shoaib', 1, N'Islamabad', N'0364-4881147', N'm.klose@yahoo.com', 1, CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (10, N'1234456', 1, N'Dera ', N'0000-0000000', N'amirr', 1, CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (11, N'Khan', 1, N'Islamabad', N'0346-4616464', N'sddada', 1, CAST(5100.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (12, N'Adnan', 1, N'dsafdf ', N'6546-4564646', N'asd@gmail.com', 1, CAST(4500.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (13, N'Shoaib Khan', 1, N'asdas', N'0346-4979464', N'amda', 1, CAST(5000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[tbl_Customer] ([CustomerID], [Name], [CusTypeID], [Address], [Contact], [Email], [ZoneID], [DuePayment], [SubRouteId]) VALUES (14, N'Ahmad', 1, N'isdjada', N'0346-4646494', N'asad', 1, CAST(1950.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[tbl_Customer] OFF
SET IDENTITY_INSERT [dbo].[tbl_CustomerTypes] ON 

INSERT [dbo].[tbl_CustomerTypes] ([CusTypeID], [CusType]) VALUES (1, N'WholeSale Dealer')
INSERT [dbo].[tbl_CustomerTypes] ([CusTypeID], [CusType]) VALUES (2, N'Merchant')
SET IDENTITY_INSERT [dbo].[tbl_CustomerTypes] OFF
SET IDENTITY_INSERT [dbo].[tbl_employee] ON 

INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (3, N'Shoaib', N'Saleem', N'admin', N'123456', N'Mcs', N'1/1/1997', N'12101-5268158-1', N'0354-6256654', N'Manager', 1, N'Dera', CAST(20000.00 AS Decimal(18, 2)), CAST(N'2019-11-19 17:16:52.160' AS DateTime), 1)
INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (4, N'niaz', N'khan', N'admin1', N'123456', N'msc', N'1/1/1990', N'12346-4164676-7', N'0354-6764616', N'Am', 1, N'Dera', CAST(18000.00 AS Decimal(18, 2)), CAST(N'2019-11-20 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (5, N'Arif', N'Abdul', NULL, NULL, N'matric', N'1/1/1990', N'13103-4643164-6', N'0346-6133467', N'Salesman', 1, N'Dera ', CAST(10000.00 AS Decimal(18, 2)), CAST(N'2019-11-20 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (6, N'Owais', N'Khan', NULL, NULL, N'Fsc', N'1/1/1995', N'13031-3464116-4', N'0344-5616467', N'Salesman', 1, N'Dera ', CAST(15000.00 AS Decimal(18, 2)), CAST(N'2019-11-20 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (7, N'Rizwan', N'khan', NULL, NULL, N'fsc', N'1/1/1990', N'21230-1334313-1', N'0354-6763164', N'Salesman', 1, N'Dera ', CAST(15000.00 AS Decimal(18, 2)), CAST(N'2019-11-20 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (8, N'Khan', N'KHani', N'operater', N'123456', N'Bsc', N'1/1/1999', N'12102-5464164-6', N'0312-4666841', N'Operater', 1, N'D I khan', CAST(15000.00 AS Decimal(18, 2)), CAST(N'2019-11-28 00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (9, N'Rizwan', N'Khan', NULL, NULL, N'Matric', N'1/1/1995', N'12364-9764313-4', N'0346-9764646', N'Salesman', 1, N'Dera', CAST(10000.00 AS Decimal(18, 2)), CAST(N'2019-12-03 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[tbl_employee] ([EmployeeID], [Name], [Fname], [Username], [Password], [Qualifiction], [DOB], [Cnic], [Contact], [Designation], [Gender], [Address], [Salary], [AsignDate], [LoginTypeID]) VALUES (10, N'Sami', N'Khan', NULL, NULL, N'Matric', N'1/1/1990', N'12121-2121545-4', N'0333-3333333', N'Salesman', 1, N'D i khan', CAST(10000.00 AS Decimal(18, 2)), CAST(N'2020-07-24 00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tbl_employee] OFF
SET IDENTITY_INSERT [dbo].[tbl_Employee_Salary] ON 

INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (1, 3, CAST(20000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-18 16:44:02.720' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (2, 4, CAST(18000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (3, 5, CAST(10000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (4, 7, CAST(15000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (5, 7, CAST(15000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (6, 6, CAST(15000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (7, 3, CAST(20000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (8, 4, CAST(18000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (9, 3, CAST(20000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Employee_Salary] ([SalaryID], [EmployeeID], [Salary], [Status], [ResginDate], [SalaryDate]) VALUES (10, 5, CAST(10000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2019-11-24 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Employee_Salary] OFF
SET IDENTITY_INSERT [dbo].[tbl_Login_Type] ON 

INSERT [dbo].[tbl_Login_Type] ([LoginTypeID], [LoginType]) VALUES (1, N'Manager')
INSERT [dbo].[tbl_Login_Type] ([LoginTypeID], [LoginType]) VALUES (2, N'Computer Operater')
SET IDENTITY_INSERT [dbo].[tbl_Login_Type] OFF
SET IDENTITY_INSERT [dbo].[tbl_Product] ON 

INSERT [dbo].[tbl_Product] ([ProductID], [ProductName], [weight], [CategoryID], [CompanyID], [Quantity], [Ctn], [PiecePerCtn]) VALUES (1, N'Safe Guard', N'50 gm', 7, 4, 1554, CAST(115 AS Decimal(18, 0)), 12)
INSERT [dbo].[tbl_Product] ([ProductID], [ProductName], [weight], [CategoryID], [CompanyID], [Quantity], [Ctn], [PiecePerCtn]) VALUES (2, N'Fair&Lovely Creame', N'100 gm ', 8, 4, 806, CAST(13 AS Decimal(18, 0)), 12)
INSERT [dbo].[tbl_Product] ([ProductID], [ProductName], [weight], [CategoryID], [CompanyID], [Quantity], [Ctn], [PiecePerCtn]) VALUES (4, N'Dove', N'100 gm', 0, 0, 40, CAST(0 AS Decimal(18, 0)), 12)
INSERT [dbo].[tbl_Product] ([ProductID], [ProductName], [weight], [CategoryID], [CompanyID], [Quantity], [Ctn], [PiecePerCtn]) VALUES (6, N'Kracklez', N'22g', 9, 5, 480, CAST(10 AS Decimal(18, 0)), 48)
SET IDENTITY_INSERT [dbo].[tbl_Product] OFF
SET IDENTITY_INSERT [dbo].[tbl_ProductPrice] ON 

INSERT [dbo].[tbl_ProductPrice] ([ProductPriceId], [ProductID], [BuyerPrice], [SellerPrice], [IsActive], [AddedDate]) VALUES (1, 1, CAST(40.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 1, NULL)
INSERT [dbo].[tbl_ProductPrice] ([ProductPriceId], [ProductID], [BuyerPrice], [SellerPrice], [IsActive], [AddedDate]) VALUES (2, 1, CAST(55.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 0, CAST(N'2020-08-22 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_ProductPrice] ([ProductPriceId], [ProductID], [BuyerPrice], [SellerPrice], [IsActive], [AddedDate]) VALUES (3, 2, CAST(180.00 AS Decimal(18, 2)), CAST(210.00 AS Decimal(18, 2)), 1, CAST(N'2020-08-22 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_ProductPrice] OFF
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseDetail] ON 

INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (1, 0, 1, 50, CAST(2500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (2, 0, 2, 50, CAST(10000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (3, 3, 1, 10, CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (4, 4, 1, 100, CAST(5000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (5, 4, 1, 100, CAST(5000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (6, 6, 2, 0, CAST(1900.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (7, 6, 2, 0, CAST(1900.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (8, 6, 2, 0, CAST(1900.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (9, 9, 1, 10, CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (10, 9, 1, 10, CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (11, 11, 3, 400, CAST(24000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (12, 12, 3, 50, CAST(3000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (13, 13, 3, 0, CAST(550.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (14, 14, 3, 0, CAST(2750.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (15, 15, 4, 30, CAST(3000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (16, 16, 3, 50, CAST(2750.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (17, 16, 4, 10, CAST(1500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (18, 17, 1, 100, CAST(4500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (19, 18, 1, 360, CAST(10800.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (20, 19, 1, 180, CAST(5400.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (21, 20, 1, 180, CAST(5400.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (22, 0, 0, 0, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (23, 0, 0, 0, CAST(2000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (24, 22, 1, 120, CAST(500.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (25, 22, 2, 120, CAST(2000.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseDetail] ([PDetailID], [PInvoice], [ProductID], [Quantity], [TotalAmount], [Ctn], [frieght], [PurchasePrice]) VALUES (26, 23, 1, 1320, CAST(4000.00 AS Decimal(18, 2)), CAST(110.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseDetail] OFF
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseMaster] ON 

INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (1, 1, CAST(N'2019-10-03 14:51:03.973' AS DateTime), CAST(1000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (2, 4, CAST(N'2019-10-18 01:27:11.000' AS DateTime), CAST(12500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (3, 4, CAST(N'2019-10-18 01:29:43.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (4, 4, CAST(N'2019-10-26 14:18:25.000' AS DateTime), CAST(5000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (5, 4, CAST(N'2019-10-26 14:18:25.000' AS DateTime), CAST(5000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (6, 4, CAST(N'2019-10-26 14:21:08.000' AS DateTime), CAST(2100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (7, 4, CAST(N'2019-10-26 14:21:08.000' AS DateTime), CAST(4000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (8, 4, CAST(N'2019-10-26 14:21:08.000' AS DateTime), CAST(4000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (9, 4, CAST(N'2019-10-28 14:13:24.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (10, 4, CAST(N'2019-10-28 14:13:24.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (11, 4, CAST(N'2019-11-13 00:39:23.000' AS DateTime), CAST(24000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (12, 4, CAST(N'2019-11-13 00:42:52.000' AS DateTime), CAST(3000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (13, 4, CAST(N'2019-11-13 01:29:10.000' AS DateTime), CAST(250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (14, 4, CAST(N'2019-11-16 15:16:10.000' AS DateTime), CAST(3250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (15, 4, CAST(N'2019-11-21 15:56:34.000' AS DateTime), CAST(7500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (16, 4, CAST(N'2019-12-01 14:42:23.000' AS DateTime), CAST(4250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(750.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (17, 4, CAST(N'2020-07-16 13:47:55.000' AS DateTime), CAST(4500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (18, 4, CAST(N'2020-07-22 13:28:31.000' AS DateTime), CAST(10800.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (19, 4, CAST(N'2020-07-22 13:30:55.000' AS DateTime), CAST(5400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (20, 4, CAST(N'2020-07-27 16:35:16.000' AS DateTime), CAST(5400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (21, 4, CAST(N'2020-08-13 12:59:45.000' AS DateTime), CAST(2250.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(182.50 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), CAST(2182.50 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (22, 4, CAST(N'2020-08-13 13:04:23.000' AS DateTime), CAST(2250.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(182.50 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), CAST(2182.50 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseMaster] ([PInvoice], [CompanyID], [PurchaseDate], [TotalAmount], [Discount], [Payment], [DuePayment], [FurDiscount], [GrandTotal]) VALUES (23, 4, CAST(N'2020-08-31 13:19:24.000' AS DateTime), CAST(3600.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(3600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(3600.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseMaster] OFF
SET IDENTITY_INSERT [dbo].[tbl_PurchaseRemain] ON 

INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (1, 0, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(N'2019-11-20 16:03:20.800' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (2, 4, NULL, CAST(1000.00 AS Decimal(18, 2)), CAST(N'2019-11-20 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (3, 4, 12, CAST(1500.00 AS Decimal(18, 2)), CAST(N'2019-11-25 14:58:29.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (4, 4, 12, CAST(1500.00 AS Decimal(18, 2)), CAST(N'2019-12-01 14:46:44.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (5, 4, NULL, CAST(1100.00 AS Decimal(18, 2)), CAST(N'2019-12-01 00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (6, 4, 13, CAST(-400.00 AS Decimal(18, 2)), CAST(N'2020-07-24 03:16:07.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (7, 4, 14, CAST(-25.77 AS Decimal(18, 2)), CAST(N'2020-08-13 19:49:01.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (8, 4, 15, CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-08-31 13:38:06.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (9, 4, 16, CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-08-31 13:41:32.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (10, 4, 17, CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-08-31 13:43:33.000' AS DateTime))
INSERT [dbo].[tbl_PurchaseRemain] ([PRemainID], [CompanyID], [PReturnID], [ReturnCash], [Date]) VALUES (11, 4, 18, CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-09-01 12:40:33.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_PurchaseRemain] OFF
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseReturn_Detail] ON 

INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (1, 13, 3, 20, CAST(1100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (2, 13, 3, 10, CAST(550.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (3, 6, 2, 10, CAST(1900.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (4, 14, 3, 50, CAST(2750.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (5, 13, 3, 20, CAST(1100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (6, 13, 3, 10, CAST(550.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (7, 8, 3, 10, CAST(550.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (8, 8, 3, 10, CAST(550.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (9, 11, 4, 20, CAST(3000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (10, 12, 4, 10, CAST(1500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (11, 13, 1, 120, CAST(5400.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (12, 14, 1, 60, CAST(225.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (13, 14, 2, 60, CAST(950.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (14, 15, 1, 120, CAST(400.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (15, 16, 1, 120, CAST(400.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseReturn_Detail] ([PReturnDetailID], [PReturnID], [ProductID], [Quantity], [Amount], [Ctn], [PurchasePrice]) VALUES (16, 18, 1, 120, CAST(400.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseReturn_Detail] OFF
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseReturn_Master] ON 

INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (1, 4, CAST(N'2019-11-11 14:59:46.593' AS DateTime), CAST(1000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (2, 4, CAST(N'2019-11-13 01:58:57.000' AS DateTime), CAST(1100.00 AS Decimal(18, 2)), CAST(1100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 13, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (3, 4, CAST(N'2019-11-13 01:58:57.000' AS DateTime), CAST(1100.00 AS Decimal(18, 2)), CAST(1100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 13, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (4, 4, CAST(N'2019-11-16 15:09:08.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(1900.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 6, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (5, 4, CAST(N'2019-11-16 15:17:48.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(2750.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 14, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (6, 4, CAST(N'2019-11-17 00:41:28.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(1100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 13, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (7, 4, CAST(N'2019-11-17 00:46:21.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(550.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 13, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (8, 4, CAST(N'2019-11-17 00:48:48.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(550.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 13, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (9, 4, CAST(N'2019-11-17 00:48:48.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(550.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 13, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (10, 4, CAST(N'2019-11-21 16:02:13.000' AS DateTime), CAST(7500.00 AS Decimal(18, 2)), CAST(7500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 15, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (11, 4, CAST(N'2019-11-21 16:07:09.000' AS DateTime), CAST(3000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 15, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (12, 4, CAST(N'2019-12-01 14:46:44.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 16, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (13, 4, CAST(N'2020-07-24 03:16:07.000' AS DateTime), CAST(5000.00 AS Decimal(18, 2)), CAST(5400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 19, NULL, NULL)
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (14, 4, CAST(N'2020-08-13 19:49:01.000' AS DateTime), CAST(1000.00 AS Decimal(18, 2)), CAST(1025.77 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 22, CAST(1025.77 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (15, 4, CAST(N'2020-08-31 13:38:06.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 23, CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (16, 4, CAST(N'2020-08-31 13:41:32.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 23, CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (17, 4, CAST(N'2020-08-31 13:43:33.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 23, CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_PurchaseReturn_Master] ([PReturnID], [CompanyID], [ReturnDate], [ReturnCash], [TotalAmount], [ReturnDue], [Discount], [PInvoice], [GrandTotal], [FurDiscount]) VALUES (18, 4, CAST(N'2020-09-01 12:40:33.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 23, CAST(360.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tbl_PurchaseReturn_Master] OFF
SET IDENTITY_INSERT [dbo].[Tbl_PurTransaction] ON 

INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (1, 4, 17, NULL, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-16 13:47:55.000' AS DateTime), CAST(10500.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (2, 4, 18, NULL, CAST(800.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-22 13:28:31.000' AS DateTime), CAST(11300.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (3, 4, 19, NULL, CAST(400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-22 13:30:55.000' AS DateTime), CAST(11700.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (4, 4, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(-400.00 AS Decimal(18, 2)), CAST(N'2020-07-24 03:16:07.000' AS DateTime), CAST(11300.00 AS Decimal(18, 2)), N'Credit', 13)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (5, 4, 20, NULL, CAST(400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-27 16:35:16.000' AS DateTime), CAST(11700.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (6, 6, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(5000.00 AS Decimal(18, 2)), N'Opening Balance', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (7, 7, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(5000.00 AS Decimal(18, 2)), N'Opening Balance', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (8, 8, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(10000.00 AS Decimal(18, 2)), N'Opening Balance', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (9, 4, 21, NULL, CAST(182.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-13 12:59:45.000' AS DateTime), CAST(11882.50 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (10, 4, 22, NULL, CAST(182.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-13 13:04:23.000' AS DateTime), CAST(12065.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (11, 4, 23, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-31 13:19:24.000' AS DateTime), CAST(12065.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (12, 4, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-08-31 13:38:06.000' AS DateTime), CAST(11705.00 AS Decimal(18, 2)), N'Credit', 15)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (13, 4, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-08-31 13:41:32.000' AS DateTime), CAST(11345.00 AS Decimal(18, 2)), N'Credit', 16)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (14, 4, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-08-31 13:43:33.000' AS DateTime), CAST(10985.00 AS Decimal(18, 2)), N'Credit', 17)
INSERT [dbo].[Tbl_PurTransaction] ([PTId], [CompanyID], [PInvoice], [PRemainID], [Credit], [Debit], [Date], [Balance], [Description], [PReturnID]) VALUES (15, 4, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(-360.00 AS Decimal(18, 2)), CAST(N'2020-09-01 12:40:33.000' AS DateTime), CAST(10625.00 AS Decimal(18, 2)), N'Credit', 18)
SET IDENTITY_INSERT [dbo].[Tbl_PurTransaction] OFF
SET IDENTITY_INSERT [dbo].[Tbl_ReturnSaleDetail] ON 

INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (1, 3, 1, 5, CAST(10.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (2, 3, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (3, 4, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (4, 5, 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (5, 6, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (6, 7, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (7, 8, 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (8, 9, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (9, 10, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (10, 11, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (11, 12, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleDetail] ([RDetailID], [RInvoice], [ProductID], [Quantity], [Discount], [Amount], [Ctn], [RetailPrice]) VALUES (12, 13, 6, 240, CAST(0.00 AS Decimal(18, 2)), CAST(1850.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL)
SET IDENTITY_INSERT [dbo].[Tbl_ReturnSaleDetail] OFF
SET IDENTITY_INSERT [dbo].[Tbl_ReturnSaleMaster] ON 

INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (1, 2, CAST(200.00 AS Decimal(18, 2)), CAST(N'2019-10-26 15:58:18.887' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (2, 14, CAST(225.00 AS Decimal(18, 2)), CAST(N'2019-11-07 00:49:37.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (3, 5, CAST(0.00 AS Decimal(18, 2)), CAST(N'2019-11-07 01:05:13.000' AS DateTime), CAST(250.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (4, 15, CAST(0.00 AS Decimal(18, 2)), CAST(N'2019-11-07 01:15:30.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (5, 9, CAST(0.00 AS Decimal(18, 2)), CAST(N'2019-11-07 01:22:00.000' AS DateTime), CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (6, 5, CAST(0.00 AS Decimal(18, 2)), CAST(N'2019-11-09 15:06:31.000' AS DateTime), CAST(250.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (7, 5, CAST(0.00 AS Decimal(18, 2)), CAST(N'2019-11-09 15:12:50.000' AS DateTime), CAST(250.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (8, 8, CAST(100.00 AS Decimal(18, 2)), CAST(N'2019-11-09 15:35:28.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (9, 17, CAST(0.00 AS Decimal(18, 2)), CAST(N'2019-11-10 12:22:38.000' AS DateTime), CAST(250.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (10, 27, CAST(500.00 AS Decimal(18, 2)), CAST(N'2019-11-12 14:40:54.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (11, 29, CAST(1000.00 AS Decimal(18, 2)), CAST(N'2019-11-12 14:51:51.000' AS DateTime), CAST(1000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (12, 35, CAST(100.00 AS Decimal(18, 2)), CAST(N'2019-12-03 16:19:40.000' AS DateTime), CAST(1900.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Tbl_ReturnSaleMaster] ([RInvoice], [Invoice#], [ReturnAmount], [ReturnDate], [ReturnCash], [TotalBill], [CustomerID]) VALUES (13, 56, CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-07-28 01:49:59.000' AS DateTime), CAST(1800.00 AS Decimal(18, 2)), CAST(1850.00 AS Decimal(18, 2)), NULL)
SET IDENTITY_INSERT [dbo].[Tbl_ReturnSaleMaster] OFF
SET IDENTITY_INSERT [dbo].[tbl_Saledetail] ON 

INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (1, 2, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (2, 2, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (3, 3, 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (4, 4, 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (5, 5, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (6, 6, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (7, 7, 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (8, 8, 1, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (9, 9, 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (10, 10, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (11, 11, 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (12, 12, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (13, 13, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (14, 14, 1, 0, CAST(10.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (15, 14, 2, 0, CAST(0.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (16, 15, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (17, 16, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (18, 17, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (19, 18, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (20, 19, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (21, 20, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (22, 20, 1, 20, CAST(0.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (23, 21, 1, 5, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (24, 22, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (25, 23, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (26, 24, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (27, 25, 2, 20, CAST(0.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (28, 26, 1, 20, CAST(0.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (29, 27, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (30, 28, 1, 30, CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (31, 29, 2, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (32, 30, 1, 20, CAST(0.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (33, 31, 2, 20, CAST(0.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (34, 32, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (35, 33, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (36, 33, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (37, 33, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (38, 33, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (39, 34, 2, 20, CAST(0.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (40, 35, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (41, 35, 3, 10, CAST(0.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (42, 36, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (43, 37, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (44, 38, 2, 20, CAST(0.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (45, 38, 3, 10, CAST(0.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (46, 39, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (47, 39, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (48, 40, 1, 20, CAST(0.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (49, 41, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (50, 42, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (51, 43, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (52, 44, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (53, 45, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (54, 46, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (55, 47, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (56, 48, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (57, 49, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (58, 50, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (59, 51, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (60, 52, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (61, 53, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (62, 54, 1, 10, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (63, 54, 2, 10, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (64, 55, 1, 120, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (65, 56, 6, 480, CAST(0.00 AS Decimal(18, 2)), CAST(3700.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (66, 57, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (67, 57, 6, 240, CAST(0.00 AS Decimal(18, 2)), CAST(1850.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (68, 58, 2, 600, CAST(0.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (69, 59, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (70, 60, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (71, 61, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (72, 62, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (73, 63, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (74, 63, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (75, 64, 1, 60, CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_Saledetail] ([SDetailID], [Invoice#], [ProductID], [Quantity], [Discount], [TotalAmount], [Ctn], [ProfitLoss], [RetailPrice]) VALUES (76, 64, 2, 24, CAST(0.00 AS Decimal(18, 2)), CAST(420.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), CAST(210.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[tbl_Saledetail] OFF
SET IDENTITY_INSERT [dbo].[tbl_SaleMAster] ON 

INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (1, CAST(100 AS Decimal(18, 0)), CAST(N'2019-09-27 14:10:02.377' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (2, CAST(2500 AS Decimal(18, 0)), CAST(N'2019-09-28 21:40:09.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (3, CAST(100 AS Decimal(18, 0)), CAST(N'2019-09-29 00:17:47.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (4, CAST(100 AS Decimal(18, 0)), CAST(N'2019-09-29 00:19:48.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (5, CAST(250 AS Decimal(18, 0)), CAST(N'2019-09-29 00:21:28.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (6, CAST(250 AS Decimal(18, 0)), CAST(N'2019-09-29 00:26:00.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (7, CAST(100 AS Decimal(18, 0)), CAST(N'2019-09-29 00:33:14.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (8, CAST(0 AS Decimal(18, 0)), CAST(N'2019-09-29 00:34:33.000' AS DateTime), 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (9, CAST(100 AS Decimal(18, 0)), CAST(N'2019-09-29 00:37:04.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (10, CAST(250 AS Decimal(18, 0)), CAST(N'2019-09-29 00:53:59.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (11, CAST(100 AS Decimal(18, 0)), CAST(N'2019-09-29 00:58:06.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (12, CAST(500 AS Decimal(18, 0)), CAST(N'2019-09-29 01:07:21.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (13, CAST(500 AS Decimal(18, 0)), CAST(N'2019-09-29 16:22:28.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (14, CAST(2000 AS Decimal(18, 0)), CAST(N'2019-10-04 21:01:13.000' AS DateTime), 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (15, CAST(500 AS Decimal(18, 0)), CAST(N'2019-10-06 23:46:57.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (16, CAST(2000 AS Decimal(18, 0)), CAST(N'2019-10-06 23:50:52.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (17, CAST(250 AS Decimal(18, 0)), CAST(N'2019-10-06 23:56:48.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (18, CAST(2000 AS Decimal(18, 0)), CAST(N'2019-10-18 00:45:28.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (19, CAST(2000 AS Decimal(18, 0)), CAST(N'2019-10-18 00:54:22.000' AS DateTime), 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (20, CAST(3000 AS Decimal(18, 0)), CAST(N'2019-10-19 17:24:48.000' AS DateTime), 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (21, CAST(250 AS Decimal(18, 0)), CAST(N'2019-10-26 14:06:08.000' AS DateTime), 3, CAST(200.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (22, CAST(500 AS Decimal(18, 0)), CAST(N'2019-10-28 14:32:51.000' AS DateTime), 2, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (23, CAST(500 AS Decimal(18, 0)), CAST(N'2019-10-28 14:45:08.000' AS DateTime), 2, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (24, CAST(500 AS Decimal(18, 0)), CAST(N'2019-11-06 14:42:10.000' AS DateTime), 3, CAST(200.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (25, CAST(4000 AS Decimal(18, 0)), CAST(N'2019-11-06 14:59:17.000' AS DateTime), 3, CAST(3000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (26, CAST(1000 AS Decimal(18, 0)), CAST(N'2019-11-06 15:22:01.000' AS DateTime), 3, CAST(1000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (27, CAST(500 AS Decimal(18, 0)), CAST(N'2019-11-12 14:40:22.000' AS DateTime), 2, CAST(500.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (28, CAST(1500 AS Decimal(18, 0)), CAST(N'2019-11-12 14:43:41.000' AS DateTime), 2, CAST(1000.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (29, CAST(0 AS Decimal(18, 0)), CAST(N'2019-11-12 14:49:09.000' AS DateTime), 3, CAST(1500.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (30, CAST(1000 AS Decimal(18, 0)), CAST(N'2019-11-19 15:35:55.000' AS DateTime), 2, CAST(0.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (31, CAST(5000 AS Decimal(18, 0)), CAST(N'2019-11-20 17:32:37.000' AS DateTime), 3, CAST(5000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (32, CAST(2500 AS Decimal(18, 0)), CAST(N'2019-11-20 17:42:43.000' AS DateTime), 2, CAST(2500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (33, CAST(2500 AS Decimal(18, 0)), CAST(N'2019-11-20 17:47:35.000' AS DateTime), 2, CAST(2500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (34, CAST(4000 AS Decimal(18, 0)), CAST(N'2019-12-01 14:50:24.000' AS DateTime), 5, CAST(3000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (35, CAST(2600 AS Decimal(18, 0)), CAST(N'2019-12-03 15:46:21.000' AS DateTime), 3, CAST(4500.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (36, CAST(500 AS Decimal(18, 0)), CAST(N'2020-01-02 13:26:20.000' AS DateTime), 2, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (37, CAST(2000 AS Decimal(18, 0)), CAST(N'2020-07-07 15:18:22.000' AS DateTime), 2, CAST(1800.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (38, CAST(4600 AS Decimal(18, 0)), CAST(N'2020-07-09 02:35:48.000' AS DateTime), 3, CAST(4000.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (39, CAST(2500 AS Decimal(18, 0)), CAST(N'2020-07-09 02:41:15.000' AS DateTime), 3, CAST(2000.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (40, CAST(1000 AS Decimal(18, 0)), CAST(N'2020-07-09 02:43:57.000' AS DateTime), 3, CAST(500.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (41, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-09 02:46:06.000' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (42, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-09 02:48:32.000' AS DateTime), 2, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (43, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-09 02:50:52.000' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (44, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-09 02:56:09.000' AS DateTime), 2, CAST(250.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (45, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:34:39.000' AS DateTime), 2, CAST(400.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (46, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:38:11.000' AS DateTime), 2, CAST(400.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (47, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:43:26.000' AS DateTime), 2, CAST(400.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (48, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:46:23.000' AS DateTime), 2, CAST(400.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (49, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:49:33.000' AS DateTime), 2, CAST(200.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (50, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:50:36.000' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (51, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:54:13.000' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (52, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:55:23.000' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (53, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-12 13:56:19.000' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (54, CAST(2500 AS Decimal(18, 0)), CAST(N'2020-07-15 00:00:00.000' AS DateTime), 2, CAST(2000.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (55, CAST(500 AS Decimal(18, 0)), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 3, CAST(400.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'Owais', NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (56, CAST(3700 AS Decimal(18, 0)), CAST(N'2020-07-27 00:00:00.000' AS DateTime), 2, CAST(3000.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), N'Arif', NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (57, CAST(2100 AS Decimal(18, 0)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), 11, CAST(2000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'Owais', NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (58, CAST(10000 AS Decimal(18, 0)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), 11, CAST(5000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), N'Owais', NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (59, CAST(250 AS Decimal(18, 0)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), 14, CAST(200.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), N'Owais', NULL)
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (60, CAST(250 AS Decimal(18, 0)), CAST(N'2020-08-30 00:00:00.000' AS DateTime), 2, CAST(250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Arif', CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (61, CAST(250 AS Decimal(18, 0)), CAST(N'2020-08-30 00:00:00.000' AS DateTime), 2, CAST(250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Arif', CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (62, CAST(250 AS Decimal(18, 0)), CAST(N'2020-08-30 00:00:00.000' AS DateTime), 2, CAST(250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Arif', CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (63, CAST(250 AS Decimal(18, 0)), CAST(N'2020-08-31 00:00:00.000' AS DateTime), 3, CAST(250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Arif', CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[tbl_SaleMAster] ([Invoice#], [TotalAmount], [SaleDate], [CustomerID], [Payment], [DuePayment], [OrderBy], [ProfitLoss]) VALUES (64, CAST(670 AS Decimal(18, 0)), CAST(N'2020-08-31 00:00:00.000' AS DateTime), 2, CAST(650.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), N'Arif', CAST(110.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[tbl_SaleMAster] OFF
SET IDENTITY_INSERT [dbo].[Tbl_SaleRecovery] ON 

INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (1, 2, NULL, CAST(1500.00 AS Decimal(18, 2)), CAST(N'2020-07-12 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (2, 2, 13, CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-07-28 01:49:59.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (3, 14, NULL, CAST(1000.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (4, 14, NULL, CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (5, 14, NULL, CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (6, 14, NULL, CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (7, 14, NULL, CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (8, 14, NULL, CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_SaleRecovery] ([SRecoveryID], [CustomerID], [RInvoice], [ReturnCash], [RecoveryDate], [RecoveryBatchNo]) VALUES (9, 14, NULL, CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-22 00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Tbl_SaleRecovery] OFF
SET IDENTITY_INSERT [dbo].[Tbl_SaleTransaction] ON 

INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (1, 2, 54, 0, CAST(400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-12 14:29:31.000' AS DateTime), CAST(1650.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (2, 2, 0, 2, CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(N'2020-07-12 00:00:00.000' AS DateTime), CAST(150.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (3, 2, 54, NULL, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-15 00:00:00.000' AS DateTime), CAST(650.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (4, 3, 55, NULL, CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-25 00:00:00.000' AS DateTime), CAST(1725.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (5, 2, 56, NULL, CAST(700.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-27 00:00:00.000' AS DateTime), CAST(1350.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (6, NULL, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-07-28 01:49:59.000' AS DateTime), CAST(1300.00 AS Decimal(18, 2)), N'Debit', 13)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (7, 11, 57, NULL, CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(100.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (8, 11, 58, NULL, CAST(5000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(5100.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (9, 14, NULL, NULL, CAST(4000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(4000.00 AS Decimal(18, 2)), N'Opening Balance', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (10, 14, 59, NULL, CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(4050.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (11, NULL, NULL, 3, CAST(0.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(3050.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (12, NULL, NULL, 4, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(2550.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (13, NULL, NULL, 5, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(2050.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (14, NULL, NULL, 6, CAST(0.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(2000.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (15, NULL, NULL, 7, CAST(0.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(2000.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (16, 14, NULL, 8, CAST(0.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(2000.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (17, 14, NULL, 9, CAST(0.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(N'2020-08-22 00:00:00.000' AS DateTime), CAST(1950.00 AS Decimal(18, 2)), N'Debit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (18, 2, 60, NULL, CAST(90.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-22 00:00:00.000' AS DateTime), CAST(1390.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (19, 2, 60, NULL, CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-22 00:00:00.000' AS DateTime), CAST(1490.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (20, 2, 60, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-30 00:00:00.000' AS DateTime), CAST(1490.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (21, 2, 61, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-30 00:00:00.000' AS DateTime), CAST(1490.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (22, 2, 62, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-30 00:00:00.000' AS DateTime), CAST(1490.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (23, 3, 63, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-31 00:00:00.000' AS DateTime), CAST(1725.00 AS Decimal(18, 2)), N'Credit', NULL)
INSERT [dbo].[Tbl_SaleTransaction] ([STId], [CustomerID], [Invoice#], [SRecoveryID], [Credit], [Debit], [Date], [Balance], [Description], [RInvoice]) VALUES (24, 2, 64, NULL, CAST(20.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-31 00:00:00.000' AS DateTime), CAST(1510.00 AS Decimal(18, 2)), N'Credit', NULL)
SET IDENTITY_INSERT [dbo].[Tbl_SaleTransaction] OFF
SET IDENTITY_INSERT [dbo].[Tbl_SubZone] ON 

INSERT [dbo].[Tbl_SubZone] ([SubRouteId], [SubRouteName], [ZoneID]) VALUES (1, N'G9/1', 1)
SET IDENTITY_INSERT [dbo].[Tbl_SubZone] OFF
SET IDENTITY_INSERT [dbo].[tbl_Zone] ON 

INSERT [dbo].[tbl_Zone] ([ZoneID], [ZoneName]) VALUES (1, N'Karachi Company(G9)')
INSERT [dbo].[tbl_Zone] ([ZoneID], [ZoneName]) VALUES (4, N'Blue Area')
SET IDENTITY_INSERT [dbo].[tbl_Zone] OFF
/****** Object:  StoredProcedure [dbo].[SP_Cate_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Cate_AddNew]
@CategoryID int
As
Begin
Select max(isnull(CategoryID,0)+1)As CategoryID from tbl_Category
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Cate_Delete]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Cate_Delete]
@CategoryID int
As
Begin
Delete from tbl_Category where CategoryID=@CategoryID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Cate_Search]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Cate_Search]
@CategoryID int
As
Begin
select * from tbl_Category where CategoryID=@CategoryID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Cate_Update]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Cate_Update]
@CategoryID int,
@CategoryName varchar(50)
As
Begin
update tbl_Category set CategoryName=@CategoryName where CategoryID=@CategoryID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Ctn_Update]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Ctn_Update]
@Ctn decimal,
@ProductID int,
@Action int
As
Begin
if(@Action=1)
update tbl_Product set Ctn= Ctn-@Ctn where ProductID=@ProductID
else if(@Action=2)
update tbl_Product set Ctn= Ctn+@Ctn where ProductID=@ProductID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Cus_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Cus_AddNew]
@CustomerID int=0
as
Begin
select Top 1 max(isnull(CustomerID,0)+1) as CustomerID from tbl_Customer
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Cus_Search]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Cus_Search]
@CustomerID int=null
As

begin

select * from View_tbl_Customer where(@CustomerID is null or CustomerID=@CustomerID) 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CustomerCheck15Days]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CustomerCheck15Days]

as
begin
select * from View_tbl_Customer where CustomerID not in (
select distinct IsNull(CustomerId,0)CustomerID from Tbl_SaleTransaction where Date>=DATEADD(DAY,-15,GetDate()))
and DuePayment>0


end
GO
/****** Object:  StoredProcedure [dbo].[SP_CusType_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  Procedure [dbo].[SP_CusType_AddNew]
@CusTypeID int=0
As
Begin
select top 1 max(isnull(CusTypeID,0)+1) As CusTypeID from tbl_CustomerTypes
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Employee_AllSalary]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Employee_AllSalary]
@EmployeeID Int


As

begin



Select Name,Cnic,Contact,Address,Designation,SalaryDate,EmployeeID,Salary,SalaryID,AsignDate ,ResignDate,
case Status
when 1 then 'Active'
when 0 then 'Not Active' end[Status] from View_Employee where EmployeeID=@EmployeeID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Employee_Salary]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Employee_Salary]

@SalaryID int

As

begin



Select * ,case Status
when 1 then 'Active'
when 0 then 'Not Active' end[Status] from View_Employee where SalaryID=@SalaryID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Employee_view]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Employee_view]
As
Begin
Select EmployeeID,Name,Fname,Username,Password,Qualifiction,DOB,Cnic,Contact,Designation,Address,Salary,AsignDate,LoginType, 
Case Gender
when 1 then 'Male'
when 0 then 'Female'
end[Gender]
 from View_Employee_Login 
End
GO
/****** Object:  StoredProcedure [dbo].[SP_EmpSalary_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_EmpSalary_AddNew] 
@SalaryID int=0
As

Begin
Select top 1 max(isnull(SalaryID,0)+1) As SalaryID from tbl_Employee_Salary
End
GO
/****** Object:  StoredProcedure [dbo].[Sp_Expense]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[Sp_Expense]
@MinDate Datetime,
@MaxDate Datetime
as 
begin
select * from tbl_Expense where Date between @MinDate and @MaxDate
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PInvoice_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_PInvoice_AddNew]
@PInvoice int=0
as

begin
select top 1 max(isnull(PInvoice,0)+1) as PInvoice from  Tbl_PurchaseMaster
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PReturn_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_PReturn_AddNew]
@PReturnID int=0
As

begin 
select top 1 max(isnull(PReturnID,0)+1) as PReturnID from Tbl_PurchaseReturn_Master 
end

GO
/****** Object:  StoredProcedure [dbo].[SP_Price_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Price_AddNew]
@ProductPriceId int=0
as
Begin
select Top 1 max(isnull(ProductPriceId,0)+1) as ProductPriceId from tbl_ProductPrice
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Prod_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_Prod_AddNew]
@ProductID int =0
as

begin
select top 1 max(isnull(ProductID,0)+1) as ProductID from tbl_Product
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ProductPrice_view]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ProductPrice_view]
As
Begin
Select ProductPriceId,ProductID,ProductName,BuyerPrice,SellerPrice,AddedDate,
Case IsActive
when 1 then 'Active'
when 0 then 'Not Active'
end[IsActive]
 from  View_ProductPrice
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Purchase_ByCom]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Purchase_ByCom]
@CompanyID int
as

begin
select InvoiceNo,CompanyID,CompanyName,Contact,Date,GrandTotal,Payment,Balance from View_DetailPurchase where CompanyID=@CompanyID
end

GO
/****** Object:  StoredProcedure [dbo].[SP_Purchase_DateDiff]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Purchase_DateDiff]
@mindate datetime,
@maxdate datetime
as

begin
select InvoiceNo,CompanyName,Contact,Date,GrandTotal,Payment,Balance,[New Balance] from View_DetailPurchase where Date between @mindate and @maxdate
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PurchaseInvoice_Search]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_PurchaseInvoice_Search]
 @PInvoice int
 As
 begin
 Select *  from View_DetailPurchase where InvoiceNo = @PInvoice 
 End
GO
/****** Object:  StoredProcedure [dbo].[SP_PurLedger]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_PurLedger]
@CompanyID int
as
Begin 
Select * from View_PurLedger where CompanyID = @CompanyID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_PurRemain_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_PurRemain_AddNew]
@PRemainID int=0
As
Begin
Select top 1 max(isnull(PRemainID,0)+1) As RemainID from tbl_PurchaseRemain
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PurRemain_ComID]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_PurRemain_ComID]
@ComID int
AS

begin

select * from View_Pur_Remain where CompanyID=@ComID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PurRemain_RemainID]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_PurRemain_RemainID]
@RemainID int
AS

begin
Select * from View_Pur_Remain where RemainID=@RemainID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PurReturn_ByCom]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_PurReturn_ByCom]
@ComID int
As
Begin 
Select * from View_PurReturn where CompanyID=@ComID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_PurReturn_DateDiff]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_PurReturn_DateDiff]
@MinDate Datetime,
@MaxDate Datetime

As
Begin
Select * from View_PurReturn where ReturnDate Between @MinDate and @MaxDate
End
GO
/****** Object:  StoredProcedure [dbo].[SP_PurReturn_Invoice]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_PurReturn_Invoice]
@PReturnID int
As
begin

select * from View_PurReturn where ReturnInvoiceNo =@PReturnID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Quantity_Update]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SP_Quantity_Update]
@Quantity int,
@ProductID int,
@Action int
As
Begin
if(@Action=1)
update tbl_Product set Quantity= Quantity-@Quantity where ProductID=@ProductID
else if(@Action=2)
update tbl_Product set Quantity= Quantity+@Quantity where ProductID=@ProductID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Return_ByCus]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_Return_ByCus]
@CusID int
As
Begin 
select *  from View_SaleReturn where CustomerID =@CusID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_RInvoice_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_RInvoice_AddNew]
 @RInvoice int=0
 as

 begin
 select top 1 max(isnull(RInvoice,0)+1) as RInvoice  from  Tbl_ReturnSaleMaster
 end
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleDetail_Sum]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SaleDetail_Sum]
@InvoiceNo int
As
begin 
select sum(TotalAmount) as Invoice# from [tbl_Saledetail] where Invoice#=@InvoiceNo
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleInvoice_Search]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_SaleInvoice_Search]
 @InvoiceNo int

 As

 begin
 select * from View_DetailSale where InvoiceNo=@InvoiceNo
 End
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleLedger]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_SaleLedger]
@CustomerID int
as
Begin 
Select * from View_SaleLedger where CustomerID = @CustomerID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleLedger_Route]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SaleLedger_Route]
@ZoneId int
as
begin
select * from View_tbl_Customer where ZoneId=@Zoneid and DuePayment>0
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleMas_ByCus]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SaleMas_ByCus]
@CusID Int
as

begin
select Invoice#,CustomerID,Name,SaleDate,Contact,GrandTotal from View_SaleMaster where CustomerID =@CusID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleMas_DateDiff]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SaleMas_DateDiff]
@MinDate datetime,
@MaxDate datetime
as

begin
select InvoiceNo,CustomerName,Date,GrandTotal,ProfitLoss from View_DetailSale where Date between @MinDate and @MaxDate
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleMAster]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SaleMAster]
@Invoice# int =0
as
begin
select top 1 max(isnull(Invoice#,0)+1)as Invoice# from tbl_SaleMAster
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleRecover_ByCusID]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SaleRecover_ByCusID]
@CustomerID int
As
Begin
select * from View_Sale_Recovery where CustomerID=@CustomerID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleRecover_ByRecoveryID]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SaleRecover_ByRecoveryID]
@RecoveryID int
As
Begin
select * from View_Sale_Recovery where RecoveryID=@RecoveryID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleRecovery_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SaleRecovery_AddNew] 
 @SRecoveryID int=0
As

Begin
Select top 1 max(isnull(SRecoveryID,0)+1) As SRecoveryID from Tbl_SaleRecovery
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SaleReturn_DateDiff]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_SaleReturn_DateDiff]
@MinDate datetime,
@MaxDate datetime

As
Begin
select * from View_SaleReturn where ReturnDate Between @MinDate and @MaxDate
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Search_Product]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_Search_Product]
@ProductID int =null
As
Begin 
Select * from View_tbl_Product where (@ProductID is null or ProductID=@ProductID)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Search_ReturnInvoice]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Search_ReturnInvoice]
@RinvoiceNo int
As
begin
Select * from View_SaleReturn where [Return Invoice]=@RinvoiceNo
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_BothPurchase]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Procedure [dbo].[SP_Update_BothPurchase]
@Quantity Int,
@Amount decimal(18,2),
@PInvoice int,
@ProductID int,
@GrandTotal decimal(18,2) 

As
BEgin
--Updating Tbl_PurchaseDetail
update Tbl_PurchaseDetail set Quantity=Quantity-@Quantity,TotalAmount=@Amount where PInvoice=@PInvoice and ProductID=@ProductID
--Updating Tbl_PurchaseMaster
update Tbl_PurchaseMaster set TotalAmount=TotalAmount - @GrandTotal where PInvoice=@PInvoice
End 

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_BothSale]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_Update_BothSale]
@Quantity int,
@ProductID int,
@InvoiceID int,
@TotalAmount decimal(18,2),
@GrandTotal decimal(18,1)
AS
Begin 
--Updating Tbl_SalesDetails
update tbl_Saledetail set TotalAmount=@TotalAmount, Quantity=(Quantity - @Quantity) where invoice#=@InvoiceID and ProductID=@ProductID
--Updating Tbl_SalesMaster
update tbl_SaleMaster set TotalAmount =TotalAmount-@GrandTotal where Invoice#=@InvoiceID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_DuePayment]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_Update_DuePayment]
@CustomerID int,
@DuePayment decimal(18,2),
@prmtype int
As

begin 
if(@prmtype=1)
update tbl_Customer set DuePayment=DuePayment+@DuePayment where CustomerID=@CustomerID
else if(@prmtype=2)
update tbl_Customer set DuePayment=DuePayment-@DuePayment where CustomerID=@CustomerID

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_PReturn_DuePayment]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Update_PReturn_DuePayment]
@CompanyID int,
@DuePayment decimal (18,2),
@Action int
as
Begin
if (@Action=1)
update tbl_Company set DuePayment=DuePayment + @DuePayment where CompanyID=@CompanyID
else if(@Action=2)
update tbl_Company set DuePayment=DuePayment - @DuePayment where CompanyID=@CompanyID
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_Zone_AddNew]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Zone_AddNew]
@ZoneID int=0
as
begin
select Top 1 max(isnull(ZoneID,0)+1)as ZoneID from tbl_Zone
End
GO
/****** Object:  StoredProcedure [dbo].[SPAddNewCom]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPAddNewCom]
@CompanyID int
As
BEgin
select max(isnull(CompanyID,0))+1 As CompanyID from tbl_Company
End
GO
/****** Object:  StoredProcedure [dbo].[SPAddNewEmp]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPAddNewEmp]
@EmployeeID int
As
begin 

select max(ISNULL(EmployeeID,0))+1 As EmployeeID from tbl_employee
end
GO
/****** Object:  StoredProcedure [dbo].[SPSelectCom]    Script Date: 9/3/2020 12:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPSelectCom]
@ComID int =null
As
begin
select * from tbl_Company where(@ComID is null or CompanyID=@ComID)

End
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[23] 2[31] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Product"
            Begin Extent = 
               Top = 22
               Left = 622
               Bottom = 152
               Right = 792
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Tbl_PurchaseDetail"
            Begin Extent = 
               Top = 13
               Left = 413
               Bottom = 143
               Right = 583
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Tbl_PurchaseMaster"
            Begin Extent = 
               Top = 18
               Left = 231
               Bottom = 148
               Right = 401
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "tbl_Company"
            Begin Extent = 
               Top = 26
               Left = 34
               Bottom = 156
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DetailPurchase'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DetailPurchase'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -96
      End
      Begin Tables = 
         Begin Table = "tbl_SaleMAster"
            Begin Extent = 
               Top = 12
               Left = 394
               Bottom = 142
               Right = 564
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "tbl_Saledetail"
            Begin Extent = 
               Top = 4
               Left = 589
               Bottom = 134
               Right = 759
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "tbl_Customer"
            Begin Extent = 
               Top = 19
               Left = 145
               Bottom = 149
               Right = 315
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Product"
            Begin Extent = 
               Top = 5
               Left = 771
               Bottom = 135
               Right = 941
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DetailSale'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DetailSale'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DetailSale'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_employee"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "tbl_Employee_Salary"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Employee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Employee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_employee"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "tbl_Login_Type"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Employee_Login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Employee_Login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Product"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_ProductPrice"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProductPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProductPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_PurchaseRemain"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbl_Company"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 419
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Tbl_PurchaseReturn_Master"
            Begin Extent = 
               Top = 6
               Left = 457
               Bottom = 136
               Right = 627
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Pur_Remain'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Pur_Remain'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tbl_PurTransaction"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "tbl_Company"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 419
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PurLedger'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PurLedger'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[41] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tbl_PurchaseReturn_Master"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Tbl_PurchaseReturn_Detail"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tbl_Company"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 136
               Right = 629
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Tbl_PurchaseMaster"
            Begin Extent = 
               Top = 6
               Left = 667
               Bottom = 136
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Product"
            Begin Extent = 
               Top = 6
               Left = 875
               Bottom = 136
               Right = 1045
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
      ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PurReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'   Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PurReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PurReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Customer"
            Begin Extent = 
               Top = 29
               Left = 331
               Bottom = 159
               Right = 501
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Tbl_SaleRecovery"
            Begin Extent = 
               Top = 28
               Left = 30
               Bottom = 158
               Right = 200
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Tbl_ReturnSaleMaster"
            Begin Extent = 
               Top = 6
               Left = 539
               Bottom = 136
               Right = 709
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Sale_Recovery'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Sale_Recovery'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tbl_SaleTransaction"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "tbl_Customer"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Tbl_SubZone"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 119
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SaleLedger'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SaleLedger'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_SaleMAster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tbl_Customer"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SaleMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SaleMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[32] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tbl_ReturnSaleMaster"
            Begin Extent = 
               Top = 19
               Left = 409
               Bottom = 149
               Right = 579
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tbl_SaleMAster"
            Begin Extent = 
               Top = 17
               Left = 210
               Bottom = 147
               Right = 380
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Customer"
            Begin Extent = 
               Top = 9
               Left = 0
               Bottom = 139
               Right = 170
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Tbl_ReturnSaleDetail"
            Begin Extent = 
               Top = 6
               Left = 617
               Bottom = 136
               Right = 787
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "tbl_Product"
            Begin Extent = 
               Top = 6
               Left = 825
               Bottom = 136
               Right = 995
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SaleReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SaleReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SaleReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tbl_SubZone"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Zone"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 102
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubZone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubZone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[32] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Customer"
            Begin Extent = 
               Top = 26
               Left = 300
               Bottom = 156
               Right = 470
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "tbl_CustomerTypes"
            Begin Extent = 
               Top = 46
               Left = 89
               Bottom = 142
               Right = 259
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Zone"
            Begin Extent = 
               Top = 0
               Left = 526
               Bottom = 96
               Right = 696
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tbl_SubZone"
            Begin Extent = 
               Top = 95
               Left = 643
               Bottom = 208
               Right = 815
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_tbl_Customer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_tbl_Customer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Product"
            Begin Extent = 
               Top = 40
               Left = 257
               Bottom = 170
               Right = 427
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "tbl_Company"
            Begin Extent = 
               Top = 44
               Left = 24
               Bottom = 174
               Right = 197
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Category"
            Begin Extent = 
               Top = 6
               Left = 457
               Bottom = 102
               Right = 627
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pr"
            Begin Extent = 
               Top = 174
               Left = 38
               Bottom = 304
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_tbl_Product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_tbl_Product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[31] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Product"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tbl_Saledetail"
            Begin Extent = 
               Top = 6
               Left = 254
               Bottom = 136
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tbl_SaleMAster"
            Begin Extent = 
               Top = 12
               Left = 481
               Bottom = 142
               Right = 651
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tbl_Customer"
            Begin Extent = 
               Top = 23
               Left = 672
               Bottom = 153
               Right = 842
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
       ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'  GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSales'
GO
USE [master]
GO
ALTER DATABASE [CashCarry] SET  READ_WRITE 
GO
