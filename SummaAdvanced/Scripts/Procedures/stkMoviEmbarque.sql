DROP PROCEDURE stkMoviEmbarqueGuardar
GO
CREATE PROCEDURE stkMoviEmbarqueGuardar
(
@pstkMoviCabe bigint,
@pcomEmbarques bigint,
@pProveed_Id varChar(25),
@pRemitoProv varchar(20),
@pDespacho_Id varchar(20) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviEmbarque WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkMoviEmbarque
	SET comEmbarques = @pcomEmbarques,
		Proveed_Id = dbo.funcFKcomProveedores(@pProveed_Id),
		RemitoProv = @pRemitoProv,
		Despacho_Id = dbo.FuncFKcomDespachos(@pDespacho_Id)
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviEmbarque
	(
		stkMoviCabe,
		comEmbarques,
		Proveed_Id,
		RemitoProv,
		Despacho_Id
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pcomEmbarques,
		dbo.funcFKcomProveedores(@pProveed_Id),
		@pRemitoProv,
		dbo.FuncFKcomDespachos(@pDespacho_Id)
	)
END 

GO

DROP PROCEDURE stkMoviEmbarqueDatos
GO
CREATE PROCEDURE stkMoviEmbarqueDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

SELECT stkMoviEmbarque.stkMoviCabe, stkMoviEmbarque.comEmbarques,
	stkMoviEmbarque.Proveed_Id, comProveedores.RazonSocial, stkMoviEmbarque.RemitoProv, comDespachos.Despacho_Id
FROM stkMoviEmbarque 
INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkMoviEmbarque.stkMoviCabe)
INNER JOIN comEmbarques  ON (comEmbarques.comEmbarques = stkMoviEmbarque.comEmbarques)
INNER JOIN comProveedores  ON (comProveedores.genEntidades = stkMoviEmbarque.Proveed_Id)
LEFT JOIN comDespachos  ON (comDespachos.comDespachos = stkMoviEmbarque.Despacho_Id)
WHERE (stkMoviEmbarque.stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviEmbarqueEliminar
GO
CREATE PROCEDURE stkMoviEmbarqueEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviEmbarque 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO
