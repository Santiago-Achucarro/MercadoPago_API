
-- comReqInternoPendAuto 1,46
DROP PROCEDURE comReqInternoPendAuto
GO
CREATE PROCEDURE comReqInternoPendAuto 
( 
	@Empresa_Id int , 
	@pUsuario Int
)
AS

	SELECT @Empresa_Id AS Empresa_Id 

	select comRISegmento.comReqInterno, comRISegmento.Empresa_Id, 
	dbo.Segmento(comRISegmento.Segmento_Id,
	comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comRISegmento.Segmento1N,comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N) as SegmentoStr, 
		comReqInterno.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		Convert(Numeric(18,2),sum(comRICuerpo.Cantidad * comRICuerpo.Precio))  as Total, 
		comReqInterno.EstadoRI_Id , comRIEstados.Descripcion as DescripcionEstadoRI, 
		genSegmentos.Segmento_Id,
		comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
		comRISegmento.Segmento1N,comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, 
			comRIAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id
		
	from comRISegmento INNER JOIN comReqInterno ON
		comRISegmento.comReqInterno = comReqInterno.comReqInterno
		INNER JOIN comRICuerpo ON
		comRICuerpo.comReqInterno = comReqInterno.comReqInterno
		LEFT JOIN comProveedores ON
		comProveedores.genEntidades = comReqInterno.Proveed_Id
		INNER JOIN comRIEstados ON 
		comRIEstados.EstadoRI_Id = comReqInterno.EstadoRI_Id
		INNER JOIN genSegmentos ON 
		genSegmentos.genSegmentos = comRISegmento.Segmento_Id
		inner JOIN comRIAutorizando on comRIAutorizando.comReqInterno= comReqInterno.comReqInterno 
		inner join comNivelesAutoUsu ON comNivelesAutoUsu.NivelAuto_id = comRIAutorizando.NivelAuto_Id
		INNER JOIN comNivelesAuto ON comNivelesAuto.comNivelesAuto = comRIAutorizando.NivelAuto_Id
		INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comReqInterno.Usuario_Id
	WHERE	
		comRISegmento.Empresa_Id = @Empresa_Id and 
		comNivelesAutoUsu.Usuario_Id = @pUsuario and 
		comRIAutorizando.Usuario_Id IS NULL AND 
		comReqInterno.EstadoRI_Id = 'P'  
	Group by comRISegmento.comReqInterno, comRISegmento.Empresa_Id, 
	comRISegmento.Segmento1N,comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N, 
	comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C, 
		comReqInterno.Fecha, comProveedores.Proveed_id, comProveedores.RazonSocial, 
		comReqInterno.EstadoRI_Id , comRIEstados.Descripcion, 
		comRISegmento.Segmento_Id , genSegmentos.Segmento_Id, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres,
		comRIAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id
	ORDER BY 1

	-- Agrego las que Necesito para Consulta
	exec comReqInternoDatos 0,' ', 0,0,0,0,' ',' ',' ',' '
GO	

DROP PROCEDURE comReqInternoCambiarEstado
GO

CREATE PROCEDURE comReqInternoCambiarEstado
	(
	@pComReqInterno Int, 
	@pEstado_Id Char(1),
	@pUsuario_Id Int
	)
	as
	
	Update comReqInterno set EstadoRI_Id = @pEstado_Id
		--,Autorizo = 
			--case when @pEstado_Id IN ('R','A') THEN @pUsuario_id else Autorizo end
	Where
		comReqInterno = @pComReqInterno
GO		
			
	
