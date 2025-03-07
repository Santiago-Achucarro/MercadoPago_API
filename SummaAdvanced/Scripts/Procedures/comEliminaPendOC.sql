DROP PROCEDURE comEliminaPendOCGuardar
GO
CREATE PROCEDURE comEliminaPendOCGuardar
(
@pcomOrdenComp int,
@pUsuario_Id int,
@pFecha qFecha,
@pAsiento_Id bigint = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comEliminaPendOC WHERE (comOrdenComp = @pcomOrdenComp)))
BEGIN 
	UPDATE comEliminaPendOC
	SET		Usuario_Id = @pUsuario_Id,
		Fecha = @pFecha,
		Asiento_Id = @pAsiento_Id
	WHERE (comOrdenComp = @pcomOrdenComp)
END 
ELSE 
BEGIN 
	INSERT INTO comEliminaPendOC
	(
		comOrdenComp,
		Usuario_Id,
		Fecha,
		Asiento_Id
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pUsuario_Id,
		@pFecha,
		@pAsiento_Id
	)
END 

GO

DROP PROCEDURE comEliminaPendOCDatos
GO
CREATE PROCEDURE comEliminaPendOCDatos
(
@pcomOrdenComp int
)
AS
SET NOCOUNT ON 

SELECT comEliminaPendOC.Fecha, 	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	conAsientos.Empresa_id, conAsientos.FechaRegistro, 
	genMonedas.Moneda_id, genMonedas.Descripcion DescripcionMoneda, 
	conAsientos.Cambio, conAsientos.CambioMonedaOriginal, conAsientos.Anulado,
	conAsientos.Observaciones, conAsientos.Posteado
FROM comEliminaPendOC 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comEliminaPendOC.Usuario_Id)
left join 
	(conAsientos inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_id )  ON conAsientos.conAsientos = comEliminaPendOC.Asiento_Id
WHERE (comEliminaPendOC.comOrdenComp = @pcomOrdenComp)


DECLARE @Asiento_id bigint 
SET @Asiento_id = (SELECT Asiento_id from comEliminaPendOC where 
	(comEliminaPendOC.comOrdenComp = @pcomOrdenComp))
	
exec conMovContDatos @Asiento_id

 
RETURN @@Error 

GO

DROP PROCEDURE comEliminaPendOCEliminar
GO
CREATE PROCEDURE comEliminaPendOCEliminar
(
@pcomOrdenComp int
)
AS
SET NOCOUNT ON 

DELETE FROM comEliminaPendOC 
WHERE (comOrdenComp = @pcomOrdenComp)
 
RETURN @@Error 

GO

