CREATE TABLE [tesMoviOficial](
	[tesMovimientos] [bigint] NOT NULL,
	[Sucursal_Of] [Sucursal] NOT NULL,
	[Comprobante_Of] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tesMovimientos] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [tesMoviOficial]  WITH CHECK ADD  CONSTRAINT [STD_TMO] FOREIGN KEY([tesMovimientos])
REFERENCES [tesMovimientos] ([tesMovimientos])
GO


CREATE TABLE [tesTalonarios](
	[Sucursal] [Sucursal] NOT NULL,
	[Desde] [int] NOT NULL,
	[Hasta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sucursal] ASC,
	[Desde] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [tesTalonCobrador](
	[Sucursal] [Sucursal] NOT NULL,
	[Desde] [int] NOT NULL,
	[Cobrador_Id] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sucursal] ASC,
	[Desde] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [tesTalonCobrador]  WITH CHECK ADD  CONSTRAINT [STD_VC] FOREIGN KEY([Cobrador_Id])
REFERENCES [venCobradores] ([venCobradores])
GO


CREATE TABLE [tesRecOfiAnul](
	[Sucursal_Of] [Sucursal] NOT NULL,
	[Comprobante_Of] [int] NOT NULL,
	[FechaAnulacion] [QFecha] NOT NULL,
	[Usuario_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sucursal_Of] ASC,
	[Comprobante_Of] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [tesRecOfiAnul] WITH CHECK ADD  CONSTRAINT [STD_USU] FOREIGN KEY([Usuario_Id])
REFERENCES [genUsuarios] ([genUsuarios])
GO

ALTER TABLE genEmpresas ADD UsaCompOficiales [SINO] NOT NULL DEFAULT(0)
GO

INSERT INTO genVersion (Version) Values(1091.14)
GO
