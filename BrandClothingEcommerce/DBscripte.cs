//USE[DbBrandClothingEcommerce]
//GO
///****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[__EFMigrationsHistory](
//    [MigrationId][nvarchar](150) NOT NULL,
//    [ProductVersion][nvarchar](32) NOT NULL,
// CONSTRAINT[PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED
//(
//    [MigrationId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[AspNetRoleClaims](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [RoleId][nvarchar](450) NOT NULL,
//    [ClaimType][nvarchar](max) NULL,
//    [ClaimValue][nvarchar](max) NULL,
// CONSTRAINT[PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[AspNetRoles]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[AspNetRoles](
//    [Id][nvarchar](450) NOT NULL,
//    [Name][nvarchar](256) NULL,
//    [NormalizedName][nvarchar](256) NULL,
//    [ConcurrencyStamp][nvarchar](max) NULL,
// CONSTRAINT[PK_AspNetRoles] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[AspNetUserClaims](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [UserId][nvarchar](450) NOT NULL,
//    [ClaimType][nvarchar](max) NULL,
//    [ClaimValue][nvarchar](max) NULL,
// CONSTRAINT[PK_AspNetUserClaims] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[AspNetUserLogins](
//    [LoginProvider][nvarchar](450) NOT NULL,
//    [ProviderKey][nvarchar](450) NOT NULL,
//    [ProviderDisplayName][nvarchar](max) NULL,
//    [UserId][nvarchar](450) NOT NULL,
// CONSTRAINT[PK_AspNetUserLogins] PRIMARY KEY CLUSTERED
//(
//    [LoginProvider] ASC,
//    [ProviderKey] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[AspNetUserRoles](
//    [UserId][nvarchar](450) NOT NULL,
//    [RoleId][nvarchar](450) NOT NULL,
// CONSTRAINT[PK_AspNetUserRoles] PRIMARY KEY CLUSTERED
//(
//    [UserId] ASC,
//    [RoleId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[AspNetUsers]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[AspNetUsers](
//    [Id][nvarchar](450) NOT NULL,
//    [UserName][nvarchar](256) NULL,
//    [NormalizedUserName][nvarchar](256) NULL,
//    [Email][nvarchar](256) NULL,
//    [NormalizedEmail][nvarchar](256) NULL,
//    [EmailConfirmed][bit] NOT NULL,
//    [PasswordHash][nvarchar](max) NULL,
//    [SecurityStamp][nvarchar](max) NULL,
//    [ConcurrencyStamp][nvarchar](max) NULL,
//    [PhoneNumber][nvarchar](max) NULL,
//    [PhoneNumberConfirmed][bit] NOT NULL,
//    [TwoFactorEnabled][bit] NOT NULL,
//    [LockoutEnd][datetimeoffset](7) NULL,
//    [LockoutEnabled][bit] NOT NULL,
//    [AccessFailedCount][int] NOT NULL,
// CONSTRAINT[PK_AspNetUsers] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[AspNetUserTokens](
//    [UserId][nvarchar](450) NOT NULL,
//    [LoginProvider][nvarchar](450) NOT NULL,
//    [Name][nvarchar](450) NOT NULL,
//    [Value][nvarchar](max) NULL,
// CONSTRAINT[PK_AspNetUserTokens] PRIMARY KEY CLUSTERED
//(
//    [UserId] ASC,
//    [LoginProvider] ASC,
//    [Name] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[CartDetail]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[CartDetail](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [ShoppingCartId][int] NOT NULL,
//    [ProductId][int] NOT NULL,
//    [Quantity][int] NOT NULL,
//    [UnitPrice][float] NOT NULL,
// CONSTRAINT[PK_CartDetail] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Order]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[Order](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [UserId][nvarchar](max) NOT NULL,
//    [CreateDate][datetime2](7) NOT NULL,
//    [OrderStatusId][int] NOT NULL,
//    [IsDeleted][bit] NOT NULL,
// CONSTRAINT[PK_Order] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[OrderDetail]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[OrderDetail](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [OrderId][int] NOT NULL,
//    [ProductId][int] NOT NULL,
//    [Quantity][int] NOT NULL,
//    [UnitPrice][float] NOT NULL,
// CONSTRAINT[PK_OrderDetail] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[OrderStatus]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[OrderStatus](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [StatusId][int] NOT NULL,
//    [StatusName][nvarchar](20) NOT NULL,
// CONSTRAINT[PK_OrderStatus] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Product]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[Product](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [ProductName][nvarchar](40) NOT NULL,
//    [Price][float] NOT NULL,
//    [Image][nvarchar](max) NULL,
//    [TypeOfСlothingId][int] NOT NULL,
// CONSTRAINT[PK_Product] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[ShoppingCart]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[ShoppingCart](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [UserId][nvarchar](max) NOT NULL,
//    [IsDelete][bit] NOT NULL,
// CONSTRAINT[PK_ShoppingCart] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[TypeOfСlothing]    Script Date: 01.12.2023 15:25:30 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[TypeOfСlothing](
//    [Id][int] IDENTITY(1, 1) NOT NULL,
//    [TypeName][nvarchar](40) NOT NULL,
// CONSTRAINT[PK_TypeOfСlothing] PRIMARY KEY CLUSTERED
//(
//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
//INSERT[dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES(N'00000000000000_CreateIdentitySchema', N'7.0.10')
//INSERT[dbo].[__EFMigrationsHistory]([MigrationId], [ProductVersion]) VALUES(N'20230928134841_added-tables', N'7.0.10')
//INSERT[dbo].[__EFMigrationsHistory]([MigrationId], [ProductVersion]) VALUES(N'20231001125752_xyz', N'7.0.10')
//GO
//INSERT[dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES(N'0c78f4e5-561c-4ada-a485-6ae322a1ea70', N'User', N'USER', NULL)
//INSERT[dbo].[AspNetRoles]([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES(N'6e58d975-984d-43f7-9cc9-f386389699e4', N'Admin', N'ADMIN', NULL)
//GO
//INSERT[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'8e19d756-4afe-4e62-b3d2-c6ad8e767e80', N'0c78f4e5-561c-4ada-a485-6ae322a1ea70')
//INSERT[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'bb6e9073-65d2-4b25-b82c-69d0b2ffe913', N'0c78f4e5-561c-4ada-a485-6ae322a1ea70')
//INSERT[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'ef3791ea-47d2-476d-8c2b-84238b7f1eb6', N'0c78f4e5-561c-4ada-a485-6ae322a1ea70')
//INSERT[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', N'6e58d975-984d-43f7-9cc9-f386389699e4')
//GO
//INSERT[dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'8e19d756-4afe-4e62-b3d2-c6ad8e767e80', N'test@gmail.com', N'TEST@GMAIL.COM', N'test@gmail.com', N'TEST@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEFlVcXmZNJOSmOcbuqgd0tPazZBGtkQ1SSyVVbIcndOnotbk7GF95pnln1j64ptVvw==', N'LQOUAARERBO2WR7ETIK27FU54M4RYODH', N'cbf6b672-2ae2-4d15-b5c3-fb3ab0ab4f72', NULL, 0, 0, NULL, 1, 0)
//INSERT[dbo].[AspNetUsers]([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'bb6e9073-65d2-4b25-b82c-69d0b2ffe913', N'vadimvoroncov47@gmail.com', N'VADIMVORONCOV47@GMAIL.COM', N'vadimvoroncov47@gmail.com', N'VADIMVORONCOV47@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAENvZ9RuLKsvobjroRKMya/yyi4VIUjyacOvk/kBJcNGeirfEtgVFDsf5TWBwfRVZGg==', N'SKX6MDFWGB6L6QYO7USAKMRWBEIFTTB2', N'00e5fe18-19d4-48ba-89a5-865f8168498f', NULL, 0, 0, NULL, 1, 0)
//INSERT[dbo].[AspNetUsers]([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEMKhXpZVLv2HwAXUgVAtampw+djqll8h6FZy2OmyEsr3fEbuBts67eKPaRPbnp5ddA==', N'ACQ4LLCQM63CGNGAEF74G4MZY36CMYBN', N'8a754961-3db9-4c3f-aa0a-7353ac9e35c9', NULL, 0, 0, NULL, 1, 0)
//INSERT[dbo].[AspNetUsers]([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'ef3791ea-47d2-476d-8c2b-84238b7f1eb6', N'Proverka@gmail.com', N'PROVERKA@GMAIL.COM', N'Proverka@gmail.com', N'PROVERKA@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAELqiSUoWnT26KCwwgujP6gB++US1vWzNdwIu+vxhcF9h4HDdchOGdn89w96HFVj+7A==', N'P3PDA3XG6O4ICITLKVOZ5VDPBRCBC5UJ', N'aa8b4897-48f7-4a7a-8882-659876aceabe', NULL, 0, 0, NULL, 1, 0)
//GO
//SET IDENTITY_INSERT [dbo].[Order] ON

//INSERT[dbo].[Order] ([Id], [UserId], [CreateDate], [OrderStatusId], [IsDeleted]) VALUES(1, N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', CAST(N'2023-10-01T13:15:53.9234037' AS DateTime2), 1, 0)
//INSERT[dbo].[Order]([Id], [UserId], [CreateDate], [OrderStatusId], [IsDeleted]) VALUES(2, N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', CAST(N'2023-10-01T16:00:12.7111530' AS DateTime2), 1, 0)
//INSERT[dbo].[Order]([Id], [UserId], [CreateDate], [OrderStatusId], [IsDeleted]) VALUES(3, N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', CAST(N'2023-11-26T12:18:28.4940285' AS DateTime2), 1, 0)
//INSERT[dbo].[Order]([Id], [UserId], [CreateDate], [OrderStatusId], [IsDeleted]) VALUES(4, N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', CAST(N'2023-11-30T10:29:20.9838710' AS DateTime2), 1, 0)
//INSERT[dbo].[Order]([Id], [UserId], [CreateDate], [OrderStatusId], [IsDeleted]) VALUES(5, N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', CAST(N'2023-11-30T10:29:25.9480651' AS DateTime2), 1, 0)
//INSERT[dbo].[Order]([Id], [UserId], [CreateDate], [OrderStatusId], [IsDeleted]) VALUES(6, N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', CAST(N'2023-11-30T10:29:51.9070885' AS DateTime2), 1, 0)
//SET IDENTITY_INSERT[dbo].[Order] OFF
//GO
//SET IDENTITY_INSERT [dbo].[OrderDetail] ON

//INSERT[dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(1, 1, 3, 1, 70.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(2, 1, 5, 1, 130)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(3, 1, 6, 1, 99.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(4, 2, 2, 1, 50)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(5, 2, 3, 1, 70.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(6, 2, 5, 1, 130)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(7, 2, 6, 1, 99.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(8, 3, 2, 2, 50)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(9, 3, 3, 2, 70.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(10, 3, 5, 2, 130)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(11, 3, 6, 1, 99.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(12, 4, 5, 1, 130)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(13, 4, 3, 1, 70.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(14, 4, 2, 1, 50)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(15, 4, 6, 1, 99.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(16, 5, 3, 1, 70.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(17, 5, 5, 1, 130)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(18, 5, 6, 1, 99.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(19, 6, 3, 1, 70.99)
//INSERT[dbo].[OrderDetail]([Id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES(20, 6, 5, 1, 130)
//SET IDENTITY_INSERT[dbo].[OrderDetail] OFF
//GO
//SET IDENTITY_INSERT [dbo].[OrderStatus] ON

//INSERT[dbo].[OrderStatus] ([Id], [StatusId], [StatusName]) VALUES(1, 1, N'Pending')
//INSERT[dbo].[OrderStatus]([Id], [StatusId], [StatusName]) VALUES(2, 2, N'Shipped')
//INSERT[dbo].[OrderStatus]([Id], [StatusId], [StatusName]) VALUES(3, 3, N'Delivered')
//INSERT[dbo].[OrderStatus]([Id], [StatusId], [StatusName]) VALUES(5, 4, N'Cancelled')
//INSERT[dbo].[OrderStatus]([Id], [StatusId], [StatusName]) VALUES(6, 5, N'Retruned')
//INSERT[dbo].[OrderStatus]([Id], [StatusId], [StatusName]) VALUES(7, 6, N'Refund')
//SET IDENTITY_INSERT[dbo].[OrderStatus] OFF
//GO
//SET IDENTITY_INSERT [dbo].[Product] ON

//INSERT[dbo].[Product] ([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(2, N'Bold Basics', 50, N'T-shirts1.jpg', 1)
//INSERT[dbo].[Product]([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(3, N'Summer Stride', 70.99, N'shorts1.jpg', 2)
//INSERT[dbo].[Product]([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(5, N'Effortless Edge', 130, N'Pants1.jpg', 3)
//INSERT[dbo].[Product]([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(6, N'Cozy Commute', 99.99, N'zip-hoodie1.jpg', 4)
//INSERT[dbo].[Product]([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(8, N'Feminine Flair', 66.5, N'T-shirts2.jpg', 1)
//INSERT[dbo].[Product]([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(9, N'Warm Embrace', 80.5, N'shorts2.jpg', 2)
//INSERT[dbo].[Product]([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(11, N'Sleek Shield', 120, N'Pants2.jpg', 3)
//INSERT[dbo].[Product]([Id], [ProductName], [Price], [Image], [TypeOfСlothingId]) VALUES(12, N'Active Attitude', 88, N'zip-hoodie2.jpg', 4)
//SET IDENTITY_INSERT[dbo].[Product] OFF
//GO
//SET IDENTITY_INSERT [dbo].[ShoppingCart] ON

//INSERT[dbo].[ShoppingCart] ([Id], [UserId], [IsDelete]) VALUES(1, N'df8cabc8-77a2-4729-94e0-9efb9a1b57d3', 0)
//SET IDENTITY_INSERT[dbo].[ShoppingCart] OFF
//GO
//SET IDENTITY_INSERT [dbo].[TypeOfСlothing] ON

//INSERT[dbo].[TypeOfСlothing] ([Id], [TypeName]) VALUES(1, N'T-shirt')
//INSERT[dbo].[TypeOfСlothing]([Id], [TypeName]) VALUES(2, N'shorts')
//INSERT[dbo].[TypeOfСlothing]([Id], [TypeName]) VALUES(3, N'pants')
//INSERT[dbo].[TypeOfСlothing]([Id], [TypeName]) VALUES(4, N'zip-hoodies')
//SET IDENTITY_INSERT[dbo].[TypeOfСlothing] OFF
//GO
//ALTER TABLE [dbo].[CartDetail] ADD DEFAULT((0.0000000000000000e+000)) FOR[UnitPrice]
//GO
//ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
//REFERENCES[dbo].[AspNetRoles]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT[FK_AspNetRoleClaims_AspNetRoles_RoleId]
//GO
//ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
//REFERENCES[dbo].[AspNetUsers]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT[FK_AspNetUserClaims_AspNetUsers_UserId]
//GO
//ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
//REFERENCES[dbo].[AspNetUsers]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT[FK_AspNetUserLogins_AspNetUsers_UserId]
//GO
//ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
//REFERENCES[dbo].[AspNetRoles]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT[FK_AspNetUserRoles_AspNetRoles_RoleId]
//GO
//ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
//REFERENCES[dbo].[AspNetUsers]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT[FK_AspNetUserRoles_AspNetUsers_UserId]
//GO
//ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
//REFERENCES[dbo].[AspNetUsers]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT[FK_AspNetUserTokens_AspNetUsers_UserId]
//GO
//ALTER TABLE [dbo].[CartDetail]  WITH CHECK ADD  CONSTRAINT [FK_CartDetail_Product_ProductId] FOREIGN KEY([ProductId])
//REFERENCES[dbo].[Product]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[CartDetail] CHECK CONSTRAINT[FK_CartDetail_Product_ProductId]
//GO
//ALTER TABLE [dbo].[CartDetail]  WITH CHECK ADD  CONSTRAINT [FK_CartDetail_ShoppingCart_ShoppingCartId] FOREIGN KEY([ShoppingCartId]) 
//REFERENCES[dbo].[ShoppingCart]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[CartDetail] CHECK CONSTRAINT[FK_CartDetail_ShoppingCart_ShoppingCartId]
//GO
//ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_OrderStatus_OrderStatusId] FOREIGN KEY([OrderStatusId])
//REFERENCES[dbo].[OrderStatus]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[Order] CHECK CONSTRAINT[FK_Order_OrderStatus_OrderStatusId]
//GO
//ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order_OrderId] FOREIGN KEY([OrderId])
//REFERENCES[dbo].[Order]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT[FK_OrderDetail_Order_OrderId]
//GO
//ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product_ProductId] FOREIGN KEY([ProductId])
//REFERENCES[dbo].[Product]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT[FK_OrderDetail_Product_ProductId]
//GO
//ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_TypeOfСlothing_TypeOfСlothingId] FOREIGN KEY([TypeOfСlothingId])
//REFERENCES[dbo].[TypeOfСlothing]([Id])
//ON DELETE CASCADE
//GO
//ALTER TABLE [dbo].[Product] CHECK CONSTRAINT[FK_Product_TypeOfСlothing_TypeOfСlothingId]
//GO

