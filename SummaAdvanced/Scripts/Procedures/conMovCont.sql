DROP PROCEDURE conMovContGuardar
GO
CREATE PROCEDURE conMovContGuardar
(
@pconAsientos bigint,
@pRenglon int,
@pCuenta_Id varchar(25) = NULL,
@pLeyendaLibroMayor varchar(100),
@pImporte qMonedaD2,
@pImporteMonedaOriginal qMonedaD2,
@pTipoMov numeric(5),
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pClase varchar(5)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conMovCont WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE conMovCont
	SET		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		LeyendaLibroMayor = @pLeyendaLibroMayor,
		Importe = @pImporte,
		ImporteMonedaOriginal = @pImporteMonedaOriginal,
		TipoMov = @pTipoMov,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		Clase = @pClase
	WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO conMovCont
	(
		conAsientos,
		Renglon,
		Cuenta_Id,
		LeyendaLibroMayor,
		Importe,
		ImporteMonedaOriginal,
		TipoMov,
		Centro1_Id,
		Centro2_Id,
		Clase
	)
	VALUES 
	(
		@pconAsientos,
		@pRenglon,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pLeyendaLibroMayor,
		@pImporte,
		@pImporteMonedaOriginal,
		@pTipoMov,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pClase
	)
END 

GO

DROP PROCEDURE conMovContDatos
GO
CREATE PROCEDURE conMovContDatos
(
@pconAsientos bigint,
@pRenglon int= null
)
AS
SET NOCOUNT ON 

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
WHERE (conMovCont.conAsientos = @pconAsientos)
AND (conMovCont.Renglon = ISNULL(@pRenglon,Renglon))
ORDER BY 2

RETURN @@Error 

GO

DROP PROCEDURE conMovContEliminar
GO
CREATE PROCEDURE conMovContEliminar
(
@pconAsientos bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conMovCont 
WHERE (conAsientos = @pconAsientos)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
