USE [SummaAdv]
GO

/****** Object:  Table [dbo].[II_MercadoPago_Hdr]    Script Date: 17/01/2025 9:18:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[II_MercadoPago_Hdr](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[merchant_Order] [varchar](31) NULL,
	[payment_ID] [varchar](31) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


