DROP PROCEDURE impPadronGuardar
GO
CREATE PROCEDURE impPadronGuardar
(
@pPadron_Id varchar(10),
@pPadron_Id_Nuevo varchar(10),
@pDescripcion varchar(100),
@pEmpresa_Id int = NULL,
@pTabla varchar(60),
@pPeriodo char(1),
@pColCuit varchar(20),
@pColAnio varchar(20),
@pColPeriodo varchar(20),
@pColBusqueda varchar(20) = null,
@pColBusquedaValor varChar(5) = null,
@pColDevolucion varchar(20),
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int,
@pStoreProcedure varChar(200),
@pPosInicioCUIT int = null, 
@pCUITConGuiones Sino, 
@pPosInicioDevolucion int = null,
@pLineaInicioDatos int,
@pLongDevolucion int,
@pTextoAReemplazar varchar(20) = null,
@pTextoDeReeemplazo varchar(20) = null,
@pConfigurable Sino 
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM impPadron WHERE (Padron_Id = @pPadron_Id)))
BEGIN 
	UPDATE impPadron
	SET	@lIdentidad = impPadron,
		Padron_Id = @pPadron_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Tabla = @pTabla,
		Periodo = @pPeriodo,
		ColCuit = @pColCuit,
		ColAnio = @pColAnio,
		ColPeriodo = @pColPeriodo,
		ColBusqueda = @pColBusqueda,
		ColBusquedaValor = @pColBusquedaValor,
		ColDevolucion = @pColDevolucion,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		StoreProcedure = @pStoreProcedure,
		PosInicioCUIT = @pPosInicioCUIT, 
		CUITConGuiones = @pCUITConGuiones, 
		PosInicioDevolucion = @pPosInicioDevolucion,
		LineaInicioDatos = @pLineaInicioDatos,
		LongDevolucion = @pLongDevolucion,
		TextoAReemplazar = @pTextoAReemplazar,
		TextoDeReeemplazo = @pTextoDeReeemplazo,
		Configurable =@pConfigurable

	WHERE (Padron_Id = @pPadron_Id)
END 
ELSE 
BEGIN 
	INSERT INTO impPadron
	(
		Padron_Id,
		Descripcion,
		Empresa_Id,
		Tabla,
		Periodo,
		ColCuit,
		ColAnio,
		ColPeriodo,
		ColBusqueda,
		ColBusquedaValor,
		ColDevolucion,
		Inactivo,
		Posteado,
		Usuario_Id,
		StoreProcedure, 
		PosInicioCUIT, 
		CUITConGuiones, 
		PosInicioDevolucion,
		LineaInicioDatos,
		LongDevolucion,
		TextoAReemplazar,
		TextoDeReeemplazo,
		Configurable

	)
	VALUES 
	(
		@pPadron_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pTabla,
		@pPeriodo,
		@pColCuit,
		@pColAnio,
		@pColPeriodo,
		@pColBusqueda,
		@pColBusquedaValor,
		@pColDevolucion,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pStoreProcedure,
		@pPosInicioCUIT, 
		@pCUITConGuiones, 
		@pPosInicioDevolucion,
		@pLineaInicioDatos,
		@pLongDevolucion,
		@pTextoAReemplazar,
		@pTextoDeReeemplazo,
		@pConfigurable

	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO
--impPadronDatos 'PBARET'
DROP PROCEDURE impPadronDatos
GO
CREATE PROCEDURE impPadronDatos
(
@pPadron_Id varchar(10)
)
AS
SET NOCOUNT ON 

SELECT impPadron.impPadron, impPadron.Padron_Id, impPadron.Descripcion, impPadron.Padron_Id Padron_Id_Nueva,
	'' Cuit,	getDate() FechaBusqueda, Cast(0 As Numeric(5, 2)) ValorRetorno,
	impPadron.Empresa_Id, Cast( Case When impPadron.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, impPadron.Tabla, impPadron.Periodo,
	impPadron.ColCuit, impPadron.ColAnio, impPadron.ColPeriodo, impPadron.ColBusqueda, impPadron.ColBusquedaValor, impPadron.ColDevolucion,
	impPadron.Inactivo, impPadron.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, impPadron.StoreProcedure,
    impPadron.PosInicioCUIT, impPadron.CUITConGuiones, impPadron.PosInicioDevolucion, impPadron.LineaInicioDatos, impPadron.LongDevolucion,
	impPadron.TextoAReemplazar, impPadron.TextoDeReeemplazo, impPadron.Configurable

FROM impPadron 
Inner JOIN genUsuarios  ON (genUsuarios.genUsuarios = impPadron.Usuario_Id)
WHERE (Padron_Id = @pPadron_Id)

Declare @pidentity bigint= dbo.FuncFKimpPadron(@pPadron_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'impPadron'
RETURN @@Error 

GO

DROP PROCEDURE impPadronEliminar
GO
CREATE PROCEDURE impPadronEliminar
(
@pPadron_Id varchar(10) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impPadron 
WHERE (Padron_Id = @pPadron_Id)
 
RETURN @@Error 

GO

DROP FUNCTION FuncFKimpPadron
GO

CREATE FUNCTION FuncFKimpPadron
(
@pPadron_Id varchar (10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = impPadron FROM impPadron WHERE 
	Padron_Id = @pPadron_Id
  RETURN @pIdentity
END

GO
Drop procedure impPadronBuscar
Go
Create procedure impPadronBuscar
(
@pPadron_Id varchar (10),
@pCuit char(14),
@pAnio smallint,
@pPeriodo smallint,
@pTrimestre smallint,
@pMes smallint
)
As

DECLARE @Sql nVarchar(max)
DECLARE @ParmDefinition nVarChar(max)
Declare @lRetorno qMonedaD4
Declare @ppPadron_Int int = (Select impPadron From impPadron Where Padron_Id = @pPadron_Id)

If (Select Configurable From impPadron Where Padron_Id = @pPadron_Id) = 0
	Select @Sql = 'Select @lRetorno = ' + ColDevolucion + ' From ' + Tabla + ' Where ' + ColCuit + '= @ppCuit' + ' And ' + 
	ColAnio + ' = @ppAnio And ' + ColPeriodo + ' = @ppPeriodo' +  isNull(' And ' + ColBusqueda + ' = ''' + ColBusquedaValor + '''', '')
	From impPadron
	Where Padron_Id = @pPadron_Id
Else
	Select @lRetorno = Alicuota From impPadronTxt Where Cuit = @pCuit And Anio = @pAnio And Trimestre = @pTrimestre And Mes = @pMes And Padron_Id = @ppPadron_Int


--Print @Sql


Set @ParmDefinition = N'@ppCuit char(14), @ppAnio smallint, @ppPeriodo smallint, @ppPadron_Id int, @lRetorno qMonedaD4 OUTPUT';  

EXEC sp_executesql @Sql, @ParmDefinition, @ppCuit = @pCuit, @ppAnio = @pAnio, @ppPeriodo = @pPeriodo, @ppPadron_Id = @ppPadron_Int, @lRetorno = @lRetorno OUTPUT

Select IsNull(@lRetorno, 0)
Go 

--impPadronEstaEn'CABAPEREX','30-50097401-6',2022,8, 8, 0

Drop procedure impPadronEstaEn
Go
Create procedure impPadronEstaEn
(
@pPadron_Id varchar (10),
@pCuit char(14),
@pAnio smallint,
@pPeriodo smallint,
@pTrimestre smallint,
@pMes smallint
)
As

DECLARE @Sql nVarchar(max)
DECLARE @ParmDefinition nVarChar(max)
Declare @lRetorno Decimal
Declare @ppPadron_Int int = (Select impPadron From impPadron Where Padron_Id = @pPadron_Id)

If (Select Configurable From impPadron Where Padron_Id = @pPadron_Id) = 0
	Select @Sql = 'Select @lRetorno = 1 From ' + Tabla + ' Where ' + ColCuit + '= @ppCuit' + ' And ' + 
	ColAnio + ' = @ppAnio And ' + ColPeriodo + ' = @ppPeriodo' +  isNull(' And ' + ColBusqueda + ' = ''' + ColBusquedaValor + '''', '')
	From impPadron
	Where Padron_Id = @pPadron_Id
Else

	Select @lRetorno = 1 From impPadronTxt Where Cuit = @pCuit And Anio = @pAnio And Trimestre = @pTrimestre And Mes = @pMes And Padron_Id = @ppPadron_Int

Print @Sql

Set @ParmDefinition = N'@ppCuit char(14), @ppAnio smallint, @ppPeriodo smallint, @ppPadron_Id int, @lRetorno qMonedaD4 OUTPUT';  

EXEC sp_executesql @Sql, @ParmDefinition, @ppCuit = @pCuit, @ppAnio = @pAnio, @ppPeriodo = @pPeriodo, @ppPadron_Id = @ppPadron_Int, @lRetorno = @lRetorno OUTPUT

Select Cast(IsNull(@lRetorno, 0) As Int)
Go 