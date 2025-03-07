DROP PROCEDURE genMovCuotasGuardar
GO
CREATE PROCEDURE genMovCuotasGuardar
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pFechaVencimiento qFecha,
@pImporte qMonedaD2,
@pSaldo qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genMovCuotas WHERE (Asiento_Id = @pAsiento_Id) AND (CuotaNro = @pCuotaNro)))
BEGIN 
	UPDATE genMovCuotas
	SET		FechaVencimiento = @pFechaVencimiento,
		Importe = @pImporte,
		Saldo = @pSaldo
	WHERE (Asiento_Id = @pAsiento_Id) AND (CuotaNro = @pCuotaNro)
END 
ELSE 
BEGIN 
	INSERT INTO genMovCuotas
	(
		Asiento_Id,
		CuotaNro,
		FechaVencimiento,
		Importe,
		Saldo
	)
	VALUES 
	(
		@pAsiento_Id,
		@pCuotaNro,
		@pFechaVencimiento,
		@pImporte,
		@pSaldo
	)
END 

GO

DROP PROCEDURE genMovCuotasDatos
GO
CREATE PROCEDURE genMovCuotasDatos
(
@pAsiento_Id bigint,
@pCuotaNro smallint = NULL
)
AS
SET NOCOUNT ON 



SELECT genMovCuotas.Asiento_Id, genMovCuotas.CuotaNro, genMovCuotas.FechaVencimiento,
	genMovCuotas.Importe, genMovCuotas.Saldo
FROM genMovCuotas 
WHERE (Asiento_Id = @pAsiento_Id)
	AND (CuotaNro = ISNULL(@pCuotaNro, CuotaNro))
order by 2 
 RETURN @@Error 

GO

DROP PROCEDURE genMovCuotasEliminar
GO
CREATE PROCEDURE genMovCuotasEliminar
(
@pAsiento_Id bigint,
@pCuotaNro smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genMovCuotas 
WHERE (Asiento_Id = @pAsiento_Id)
AND (CuotaNro = ISNULL(@pCuotaNro, CuotaNro))
 
 RETURN @@Error 

GO


DROP PROCEDURE genMovCuotasAplicar
GO
CREATE PROCEDURE genMovCuotasAplicar
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pMonto qMonedaD2
)
AS
UPDATE genMovCuotas
	SET	Saldo = Saldo - @pMonto
		WHERE (Asiento_Id = @pAsiento_Id) AND (CuotaNro = @pCuotaNro)

-- LLAMO AQUI TAMBIEN A LOS PADRES

UPDATE venMovimientos SET Saldo = Saldo - @pMonto where
	venMovimientos = @pAsiento_Id

UPDATE comMovprov SET Saldo = Saldo - @pMonto where
	comMovprov = @pAsiento_Id


GO
