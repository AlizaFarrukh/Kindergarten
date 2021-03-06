USE [KinderGarten]
GO
/****** Object:  Table [dbo].[SASignUp]    Script Date: 12/6/2018 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SASignUp](
	[UserID] [nchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[ConfirmPassword] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SASignUp] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
