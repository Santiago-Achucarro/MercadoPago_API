DROP PROCEDURE sueConceptosPropGuardar
GO
CREATE PROCEDURE sueConceptosPropGuardar
(
@pPropiedad varchar(10),
@pPropiedad_Nuevo varchar(10),
@pOrden int,
@pDescripcion varchar(80),
@pAgrupamiento varchar(20)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueConceptosProp WHERE (Propiedad = @pPropiedad)))
BEGIN 
	UPDATE sueConceptosProp
	SET @lIdentidad = sueConceptosProp,
		Propiedad = @pPropiedad_Nuevo,
		Orden = @pOrden,
		Descripcion = @pDescripcion,
		Agrupamiento = @pAgrupamiento
	WHERE (Propiedad = @pPropiedad)
END 
ELSE 
BEGIN 
	INSERT INTO sueConceptosProp
	(
		Propiedad,
		Orden,
		Descripcion,
		Agrupamiento
	)
	VALUES 
	(
		@pPropiedad,
		@pOrden,
		@pDescripcion,
		@pAgrupamiento
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueConceptosPropDatos
GO
CREATE PROCEDURE sueConceptosPropDatos
(
@pPropiedad varchar(10)
)
AS
SET NOCOUNT ON 

SELECT sueConceptosProp.sueConceptosProp, sueConceptosProp.Propiedad, sueConceptosProp.Orden, sueConceptosProp.Descripcion,
	sueConceptosProp.Agrupamiento
FROM sueConceptosProp 
WHERE (Propiedad = @pPropiedad)
 


Declare @pidentity bigint= dbo.FuncFKsueConceptosProp(@pPropiedad)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueConceptosProp'
RETURN @@Error 

GO

DROP PROCEDURE sueConceptosPropEliminar
GO
CREATE PROCEDURE sueConceptosPropEliminar
(
@pPropiedad varchar(10) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueConceptosProp 
WHERE (Propiedad = @pPropiedad)
 
RETURN @@Error 

GO

DROP FUNCTION FuncFKsueConceptosProp
GO

CREATE FUNCTION FuncFKsueConceptosProp
(
@pPropiedad varchar (10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueConceptosProp FROM sueConceptosProp WHERE 
	Propiedad = @pPropiedad
  RETURN @pIdentity
END

GO

Drop procedure sueConceptosPropTodosDatos
Go
Create procedure sueConceptosPropTodosDatos
As
Select 0 Empresa_Id

Select Propiedad, Orden, Descripcion, Agrupamiento
From sueConceptosProp
Go

Drop procedure sueConceptosPropValorTieneInfo
Go
Create procedure sueConceptosPropValorTieneInfo
(
@pPropiedad varChar(10)
)
As

Select sueConceptos.Concepto_Id, sueConceptos.Descripcion, sueConceptosProp.Propiedad, sueConceptosProp.Descripcion DescPropiedad
From sueConceptosPropValor
Inner Join sueConceptos On sueConceptos.Concepto_Id = sueConceptosPropValor.Concepto_Id
Inner Join sueConceptosProp On sueConceptosProp.sueConceptosProp = sueConceptosPropValor.Propiedad
Where sueConceptosProp.Propiedad = @pPropiedad
Go
