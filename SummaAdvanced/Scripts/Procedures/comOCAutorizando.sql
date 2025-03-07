DROP PROCEDURE comOCAutorizandoGuardar
GO
CREATE PROCEDURE comOCAutorizandoGuardar
(
@pcomOrdenComp int,
@pSecuencia int,
@pNivelAuto_Id varchar(5),
@pUsuario_Id int = NULL,
@pFecha qFechaHora = NULL,
@pTipoApro char(1),
@pResultadoFormula varchar(max) = NULL
)
AS
SET NOCOUNT ON 
print @pSecuencia
IF (@pSecuencia > 0)

BEGIN 
	print 'Entro'
	UPDATE comOCAutorizando
	SET		NivelAuto_Id = dbo.FuncFKcomNivelesAuto(@pNivelAuto_Id),
		Usuario_Id = @pUsuario_Id,
		Fecha = @pFecha,
		TipoApro = @pTipoApro,
		ResultadoFormula = @pResultadoFormula
	WHERE (comOrdenComp = @pcomOrdenComp) AND (Secuencia = @pSecuencia)
END 
ELSE 
BEGIN 

SET @pSecuencia = ISNULL((SELECT MAX(Secuencia) 
		from comOCAutorizando
			WHERE
			comOrdenComp = @pcomOrdenComp),0)+1

	INSERT INTO comOCAutorizando
	(
		comOrdenComp,
		Secuencia,
		NivelAuto_Id,
		Usuario_Id,
		Fecha,
		TipoApro,
		ResultadoFormula
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pSecuencia,
		dbo.FuncFKcomNivelesAuto(@pNivelAuto_Id),
		@pUsuario_Id,
		@pFecha,
		@pTipoApro,
		@pResultadoFormula
	)
END 
SELECT @pSecuencia AS Secuencia
GO

DROP PROCEDURE comOCAutorizandoDatos
GO
CREATE PROCEDURE comOCAutorizandoDatos
(
@pcomOrdenComp int,
@pSecuencia int=null
)
AS
SET NOCOUNT ON 


SELECT  comOrdenComp.comOrdenComp, comOCAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id, comNivelesAuto.Descripcion as DescripcionNivelesAuto,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comOCAutorizando.Fecha, comOCAutorizando.TipoApro,
	comOCAutorizando.ResultadoFormula
FROM comOCAutorizando 
INNER JOIN comOrdenComp  ON (comOrdenComp.comOrdenComp = comOCAutorizando.comOrdenComp)
INNER JOIN comNivelesAuto  ON (comNivelesAuto.comNivelesAuto = comOCAutorizando.NivelAuto_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = comOCAutorizando.Usuario_Id)
WHERE (comOrdenComp.comOrdenComp = @pcomOrdenComp)
AND (Secuencia = isnull(@pSecuencia,Secuencia))
 
 RETURN @@Error 

GO

DROP PROCEDURE comOCAutorizandoEliminar
GO
CREATE PROCEDURE comOCAutorizandoEliminar
(
@pcomOrdenComp int,
@pSecuencia int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comOCAutorizando 
WHERE (comOrdenComp = @pcomOrdenComp)
AND (Secuencia = ISNULL(@pSecuencia, Secuencia))
 
 RETURN @@Error 

GO

DROP PROCEDURE comOCAutorizandoDatosSecuencia
GO
CREATE PROCEDURE comOCAutorizandoDatosSecuencia
(
@pcomOrdenComp int,
@pSecuencia int
)
AS
SET NOCOUNT ON 

SELECT comOCAutorizando.comOrdenComp, 
	comOCAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id, comNivelesAuto.Descripcion as DescripcionNivelesAuto,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comOCAutorizando.Fecha, comOCAutorizando.TipoApro,
	comOCAutorizando.ResultadoFormula, genUsuarios.genUsuarios
FROM comOCAutorizando 
INNER JOIN comOrdenComp ON (comOrdenComp.comOrdenComp = comOCAutorizando.comOrdenComp)
INNER JOIN comNivelesAuto  ON (comNivelesAuto.ComNivelesAuto = comOCAutorizando.NivelAuto_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = comOCAutorizando.Usuario_Id)
WHERE comOrdenComp.comOrdenComp =@pcomOrdenComp
AND comOCAutorizando.Secuencia = @pSecuencia
 
RETURN @@Error 

GO