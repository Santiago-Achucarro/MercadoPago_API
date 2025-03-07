DROP PROCEDURE conAsieTipoCuerpoInsertar
GO
CREATE PROCEDURE conAsieTipoCuerpoInsertar
(
@pAsiTipo_Id int,
@pRenglon smallint,
@pCuenta_Id varchar(25) = NULL,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pLeyendaLibroMayor varchar(100),
@pHaber qMonedaD2,
@pDebe qMonedaD2
)
AS
SET NOCOUNT ON 

	INSERT INTO conAsieTipoCuerpo
	(
		AsiTipo_Id,
		Renglon,
		Cuenta_Id,
		Centro1_Id,
		Centro2_Id,
		LeyendaLibroMayor,
		Haber,
		Debe
	)
	VALUES 
	(
		@pAsiTipo_Id,
		@pRenglon,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pLeyendaLibroMayor,
		@pHaber,
		@pDebe
	)


GO

DROP PROCEDURE conAsieTipoCuerpoDatos
GO
CREATE PROCEDURE conAsieTipoCuerpoDatos
(
@pAsiTipo_Id int,
@pRenglon smallint=null
)
AS
SET NOCOUNT ON 

SELECT conAsieTipoCuerpo.AsiTipo_Id, conAsieTipoCuerpo.Renglon, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	conAsieTipoCuerpo.LeyendaLibroMayor, conAsieTipoCuerpo.Haber, conAsieTipoCuerpo.Debe
FROM conAsieTipoCuerpo 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = conAsieTipoCuerpo.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = conAsieTipoCuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = conAsieTipoCuerpo.Centro2_Id)
WHERE (conAsieTipoCuerpo.AsiTipo_Id = @pAsiTipo_Id)
AND (conAsieTipoCuerpo.Renglon = ISNULL(@pRenglon,conAsieTipoCuerpo.Renglon))
 
RETURN @@Error 

GO

DROP PROCEDURE conAsieTipoCuerpoEliminar
GO
CREATE PROCEDURE conAsieTipoCuerpoEliminar
(
@pAsiTipo_Id int,
@pRenglon smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conAsieTipoCuerpo 
WHERE (AsiTipo_Id = @pAsiTipo_Id)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
RETURN @@Error 

GO


