
-- comOrdenCompPendAuto 1,46
DROP PROCEDURE comOrdenCompPendAuto
GO
CREATE PROCEDURE comOrdenCompPendAuto 
( 
	@Empresa_Id int , 
	@pUsuario Int
)
AS

	SELECT @Empresa_Id AS Empresa_Id 

	select comOCSegmentos.comOrdenComp, comOCSegmentos.Empresa_Id, 
	dbo.Segmento(comOCSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as SegmentoStr, 
		comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		Convert(Numeric(18,2),sum(comOCCuerpo.Cantidad * comOCCuerpo.Precio))  as Total, 
		comOrdenComp.Estado_Id , comOCEstados.Descripcion as DescripcionEstadoRI, 
		genSegmentos.Segmento_Id,
		comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
		comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, 
			comOCAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id
		
	from comOCSegmentos INNER JOIN comOrdenComp ON
		comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
		INNER JOIN comOCCuerpo ON
		comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp
		LEFT JOIN comProveedores ON
		comProveedores.genEntidades = comOrdenComp.Proveed_Id
		INNER JOIN comOCEstados ON 
		comOcEstados.Estado_Id = comOrdenComp.Estado_Id
		INNER JOIN genSegmentos ON 
		genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
		inner JOIN comOCAutorizando on comOCAutorizando.comOrdenComp= comOrdenComp.comOrdenComp 
		inner join comNivelesAutoUsu ON comNivelesAutoUsu.NivelAuto_id = comOCAutorizando.NivelAuto_Id
		INNER JOIN comNivelesAuto ON comNivelesAuto.comNivelesAuto = comOCAutorizando.NivelAuto_Id
		INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comOrdenComp.Usuario_Id
	WHERE	
		comOCSegmentos.Empresa_Id = @Empresa_Id and 
		comNivelesAutoUsu.Usuario_Id = @pUsuario and 
		comOCAutorizando.Usuario_Id IS NULL AND 
		comOrdenComp.Estado_Id = 'P'  and 
		comOrdenComp.Posteado = 1
	Group by comOCSegmentos.comOrdenComp, comOCSegmentos.Empresa_Id, 
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N, 
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, 
		comOrdenComp.Fecha, comProveedores.Proveed_id, comProveedores.RazonSocial, 
		comOrdenComp.Estado_Id , comOCEstados.Descripcion, 
		comOCSegmentos.Segmento_Id , genSegmentos.Segmento_Id, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres,
		comOCAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id
	ORDER BY 1

	-- Agrego las que Necesito para Consulta
	exec comOrdenCompDatos 0,' ', 0,0,0,0,' ',' ',' ',' '
GO	

DROP PROCEDURE comOrdenCompCambiarEstado
GO

CREATE PROCEDURE comOrdenCompCambiarEstado
	(
	@pcomOrdenComp Int, 
	@pEstado_Id Char(1),
	@pUsuario_Id Int
	)
	as
	
	Update comOrdenComp set Estado_Id = @pEstado_Id
		--,Autorizo = 
			--case when @pEstado_Id IN ('R','A') THEN @pUsuario_id else Autorizo end
	Where
		comOrdenComp = @pcomOrdenComp
GO		
			
	
