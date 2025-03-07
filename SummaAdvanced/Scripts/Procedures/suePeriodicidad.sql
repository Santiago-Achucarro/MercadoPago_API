DROP PROCEDURE suePeriodicidadGuardar
GO
CREATE PROCEDURE suePeriodicidadGuardar
(
@pPeriodo_Id char(1),
@pPeriodo_Id_Nueva char(1),
@pDescripcion varchar(30),
@pDias qMonedaD4,
@pCodFiscal VarChar(2) = NULL,
@pEmpresa_Id int =null
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM suePeriodicidad WHERE (Periodo_Id = @pPeriodo_Id)))
BEGIN 
	UPDATE suePeriodicidad
	SET		Periodo_Id=@pPeriodo_Id_Nueva,
	Descripcion = @pDescripcion,
		Dias = @pDias, 
		CodFiscal = @pCodFiscal,
		Empresa_Id=@pEmpresa_Id
	WHERE (Periodo_Id = @pPeriodo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO suePeriodicidad
	(
		Periodo_Id,
		Descripcion,
		Dias,
		FechaActiva,
		CodFiscal,
		Empresa_Id
	)
	VALUES 
	(
		@pPeriodo_Id_Nueva,
		@pDescripcion,
		@pDias,
		dbo.FechaActual(),
		@pCodFiscal,
		@pEmpresa_Id
	)
END 

GO

DROP PROCEDURE suePeriodicidadDatos
GO
CREATE PROCEDURE suePeriodicidadDatos
(
@pPeriodo_Id char(1)
)
AS
SET NOCOUNT ON 

SELECT suePeriodicidad.Periodo_Id, suePeriodicidad.Periodo_Id as Periodo_Id_Nueva, suePeriodicidad.Descripcion, suePeriodicidad.Dias, suePeriodicidad.FechaActiva,
Empresa_Id, cast(case when suePeriodicidad.Empresa_Id is null then 1 else 0 end as bit) as PTodasEmpresas, CodFiscal
FROM suePeriodicidad 
WHERE (Periodo_Id = @pPeriodo_Id)

RETURN @@Error 
GO

DROP PROCEDURE suePeriodicidadEliminar
GO
CREATE PROCEDURE suePeriodicidadEliminar
(
@pPeriodo_Id char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePeriodicidad 
WHERE (Periodo_Id = ISNULL(@pPeriodo_Id, Periodo_Id))
 
 RETURN @@Error 

GO

GO
