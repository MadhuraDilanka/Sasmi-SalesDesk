CREATE DATABASE [POS System]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Category Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Config]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config](
	[Key] [nvarchar](50) NOT NULL,
	[Value] [nvarchar](50) NULL,
	[Value2] [nvarchar](50) NULL,
 CONSTRAINT [PK_Config] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone Number] [nvarchar](50) NULL,
	[NIC] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan](
	[LoanID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[CustomerID] [int] NULL,
	[SaleName] [nvarchar](100) NULL,
	[Date] [nvarchar](100) NULL,
	[Time] [nvarchar](100) NULL,
	[CostAmount] [bigint] NULL,
	[TotalAmount] [nvarchar](100) NULL,
	[Profit] [bigint] NULL,
	[NDate] [nvarchar](100) NULL,
 CONSTRAINT [PK_Loan] PRIMARY KEY CLUSTERED 
(
	[LoanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan_Payments]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan_Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[Payment] [bigint] NULL,
 CONSTRAINT [PK_Loan_Payments] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginUsers]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginUsers](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoginUsers] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Product Name] [nvarchar](50) NULL,
	[ProductPrice] [float] NULL,
	[Quantity] [float] NULL,
	[Selling Price] [float] NULL,
	[Discount] [float] NULL,
	[New Selling Price] [float] NULL,
	[Item Profit] [float] NULL,
	[TotalPrice] [float] NULL,
	[Total Selling Price] [float] NULL,
	[Total Profit] [float] NULL,
	[CategoryID] [int] NULL,
	[Category] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL,
	[AvailableQuantity] [float] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[SaleName] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[Time] [nvarchar](50) NULL,
	[Cost] [float] NULL,
	[Selling Price] [float] NULL,
	[Profit] [float] NULL,
	[NDate] [date] NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesTempTable]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesTempTable](
	[SalesID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[Product Name] [nvarchar](50) NULL,
	[Cost] [float] NULL,
	[Price] [float] NULL,
	[Discount] [float] NULL,
	[Qty] [float] NULL,
	[Total Cost] [float] NULL,
	[Amount] [float] NULL,
	[Sale Profit] [float] NULL,
 CONSTRAINT [PK_SalesTempTable] PRIMARY KEY CLUSTERED 
(
	[SalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleTempInformation]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleTempInformation](
	[SaleTempID] [int] NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[Product CostPrice] [float] NULL,
	[Quantity] [float] NULL,
	[Total Cost] [float] NULL,
	[ItemSellPrice] [float] NULL,
	[Discount] [float] NULL,
	[New ItemSellPrice] [float] NULL,
	[Total Sell Price] [float] NULL,
	[ItemProfit] [float] NULL,
	[Total ItemProfit] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AddCustomers]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddCustomers] (@CustomerName nvarchar(50), 
@CustomerAddress nvarchar(100), @CustomerMail nvarchar(50), @CustomerPhone nvarchar(50), @CustomerNIC nvarchar(50))
AS
BEGIN
	INSERT INTO [dbo].[Customers] ([Name], [Address], [Email], [Phone Number], [NIC])
	VALUES (@CustomerName, @CustomerAddress, @CustomerMail, @CustomerPhone, @CustomerNIC)
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteCustomer](@customerID int)
AS
BEGIN
	DELETE FROM [dbo].[Customers] WHERE [CustomerID] = @customerID;
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteInsertCategory]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteInsertCategory] (@categoryID INT)
AS
BEGIN
	DELETE FROM [dbo].[Category] WHERE [CategoryID] = @categoryID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteProduct] (@productID INT)
AS
BEGIN
	DELETE FROM [dbo].[Products] WHERE [ProductID] = @productID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteSalesItems]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteSalesItems]
AS
BEGIN
	DELETE FROM [dbo].[SalesTempTable]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomer]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCustomer]
AS
BEGIN
	SELECT * FROM [dbo].[Customers]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllCustomers]
AS
BEGIN
	SELECT * FROM [dbo].[Customers]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllLoans]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllLoans]
AS
BEGIN
	SELECT [LoanID], [CustomerName] as Customer, [SaleName] as Sale_Name, [Date], [Time], [TotalAmount] as Amount
	 FROM [dbo].[Loan]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllProduct]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllProduct]
AS
BEGIN
	SELECT * FROM [dbo].[Products]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllProductForTableView]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllProductForTableView]
AS
BEGIN
	SELECT [ProductID],[Product Name] as Product_Name,[ProductPrice] as Item_Cost,[Quantity],[AvailableQuantity] as Available,
	[TotalPrice] as Total_Cost, [Selling Price],[Discount],[CategoryID],[Category],[Description] FROM [dbo].[Products]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllSalesTable]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllSalesTable]
AS
BEGIN
	SELECT * FROM [dbo].[Sales]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllTempSales]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllTempSales]
AS
BEGIN
	SELECT * FROM [dbo].[SalesTempTable]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAmountFromSalesTempTable]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAmountFromSalesTempTable]
AS
BEGIN
	SELECT [Amount] FROM [dbo].[SalesTempTable]
END

GO
/****** Object:  StoredProcedure [dbo].[GetAvailablePaymentBycustomerID]    Script Date: 2/20/2021 6:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAvailablePaymentBycustomerID](@customerID int)
AS
BEGIN
	SELECT [Payment] FROM [dbo].[Loan_Payments] WHERE [CustomerID] = @customerID
END

GO
/****** Object:  StoredProcedure [dbo].[GetCategories]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCategories]
AS
BEGIN
	SELECT * FROM [dbo].[Category]
END

GO
/****** Object:  StoredProcedure [dbo].[GetFullCustomerNameAndId]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetFullCustomerNameAndId]
AS
BEGIN
	SELECT [CustomerID],[Name] FROM [dbo].[Customers]
END

GO
/****** Object:  StoredProcedure [dbo].[GetLoanByCustomerID]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetLoanByCustomerID](@customerID int)
AS
BEGIN
	SELECT [LoanID], [CustomerName] as Customer, [SaleName] as Sale_Name, [Date], [Time], [TotalAmount] as Amount
	 FROM [dbo].[Loan] where [CustomerID] = @customerID
END

GO
/****** Object:  StoredProcedure [dbo].[GetProductsByProductID]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetProductsByProductID] (@productID INT)
AS
BEGIN
	SELECT * FROM [dbo].[Products] WHERE [ProductID] = @productID
END

GO
/****** Object:  StoredProcedure [dbo].[GetProductsForSales]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetProductsForSales]
AS
BEGIN
	SELECT [ProductID],[Product Name], [Selling Price], [AvailableQuantity] as AvailableQty, [dbo].[Products].Discount,[Description] FROM [dbo].[Products]
END

GO
/****** Object:  StoredProcedure [dbo].[GetSalesByDateBetween]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetSalesByDateBetween](@from nvarchar(50), @to nvarchar(50))
AS
BEGIN
	SELECT [SaleID],[SaleName],[Date],[Time],[Cost],[Selling Price],[Profit] FROM [dbo].[Sales] WHERE [NDate] BETWEEN @from AND @to
END

GO
/****** Object:  StoredProcedure [dbo].[GetSalesInforForDate]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetSalesInforForDate](@SalesDate nvarchar(50))
AS
BEGIN
	SELECT * FROM [dbo].[Sales] WHERE [Date] LIKE @SalesDate
END

GO
/****** Object:  StoredProcedure [dbo].[GetSearchProductsByCategory]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetSearchProductsByCategory] (@CategoryID INT)
AS
BEGIN
	SELECT [ProductID],[Product Name], [Selling Price], [AvailableQuantity] as AvailableQty, [dbo].[Products].Discount,[Description] FROM [dbo].[Products] WHERE [CategoryID] = @CategoryID
END

GO
/****** Object:  StoredProcedure [dbo].[GetTempareySalesData]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetTempareySalesData]
AS
BEGIN
	SELECT [SalesID] AS ID,[Product Name],[Price],[Discount],[Qty],[Amount] FROM [dbo].[SalesTempTable]
END

GO
/****** Object:  StoredProcedure [dbo].[GetTotalCostFromSalesTempTable]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetTotalCostFromSalesTempTable]
AS
BEGIN
	SELECT [Cost] FROM [dbo].[SalesTempTable]
END

GO
/****** Object:  StoredProcedure [dbo].[GetUserNameAndPassword]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetUserNameAndPassword]
AS
BEGIN
	SELECT * FROM [dbo].[LoginUsers]
END

GO
/****** Object:  StoredProcedure [dbo].[GetValueByKeyFromConfig]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetValueByKeyFromConfig] (@key nvarchar(50))
AS
BEGIN
	SELECT [Value], [Value2] FROM [dbo].[Config] WHERE [Key] = @key
END

GO
/****** Object:  StoredProcedure [dbo].[InsertCategory]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertCategory] (@categoryName nvarchar(50))
AS
BEGIN
	INSERT INTO [dbo].[Category]([Category Name]) VALUES (@categoryName)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertLoan]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertLoan] (@CustomerName nvarchar(100), @CustomerID int, @SaleName nvarchar(100), @Date nvarchar(100),
@Time nvarchar(100),@CostAmount bigint, @TotalAmount nvarchar(100), @Profit bigint, 
@NDate nvarchar(100))
AS
BEGIN
	INSERT INTO [dbo].[Loan] ([CustomerName], [CustomerID], [SaleName], [Date], [Time], [CostAmount], [TotalAmount],
	[Profit], [NDate])
	VALUES(@CustomerName, @CustomerID, @SaleName, @Date, @Time, @CostAmount, @TotalAmount, @Profit, @NDate);
END

GO
/****** Object:  StoredProcedure [dbo].[InsertProduct]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertProduct] (@ProductName nvarchar(50), @ProductPrice float, @Quantity float, 
@SellingPrice float, @Discount float, @NewSellingPrice float, @ItemProfit float, @TotalPrice float, 
@TotalSellingPrice float, @TotalProfit float, @CategoryID INT, @Category nvarchar(50), 
@Description nvarchar(200), @AvailableQty float)
AS
BEGIN
	INSERT INTO [dbo].[Products]([Product Name], [ProductPrice], [Quantity], [Selling Price], [Discount], 
	[New Selling Price], [Item Profit], [TotalPrice], [Total Selling Price], [Total Profit], [CategoryID],
	[Category], [Description], [AvailableQuantity])
	VALUES(@ProductName, @ProductPrice, @Quantity, @SellingPrice, @Discount, @NewSellingPrice, @ItemProfit, 
	@TotalPrice, @TotalSellingPrice, @TotalProfit, @CategoryID, @Category, @Description, @AvailableQty);
END

GO
/****** Object:  StoredProcedure [dbo].[InsertSalesToTempTable]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertSalesToTempTable] (@productID INT, @productName nvarchar(50), 
@cost float, @price float, @discount float, @qty float, @totalCost float, @amount float, @saleProfit float)
AS
BEGIN
	INSERT INTO [dbo].[SalesTempTable] ([ProductID],[Product Name],[Cost],[Price],[Discount],
	[Qty],[Total Cost],[Amount],[Sale Profit])
	VALUES(@productID,@productName,@cost,@price,@discount,@qty,@totalCost,@amount,@saleProfit)
END

GO
/****** Object:  StoredProcedure [dbo].[KeywordSearchProductsData]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KeywordSearchProductsData](@Keyword nvarchar(100))
AS
BEGIN
	SELECT [ProductID],[Product Name], [Selling Price], [AvailableQuantity] as AvailableQty, [dbo].[Products].Discount,[Description] FROM [dbo].[Products]
	WHERE [Product Name] LIKE @Keyword
END

GO
/****** Object:  StoredProcedure [dbo].[loginVerificationDetails]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[loginVerificationDetails] (@Username nvarchar(50), @Password nvarchar(50))
AS
BEGIN
	SELECT '#' FROM [dbo].[LoginUsers]
	WHERE [UserName] = @Username
	AND [Password] = @Password
END

GO
/****** Object:  StoredProcedure [dbo].[RemoveSaleItemFromID]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RemoveSaleItemFromID] (@saleID INT)
AS
BEGIN
	DELETE FROM [dbo].[SalesTempTable] WHERE [SalesID] = @saleID
END

GO
/****** Object:  StoredProcedure [dbo].[SaveLoanPayment]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SaveLoanPayment](@customerID int, @Payment bigint)
AS
BEGIN
	INSERT INTO [dbo].[Loan_Payments] ([CustomerID], [Payment]) 
	VALUES(@customerID, @Payment)
END

GO
/****** Object:  StoredProcedure [dbo].[SavePassword]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SavePassword](@oldPassword nvarchar(50), @newPassword nvarchar(50))
AS
BEGIN
	UPDATE [dbo].[LoginUsers] SET [Password] = @newPassword WHERE [Password] = @oldPassword
END

GO
/****** Object:  StoredProcedure [dbo].[SaveUserName]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SaveUserName](@olduserName nvarchar(50), @newuserName nvarchar(50))
AS
BEGIN
	UPDATE [dbo].[LoginUsers] SET [UserName] = @newuserName WHERE [UserName] = @olduserName
END

GO
/****** Object:  StoredProcedure [dbo].[SetSaleRecords]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SetSaleRecords](@SaleName nvarchar(50), @Date nvarchar(50), @Time nvarchar(50), 
@CostAmount float, @TotalAmount float, @Profit float, @Ndate date)
AS
BEGIN
	INSERT INTO [dbo].[Sales]([SaleName],[Date],[Time],[Cost],[Selling Price],[Profit],[NDate])
	VALUES(@SaleName, @Date, @Time, @CostAmount, @TotalAmount, @Profit, @Ndate)
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateAvailableQuantity]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateAvailableQuantity](@productID INT, @qty float)
AS
BEGIN
	UPDATE [dbo].[Products] SET [AvailableQuantity] = [AvailableQuantity] - @qty
	WHERE [ProductID] = @productID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCategories]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateCategories](@CategoryID INT, @CategoryName nvarchar(50))
AS
BEGIN
	UPDATE [dbo].[Category] SET [Category Name] = @CategoryName
	WHERE [CategoryID] = @CategoryID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateConfigTable]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateConfigTable] (@key nvarchar(50), @value1 nvarchar(50), @value2 nvarchar(50))
AS
BEGIN
	UPDATE [dbo].[Config] SET [Value] = @value1, [Value2] = @value2 WHERE [Key] = @key
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomers]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateCustomers] (@CustomerID int, @CustomerName nvarchar(50), 
@CustomerAddress nvarchar(100), @CustomerMail nvarchar(50), @CustomerPhone nvarchar(50), @CustomerNIC nvarchar(50))
AS
BEGIN
	UPDATE [dbo].[Customers] 
	SET [Name] = @CustomerName, [Address] = @CustomerAddress, 
	[Email] = @CustomerMail, [Phone Number] = @CustomerPhone, [NIC] = @CustomerNIC
	WHERE [CustomerID] = @CustomerID;
	
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 2/20/2021 6:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateProduct] (@ProductID INT, @ProductName nvarchar(50), @ProductPrice float, 
@Quantity float, @SellingPrice float, @Discount float, @NewSellingPrice float, @ItemProfit float, @TotalPrice float, 
@TotalSellingPrice float, @TotalProfit float, @CategoryID INT, @Category nvarchar(50), 
@Description nvarchar(200))
AS
BEGIN
	declare @perQty float;
	set @perQty = (Select [Quantity] from [dbo].[Products] where [ProductID] = @ProductID);

	UPDATE [dbo].[Products] SET [Product Name] = @ProductName, [ProductPrice] = @ProductPrice, 
	[Quantity] = @Quantity, [Selling Price] = @SellingPrice, [Discount] = @Discount, 
	[New Selling Price] = @NewSellingPrice, [Item Profit] = @ItemProfit, [TotalPrice] = @TotalPrice, 
	[Total Selling Price] = @TotalSellingPrice, [Total Profit] = @TotalProfit, [CategoryID] = @CategoryID, 
	[Category] = @Category, [Description] = @Description, 
	[AvailableQuantity] = [AvailableQuantity] + (@Quantity - @perQty)
	WHERE [ProductID] = @ProductID
END

GO
