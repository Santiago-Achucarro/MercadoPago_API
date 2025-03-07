CREATE TABLE [dbo].[proTurnos](
	[proTurnos] [int] IDENTITY(1,1) NOT NULL,
	[Turno_Id] [varchar](10) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Inicio] [varchar](5) NOT NULL,
	[Fin] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[proTurnos] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE proMovCierreOrden ADD [Turno_Id] [int] NULL
GO

ALTER TABLE [proMovCierreOrden]  WITH CHECK ADD  CONSTRAINT [V3R_4137] FOREIGN KEY([Turno_Id])
REFERENCES [proTurnos] ([proTurnos])
GO

ALTER TABLE [dbo].[proMovCierreOrden] CHECK CONSTRAINT [V3R_4137]
GO


INSERT INTO genVersion (Version) VALUES (1116.14)
GO

