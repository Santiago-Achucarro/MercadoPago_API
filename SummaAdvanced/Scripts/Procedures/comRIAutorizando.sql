DROP PROCEDURE comRIAutorizandoGuardar
GO
CREATE PROCEDURE comRIAutorizandoGuardar
(
@pcomReqInterno int,
@pSecuencia int,
@pNivelAuto_Id varchar(5),
@pUsuario_Id int = NULL,
@pFecha qFechaHora = NULL,
@pTipoApro char(1),
@pResultadoFormula QMemo = NULL
)
AS
SET NOCOUNT ON 
IF (@pSecuencia > 0)
BEGIN 
	UPDATE comRIAutorizando
	SET		NivelAuto_Id = dbo.FuncFKcomNivelesAuto(@pNivelAuto_Id),
		Usuario_Id = @pUsuario_Id,
		Fecha = @pFecha,
		TipoApro = @pTipoApro,
		ResultadoFormula = @pResultadoFormula
	WHERE (comReqInterno = @pcomReqInterno) AND (Secuencia = @pSecuencia)
END 
ELSE 
BEGIN 
	SET @pSecuencia = ISNULL((SELECT MAX(Secuencia) 
		from comRIAutorizando 
			WHERE
			comReqInterno = @pcomReqInterno),0)+1

	INSERT INTO comRIAutorizando
	(
		comReqInterno,
		Secuencia,
		NivelAuto_Id,
		Usuario_Id,
		Fecha,
		TipoApro,
		ResultadoFormula
	)
	VALUES 
	(
		@pcomReqInterno,
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

DROP PROCEDURE comRIAutorizandoDatos
GO
CREATE PROCEDURE comRIAutorizandoDatos
(
@pcomReqInterno int,
@pSecuencia int=null
)
AS
SET NOCOUNT ON 

SELECT comRIAutorizando.comReqInterno, 
	comRIAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id, comNivelesAuto.Descripcion as DescripcionNivelesAuto,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comRIAutorizando.Fecha, comRIAutorizando.TipoApro,
	comRIAutorizando.ResultadoFormula, genUsuarios.genUsuarios
FROM comRIAutorizando 
INNER JOIN comReqInterno  ON (comReqInterno.comReqInterno = comRIAutorizando.comReqInterno)
INNER JOIN comNivelesAuto  ON (comNivelesAuto.comNivelesAuto = comRIAutorizando.NivelAuto_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = comRIAutorizando.Usuario_Id)
WHERE (comReqInterno.comReqInterno = @pcomReqInterno)
AND (Secuencia = isnull(@pSecuencia,Secuencia))
 
 RETURN @@Error 

GO

DROP PROCEDURE comRIAutorizandoEliminar
GO
CREATE PROCEDURE comRIAutorizandoEliminar
(
@pcomReqInterno int,
@pSecuencia int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comRIAutorizando 
WHERE (comReqInterno = @pcomReqInterno)
AND (Secuencia = ISNULL(@pSecuencia, Secuencia))
 
 RETURN @@Error 

GO

DROP PROCEDURE comRiAutorizandoDatosSecuencia
GO
CREATE PROCEDURE comRiAutorizandoDatosSecuencia
(
@pcomReqInterno int,
@pSecuencia int
)
AS
SET NOCOUNT ON 

SELECT comRIAutorizando.comReqInterno, 
	comRIAutorizando.Secuencia, comNivelesAuto.NivelAuto_Id, comNivelesAuto.Descripcion as DescripcionNivelesAuto,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comRIAutorizando.Fecha, comRIAutorizando.TipoApro,
	comRIAutorizando.ResultadoFormula, genUsuarios.genUsuarios
FROM comRiAutorizando 
INNER JOIN comReqInterno ON (comReqInterno.comReqInterno = comRiAutorizando.comReqInterno)
INNER JOIN comNivelesAuto  ON (comNivelesAuto.ComNivelesAuto = comRiAutorizando.NivelAuto_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = comRiAutorizando.Usuario_Id)
WHERE comRiAutorizando.comReqInterno = @pcomReqInterno
AND comRiAutorizando.Secuencia = @pSecuencia
 
RETURN @@Error 

GO