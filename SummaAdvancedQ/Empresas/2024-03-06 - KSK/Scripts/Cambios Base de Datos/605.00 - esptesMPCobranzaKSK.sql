USE [SummaAdv]
GO

/****** Object:  Table [dbo].[esptesMPCobranzaKSK]    Script Date: 8/12/2023 14:10:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[esptesMPCobranzaKSK](
	[id] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[external_reference] [nvarchar](50) NOT NULL,
	[pay_transaction_amount] [decimal](18, 2) NOT NULL,
	[pay_status] [nvarchar](50) NOT NULL,
	[date_created] [nvarchar](50) NOT NULL,
	[col_id] [int] NOT NULL,
	[col_email] [nvarchar](50) NOT NULL,
	[col_nickname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_esptesMPCobranzaKSK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

