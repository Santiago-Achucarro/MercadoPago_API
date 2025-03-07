DROP PROCEDURE tesFlujoFondoGuardar
GO
CREATE PROCEDURE tesFlujoFondoGuardar
(
@tesFlujoFondo bigint = NULL,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pDetallaClientes bit,
@pDetallaProveedores bit,
@pUsuario_Id int,
@pFechaRegistro datetime,
@pPeriodo char(1)
)
AS
SET NOCOUNT ON 

IF (EXISTS (SELECT 1 FROM tesFlujoFondo WHERE tesFlujoFondo = @tesFlujoFondo))
BEGIN 
	UPDATE tesFlujoFondo
	SET	FechaDesde = @pFechaDesde,
		FechaHasta = @pFechaHasta,
		DetallaClientes = @pDetallaClientes,
		DetallaProveedores = @pDetallaProveedores,
		Usuario_Id = @pUsuario_Id,
		FechaRegistro = dbo.FechaActual() ,
		Periodo = @pPeriodo
	WHERE 
		tesFlujoFondo = @tesFlujoFondo
END 
ELSE 
BEGIN 
	INSERT INTO tesFlujoFondo
	(
		FechaDesde,
		FechaHasta,
		DetallaClientes,
		DetallaProveedores,
		Usuario_Id,
		FechaRegistro,
		Periodo
	)
	VALUES 
	(
		@pFechaDesde,
		@pFechaHasta,
		@pDetallaClientes,
		@pDetallaProveedores,
		@pUsuario_Id,
		getDate(),
		@pPeriodo
	)
	SET @tesFlujoFondo =  Cast(SCOPE_IDENTITY() as bigint) 
END 
Select @tesFlujoFondo as RetVal 

GO

DROP PROCEDURE tesFlujoFondoDatos
GO
CREATE PROCEDURE tesFlujoFondoDatos
(
	@Empresa_Id INT, 
	@Segmento_Id Char(5),
	@Segmento1C Char(25),
	@Segmento2C Char(25),
	@Segmento3C Char(25),
	@Segmento4C Char(25),
	@Segmento1N int,
	@Segmento2N int,
	@Segmento3N int,
	@Segmento4N int 
)
AS
SET NOCOUNT ON 

SELECT tesFlujoFondo.tesFlujoFondo, 
	genSegmentos.Segmento_Id, tesFFSegmentos.Segmento1N, tesFFSegmentos.Segmento2N,
	tesFFSegmentos.Segmento3N, tesFFSegmentos.Segmento4N, tesFFSegmentos.Segmento1C,
	tesFFSegmentos.Segmento2C, tesFFSegmentos.Segmento3C, tesFFSegmentos.Segmento4C,
	tesFlujoFondo.FechaDesde, tesFlujoFondo.FechaHasta, tesFlujoFondo.DetallaClientes,
	tesFlujoFondo.DetallaProveedores, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, tesFlujoFondo.FechaRegistro,
	tesFlujoFondo.Periodo, tesFFSegmentos.Empresa_Id, 
		tesFlujoFondo.FechaDesde as Fecha
FROM tesFlujoFondo 
INNER JOIN tesFFSegmentos ON tesFFSegmentos.tesFlujoFondo =tesFlujoFondo.tesFlujoFondo
INNER JOIN genSegmentos ON genSegmentos.genSegmentos =tesFFSegmentos.Segmento_Id
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesFlujoFondo.Usuario_Id)
WHERE  
	genSegmentos.Segmento_Id = @Segmento_Id and 
	tesFFSegmentos.Empresa_Id = @Empresa_Id and 
	tesFFSegmentos.Segmento1N = @Segmento1N and 
	tesFFSegmentos.Segmento2N = @Segmento2N and 
	tesFFSegmentos.Segmento3N = @Segmento3N and 
	tesFFSegmentos.Segmento4N = @Segmento4N and 
	tesFFSegmentos.Segmento1C = @Segmento1C and 
	tesFFSegmentos.Segmento2C = @Segmento2C and 
	tesFFSegmentos.Segmento3C = @Segmento3C and 
	tesFFSegmentos.Segmento4C = @Segmento4C 

declare  @tesFlujoFondo bigint
SELECT @tesFlujoFondo = tesFFSegmentos.tesFlujoFondo
from tesFFSegmentos inner join genSegmentos ON 
	tesFFSegmentos.Segmento_Id = genSegmentos.genSegmentos
	Where
		genSegmentos.Segmento_Id = @Segmento_Id and 
		tesFFSegmentos.Empresa_Id = @Empresa_Id and 
		tesFFSegmentos.Segmento1N = @Segmento1N and 
		tesFFSegmentos.Segmento2N = @Segmento2N and 
		tesFFSegmentos.Segmento3N = @Segmento3N and 
		tesFFSegmentos.Segmento4N = @Segmento4N and 
		tesFFSegmentos.Segmento1C = @Segmento1C and 
		tesFFSegmentos.Segmento2C = @Segmento2C and 
		tesFFSegmentos.Segmento3C = @Segmento3C and 
		tesFFSegmentos.Segmento4C = @Segmento4C 

Exec genAtributosGeneralesIdentityDatos @tesFlujoFondo, 'tesFlujoFondo'
RETURN @@Error 

GO

DROP PROCEDURE tesFlujoFondoEliminar
GO
CREATE PROCEDURE tesFlujoFondoEliminar
(
	@tesFlujoFondo bigInt
)
AS
SET NOCOUNT ON 

DELETE FROM tesFlujoFondo 
WHERE  
	tesFlujoFondo = @tesFlujoFondo
RETURN @@Error 

GO

GO
