-- exec comOcReveRecepcionDatos 1, 'REVOC', 1,0,0,0,'0001',' ',' ',' ', 'REOC',0,0,0,0,'',' ',' ',' '
DROP PROCEDURE comOcReveRecepcionDatos 
GO
CREATE PROCEDURE comOcReveRecepcionDatos (

@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pSegmento_Id_RE VarChar(10), 
@pSegmento1N_RE int,
@pSegmento2N_RE int,
@pSegmento3N_RE int,
@pSegmento4N_RE int,
@pSegmento1C_RE VarChar(20),
@pSegmento2C_RE VarChar(20),
@pSegmento3C_RE VarChar(20),
@pSegmento4C_RE VarChar(20)

)

as

SET NOCOUNT ON 

DECLARE @pAsiento_Id bigint
DECLARE @pAsiento_Id_Re bigint

SET @pAsiento_Id = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @pEmpresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id) and
	Segmento1N =@pSegmento1N and
	Segmento2N = @pSegmento2N and
	Segmento3N = @pSegmento3N and
	Segmento4N = @pSegmento4N and
	Segmento1C = @pSegmento1C and
	Segmento2C = @pSegmento2C and 
	Segmento3C = @pSegmento3C and 
	Segmento4C = @pSegmento4C )



SELECT conAsientos.conAsientos, 
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,
	conAsientos.Fecha, conAsientos.FechaRegistro,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescripcionMonedas,
	conAsientos.Cambio, conAsientos.CambioMonedaOriginal, conAsientos.Anulado, conAsientos.Observaciones,
	disFormularios.Formulario_Id , disFormularios.Descripcion as DescripcionFormulario, conAsientos.Posteado, 
		conAsientos.Especial, ISNULL(genSucursalesEmpr.Sucursal,' ') AS Sucursal
FROM conAsientos 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_id
INNER JOIN genUsuarios  ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
LEFT JOIN genMonedas  ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN disFormularios  ON disFormularios.disFormularios = conAsientos.Formulario_Id
LEFT JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE  
	conAsientos.conAsientos = @pAsiento_id






SET @pAsiento_Id_Re = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @pEmpresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_RE) and
	Segmento1N =@pSegmento1N_RE and
	Segmento2N = @pSegmento2N_RE and
	Segmento3N = @pSegmento3N_RE and
	Segmento4N = @pSegmento4N_RE and
	Segmento1C = @pSegmento1C_RE and
	Segmento2C = @pSegmento2C_RE and 
	Segmento3C = @pSegmento3C_RE and 
	Segmento4C = @pSegmento4C_RE )



			
if @pAsiento_Id is null
-- es nuevo
BEGIN


	SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		conAsientos.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		genMonedas.Moneda_Id, conAsientos.Cambio, conAsientos.conAsientos
	From genAsiSegmentos 
	INNER JOIN conAsientos on conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	inner join (select distinct comOcReceCuerpo.comOrdenComp, comOcReceCuerpo.comOcRecepcion 
		from comOcReceCuerpo ) as comOcRecepcion ON
		comOcRecepcion.comOcRecepcion = conAsientos.conAsientos
	INNER JOIN comOrdenComp ON  comOrdenComp.comOrdenComp = comOcRecepcion.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Where
			comOcRecepcion.comOcRecepcion = @pAsiento_Id_Re

	SELECT comOCMemo.comOrdenComp,  comOCMemo.Renglon_OC, 
		comOCMemo.Detalle , conCuentas.Cuenta_Id, 
		conCuentas.Descripcion, comOCCuerpo.Cantidad, 
		conCentro1.Centro1_id, conCentro2.Centro2_id , 
		comOcReceCuerpo.Cantidad as Cantidad_Recibida, 
		comOcReceCuerpo.Cantidad*0 as CantidadForm, 
			comOcReceCuerpo.Observaciones, comOCCuerpo.Precio, comOcReceCuerpo.conRenglon
	from comOcReceCuerpo INNER JOIN  comOCMemo ON
		comOcReceCuerpo.comOrdenComp = comOCMemo.comOrdenComp and 
		comOcReceCuerpo.Renglon_OC = comOCMemo.Renglon_OC
		INNER JOIN comOCCuerpo on
		comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp and 
		comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
		inner join conMovCont ON
		conMovCont.conAsientos = comOcReceCuerpo.comOcRecepcion and 
		conMovCont.Renglon = comOcReceCuerpo.conRenglon
		INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
		LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
		LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
		Where
			comOcReceCuerpo.comOcRecepcion = @pAsiento_Id_re

end

ELSE
begin

	
	SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		conAsientos.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		genMonedas.Moneda_Id, conAsientos.Cambio, conAsientos.conAsientos
	From genAsiSegmentos 
	INNER JOIN conAsientos on conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN comOCAntiRecepcion ON comOCAntiRecepcion.comOcRecepcion = conAsientos.conAsientos
	inner join (select distinct comOcReceCuerpo.comOrdenComp, comOcReceCuerpo.comOcRecepcion 
		from comOcReceCuerpo ) as comOcRecepcion ON
		comOcRecepcion.comOcRecepcion = conAsientos.conAsientos
	INNER JOIN comOrdenComp ON  comOrdenComp.comOrdenComp = comOcRecepcion.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Where
			comOCAntiRecepcion.comAntiRecepcion = @pAsiento_Id


	SELECT comOCMemo.comOrdenComp,  comOCMemo.Renglon_OC, 
		comOCMemo.Detalle , conCuentas.Cuenta_Id, 
		conCuentas.Descripcion, comOCCuerpo.Cantidad, 
		conCentro1.Centro1_id, conCentro2.Centro2_id , 
		comOcReceCuerpo.Cantidad as Cantidad_Recibida, 
		-comOcReceCuerpoAnti.Cantidad as CantidadForm, 
			comOcReceCuerpo.Observaciones, comOCCuerpo.Precio, comOcReceCuerpo.conRenglon
	from comOcReceCuerpo INNER JOIN  comOCMemo ON
		comOcReceCuerpo.comOrdenComp = comOCMemo.comOrdenComp and 
		comOcReceCuerpo.Renglon_OC = comOCMemo.Renglon_OC
		INNER JOIN comOCCuerpo on
		comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp and 
		comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
		inner join conMovCont ON
		conMovCont.conAsientos = comOcReceCuerpo.comOcRecepcion and 
		conMovCont.Renglon = comOcReceCuerpo.conRenglon
		INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
		INNER JOIN comOCAntiRecepcion on comOCAntiRecepcion.comOcRecepcion = comOcReceCuerpo.comOcRecepcion
		INNER JOIN comOcReceCuerpo AS comOcReceCuerpoAnti on 
			comOcReceCuerpoAnti.comOcRecepcion = comOCAntiRecepcion.comAntiRecepcion and 
			comOcReceCuerpo.comOrdenComp = comOcReceCuerpoAnti.comOrdenComp and
			comOcReceCuerpo.conRenglon = comOcReceCuerpoAnti.conRenglon
		LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
		LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
		Where
			comOCAntiRecepcion.comAntiRecepcion = @pAsiento_Id


end
Go


