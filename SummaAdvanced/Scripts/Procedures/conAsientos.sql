-- AGO 17 Especial en ConAsientos

DROP PROCEDURE conAsientosGuardar
GO
CREATE PROCEDURE conAsientosGuardar
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pFecha qFecha,
/*@pFechaRegistro datetime,*/
@pUsuario_Id int,
@pMoneda_Id varchar(3) = NULL,
@pCambio qMonedaD8,
@pCambioMonedaOriginal qMonedaD8,
@pAnulado Sino,
@pObservaciones QMemo = NULL,
@pFormulario varchar(45),
@pPosteado Sino, 
@pEspecial VarChar(3), 
@pSucursal VarChar(4)
)
AS
SET NOCOUNT ON 
Declare @pidentity bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )




IF (@pidentity IS NOT NULL)
BEGIN 
	UPDATE conAsientos
	SET	
		Empresa_Id = @pEmpresa_Id,
		Fecha = @pFecha,
		FechaRegistro =dbo.FechaActual(),
		Usuario_Id = @pUsuario_Id,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Cambio = @pCambio,
		CambioMonedaOriginal = @pCambioMonedaOriginal,
		Anulado = @pAnulado,
		Observaciones = @pObservaciones,
		Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario),
		Posteado = @pPosteado, 
		Especial = @pEspecial, 
		Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal)
	WHERE 
		conAsientos = @pidentity
END 
ELSE 
BEGIN 
	INSERT INTO conAsientos
	(
		Empresa_Id,
		Fecha,
		FechaRegistro,
		Usuario_Id,
		Moneda_Id,
		Cambio,
		CambioMonedaOriginal,
		Anulado,
		Observaciones,
		Formulario_Id,
		Posteado, 
		Especial,
		Sucursal
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pFecha,
		dbo.FechaActual(),
		@pUsuario_Id,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pCambio,
		@pCambioMonedaOriginal,
		@pAnulado,
		@pObservaciones,
		dbo.FuncFKdisFormularios(@pFormulario),
		@pPosteado, 
		@pEspecial,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal)
	)
	SET @pidentity =  Cast(SCOPE_IDENTITY() as bigint) 
END 
Select @pidentity as RetVal 

GO
DROP PROCEDURE conAsientosDatos_Private 
GO
CREATE PROCEDURE conAsientosDatos_Private 
(
@pAsiento_id bigint
)

AS

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
		conAsientos.Especial, isnull(genSucursalesEmpr.Sucursal,' ')  as Sucursal, 
		Cast(0 as bit) as EsSaldoInicial, ' ' as TipoEnvio, ' ' Cliente_Id , 
			' ' Proveed_Id, ' ' AS Tipomov, 0 as AnioSueldos, 0 as MesSueldos, 
			0 as QuinSueldos, 0 as DecenaSueldos, 0 as SemanaSueldos, 0 as VezSueldos
FROM conAsientos 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_id
INNER JOIN genUsuarios  ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
LEFT JOIN genMonedas  ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN disFormularios  ON disFormularios.disFormularios = conAsientos.Formulario_Id
LEFT JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE  
	conAsientos.conAsientos = @pAsiento_id



SELECT conAsientos.conAsientos, conMovCont.Renglon,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conMovCont.LeyendaLibroMayor, conMovCont.Importe, conMovCont.ImporteMonedaOriginal, 
	conMovCont.TipoMov, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, conMovCont.Clase
FROM conMovCont 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = conMovCont.conAsientos)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = conMovCont.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = conMovCont.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = conMovCont.Centro2_Id)
WHERE 
	(conMovCont.conAsientos = @pAsiento_id)
ORDER BY 2	

 Exec genAtributosGeneralesIdentityDatos @pAsiento_id, 'conAsientos'
 RETURN @@Error 

GO


DROP PROCEDURE conAsientosDatos
GO
CREATE PROCEDURE conAsientosDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @pIdentity bigint= (select Asiento_id from genAsiSegmentos
	Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C)

EXEC 	conAsientosDatos_Private @pIdentity
GO


DROP PROCEDURE conAsientosEliminar
GO
CREATE PROCEDURE conAsientosEliminar
(
	@pconAsientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM conAsientos WHERE  conAsientos = @pconAsientos
RETURN @@Error 

GO


DROP PROCEDURE conAsientosAnular
GO
CREATE PROCEDURE conAsientosAnular
(
	@pconAsientos bigint,
	@pUsuario_id int 
	
)
AS
SET NOCOUNT ON 

UPDATE conAsientos SET Anulado = 1, Usuario_id = @pUsuario_id, 
	FechaRegistro = dbo.FechaActual()
	WHERE  conAsientos = @pconAsientos
RETURN @@Error 

GO


DROP PROCEDURE conAsientosContDatos
GO
CREATE PROCEDURE conAsientosContDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)

AS
Declare @pAsiento_id bigint= (select Asiento_id from genAsiSegmentos
	Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C)



SELECT conAsientos.conAsientos, conEjercicio.Ejercicio, 
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,
	conAsientos.Fecha, conAsientos.FechaRegistro, conAsientosCon.LeyendaLibroDiario,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescripcionMonedas,
	conAsientos.Cambio, conAsientos.CambioMonedaOriginal, conAsientos.Anulado, conAsientos.Observaciones,
	disFormularios.Formulario_Id , disFormularios.Descripcion as DescripcionFormulario, conAsientos.Posteado, 
	conAsientos.Especial, genSucursalesEmpr.Sucursal,
	SUM(CASE WHEN conMovContCon.TipoMov=1 THEN  conMovContCon.Importe ELSE 0 END) as TotalDebe, 
	SUM(CASE WHEN conMovContCon.TipoMov=2 THEN  conMovContCon.Importe ELSE 0 END) as TotalHaber,
	SUM(conMovContCon.Importe *(-2*conMovContCon.TipoMov+3)) Diferencia, 
	0 as AsientosTipo_Id, ' ' as LeyendaLibroDiario1, '' as Upload
FROM conAsientos 
INNER JOIN conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_id
INNER JOIN genUsuarios  ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN conPeriodos ON conAsientos.Fecha between conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta and 
conPeriodos.Empresa_Id = @pEmpresa_id
INNER JOIN conEjercicio ON conEjercicio.Ejercicio = conPeriodos.Ejercicio
LEFT JOIN genMonedas  ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN disFormularios  ON disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN conMovContCon on conMovContCon.conAsientos = conASientos.conAsientos
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE  
	conAsientos.conAsientos = @pAsiento_id
	GROUP BY conAsientos.conAsientos, 
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,
	conAsientos.Fecha, conAsientos.FechaRegistro,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres , genMonedas.Moneda_Id, 
	genMonedas.Descripcion ,conAsientos.Cambio, conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones,conAsientosCon.LeyendaLibroDiario, 
	disFormularios.Formulario_Id , disFormularios.Descripcion ,conAsientos.Posteado, 
	conAsientos.Especial,genSucursalesEmpr.Sucursal, conEjercicio.Ejercicio

Exec conMovContConDatos @pAsiento_id,null
Exec genAtributosGeneralesIdentityDatos @pAsiento_id, 'conAsientos'

SELECT CASE WHEN Rever.Fecha IS NULL THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END Revertir, 
ISNULL(Rever.Fecha,GETDATE()) FechaReversion
FROM conAsientos 
LEFT OUTER JOIN (SELECT B.Fecha, B.conAsientos FROM 
conAsieReversion A INNER JOIN conAsientos B ON 
A.Asiento_id = B.conAsientos) Rever ON conAsientos.conAsientos = Rever.conAsientos  
WHERE conAsientos.conAsientos = @pAsiento_id

RETURN @@Error 
GO



DROP PROCEDURE conMarcarEspecial
GO
CREATE PROCEDURE conMarcarEspecial
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pEspecial VarChar(3)
)
AS
SET NOCOUNT ON 

	UPDATE conAsientos
	SET	Especial = @pEspecial
		WHERE Exists(select 1 from genAsiSegmentos
	Where
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos and
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

GO



DROP PROCEDURE conAsientosConGuardar
GO
CREATE PROCEDURE conAsientosConGuardar
(
@pconAsientos bigint,
@pLeyendaLibroDiario varchar(100)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conAsientosCon WHERE (conAsientos = @pconAsientos)))
BEGIN 
	UPDATE conAsientosCon
	SET		LeyendaLibroDiario = @pLeyendaLibroDiario
	WHERE (conAsientos = @pconAsientos)
END 
ELSE 
BEGIN 
	INSERT INTO conAsientosCon
	(
		conAsientos,
		LeyendaLibroDiario
	)
	VALUES 
	(
		@pconAsientos,
		@pLeyendaLibroDiario
	)
END 

GO

DROP PROCEDURE conAsientosInsertar
GO
CREATE PROCEDURE conAsientosInsertar
(
@pEmpresa_Id int, 
@pFecha qFecha,
@pUsuario_Id int,
@pMoneda_Id varchar(3) = NULL,
@pCambio qMonedaD8,
@pCambioMonedaOriginal qMonedaD8,
@pAnulado Sino,
@pObservaciones QMemo = NULL,
@pFormulario varchar(45),
@pPosteado Sino, 
@pEspecial VarChar(3), 
@pSucursal VarChar(4)
)
AS
SET NOCOUNT ON 
Declare @pidentity bigint

INSERT INTO conAsientos
(
	Empresa_Id,
	Fecha,
	FechaRegistro,
	Usuario_Id,
	Moneda_Id,
	Cambio,
	CambioMonedaOriginal,
	Anulado,
	Observaciones,
	Formulario_Id,
	Posteado, 
	Especial,
	Sucursal
)
VALUES 
(
	@pEmpresa_Id,
	@pFecha,
	dbo.FechaActual(),
	@pUsuario_Id,
	dbo.FuncFKgenMonedas(@pMoneda_Id),
	@pCambio,
	@pCambioMonedaOriginal,
	@pAnulado,
	@pObservaciones,
	dbo.FuncFKdisFormularios(@pFormulario),
	@pPosteado, 
	@pEspecial,
	dbo.FuncFKgenSucursalesEmpr(@pSucursal)
)
SET @pidentity =  Cast(SCOPE_IDENTITY() as bigint) 

Select @pidentity as RetVal

Go

DROP PROCEDURE conAsientosModificarFecha
GO
CREATE PROCEDURE conAsientosModificarFecha
(
	@pconAsientos bigint,
	@pFecha qFecha
	
)
AS
SET NOCOUNT ON 

UPDATE conAsientos SET Fecha = @pFecha WHERE  conAsientos = @pconAsientos

RETURN @@Error 

GO
