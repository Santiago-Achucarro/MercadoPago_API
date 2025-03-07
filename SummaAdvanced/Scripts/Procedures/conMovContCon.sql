DROP PROCEDURE conMovContConGuardar
GO
CREATE PROCEDURE conMovContConGuardar
(
@pconAsientos bigint,
@pRenglon int,
@pCuenta_Id varchar(25) = NULL,
@pLeyendaLibroMayor varchar(100),
@pImporte qMonedaD2,
@pTipoMov numeric(5),
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pReferenciaT QMemo = NULL,
@pReferencia1 varchar(100) = NULL,
@pReferencia2 varchar(100) = NULL,
@pReferencia3 varchar(100) = NULL,
@pReferencia4 varchar(100) = NULL,
@pReferencia5 varchar(100) = NULL,
@pBase_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conMovContCon WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE conMovContCon
	SET		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		LeyendaLibroMayor = @pLeyendaLibroMayor,
		Importe = @pImporte,
		TipoMov = @pTipoMov,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		ReferenciaT = @pReferenciaT,
		Referencia1 = @pReferencia1,
		Referencia2 = @pReferencia2,
		Referencia3 = @pReferencia3,
		Referencia4 = @pReferencia4,
		Referencia5 = @pReferencia5,
		Base_Id = dbo.FuncFKconBaseDistri(@pBase_Id)
	WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO conMovContCon
	(
		conAsientos,
		Renglon,
		Cuenta_Id,
		LeyendaLibroMayor,
		Importe,
		TipoMov,
		Centro1_Id,
		Centro2_Id,
		ReferenciaT,
		Referencia1,
		Referencia2,
		Referencia3,
		Referencia4,
		Referencia5,
		Base_Id
	)
	VALUES 
	(
		@pconAsientos,
		@pRenglon,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pLeyendaLibroMayor,
		@pImporte,
		@pTipoMov,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pReferenciaT,
		@pReferencia1,
		@pReferencia2,
		@pReferencia3,
		@pReferencia4,
		@pReferencia5,
		dbo.FuncFKconBaseDistri(@pBase_Id)
	)
END 

GO

DROP PROCEDURE conMovContConDatos
GO
CREATE PROCEDURE conMovContConDatos
(
@pconAsientos bigint,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT conMovContCon.conAsientos as Asiento_id, conMovContCon.Renglon, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conMovContCon.LeyendaLibroMayor, 
	CASE WHEN conMovContCon.TipoMov=1 THEN  conMovContCon.Importe ELSE 0 END AS Debe,
	CASE WHEN conMovContCon.TipoMov!=1 THEN  conMovContCon.Importe ELSE 0 END AS Haber,
	conCentro1.Centro1_Id,	conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	conMovContCon.ReferenciaT, conMovContCon.Referencia1, conMovContCon.Referencia2, 
	conMovContCon.Referencia3, conMovContCon.Referencia4, conMovContCon.Referencia5, 
	conBaseDistri.Base_Id, conBaseDistri.Descripcion as DescripcionBaseDistri
FROM conMovContCon 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = conMovContCon.conAsientos)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = conMovContCon.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = conMovContCon.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = conMovContCon.Centro2_Id)
LEFT JOIN conBaseDistri  ON (conBaseDistri.conBaseDistri = conMovContCon.Base_Id)
WHERE (conMovContCon.conAsientos = @pconAsientos)
AND (conMovContCon.Renglon = isnull(@pRenglon,conMovContCon.Renglon))
 
RETURN @@Error 

GO

DROP PROCEDURE conMovContConEliminar
GO
CREATE PROCEDURE conMovContConEliminar
(
@pconAsientos bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conMovContCon 
WHERE (conAsientos = @pconAsientos)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

