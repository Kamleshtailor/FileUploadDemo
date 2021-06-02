CREATE TABLE [dbo].[UserDetails](
	[UserId] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserEmail] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO