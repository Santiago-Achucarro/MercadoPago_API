
DROP PROCEDURE comAsiSegmentosAnulGuardar
GO
CREATE PROCEDURE comAsiSegmentosAnulGuardar
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pFechaAnulacion qFechaHora,
@pAsiento_Id bigint,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comAsiSegmentosAnul WHERE (Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
		(Segmento1N = @pSegmento1N) AND (Segmento2N = @pSegmento2N) AND (Segmento3N = @pSegmento3N) AND 
		(Segmento4N = @pSegmento4N) AND (Segmento1C = @pSegmento1C) AND (Segmento2C = @pSegmento2C) AND 
		(Segmento3C = @pSegmento3C) AND (Segmento4C = @pSegmento4C) AND (FechaAnulacion = @pFechaAnulacion)))
BEGIN 
	UPDATE comAsiSegmentosAnul
	SET	Empresa_Id = @pEmpresa_Id,
		Usuario_Id = @pUsuario_Id, 
		Asiento_Id = @pAsiento_Id
	WHERE (Empresa_Id = @pEmpresa_Id) AND 
		(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
		(Segmento1N = @pSegmento1N) AND (Segmento2N = @pSegmento2N) AND (Segmento3N = @pSegmento3N) AND 
		(Segmento4N = @pSegmento4N) AND 
		(Segmento1C = @pSegmento1C) AND (Segmento2C = @pSegmento2C) AND 
		(Segmento3C = @pSegmento3C) AND (Segmento4C = @pSegmento4C) AND 
		(FechaAnulacion = @pFechaAnulacion)
END 
ELSE 
BEGIN 
	INSERT INTO comAsiSegmentosAnul
	(
		Empresa_Id,
		Segmento_Id,
		Segmento1N,
		Segmento2N,
		Segmento3N,
		Segmento4N,
		Segmento1C,
		Segmento2C,
		Segmento3C,
		Segmento4C,
		FechaAnulacion,
		Asiento_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKgenSegmentos(@pSegmento_Id),
		@pSegmento1N,
		@pSegmento2N,
		@pSegmento3N,
		@pSegmento4N,
		@pSegmento1C,
		@pSegmento2C,
		@pSegmento3C,
		@pSegmento4C,
		@pFechaAnulacion,
		@pAsiento_Id,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE comAsiSegmentosAnulDatos
GO
CREATE PROCEDURE comAsiSegmentosAnulDatos
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pFechaAnulacion qFechaHora
)
AS
SET NOCOUNT ON 

SELECT comAsiSegmentosAnul.Empresa_Id, comAsiSegmentosAnul.Empresa_Id, 
	genSegmentos.Segmento_Id, comAsiSegmentosAnul.Segmento1N,
	comAsiSegmentosAnul.Segmento2N, comAsiSegmentosAnul.Segmento3N, comAsiSegmentosAnul.Segmento4N, comAsiSegmentosAnul.Segmento1C,
	comAsiSegmentosAnul.Segmento2C, comAsiSegmentosAnul.Segmento3C, comAsiSegmentosAnul.Segmento4C, genSegmentos.Descripcion as DescripciongenSegmentos,
	comAsiSegmentosAnul.FechaAnulacion, comAsiSegmentosAnul.Asiento_Id,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM comAsiSegmentosAnul 
INNER JOIN genSegmentos  ON 
		genSegmentos.genSegmentos = comAsiSegmentosAnul.Segmento_Id
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = comAsiSegmentosAnul.Usuario_Id)
WHERE 
(comAsiSegmentosAnul.Empresa_Id = @pEmpresa_Id)
AND (genSegmentos.Segmento_Id = @pSegmento_Id)
AND (Segmento1N = @pSegmento1N)
AND (Segmento2N = @pSegmento2N)
AND (Segmento3N = @pSegmento3N)
AND (Segmento4N = @pSegmento4N)
AND (Segmento1C = @pSegmento1C)
AND (Segmento2C = @pSegmento2C)
AND (Segmento3C = @pSegmento3C)
AND (Segmento4C = @pSegmento4C)
AND (FechaAnulacion = @pFechaAnulacion)
 
 RETURN @@Error 

GO

DROP PROCEDURE comAsiSegmentosAnulEliminar
GO
CREATE PROCEDURE comAsiSegmentosAnulEliminar
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pFechaAnulacion qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comAsiSegmentosAnul 
WHERE (Empresa_Id = @pEmpresa_Id)
AND (Segmento_Id =  dbo.FuncFKgenSegmentos(@pSegmento_Id))
AND (Segmento1N = @pSegmento1N)
AND (Segmento2N = @pSegmento2N)
AND (Segmento3N = @pSegmento3N)
AND (Segmento4N = @pSegmento4N)
AND (Segmento1C = @pSegmento1C)
AND (Segmento2C = @pSegmento2C)
AND (Segmento3C = @pSegmento3C)
AND (Segmento4C = @pSegmento4C)
AND (FechaAnulacion = ISNULL(@pFechaAnulacion, FechaAnulacion))
 
RETURN @@Error 

GO

