DROP PROCEDURE conInfDefCuentasInsertar
GO
CREATE PROCEDURE conInfDefCuentasInsertar
(
@pInforme_Id int,
@pFila int,
@pCuentaDesde varchar(25),
@pCuentaHasta varchar(25)
)
AS
BEGIN 
	INSERT INTO conInfDefCuentas
	(
		Informe_Id,
		Fila,
		CuentaDesde,
		CuentaHasta
	)
	VALUES 
	(
		@pInforme_Id,
		@pFila,
		@pCuentaDesde,
		@pCuentaHasta
	)
END 

GO

DROP PROCEDURE conInfDefCuentasDatos
GO
CREATE PROCEDURE conInfDefCuentasDatos
(
@pInforme_Id VarChar(15),
@pFila int = NULL,
@pCuentaDesde varchar(25)= NULL
)
AS
SET NOCOUNT ON 

SELECT conInfDefinibles.Informe_Id, conInfDefCuentas.Fila,  conInfDefCuentas.CuentaDesde, conInfDefCuentas.CuentaHasta,
	conInfDefinibles.conInfDefinibles
FROM conInfDefCuentas 
	INNER JOIN conInfDefinibles ON  conInfDefinibles.conInfDefinibles = conInfDefCuentas.Informe_Id
WHERE 
conInfDefinibles.Informe_Id = @pInforme_Id
AND Fila = ISNULL(@pFila,Fila)
AND CuentaDesde = ISNULL(@pCuentaDesde,CuentaDesde)
 
RETURN @@Error 

GO

DROP PROCEDURE conInfDefCuentasEliminar
GO
CREATE PROCEDURE conInfDefCuentasEliminar
(
@pInforme_Id varchar(15),
@pFila int = null,
@pCuentaDesde varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conInfDefCuentas 
WHERE  
(Informe_Id = dbo.FuncFKconInfDefinibles(@pInforme_Id))
AND Fila = ISNULL(@pFila,Fila)
AND CuentaDesde = ISNULL(@pCuentaDesde,CuentaDesde)
 
RETURN @@Error 

GO
