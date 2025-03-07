DROP PROCEDURE genLogRequestGuardar
GO
CREATE PROCEDURE genLogRequestGuardar
(
@pNombreClase varchar(254),
@pEmpresa_Id int,
@pTipo varchar(100),
@pRequest varchar(max),
@pRequestEsp varchar(max)=NULL,
@pAccion varchar(254)=NULL,
@pFormulario_Id varchar(100),
@pUsuario_Id int,
@pSegmento_Id varChar(10) = Null,
@pSegmento1C varchar(20) = Null,
@pSegmento2C varchar(20) = Null,
@pSegmento3C varchar(20) = Null,
@pSegmento4C varchar(20) = Null,
@pSegmento1N int = Null,
@pSegmento2N int = Null,
@pSegmento3N int = Null,
@pSegmento4N int = Null
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
	INSERT INTO genLogRequest
	(
		Empresa_Id,
		NombreClase,
		Tipo,
		Request,
		RequestEsp,
		Accion,
		FechaRegistro,
		Formulario_Id,
		Usuario_Id,
		Segmento_Id,
		Segmento1C,
		Segmento2C,
		Segmento3C,
		Segmento4C,
		Segmento1N,
		Segmento2N,
		Segmento3N,
		Segmento4N
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pNombreClase,
		@pTipo,
		@pRequest,
		@pRequestEsp,
		@pAccion,
		getDate(),
		@pFormulario_Id,
		@pUsuario_Id,
		dbo.funcFKgenSegmentos(@pSegmento_Id),
		@pSegmento1C,
		@pSegmento2C,
		@pSegmento3C,
		@pSegmento4C,
		@pSegmento1N,
		@pSegmento2N,
		@pSegmento3N,
		@pSegmento4N
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
	Select @lIdentidad as RetVal 

GO

DROP PROCEDURE genLogRequestDatos
GO
CREATE PROCEDURE genLogRequestDatos
(
@pgenLogRequest int

)
AS
SET NOCOUNT ON 

SELECT genLogRequest, genLogRequest.Empresa_Id, NombreClase, Tipo, Request, RequestEsp, Accion, FechaRegistro, Formulario_Id, genLogRequest.Usuario_Id, 
genSegmentos.Segmento_Id, Segmento1C, Segmento2C, Segmento3C, Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N
FROM genLogRequest
Left Join genSegmentos On genSegmentos.genSegmentos = genLogRequest.Segmento_Id
WHERE genLogRequest= @pgenLogRequest 

RETURN @@Error 

GO

DROP PROCEDURE genLogRequestEliminar
GO
CREATE PROCEDURE genLogRequestEliminar
(
@pgenLogRequest int
)
AS
SET NOCOUNT ON 

DELETE FROM genLogRequest 
WHERE genLogRequest= @pgenLogRequest 

RETURN @@Error 

GO
DROP PROCEDURE genLogRequestDatosTodos
GO
CREATE PROCEDURE genLogRequestDatosTodos
(
@pEmpresa_Id Int,
@pTipo varchar(100) = NULL
)
AS

Select @pTipo Tipo, '' Usuario_Id, '' DescripcionUsuario

SELECT genLogRequest, NombreClase, Tipo, Request, RequestEsp, Accion, FechaRegistro,genLogRequest.Formulario_Id, disFormularios.Titulo DescripcionFormulario, 
genLogRequest.Usuario_Id, genSegmentos.Segmento_Id, Segmento1C, Segmento2C, Segmento3C, Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N,
dbo.Segmento(genLogRequest.Segmento_Id, Segmento1C, Segmento2C, Segmento2C, Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N) Comprobante
FROM genLogRequest
Left Join genSegmentos On genSegmentos.genSegmentos = genLogRequest.Segmento_Id
Inner Join disFormularios On disFormularios.Formulario_Id = genLogRequest.Formulario_Id
WHERE Empresa_Id = @pEmpresa_Id And Tipo = ISNULL(@pTipo, Tipo)

RETURN @@Error 

GO

DROP PROCEDURE genLogRequestEliminarXSeg
GO
CREATE PROCEDURE genLogRequestEliminarXSeg
(
@pEmpresa_Id int,
@pSegmento_Id varChar(10),
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int
)
AS
SET NOCOUNT ON 

DELETE FROM genLogRequest 
WHERE 
Empresa_Id = @pEmpresa_Id And
Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
isNull(Segmento1C, '') = @pSegmento1C And
isNull(Segmento2C, '') = @pSegmento2C And
isNull(Segmento3C, '') = @pSegmento3C And
isNull(Segmento4C, '') = @pSegmento4C And
isNull(Segmento1N, 0) = @pSegmento1N And
isNull(Segmento2N, 0) = @pSegmento2N And
isNull(Segmento3N, 0) = @pSegmento3N And
isNull(Segmento4N, 0) = @pSegmento4N

RETURN @@Error 

GO
