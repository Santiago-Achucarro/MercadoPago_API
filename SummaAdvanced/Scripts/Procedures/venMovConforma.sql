DROP PROCEDURE venMovConformaGuardar
GO
CREATE PROCEDURE venMovConformaGuardar
(
@pvenMovimientos BigInt,
@pUsuario_Id int ,
@pFechaConforma datetime,
@pFechaRegistro qFechaHora,
@pObservaciones QMemo = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovConforma WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovConforma
	SET	Usuario_Id = @pUsuario_Id,
		FechaConforma = @pFechaConforma,
		FechaRegistro = dbo.FechaActual(),
		Observaciones = @pObservaciones
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovConforma
	(
		venMovimientos,
		Usuario_Id,
		FechaConforma,
		FechaRegistro,
		Observaciones
	)
	VALUES 
	(
		@pvenMovimientos,
		@pUsuario_Id,
		@pFechaConforma,
		dbo.FechaActual(),
		@pObservaciones
	)
END 

GO

DROP PROCEDURE venMovConformaDatos
GO
CREATE PROCEDURE venMovConformaDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
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

SELECT venMovimientos.venMovimientos, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N , conAsientos.Fecha, venClientes.Cliente_Id, 
	venClientes.RazonSocial, venFormaEntrega.FormaEntrega_Id, 
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega,
	venVendedores.Vendedor_Id, venVendedores.Nombre DescripcionVendedor , 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	venMovConforma.FechaConforma, venMovConforma.FechaRegistro, venMovConforma.Observaciones,
	conAsientos.Anulado
FROM venMovimientos
LEFT JOIN venMovConforma  ON (venMovimientos.venMovimientos = venMovConforma.venMovimientos)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = venMovConforma.Usuario_Id)
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venMovimientos.FormaEntrega_Id
INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
WHERE conAsientos.Posteado = 1  and 
	genSegmentos.Segmento_Id = @pSegmento_Id and
	genAsiSegmentos.Segmento1C = @pSegmento1C AND
	genAsiSegmentos.Segmento2C = @pSegmento2C	AND
	genAsiSegmentos.Segmento3C = @pSegmento3C AND
	genAsiSegmentos.Segmento4C = @pSegmento4C AND
	genAsiSegmentos.Segmento1N = @pSegmento1N AND
	genAsiSegmentos.Segmento2N = @pSegmento2N AND
	genAsiSegmentos.Segmento3N = @pSegmento3N AND
	genAsiSegmentos.Segmento4N = @pSegmento4N 


	exec genAdjuntosIdentityDatos 'venMovConforma', 0

 RETURN @@Error 

GO

DROP PROCEDURE venMovConformaEliminar
GO
CREATE PROCEDURE venMovConformaEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venMovConforma 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE genMovCuotasActuFecha
GO
CREATE PROCEDURE genMovCuotasActuFecha
(
	@pAsiento_Id bigint,
	@pDias Int
)
as
Update genMovCuotas SET FechaVencimiento = dateadd(dd, @pDias, FechaVencimiento) Where Asiento_Id = @pAsiento_Id

GO
