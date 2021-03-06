USE [BD]
GO
/****** Object:  Table [dbo].[Carrier]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carrier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Carrier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cast]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Person] [int] NOT NULL,
	[Role] [int] NOT NULL,
	[Film] [int] NOT NULL,
	[Character] [varchar](50) NULL,
 CONSTRAINT [PK_Cast] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Country]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Film]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Film](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Genre] [int] NOT NULL,
	[ProductionDate] [date] NULL,
	[ProductionCompany] [int] NOT NULL,
	[Duration] [int] NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Genre](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hire]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hire](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Inmate] [int] NOT NULL,
	[Specimen] [int] NOT NULL,
	[Rentaldate] [date] NOT NULL,
	[Returned] [bit] NOT NULL,
 CONSTRAINT [PK_Hire] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inmate]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inmate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Inmate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Location]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Location](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Place] [varchar](50) NOT NULL,
	[LocationType] [int] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocationType]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LocationType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Location Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Country] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductionCompany]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductionCompany](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ProductionCompany] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductionCountry]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionCountry](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Film] [int] NOT NULL,
	[Country] [int] NOT NULL,
 CONSTRAINT [PK_ProductionCountry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Specimen]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specimen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Film] [int] NOT NULL,
	[Carrier] [int] NULL,
	[Location] [int] NOT NULL,
	[DateAdded] [date] NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Specimen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](31) NOT NULL,
	[HashedPassword] [varchar](255) NULL,
	[Inmate] [int] NOT NULL,
	[Admin] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Borrowed]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Borrowed]
AS
SELECT        f.Name AS Film, i.Name AS Inmate, h.Rentaldate
FROM            dbo.Hire AS h LEFT OUTER JOIN
                         dbo.Specimen AS s ON s.Id = h.Specimen LEFT OUTER JOIN
                         dbo.Inmate AS i ON i.Id = h.Inmate LEFT OUTER JOIN
                         dbo.Film AS f ON f.Id = s.Film
WHERE        (h.Returned = 0)

GO
/****** Object:  View [dbo].[WishList]    Script Date: 21.12.2017 23:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[WishList]
AS
SELECT        f.Id, f.Name, f.ProductionDate, f.Duration
FROM            dbo.Film AS f LEFT OUTER JOIN
                         dbo.Specimen AS s ON s.Film = f.Id LEFT OUTER JOIN
                         dbo.Genre AS g ON f.Genre = g.Id LEFT OUTER JOIN
                         dbo.ProductionCompany AS p ON p.Id = f.ProductionCompany
WHERE        (s.Id IS NULL)

GO
SET IDENTITY_INSERT [dbo].[Carrier] ON 

INSERT [dbo].[Carrier] ([Id], [Name]) VALUES (1, N'VHS')
INSERT [dbo].[Carrier] ([Id], [Name]) VALUES (2, N'DVD')
INSERT [dbo].[Carrier] ([Id], [Name]) VALUES (3, N'Blu-Ray')
INSERT [dbo].[Carrier] ([Id], [Name]) VALUES (4, N'Karta pamięci')
INSERT [dbo].[Carrier] ([Id], [Name]) VALUES (5, N'Dysk twardy')
SET IDENTITY_INSERT [dbo].[Carrier] OFF
SET IDENTITY_INSERT [dbo].[Cast] ON 

INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (1, 1, 3, 5, N'Frodo Baggins')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (2, 2, 3, 5, N'Gandalf Biały')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (3, 3, 1, 5, NULL)
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (4, 5, 3, 5, N'Saruman')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (5, 6, 3, 5, N'Pippin')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (6, 8, 3, 4, N'Harry Potter')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (7, 9, 3, 4, N'Ron Wesley')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (8, 10, 3, 4, N'Severus Snape')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (9, 11, 3, 4, N'Luna Lovegood')
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (10, 13, 5, 7, NULL)
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (11, 13, 5, 20, NULL)
INSERT [dbo].[Cast] ([Id], [Person], [Role], [Film], [Character]) VALUES (12, 14, 5, 4, NULL)
SET IDENTITY_INSERT [dbo].[Cast] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name]) VALUES (21, N'Austia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (12, N'Australia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (18, N'Belgia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (16, N'Brazylia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (11, N'Chiny')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (5, N'Czechy')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (9, N'Francja')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (10, N'Hiszpania')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (17, N'Holandia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (4, N'Indie')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (20, N'Irlandia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (22, N'Kanada')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (15, N'Meksyk')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (3, N'Niemcy')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (13, N'Nowa Zelandia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (1, N'Polska')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (8, N'Rosja')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (6, N'Serbia')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (19, N'Słowacja')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (7, N'Ukraina')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (2, N'USA')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (14, N'Wielka Brytania')
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Film] ON 

INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (4, N'Harry Potter i Komnata Tajemnic', 5, CAST(N'2003-01-01' AS Date), 1, 160)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (5, N'Władca Pierścieni: Powrót Króla', 5, CAST(N'2003-12-01' AS Date), 7, 200)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (7, N'Forrest Gump', 3, CAST(N'1994-06-23' AS Date), 3, 142)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (8, N'Opowieści z Narnii: Lew, Czarownica i Stara szafa', 5, CAST(N'2005-12-07' AS Date), 2, 143)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (9, N'Zielona Mila', 15, CAST(N'1996-12-06' AS Date), 1, 188)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (10, N'Titanic', 10, CAST(N'1997-11-01' AS Date), 8, 194)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (11, N'Faceci w czerni', 3, CAST(N'1997-07-02' AS Date), 9, 98)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (12, N'Marsjanin', 16, CAST(N'2015-09-11' AS Date), 10, 141)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (13, N'Interstellar', 17, CAST(N'2014-10-26' AS Date), 1, 169)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (15, N'Thor', 5, CAST(N'2011-04-17' AS Date), 11, 114)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (17, N'Iron Man', 5, CAST(N'2008-04-14' AS Date), 11, 126)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (18, N'Avatar', 17, CAST(N'2009-12-10' AS Date), 8, 162)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (19, N'Atomowy amant', 3, CAST(N'1999-01-27' AS Date), 7, 112)
INSERT [dbo].[Film] ([Id], [Name], [Genre], [ProductionDate], [ProductionCompany], [Duration]) VALUES (20, N'Powrót do Przyszłości', 5, CAST(N'1985-07-03' AS Date), 5, 116)
SET IDENTITY_INSERT [dbo].[Film] OFF
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([Id], [Name]) VALUES (1, N'Animowany')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (2, N'Biograficzny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (3, N'Komedia')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (4, N'Horror')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (5, N'Przygodowy')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (6, N'Sensacyjny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (7, N'Kryminalny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (8, N'Dokumentalny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (9, N'Fabularny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (10, N'Melodramat')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (11, N'Pornograficzny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (12, N'Wojenny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (13, N'Historyczny')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (14, N'Western')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (15, N'Dramat')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (16, N'Akcja')
INSERT [dbo].[Genre] ([Id], [Name]) VALUES (17, N'Sci-Fi')
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[Inmate] ON 

INSERT [dbo].[Inmate] ([Id], [Name]) VALUES (1, N'Karolina')
INSERT [dbo].[Inmate] ([Id], [Name]) VALUES (2, N'Kuba')
INSERT [dbo].[Inmate] ([Id], [Name]) VALUES (3, N'Marysia')
INSERT [dbo].[Inmate] ([Id], [Name]) VALUES (4, N'Natalia')
INSERT [dbo].[Inmate] ([Id], [Name]) VALUES (5, N'Mateusz')
INSERT [dbo].[Inmate] ([Id], [Name]) VALUES (6, N'Madzia')
SET IDENTITY_INSERT [dbo].[Inmate] OFF
SET IDENTITY_INSERT [dbo].[Location] ON 

INSERT [dbo].[Location] ([Id], [Place], [LocationType]) VALUES (1, N'Pokój Kuby', 6)
INSERT [dbo].[Location] ([Id], [Place], [LocationType]) VALUES (2, N'Pokój Mateusza', 6)
INSERT [dbo].[Location] ([Id], [Place], [LocationType]) VALUES (3, N'Przedpokój', 6)
INSERT [dbo].[Location] ([Id], [Place], [LocationType]) VALUES (4, N'Piwnica', 6)
INSERT [dbo].[Location] ([Id], [Place], [LocationType]) VALUES (5, N'http://cda-x.pl/filmy/iron-man/', 5)
INSERT [dbo].[Location] ([Id], [Place], [LocationType]) VALUES (6, N'http://cda-x.pl/filmy/titanic/', 5)
SET IDENTITY_INSERT [dbo].[Location] OFF
SET IDENTITY_INSERT [dbo].[LocationType] ON 

INSERT [dbo].[LocationType] ([Id], [Name]) VALUES (1, N'OneDrive')
INSERT [dbo].[LocationType] ([Id], [Name]) VALUES (2, N'Google Drive')
INSERT [dbo].[LocationType] ([Id], [Name]) VALUES (3, N'Netflix')
INSERT [dbo].[LocationType] ([Id], [Name]) VALUES (4, N'HBO GO')
INSERT [dbo].[LocationType] ([Id], [Name]) VALUES (5, N'Inna lokalizacja internetowa')
INSERT [dbo].[LocationType] ([Id], [Name]) VALUES (6, N'Fizyczna')
SET IDENTITY_INSERT [dbo].[LocationType] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (1, N'Elijah', N'Wood', 2)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (2, N'Ian', N'McKellen', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (3, N'Peter', N'Jackson', 13)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (4, N'Martin', N'Freeman', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (5, N'Christopher', N'Lee', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (6, N'Orlando', N'Bloom', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (7, N'Billy', N'Boyd', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (8, N'Daniel', N'Radcliffe', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (9, N'Rupert', N'Grint', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (10, N'Alan', N'Rickman', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (11, N'Evanna', N'Lynch', 20)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (12, N'Benedict', N'Cumberbatch', 14)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (13, N'Alan', N'Silvestri', 2)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (14, N'John', N'Williams', 2)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (15, N'Arnold', N'Schwarzenegger', 21)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (16, N'Harrison', N'Ford', 2)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (17, N'Matt', N'Smith', 12)
INSERT [dbo].[Person] ([Id], [Name], [Surname], [Country]) VALUES (18, N'David', N'Tennant', 14)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[ProductionCompany] ON 

INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (1, N'Warner Bros.')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (2, N'Disney')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (3, N'Paramount Pictures')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (4, N'DreamWorks')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (5, N'Universal Pictures')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (6, N'Wytwórnia Filmów Dokumentalnych i Fabularnych (WFDiF)')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (7, N'New Line Cinema')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (8, N'20th Century Fox')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (9, N'Amblin Entertainment')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (10, N'Scott Film Productions')
INSERT [dbo].[ProductionCompany] ([Id], [Name]) VALUES (11, N'Marvel Studios')
SET IDENTITY_INSERT [dbo].[ProductionCompany] OFF
SET IDENTITY_INSERT [dbo].[ProductionCountry] ON 

INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (1, 4, 14)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (2, 5, 13)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (3, 5, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (5, 7, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (6, 8, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (7, 8, 14)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (8, 9, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (9, 10, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (10, 11, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (11, 12, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (12, 12, 14)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (13, 13, 22)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (14, 13, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (15, 13, 14)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (16, 15, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (17, 17, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (18, 18, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (19, 18, 14)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (20, 19, 2)
INSERT [dbo].[ProductionCountry] ([Id], [Film], [Country]) VALUES (21, 20, 2)
SET IDENTITY_INSERT [dbo].[ProductionCountry] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [Name]) VALUES (1, N'Reżyser')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (2, N'Scenarzysta')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (3, N'Aktor')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (4, N'Scenograf')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (5, N'Kompozytor')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Specimen] ON 

INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (2, 4, 2, 1, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (5, 5, 3, 2, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (6, 7, 2, 2, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (7, 7, 1, 1, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (8, 9, 5, 3, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (9, 12, 3, 2, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (10, 19, 1, 4, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (11, 20, 1, 4, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (12, 7, 1, 4, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (13, 9, 1, 1, CAST(N'2017-12-21' AS Date), 1)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (14, 17, NULL, 5, CAST(N'2016-12-01' AS Date), 0)
INSERT [dbo].[Specimen] ([Id], [Film], [Carrier], [Location], [DateAdded], [Active]) VALUES (18, 10, NULL, 6, CAST(N'2016-11-11' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Specimen] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Login], [HashedPassword], [Inmate], [Admin], [Active]) VALUES (1, N'admin', NULL, 2, 1, 1)
INSERT [dbo].[User] ([Id], [Login], [HashedPassword], [Inmate], [Admin], [Active]) VALUES (2, N'karolina1', NULL, 1, 0, 1)
INSERT [dbo].[User] ([Id], [Login], [HashedPassword], [Inmate], [Admin], [Active]) VALUES (3, N'landryna', NULL, 3, 0, 1)
INSERT [dbo].[User] ([Id], [Login], [HashedPassword], [Inmate], [Admin], [Active]) VALUES (4, N'natashka', NULL, 4, 0, 0)
INSERT [dbo].[User] ([Id], [Login], [HashedPassword], [Inmate], [Admin], [Active]) VALUES (5, N'bortek', NULL, 5, 1, 1)
INSERT [dbo].[User] ([Id], [Login], [HashedPassword], [Inmate], [Admin], [Active]) VALUES (6, N'mahda22', NULL, 6, 0, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [C_CountryName]    Script Date: 21.12.2017 23:23:36 ******/
ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [C_CountryName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cast]  WITH CHECK ADD  CONSTRAINT [FK_Cast_Film] FOREIGN KEY([Film])
REFERENCES [dbo].[Film] ([Id])
GO
ALTER TABLE [dbo].[Cast] CHECK CONSTRAINT [FK_Cast_Film]
GO
ALTER TABLE [dbo].[Cast]  WITH CHECK ADD  CONSTRAINT [FK_Cast_Person] FOREIGN KEY([Person])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Cast] CHECK CONSTRAINT [FK_Cast_Person]
GO
ALTER TABLE [dbo].[Cast]  WITH CHECK ADD  CONSTRAINT [FK_Cast_Role] FOREIGN KEY([Role])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[Cast] CHECK CONSTRAINT [FK_Cast_Role]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_Genre] FOREIGN KEY([Genre])
REFERENCES [dbo].[Genre] ([Id])
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_Genre]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_ProductionCompany] FOREIGN KEY([ProductionCompany])
REFERENCES [dbo].[ProductionCompany] ([Id])
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_ProductionCompany]
GO
ALTER TABLE [dbo].[Hire]  WITH CHECK ADD  CONSTRAINT [FK_Hire_Inmate] FOREIGN KEY([Inmate])
REFERENCES [dbo].[Inmate] ([Id])
GO
ALTER TABLE [dbo].[Hire] CHECK CONSTRAINT [FK_Hire_Inmate]
GO
ALTER TABLE [dbo].[Hire]  WITH CHECK ADD  CONSTRAINT [FK_Hire_Specimen] FOREIGN KEY([Specimen])
REFERENCES [dbo].[Specimen] ([Id])
GO
ALTER TABLE [dbo].[Hire] CHECK CONSTRAINT [FK_Hire_Specimen]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Location Type] FOREIGN KEY([LocationType])
REFERENCES [dbo].[LocationType] ([Id])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Location Type]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Country] FOREIGN KEY([Country])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Country]
GO
ALTER TABLE [dbo].[ProductionCountry]  WITH CHECK ADD  CONSTRAINT [FK_ProductionCountry_Country] FOREIGN KEY([Id])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[ProductionCountry] CHECK CONSTRAINT [FK_ProductionCountry_Country]
GO
ALTER TABLE [dbo].[Specimen]  WITH CHECK ADD  CONSTRAINT [FK_Specimen_Carrier] FOREIGN KEY([Carrier])
REFERENCES [dbo].[Carrier] ([Id])
GO
ALTER TABLE [dbo].[Specimen] CHECK CONSTRAINT [FK_Specimen_Carrier]
GO
ALTER TABLE [dbo].[Specimen]  WITH CHECK ADD  CONSTRAINT [FK_Specimen_Film] FOREIGN KEY([Film])
REFERENCES [dbo].[Film] ([Id])
GO
ALTER TABLE [dbo].[Specimen] CHECK CONSTRAINT [FK_Specimen_Film]
GO
ALTER TABLE [dbo].[Specimen]  WITH CHECK ADD  CONSTRAINT [FK_Specimen_Location] FOREIGN KEY([Location])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Specimen] CHECK CONSTRAINT [FK_Specimen_Location]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Inmate] FOREIGN KEY([Inmate])
REFERENCES [dbo].[Inmate] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Inmate]
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
         Begin Table = "h"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "i"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 234
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "f"
            Begin Extent = 
               Top = 138
               Left = 246
               Bottom = 268
               Right = 446
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Borrowed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Borrowed'
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
         Begin Table = "f"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 238
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 6
               Left = 276
               Bottom = 136
               Right = 446
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "g"
            Begin Extent = 
               Top = 6
               Left = 484
               Bottom = 102
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 6
               Left = 692
               Bottom = 102
               Right = 862
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'WishList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'WishList'
GO
