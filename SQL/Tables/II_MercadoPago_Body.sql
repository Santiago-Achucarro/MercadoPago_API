USE [SummaAdv]
GO

/****** Object:  Table [dbo].[II_MercadoPago_Body]    Script Date: 17/01/2025 9:16:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[II_MercadoPago_Body](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[merchant_Order] [varchar](31) NULL,
	[payment_ID] [varchar](31) NULL,
	[status] [varchar](31) NULL,
	[external_reference] [varchar](31) NULL,
	[transaction_amount] [numeric](19, 8) NULL,
	[total_paid_amount] [numeric](19, 8) NULL,
	[date_created] [varchar](51) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


