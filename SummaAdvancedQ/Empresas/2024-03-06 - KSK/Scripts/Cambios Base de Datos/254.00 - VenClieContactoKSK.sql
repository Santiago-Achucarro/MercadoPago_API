USE [SummaAdv]
GO

/****** Object:  Table [dbo].[espvenClieContactoKSK]    Script Date: 08/11/2022 11:39:01 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[espvenClieContactoKSK](
	[Cliente_Id] [bigint] NOT NULL,
	[Sucursal] [dbo].[SucursalN] NOT NULL,
	[NroContacto] [int] NOT NULL,
	[Instragram] [varchar](120) NULL,
	[Facebook] [varchar](120) NULL,
	[Linkedin] [varchar](120) NULL,
	[Youtube] [varchar](120) NULL,
 CONSTRAINT [XPKespvenClieContactoKSK] PRIMARY KEY CLUSTERED 
(
	[Cliente_Id] ASC,
	[Sucursal] ASC,
	[NroContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[espvenClieContactoKSK]  WITH CHECK ADD  CONSTRAINT [espvenClieContacto] FOREIGN KEY([Cliente_Id], [Sucursal], [NroContacto])
REFERENCES [dbo].[venClieContacto] ([Cliente_Id], [Sucursal], [NroContacto])
GO

ALTER TABLE [dbo].[espvenClieContactoKSK] CHECK CONSTRAINT [espvenClieContacto]
GO


