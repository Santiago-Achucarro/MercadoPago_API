DROP PROCEDURE conInfDefFilasInsertar
GO
CREATE PROCEDURE conInfDefFilasInsertar
(
@pInforme_Id int,
@pFila int,
@pNivel int,
@pTitulo VarChar(100),
@pTipo char(2),
@pFuente char(1),
@pInvierteSigno Sino,
@pCentro1Desde varchar(8),
@pCentro1Hasta varchar(8),
@pCentro2Desde varchar(8),
@pCentro2Hasta varchar(8)
)
AS
SET NOCOUNT ON 
	INSERT INTO conInfDefFilas
	(
		Informe_Id,
		Fila,
		Nivel,
		Titulo,
		Tipo,
		Fuente,
		InvierteSigno,
		Centro1Desde,
		Centro1Hasta,
		Centro2Desde,
		Centro2Hasta
	)
	VALUES 
	(
		@pInforme_Id,
		@pFila,
		@pNivel,
		@pTitulo,
		@pTipo,
		@pFuente,
		@pInvierteSigno,
		@pCentro1Desde,
		@pCentro1Hasta,
		@pCentro2Desde,
		@pCentro2Hasta
	)
GO

DROP PROCEDURE conInfDefFilasDatos
GO
CREATE PROCEDURE conInfDefFilasDatos
(
@pInforme_Id VarChar(15),
@pFila int = NULL
)
AS
SET NOCOUNT ON 

SELECT conInfDefinibles.Informe_Id, conInfDefFilas.Fila, conInfDefFilas.Nivel,
	conInfDefFilas.Titulo, 
	conInfDefFilas.Tipo, conInfDefFilas.Fuente, conInfDefFilas.InvierteSigno, conInfDefFilas.Centro1Desde,
	conInfDefFilas.Centro1Hasta, conInfDefFilas.Centro2Desde, conInfDefFilas.Centro2Hasta, 
	conInfDefinibles.conInfDefinibles, conInfDefFilas.Fila as FilaMan
FROM conInfDefFilas 
INNER JOIN conInfDefinibles  ON (conInfDefinibles.conInfDefinibles = conInfDefFilas.Informe_Id)
WHERE conInfDefinibles.Informe_Id = @pInforme_Id
AND Fila = ISNULL(@pFila,Fila)
 
 RETURN @@Error 

GO

DROP PROCEDURE conInfDefFilasEliminar
GO
CREATE PROCEDURE conInfDefFilasEliminar
(
@pInforme_Id varchar(15),
@pFila int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conInfDefFilas 
WHERE (Informe_Id = dbo.FuncFKconInfDefinibles(@pInforme_Id))
AND (Fila = ISNULL(@pFila, Fila))
 
 RETURN @@Error 

GO

GO
