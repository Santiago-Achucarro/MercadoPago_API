Alter Table sueLiquidacion drop column FechaPago, FechaContabilizacion
GO
Alter Table sueLiquidacion add FechaPago datetime null, 
	FechaContabilizacion datetime null
GO
insert into genVersion(Version) values (526.02)
GO
