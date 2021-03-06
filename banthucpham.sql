USE [bandoan1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01/06/2021 9:52:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameVN] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Fullname] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Members]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Members](
	[Username] [varchar](50) NOT NULL,
	[password] [varchar](255) NULL,
	[Rule] [int] NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [nvarchar](max) NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[RequireDate] [datetime2](7) NOT NULL,
	[Receiver] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Amount] [float] NOT NULL,
	[CustomerId1] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[UnitBrief] [nvarchar](max) NULL,
	[UnitPrice] [float] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[ProductDate] [datetime2](7) NOT NULL,
	[Available] [bit] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryId] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
	[Special] [bit] NOT NULL,
	[Latest] [bit] NOT NULL,
	[Views] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 01/06/2021 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210105211636_InitialCreate', N'5.0.0')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7abc8413-22d3-4648-bb0a-10959bfeac29', N'TantaiIT3000@gmail.com', N'TANTAIIT3000@GMAIL.COM', N'TantaiIT3000@gmail.com', N'TANTAIIT3000@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEM/5Pqw1zJYWIZf1q+A0BVIayB1N035RcZ3pqLfCWzmZ6qDBfio5ezrBUodXn8xK5g==', N'VB4LTN2DHRY6DRAFGH5R6XQK4SS6LGTZ', N'dc0e6627-32cd-47ba-aa04-1fff3acf7b39', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b11deb39-92b3-494d-bfcf-1da5158c3101', N'0306171389@gmail.com', N'0306171389@GMAIL.COM', N'0306171389@gmail.com', N'0306171389@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEL2/6jXTAn4KIoCo3wpZ1rhI3kAVKNUHunN8X51xW/L8RzC+aQzSqUR4Ww0J2ylJFw==', N'K4Y6WCQ6PIWOWVWEROBRG25XHZ5FDIYJ', N'04dcb285-05ea-4dc8-bb14-d020b7b29b77', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [NameVN], [Name]) VALUES (1, N'quả hạnh', N'almonds')
INSERT [dbo].[Categories] ([Id], [NameVN], [Name]) VALUES (2, N'Trái Cây Khô', N'Dry Fruit')
INSERT [dbo].[Categories] ([Id], [NameVN], [Name]) VALUES (3, N'Gạo và sản phẩm từ gạo', N'Rice and product price')
INSERT [dbo].[Categories] ([Id], [NameVN], [Name]) VALUES (4, N'hạt điều', N'cashews')
INSERT [dbo].[Categories] ([Id], [NameVN], [Name]) VALUES (5, N'Nước giải khát', N'Drink')
INSERT [dbo].[Categories] ([Id], [NameVN], [Name]) VALUES (6, N'Gia vị', N'Spice')
SET IDENTITY_INSERT [dbo].[Categories] OFF
INSERT [dbo].[Members] ([Username], [password], [Rule]) VALUES (N'Admin', N'e10adc3949ba59abbe56e057f20f883e', 0)
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [UnitBrief], [UnitPrice], [Image], [ProductDate], [Available], [Description], [CategoryId], [SupplierId], [Quantity], [Discount], [Special], [Latest], [Views]) VALUES (4, N'Parryss-Sugar', N'cai', 12, N'4.png', CAST(0x07002CB0DBB0FE410B AS DateTime2), 1, N'deleciuos foods for baby and for health', 6, 2, 3, 1.2, 1, 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [UnitBrief], [UnitPrice], [Image], [ProductDate], [Available], [Description], [CategoryId], [SupplierId], [Quantity], [Discount], [Special], [Latest], [Views]) VALUES (5, N'Saffola-Gold', N'box', 80.99, N'5.png', CAST(0x07007273FFB006420B AS DateTime2), 0, N'quality elimited, should be buoght right now', 4, 2, 3, 0, 1, 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [UnitBrief], [UnitPrice], [Image], [ProductDate], [Available], [Description], [CategoryId], [SupplierId], [Quantity], [Discount], [Special], [Latest], [Views]) VALUES (6, N'Sampann-Toor-Dal', N'box', 35.5, N'6.png', CAST(0x0700B83623B106420B AS DateTime2), 1, N'deleciuos foods for baby and for health', 3, 3, 2, 0, 1, 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [UnitBrief], [UnitPrice], [Image], [ProductDate], [Available], [Description], [CategoryId], [SupplierId], [Quantity], [Discount], [Special], [Latest], [Views]) VALUES (7, N'Toor Dal', N'box', 35.99, N'7.png', CAST(0x070044BD6AB118420B AS DateTime2), 1, N'deleciuos foods for baby and for health', 2, 4, -1, 1.2, 1, 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [UnitBrief], [UnitPrice], [Image], [ProductDate], [Available], [Description], [CategoryId], [SupplierId], [Quantity], [Discount], [Special], [Latest], [Views]) VALUES (8, N'Arhar Dal', N'box', 25.8, N'8.png', CAST(0x07008A808EB10B420B AS DateTime2), 1, N'quality elimited, should be buoght right now', 2, 4, 2, 0, 1, 1, 2)
INSERT [dbo].[Products] ([Id], [Name], [UnitBrief], [UnitPrice], [Image], [ProductDate], [Available], [Description], [CategoryId], [SupplierId], [Quantity], [Discount], [Special], [Latest], [Views]) VALUES (9, N'Sampann-Toor-Dal', N'box', 45.2, N'9.png', CAST(0x07001607D6B118420B AS DateTime2), 1, N'Salt provide iot for your brain to make everthing easier', 1, 2, 2, 1.2, 1, 1, 2)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([Id], [Name], [address], [Email], [Phone]) VALUES (2, N'Kentucky', NULL, N'Kentucky@gmail.com', N'01222026282')
INSERT [dbo].[Suppliers] ([Id], [Name], [address], [Email], [Phone]) VALUES (3, N'KavinKen', NULL, N'Kavinken@gmail.com', N'01689114396')
INSERT [dbo].[Suppliers] ([Id], [Name], [address], [Email], [Phone]) VALUES (4, N'Bakery', NULL, N'Barkery', N'01677055104')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_CustomerId1] FOREIGN KEY([CustomerId1])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_CustomerId1]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers_SupplierId] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers_SupplierId]
GO
