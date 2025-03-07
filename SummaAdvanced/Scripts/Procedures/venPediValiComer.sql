DROP PROCEDURE venPediValiComerGuardar
GO
CREATE PROCEDURE venPediValiComerGuardar
(
@pvenPedidos int,
@pMVendedor Sino,
@pMFormaE Sino,
@pMListaP Sino,
@pMBonifDato Sino,
@pMBonifReng Sino,
@pMPrecioReng Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venPediValiComer WHERE (venPedidos = @pvenPedidos)))
BEGIN 
	UPDATE venPediValiComer
	SET MVendedor = @pMVendedor,
		MFormaE = @pMFormaE,
		MListaP = @pMListaP,
		MBonifDato = @pMBonifDato,
		MBonifReng = @pMBonifReng,
		MPrecioReng = @pMPrecioReng
	WHERE (venPedidos = @pvenPedidos)
END 
ELSE 
BEGIN 
	INSERT INTO venPediValiComer
	(
		venPedidos,
		MVendedor,
		MFormaE,
		MListaP,
		MBonifDato,
		MBonifReng,
		MPrecioReng
	)
	VALUES 
	(
		@pvenPedidos,
		@pMVendedor,
		@pMFormaE,
		@pMListaP,
		@pMBonifDato,
		@pMBonifReng,
		@pMPrecioReng
	)
END 

GO

DROP PROCEDURE venPediValiComerDatos
GO
CREATE PROCEDURE venPediValiComerDatos
(
@pvenPedidos int
)
AS
SET NOCOUNT ON 

SELECT venPediValiComer.venPedidos, venPediValiComer.MVendedor, venPediValiComer.MFormaE, venPediValiComer.MListaP,
	venPediValiComer.MBonifDato, venPediValiComer.MBonifReng, venPediValiComer.MPrecioReng
FROM venPediValiComer 
WHERE (venPedidos = @pvenPedidos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venPediValiComerEliminar
GO
CREATE PROCEDURE venPediValiComerEliminar
(
@pvenPedidos int
)
AS
SET NOCOUNT ON 

DELETE FROM venPediValiComer 
WHERE venPedidos = @pvenPedidos
 
RETURN @@Error 

GO
