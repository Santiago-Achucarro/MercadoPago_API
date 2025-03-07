
CREATE TABLE [espvenClieHabitualKSK](
	[Cliente_Id] [bigint] NOT NULL,
	[Sucursal] [SucursalN] NOT NULL,
	[Celular] [Varchar](35) NOT NULL,
	[Mes] [int] NOT NULL,
	[Dia] [int] NOT NULL,
	[Instagram] [Varchar](50) NOT NULL,
	[Youtube] [Varchar](50) NOT NULL,
	[Linkedin] [Varchar](50) NOT NULL,
	[Facebook] [Varchar](50) NOT NULL,	
PRIMARY KEY CLUSTERED 
(
	[Cliente_id] ASC,
	[Sucursal] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [espvenClieHabitualKSK] WITH CHECK ADD  CONSTRAINT [KSK_4010] FOREIGN KEY(Cliente_Id,Sucursal)
REFERENCES venClieHabitual(genEntidades,Sucursal)
GO
ALTER TABLE [espvenClieHabitualKSK] CHECK CONSTRAINT [KSK_4010]
GO

INSERT INTO genVersionEmpresas (Version) Values(601)
GO


select * from espvenClieHabitualKSK