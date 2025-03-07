DROP PROCEDURE venCompCartaPorteGuardar
GO
CREATE PROCEDURE venCompCartaPorteGuardar
(
@pvenmovimientos bigint,
@pTranspInternac varchar(2),
@pEntradaSalidaMerc varchar(7),
@pViaEntradaSalida varchar(2),
@pTotalDistRec numeric(5,2),
@pPesoBrutoTotal numeric(18,3),
@pUnidadPeso varchar(5) = NULL,
@pPesoNetoTotal numeric(18,3),
@pCargoPorTasacion numeric(18,3),
@pCamion_Id varchar(20) = NULL,
@pRemolque1 varchar(20) = NULL,
@pRemolque2 varchar(20) = NULL, 
@pOperador_Id VarChar(15) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCompCartaPorte WHERE (venmovimientos = @pvenmovimientos)))
BEGIN 
	UPDATE venCompCartaPorte
	SET		TranspInternac = @pTranspInternac,
		EntradaSalidaMerc = @pEntradaSalidaMerc,
		ViaEntradaSalida = @pViaEntradaSalida,
		TotalDistRec = @pTotalDistRec,
		PesoBrutoTotal = @pPesoBrutoTotal,
		UnidadPeso = @pUnidadPeso,
		PesoNetoTotal = @pPesoNetoTotal,
		CargoPorTasacion = @pCargoPorTasacion,
		Camion_Id = dbo.FuncFKvenCamiones(@pCamion_Id),
		Remolque1 = dbo.FuncFKvenCamiones(@pRemolque1),
		Remolque2 = dbo.FuncFKvenCamiones(@pRemolque2), 
		Operador_Id = dbo.FuncFKvenOperadores(@pOperador_Id)
	WHERE (venmovimientos = @pvenmovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venCompCartaPorte
	(
		venmovimientos,
		TranspInternac,
		EntradaSalidaMerc,
		ViaEntradaSalida,
		TotalDistRec,
		PesoBrutoTotal,
		UnidadPeso,
		PesoNetoTotal,
		CargoPorTasacion,
		Camion_Id,
		Remolque1,
		Remolque2, 
		Operador_Id 
	)
	VALUES 
	(
		@pvenmovimientos,
		@pTranspInternac,
		@pEntradaSalidaMerc,
		@pViaEntradaSalida,
		@pTotalDistRec,
		@pPesoBrutoTotal,
		@pUnidadPeso,
		@pPesoNetoTotal,
		@pCargoPorTasacion,
		dbo.FuncFKvenCamiones(@pCamion_Id),
		dbo.FuncFKvenCamiones(@pRemolque1),
		dbo.FuncFKvenCamiones(@pRemolque2),
		dbo.FuncFKvenOperadores(@pOperador_Id)
	)
END 

GO

DROP PROCEDURE venCompCartaPorteDatos
GO
CREATE PROCEDURE venCompCartaPorteDatos
(
@pvenmovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venCompCartaPorte.venmovimientos, venCompCartaPorte.TranspInternac, venCompCartaPorte.EntradaSalidaMerc,
	venCompCartaPorte.ViaEntradaSalida, venCompCartaPorte.TotalDistRec, venCompCartaPorte.PesoBrutoTotal, venCompCartaPorte.UnidadPeso,
	venCompCartaPorte.PesoNetoTotal, venCompCartaPorte.CargoPorTasacion, venCamiones.Patente_Id Camion_Id, venCamiones.Descripcion as DescripcionCamiones,
	venCamiones2.Patente_Id Remolque1, venCamiones2.Descripcion as DescripcionRemolque1, venCamiones3.Patente_Id Remolque2, venCamiones3.Descripcion as DescripcionRemolque2,
	venOperadores.Operador_Id, venOperadores.NombreOperador
FROM venCompCartaPorte 
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venCompCartaPorte.venmovimientos)
LEFT JOIN venCamiones  ON (venCamiones.venCamiones = venCompCartaPorte.Camion_Id)
LEFT JOIN venCamiones venCamiones2 ON (venCamiones2.venCamiones = venCompCartaPorte.Remolque1)
LEFT JOIN venCamiones venCamiones3 ON (venCamiones3.venCamiones = venCompCartaPorte.Remolque2)
LEFT JOIN venOperadores ON  venOperadores.venOperadores =venCompCartaPorte.Operador_Id
WHERE (venCompCartaPorte.venmovimientos = @pvenmovimientos)
 
RETURN @@Error 

GO

DROP PROCEDURE venCompCartaPorteEliminar
GO
CREATE PROCEDURE venCompCartaPorteEliminar
(
@pvenmovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venCompCartaPorte 
WHERE (venmovimientos = @pvenmovimientos)
RETURN @@Error 

GO

