-- genCopiaSegmentos 'BME',' ','ZZZZ', 2, 1
drop PROCEDURE genCopiaSegmentos 
go
CREATE PROCEDURE genCopiaSegmentos 
(@SucursalOrigen VarChar(4), 
@SucursalDestinoDesde VarChar(4),
@SucursalDestinoHasta VarChar(4),
@Empresa_Id INT, 
@Usuarios_Id INT
)

as

INSERT INTO genContadorSegmento (Empresa_Id, Segmento_Id, 
	Segmento2N, Segmento3N, Segmento4N, PrimerNumero,
	Segmento1C, Segmento2C, Segmento3C, Segmento4C, 
	Cai, FechaAutoSRI, FechaCai, FechaDesde, NumeroDesde, NumeroHasta, TieneColumnaAutomatica,
	Usuario_Id) 
select genContadorSegmento.Empresa_Id, genContadorSegmento.Segmento_Id, Segmento2N, Segmento3N, Segmento4N, 1,
	genSucursalesEmpr.Sucursal Segmento1C, Segmento2C, Segmento3C, Segmento4C , 
		Cai, FechaAutoSRI, FechaCai, FechaDesde, NumeroDesde, NumeroHasta, 
		genContadorSegmento.TieneColumnaAutomatica,	@Usuarios_Id Usuario_Id
		from genContadorSegmento inner join genSegmentos ON
		genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id and 
		genSegmentos.Origen1C = 11
		inner join genSucursalesEmpr ON 
		genSucursalesEmpr.Sucursal Between @SucursalDestinoDesde and @SucursalDestinoHasta and 
		@Empresa_Id = ISNULL(genSucursalesEmpr.Empresa_Id ,@Empresa_id)
		where
			genContadorSegmento.Segmento1C = @SucursalOrigen and 
			Not exists(select 1 from genContadorSegmento s1 where
				s1.Segmento_Id = genContadorSegmento.Segmento_Id and 
				s1.Segmento1C = genSucursalesEmpr.Sucursal and
				s1.Segmento2C = genContadorSegmento.Segmento2C and
				s1.Segmento3C = genContadorSegmento.Segmento3C and
				s1.Segmento4C = genContadorSegmento.Segmento4C and
				s1.Segmento2N = genContadorSegmento.Segmento2N and
				s1.Segmento3N = genContadorSegmento.Segmento3N and
				s1.Segmento4N = genContadorSegmento.Segmento4N AND 
				s1.Empresa_Id = @Empresa_Id) AND 
				genContadorSegmento.Empresa_Id = @Empresa_Id
UNION ALL
select genContadorSegmento.Empresa_Id, genContadorSegmento.Segmento_Id, Segmento2N, Segmento3N, Segmento4N, 1,
	Segmento1C, genSucursalesEmpr.Sucursal Segmento2C, Segmento3C, Segmento4C , 
		Cai, FechaAutoSRI, FechaCai, FechaDesde, NumeroDesde, NumeroHasta, 
		genContadorSegmento.TieneColumnaAutomatica,	@Usuarios_Id Usuario_Id
		from genContadorSegmento inner join genSegmentos ON
		genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id and 
		genSegmentos.Origen2C = 11
		inner join genSucursalesEmpr ON 
		genSucursalesEmpr.Sucursal Between @SucursalDestinoDesde and @SucursalDestinoHasta and 
		@Empresa_Id = ISNULL(genSucursalesEmpr.Empresa_Id ,@Empresa_id)
		where
			genContadorSegmento.Segmento2C = @SucursalOrigen and 
			Not exists(select 1 from genContadorSegmento s1 where
				s1.Segmento_Id = genContadorSegmento.Segmento_Id and 
				s1.Segmento2C = genSucursalesEmpr.Sucursal and
				s1.Segmento1C = genContadorSegmento.Segmento1C and
				s1.Segmento3C = genContadorSegmento.Segmento3C and
				s1.Segmento4C = genContadorSegmento.Segmento4C and
				s1.Segmento2N = genContadorSegmento.Segmento2N and
				s1.Segmento3N = genContadorSegmento.Segmento3N and
				s1.Segmento4N = genContadorSegmento.Segmento4N and 
				s1.Empresa_Id = @Empresa_Id) AND 
				genContadorSegmento.Empresa_Id = @Empresa_Id
UNION ALL
select genContadorSegmento.Empresa_Id, genContadorSegmento.Segmento_Id, Segmento2N, Segmento3N, Segmento4N, 1,
	Segmento1C, Segmento2C, genSucursalesEmpr.Sucursal Segmento3C, Segmento4C , 
		Cai, FechaAutoSRI, FechaCai, FechaDesde, NumeroDesde, NumeroHasta, 
		genContadorSegmento.TieneColumnaAutomatica,	@Usuarios_Id Usuario_Id
		from genContadorSegmento inner join genSegmentos ON
		genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id and 
		genSegmentos.Origen3C = 11
		inner join genSucursalesEmpr ON 
		genSucursalesEmpr.Sucursal Between @SucursalDestinoDesde and @SucursalDestinoHasta and 
		@Empresa_Id = ISNULL(genSucursalesEmpr.Empresa_Id ,@Empresa_id)
		where
			genContadorSegmento.Segmento3C = @SucursalOrigen and 
			Not exists(select 1 from genContadorSegmento s1 where
				s1.Segmento_Id = genContadorSegmento.Segmento_Id and 
				s1.Segmento3C = genSucursalesEmpr.Sucursal and
				s1.Segmento1C = genContadorSegmento.Segmento1C and
				s1.Segmento2C = genContadorSegmento.Segmento2C and
				s1.Segmento4C = genContadorSegmento.Segmento4C and
				s1.Segmento2N = genContadorSegmento.Segmento2N and
				s1.Segmento3N = genContadorSegmento.Segmento3N and
				s1.Segmento4N = genContadorSegmento.Segmento4N) AND 
				genContadorSegmento.Empresa_Id = @Empresa_Id

UNION ALL
select genContadorSegmento.Empresa_Id, genContadorSegmento.Segmento_Id, Segmento2N, Segmento3N, Segmento4N, 1,
	Segmento1C, Segmento2C,  Segmento3C, genSucursalesEmpr.Sucursal  Segmento4C , 
		Cai, FechaAutoSRI, FechaCai, FechaDesde, NumeroDesde, NumeroHasta, 
		genContadorSegmento.TieneColumnaAutomatica,	@Usuarios_Id Usuario_Id
		from genContadorSegmento inner join genSegmentos ON
		genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id and 
		genSegmentos.Origen4C = 11
		inner join genSucursalesEmpr ON 
		genSucursalesEmpr.Sucursal Between @SucursalDestinoDesde and @SucursalDestinoHasta and 
		@Empresa_Id = ISNULL(genSucursalesEmpr.Empresa_Id ,@Empresa_id)
		where
			genContadorSegmento.Segmento4C = @SucursalOrigen and 
			Not exists(select 1 from genContadorSegmento s1 where
				s1.Segmento_Id = genContadorSegmento.Segmento_Id and 
				s1.Segmento4C = genSucursalesEmpr.Sucursal and
				s1.Segmento1C = genContadorSegmento.Segmento1C and
				s1.Segmento2C = genContadorSegmento.Segmento2C and
				s1.Segmento3C = genContadorSegmento.Segmento3C and
				s1.Segmento2N = genContadorSegmento.Segmento2N and
				s1.Segmento3N = genContadorSegmento.Segmento3N and
				s1.Segmento4N = genContadorSegmento.Segmento4N) AND 
				genContadorSegmento.Empresa_Id = @Empresa_Id

			
			
go

