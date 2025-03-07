


CREATE TABLE [dbo].[esptesT3PromocionesKSK](
	[tesT3Promociones] [int] NOT NULL,
	 PorcentajeEntidad qPorcentaje NOT NULL ,
     PorcentajeBanco qPorcentaje NOT NULL 
 CONSTRAINT [XPKesptesT3PromocionesKSK] PRIMARY KEY CLUSTERED 
(
	[tesT3Promociones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[esptesT3PromocionesKSK]  WITH CHECK ADD  FOREIGN KEY([tesT3Promociones])
REFERENCES [dbo].[tesT3Promociones] ([tesT3Promociones])
GO

Insert Into genVersionEmpresas (Version) Values (603.00)

