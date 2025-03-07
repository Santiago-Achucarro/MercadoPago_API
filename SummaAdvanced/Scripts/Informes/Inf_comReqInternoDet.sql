-- Inf_comReqInternoDet '20200101','20200131',0,' ','ZZZ',' ','ZZZ',1

DROP PROCEDURE Inf_comReqInternoDet
GO
CREATE PROCEDURE Inf_comReqInternoDet
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Pendiente Bit, 
	@UsuarioDesde VarChar(25),
	@UsuarioHasta VarChar(25),
	@TipoPermiDesde VarChar(5),
	@TipoPermiHasta VarChar(5),
	@Empresa_Id Int
	
)
AS

Select comReqInterno.comReqInterno, comReqInterno.Fecha, 
	dbo.Segmento(comRISegmento.Segmento_Id, comRISegmento.Segmento1C, 
	comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N,
	comRISegmento.Segmento4N) as Segmento, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuaurio,
		comTipoPermiRI.TipoPermiRI_Id, comTipoPermiRI.Descripcion  as DescripcionTipoPermi,
		comReqInterno.EstadoRI_Id, comTipoPermiRI.GeneraOC, 
		stkProductos.Producto_Id, stkProductos.Descripcion, 
		comRiCuerpo.Cantidad, comRiCuerpo.CantidadRecibida, 
		comRiCuerpo.Precio, 	comRiCuerpo.Pendiente,
			conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta ,
			ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id , 
			ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id
from comReqInterno INNER join comRISegmento ON
	comReqInterno.comReqInterno = comRISegmento.comReqInterno
	inner join comTipoPermiRI ON
	comTipoPermiRI.comTipoPermiRI = comReqInterno.TipoPermi_Id
	INNER join genUsuarios ON
	genUsuarios.genUsuarios = comReqInterno.Usuario_Id
	inner join comRICuerpo ON
	comRICuerpo.comReqInterno = comReqInterno.comReqInterno  
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = comRICuerpo.Medida_Id
	inner join comRiArticulo ON
	comRiArticulo.comReqInterno = comRICuerpo.comReqInterno  and 
	comRiArticulo.Renglon_RI = comRICuerpo.Renglon_RI
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = comRiArticulo.Producto_Id
	INNER JOIN conCuentas ON
	conCuentas.conCuentas = comRICuerpo.Cuenta_Id
	LEFT JOIN conCentro1 ON
	conCentro1.conCentro1 = comRICuerpo.Centro1_Id
	LEFT JOIN conCentro2 ON
	conCentro2.conCentro2 = comRICuerpo.Centro2_Id
WHERE
	comRISegmento.Empresa_Id = @Empresa_Id and 
	(@Pendiente = 1  or comReqInterno.Fecha BETWEEN @FechaDesde And @FechaHasta) and		
	genUsuarios.Usuario_Id BETWEEN @UsuarioDesde and @UsuarioHasta and 
	(@Pendiente = 0 or (comReqInterno.EstadoRI_Id IN ('A','P') AND 
		comRiCuerpo.Pendiente = 1)) and 
	comTipoPermiRI.TipoPermiRI_Id BETWEEN @TipoPermiDesde and @TipoPermiHasta 
	
UNION ALL
Select comReqInterno.comReqInterno, comReqInterno.Fecha, 
	dbo.Segmento(comRISegmento.Segmento_Id, comRISegmento.Segmento1C, 
	comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N,
	comRISegmento.Segmento4N) as Segmento, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuaurio,
		comTipoPermiRI.TipoPermiRI_Id, comTipoPermiRI.Descripcion  as DescripcionTipoPermi,
		comReqInterno.EstadoRI_Id, comTipoPermiRI.GeneraOC, 
		' ' Producto_Id, comRiMemo.Detalle as Descripcion, 
		comRiCuerpo.Cantidad, comRiCuerpo.CantidadRecibida, 
		comRiCuerpo.Precio, 	comRiCuerpo.Pendiente, 
		conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta ,
		ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id , 
		ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id
from comReqInterno INNER join comRISegmento ON
	comReqInterno.comReqInterno = comRISegmento.comReqInterno
	inner join comTipoPermiRI ON
	comTipoPermiRI.comTipoPermiRI = comReqInterno.TipoPermi_Id
	INNER join genUsuarios ON
	genUsuarios.genUsuarios = comReqInterno.Usuario_Id
	inner join comRICuerpo ON
	comRICuerpo.comReqInterno = comReqInterno.comReqInterno  
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = comRICuerpo.Medida_Id
	inner join comRiMemo ON
	comRiMemo.comReqInterno = comRICuerpo.comReqInterno  and 
	comRiMemo.Renglon_RI = comRICuerpo.Renglon_RI
	INNER JOIN conCuentas ON
	conCuentas.conCuentas = comRICuerpo.Cuenta_Id
	LEFT JOIN conCentro1 ON
	conCentro1.conCentro1 = comRICuerpo.Centro1_Id
	LEFT JOIN conCentro2 ON
	conCentro2.conCentro2 = comRICuerpo.Centro2_Id
WHERE
	comRISegmento.Empresa_Id = @Empresa_Id and 
	(@Pendiente = 1  or comReqInterno.Fecha BETWEEN @FechaDesde And @FechaHasta) and		
	genUsuarios.Usuario_Id BETWEEN @UsuarioDesde and @UsuarioHasta and 
	(@Pendiente = 0 or (comReqInterno.EstadoRI_Id IN ('A','P') AND 
		comRiCuerpo.Pendiente = 1)) and 
	comTipoPermiRI.TipoPermiRI_Id BETWEEN @TipoPermiDesde and @TipoPermiHasta 
ORDER BY 2,1		 


