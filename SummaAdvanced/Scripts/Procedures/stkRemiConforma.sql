DROP PROCEDURE stkRemiConformaGuardar
GO
CREATE PROCEDURE stkRemiConformaGuardar
(
@pstkMoviCabe bigint,
@pUsuario_Id int,
@pFechaConforma datetime,
@pObservaciones QMemo = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkRemiConforma WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkRemiConforma
	SET		Usuario_Id = @pUsuario_Id,
		FechaConforma = @pFechaConforma,
		FechaRegistro = getDate() ,
		Observaciones = @pObservaciones
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkRemiConforma
	(
		stkMoviCabe,
		Usuario_Id,
		FechaConforma,
		FechaRegistro,
		Observaciones
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pUsuario_Id,
		@pFechaConforma,
		getDate(),
		@pObservaciones
	)
END 

GO

DROP PROCEDURE stkRemiConformaDatos
GO
CREATE PROCEDURE stkRemiConformaDatos
(
@pSegmento_Id VarChar(10),
@pSegmento1C VarChar(25),
@pSegmento2C VarChar(25),
@pSegmento3C VarChar(25),
@pSegmento4C VarChar(25),
@pSegmento1N Int,
@pSegmento2N Int,
@pSegmento3N Int,
@pSegmento4N Int,
@pEmpresa_Id Int

)
AS
SET NOCOUNT ON 

DECLARE @stkMoviCabe bigint

SELECT @stkMoviCabe=stkRemiConforma.stkMoviCabe
FROM stkRemiConforma 
INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkRemiConforma.stkMoviCabe)
INNER JOIN stkRemitos ON stkRemitos.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkRemiConforma.Usuario_Id)
INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN venClientes ON  venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
WHERE 
genSegmentos.Segmento_Id = @pSegmento_Id and 
genAsiSegmentos.Segmento1C = @pSegmento1C and 
genAsiSegmentos.Segmento2C = @pSegmento2C and 
genAsiSegmentos.Segmento3C = @pSegmento3C and 
genAsiSegmentos.Segmento4C = @pSegmento4C and 
genAsiSegmentos.Segmento1N = @pSegmento1N and 
genAsiSegmentos.Segmento2N = @pSegmento2N and 
genAsiSegmentos.Segmento3N = @pSegmento3N and 
genAsiSegmentos.Segmento4N = @pSegmento4N and 
genAsiSegmentos.Empresa_Id = @pEmpresa_Id


SELECT stkRemiConforma.stkMoviCabe, genSegmentos.Segmento_Id,
genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
conAsientos.Fecha, conAsientos.Anulado, conAsientos.Posteado,
venClientes.Cliente_Id, venClientes.RazonSocial,
genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	stkRemiConforma.FechaConforma, stkRemiConforma.FechaRegistro, stkRemiConforma.Observaciones
FROM stkRemiConforma 
INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkRemiConforma.stkMoviCabe)
INNER JOIN stkRemitos ON stkRemitos.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkRemiConforma.Usuario_Id)
INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN venClientes ON  venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
WHERE 
genSegmentos.Segmento_Id = @pSegmento_Id and 
genAsiSegmentos.Segmento1C = @pSegmento1C and 
genAsiSegmentos.Segmento2C = @pSegmento2C and 
genAsiSegmentos.Segmento3C = @pSegmento3C and 
genAsiSegmentos.Segmento4C = @pSegmento4C and 
genAsiSegmentos.Segmento1N = @pSegmento1N and 
genAsiSegmentos.Segmento2N = @pSegmento2N and 
genAsiSegmentos.Segmento3N = @pSegmento3N and 
genAsiSegmentos.Segmento4N = @pSegmento4N and 
genAsiSegmentos.Empresa_Id = @pEmpresa_Id
 
 exec genAtributosGeneralesIdentityDatos @stkmovicabe , 'stkRemiConforma'
 exec genAdjuntosIdentityDatos 'stkRemiConforma', 0
 RETURN @@Error 

GO

DROP PROCEDURE stkRemiConformaEliminar
GO
CREATE PROCEDURE stkRemiConformaEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkRemiConforma 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO

GO
