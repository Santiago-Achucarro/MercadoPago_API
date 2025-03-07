DROP PROCEDURE sueConceptosPropValorGuardar
GO
CREATE PROCEDURE sueConceptosPropValorGuardar
(
@pConcepto_Id int,
@pPropiedad varchar(10),
@pSiNo Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueConceptosPropValor WHERE (Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)) AND (Propiedad = dbo.FuncFKsueConceptosProp(@pPropiedad))))
BEGIN 
	UPDATE sueConceptosPropValor
	SET		SiNo = @pSiNo
	WHERE (Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)) AND (Propiedad =  dbo.FuncFKsueConceptosProp(@pPropiedad))
END 
ELSE 
BEGIN 
	INSERT INTO sueConceptosPropValor
	(
		Concepto_Id,
		Propiedad,
		SiNo
	)
	VALUES 
	(
		dbo.FuncFKsueConceptos(@pConcepto_Id),
		 dbo.FuncFKsueConceptosProp(@pPropiedad),
		@pSiNo
	)
END 

GO

DROP PROCEDURE sueConceptosPropValorDatos
GO
CREATE PROCEDURE sueConceptosPropValorDatos
(
@pConcepto_Id int,
@pPropiedad int
)
AS
SET NOCOUNT ON 

SELECT sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConceptos, sueConceptosProp.Descripcion as DescripcionConceptosProp, sueConceptosPropValor.SiNo
FROM sueConceptosPropValor 
INNER JOIN sueConceptos  ON (sueConceptos.sueConceptos = sueConceptosPropValor.Concepto_Id)
INNER JOIN sueConceptosProp  ON (sueConceptosProp.sueConceptosProp = sueConceptosPropValor.Propiedad)
WHERE (sueConceptos.Concepto_Id = @pConcepto_Id)
AND (sueConceptosProp.Propiedad = @pPropiedad)
 
 RETURN @@Error 

GO

DROP PROCEDURE sueConceptosPropValorEliminar
GO
CREATE PROCEDURE sueConceptosPropValorEliminar
(
@pConcepto_Id int,
@pPropiedad int=null
)
AS
SET NOCOUNT ON 

DELETE FROM sueConceptosPropValor 
WHERE (Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id))
AND (Propiedad = isnull( dbo.FuncFKsueConceptosProp(@pPropiedad), Propiedad))
 
 RETURN @@Error 

GO
drop FUNCTION FuncFKsueConceptosProp
go
CREATE FUNCTION FuncFKsueConceptosProp
(
@pPropiedad_Id varchar(10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueConceptosProp.sueConceptosProp FROM sueConceptosProp WHERE 
	Propiedad = @pPropiedad_Id
  RETURN @pIdentity
END
--select dbo.FuncFKsueConceptos('BaseSDI')

GO
