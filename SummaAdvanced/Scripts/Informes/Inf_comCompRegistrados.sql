-- Inf_comCompRegistrados '20180101','20201231',' ','ZZZ',1
DROP PROCEDURE Inf_comCompRegistrados
GO
CREATE PROCEDURE Inf_comCompRegistrados 
(
	
	@FechaDesde DateTime,
	@FechaHasta DateTime, 
	@UsuarioDesde VarChar(25),
	@UsuarioHasta VarChar(25),
	@Empresa int
)
AS

DECLARE @FechaHastaDT DateTime
SET @FechaHastaDT = DATEADD(ms,1,DATEADD(dd,1,@FechaHasta))

SELECT conAsientos.FechaRegistro, 
	commovprov.comMovProv,  dbo.Segmento(genAsiSegmentos.Segmento_id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as Segmento, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial,
		conAsientos.Fecha, 
		disFormularios.Formulario_Id, disFormularios.Descripcion, 
		comMovprov.Importe, genMonedas.Simbolo, genMonedas.Moneda_Id , 
		genUsuarios.Usuario_Id, 
			CASE WHEN conAsientos.Anulado=1 then 'Anulado' else ' ' end as Estado
FROM comMovprov INNER JOIn conAsientos ON
	comMovprov.comMovProv = conAsientos.conAsientos 
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	inner join comProveedores on
	comProveedores.genEntidades = comMovprov.Proveed_Id
	inner join disFormularios ON
	disFormularios.disFormularios = conAsientos.Formulario_Id
	inner join genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join genUsuarios ON
	genUsuarios.genUsuarios = conAsientos.Usuario_Id
Where
	conAsientos.FechaRegistro between @FechaDesde and @FechaHastaDT and
	genAsiSegmentos.Empresa_Id = @Empresa and
	genUsuarios.Usuario_Id Between @UsuarioDesde and @UsuarioHasta
ORDER BY 1
GO