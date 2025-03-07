-- exec comOcRecepcionDatos 1, 'REOC', 3,0,0,0,'0001',' ',' ',' ', ' ',0,0,0,0,' ',' ',' ',' '
DROP PROCEDURE comOcRecepcionDatos 
GO
CREATE PROCEDURE comOcRecepcionDatos (

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
@pSegmento_Id_OC VarChar(10), 
@pSegmento1N_OC int,
@pSegmento2N_OC int,
@pSegmento3N_OC int,
@pSegmento4N_OC int,
@pSegmento1C_OC VarChar(20),
@pSegmento2C_OC VarChar(20),
@pSegmento3C_OC VarChar(20),
@pSegmento4C_OC VarChar(20)

)

as

SET NOCOUNT ON 

DECLARE @pAsiento_Id bigint

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




if @pAsiento_Id is null
-- es nuevo
BEGIN

	SELECT comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
		comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N,
		comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
		comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		genMonedas.Moneda_Id

	From comOCSegmentos 
	INNER JOIN comOrdenComp on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
	WHERE 
	
		comOCSegmentos.Empresa_Id =@pEmpresa_id and 
		comOCSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_OC) and
		comOCSegmentos.Segmento1N =@pSegmento1N_OC and
		comOCSegmentos.Segmento2N = @pSegmento2N_OC and
		comOCSegmentos.Segmento3N = @pSegmento3N_OC and
		comOCSegmentos.Segmento4N = @pSegmento4N_OC and
		comOCSegmentos.Segmento1C = @pSegmento1C_OC and
		comOCSegmentos.Segmento2C = @pSegmento2C_OC and 
		comOCSegmentos.Segmento3C = @pSegmento3C_OC and 
		comOCSegmentos.Segmento4C = @pSegmento4C_OC 
	ORDER BY 2


	SELECT comOCMemo.comOrdenComp,  comOCMemo.Renglon_OC, 
		comOCMemo.Detalle , conCuentas.Cuenta_Id, 
		conCuentas.Descripcion, comOCCuerpo.Cantidad, 
		comOCCuerpo.Cantidad_Recibida, comOCCuerpo.Cantidad - comOCCuerpo.Cantidad_Recibida as CantidadPendiente,
		conCentro1.Centro1_id, conCentro2.Centro2_id , 
		comOCCuerpo.Cantidad*0 as CantidadForm, ' ' as Observaciones, comOCCuerpo.Precio, 0 as conRenglon
	from comOCMemo INNER JOIN comOCCuerpo on
		comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp and 
		comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
		inner join comOrdenComp ON
		comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp 
		INNER JOIN comOCSegmentos ON
		comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
		INNER JOIN conCuentas ON conCuentas.conCuentas = comOCMemo.Cuenta_Id
		LEFT JOIN conCentro1 ON conCentro1.conCentro1 = comOCCuerpo.Centro1_Id
		LEFT JOIN conCentro2 ON conCentro2.conCentro2 = comOCCuerpo.Centro2_Id
		Where
			comOCCuerpo.Cantidad > comOCCuerpo.Cantidad_Recibida  and
			comOCCuerpo.Pendiente = 1 and 
			comOCSegmentos.Empresa_Id =@pEmpresa_id and 
			comOCSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_OC) and
			comOCSegmentos.Segmento1N =@pSegmento1N_OC and
			comOCSegmentos.Segmento2N = @pSegmento2N_OC and
			comOCSegmentos.Segmento3N = @pSegmento3N_OC and
			comOCSegmentos.Segmento4N = @pSegmento4N_OC and
			comOCSegmentos.Segmento1C = @pSegmento1C_OC and
			comOCSegmentos.Segmento2C = @pSegmento2C_OC and 
			comOCSegmentos.Segmento3C = @pSegmento3C_OC and 
			comOCSegmentos.Segmento4C = @pSegmento4C_OC 

end

else
begin


SELECT comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id

From comOCSegmentos 
INNER JOIN comOrdenComp on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id


WHERE 
	Exists(select 1 from comOcReceCuerpo where
		comOcReceCuerpo.comOcRecepcion = @pAsiento_Id and 
		comOcReceCuerpo.comOrdenComp =	comOrdenComp.comOrdenComp)


	SELECT comOCMemo.comOrdenComp,  comOCMemo.Renglon_OC, 
		comOCMemo.Detalle , conCuentas.Cuenta_Id, 
		conCuentas.Descripcion, comOCCuerpo.Cantidad, 
		comOCCuerpo.Cantidad_Recibida, comOCCuerpo.Cantidad - comOCCuerpo.Cantidad_Recibida as CantidadPendiente,
		conCentro1.Centro1_id, conCentro2.Centro2_id , 
		comOcReceCuerpo.Cantidad as CantidadForm, isNull(comOcReceCuerpo.Observaciones, '') Observaciones, comOCCuerpo.Precio, comOcReceCuerpo.conRenglon
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
			comOcReceCuerpo.comOcRecepcion = @pAsiento_Id

end
Go
