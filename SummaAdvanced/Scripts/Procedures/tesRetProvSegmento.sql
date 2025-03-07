DROP PROCEDURE tesRetProvSegmentoGuardar
GO
CREATE PROCEDURE tesRetProvSegmentoGuardar
(
@pEmpresa_Id int,
@pSegmento_Id varChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@ptesMovimientos bigint,
@pconRenglon int,
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesRetProvSegmento 
		WHERE (Empresa_Id = @pEmpresa_Id) AND 
		(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
		(Segmento1N = @pSegmento1N) AND 
		(Segmento2N = @pSegmento2N) AND 
		(Segmento3N = @pSegmento3N) AND 
		(Segmento4N = @pSegmento4N) AND 
		(Segmento1C = @pSegmento1C) AND 
		(Segmento2C = @pSegmento2C) AND 
		(Segmento3C = @pSegmento3C) AND 
		(Segmento4C = @pSegmento4C)))
BEGIN 
	UPDATE tesRetProvSegmento
	SET	Empresa_Id = @pEmpresa_Id,
		tesMovimientos = @ptesMovimientos,
		conRenglon = @pconRenglon
	WHERE (Empresa_Id = @pEmpresa_Id) AND 
		(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
		(Segmento1N = @pSegmento1N) AND 
		(Segmento2N = @pSegmento2N) AND 
		(Segmento3N = @pSegmento3N) AND 
		(Segmento4N = @pSegmento4N) AND 
		(Segmento1C = @pSegmento1C) AND 
		(Segmento2C = @pSegmento2C) AND 
		(Segmento3C = @pSegmento3C) AND 
		(Segmento4C = @pSegmento4C)
END 
ELSE 
BEGIN

	If @pTieneAutomatico = 1
	Begin
		-- Busco si el siguiente si ya tiene movimientos --
		SET @pSegmento1N = (SELECT MAX(tesRetProvSegmento.Segmento1N)+1 AS Segmento1N 
				FROM tesRetProvSegmento 
					Where				
					tesRetProvSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					tesRetProvSegmento.Segmento2N = @pSegmento2N AND 
					tesRetProvSegmento.Segmento3N = @pSegmento3N AND 
					tesRetProvSegmento.Segmento4N = @pSegmento4N AND 
					tesRetProvSegmento.Segmento1C = @pSegmento1C AND 
					tesRetProvSegmento.Segmento2C = @pSegmento2C AND 
					tesRetProvSegmento.Segmento3C = @pSegmento3C AND 
					tesRetProvSegmento.Segmento4C = @pSegmento4C And
					tesRetProvSegmento.Empresa_Id = @pEmpresa_Id)
		
		If @pSegmento1N Is Null
			-- No tiene mov. entonces busco el primer número en el contador --
			SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
				FROM genContadorSegmento
				Where
				genContadorSegmento.Empresa_Id = @pEmpresa_id And
					genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					genContadorSegmento.Segmento2N = @pSegmento2N AND 
					genContadorSegmento.Segmento3N = @pSegmento3N AND 
					genContadorSegmento.Segmento4N = @pSegmento4N AND 
					genContadorSegmento.Segmento1C = @pSegmento1C AND 
					genContadorSegmento.Segmento2C = @pSegmento2C AND 
					genContadorSegmento.Segmento3C = @pSegmento3C AND 
					genContadorSegmento.Segmento4C = @pSegmento4C)

		If @pSegmento1N Is Null
			Set @pSegmento1N = 1
	End

	INSERT INTO tesRetProvSegmento
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
		tesMovimientos,
		conRenglon
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
		@ptesMovimientos,
		@pconRenglon
	)
END 
SELECT @pSegmento1N as RetVal
GO

DROP PROCEDURE tesRetProvSegmentoDatos
GO
CREATE PROCEDURE tesRetProvSegmentoDatos
(
@pEmpresa_Id int,
@pSegmento_Id varChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20)
)
AS
SET NOCOUNT ON 

SELECT tesRetProvSegmento.Empresa_Id, genSegmentos.Segmento_Id, genSegmentos.Descripcion as DescripcionSegmentos, tesRetProvSegmento.Segmento1N,
	tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, tesRetProvSegmento.Segmento4N, tesRetProvSegmento.Segmento1C,
	tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C, tesRetProvSegmento.tesMovimientos,
	tesRetProvSegmento.conRenglon, genSegmentos.TieneColumnaAutomatica
FROM tesRetProvSegmento 
INNER JOIN genSegmentos ON (genSegmentos.genSegmentos = tesRetProvSegmento.Segmento_Id)
WHERE (tesRetProvSegmento.Empresa_Id = @pEmpresa_Id)
AND (tesRetProvSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
AND (Segmento1N = @pSegmento1N)
AND (Segmento2N = @pSegmento2N)
AND (Segmento3N = @pSegmento3N)
AND (Segmento4N = @pSegmento4N)
AND (Segmento1C = @pSegmento1C)
AND (Segmento2C = @pSegmento2C)
AND (Segmento3C = @pSegmento3C)
AND (Segmento4C = @pSegmento4C)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesRetProvSegmentoEliminar
GO
CREATE PROCEDURE tesRetProvSegmentoEliminar
(
@pEmpresa_Id int,
@pSegmento_Id varchar(10),
@pSegmento1N int = NULL,
@pSegmento2N int = NULL,
@pSegmento3N int = NULL,
@pSegmento4N int = NULL,
@pSegmento1C varchar(20) = NULL,
@pSegmento2C varchar(20) = NULL,
@pSegmento3C varchar(20) = NULL,
@pSegmento4C varchar(20) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesRetProvSegmento 
WHERE (Empresa_Id = dbo.FuncFKgenEmpresas(@pEmpresa_Id))
AND (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
AND (Segmento1N = ISNULL(@pSegmento1N, Segmento1N))
AND (Segmento2N = ISNULL(@pSegmento2N, Segmento2N))
AND (Segmento3N = ISNULL(@pSegmento3N, Segmento3N))
AND (Segmento4N = ISNULL(@pSegmento4N, Segmento4N))
AND (Segmento1C = ISNULL(@pSegmento1C, Segmento1C))
AND (Segmento2C = ISNULL(@pSegmento2C, Segmento2C))
AND (Segmento3C = ISNULL(@pSegmento3C, Segmento3C))
AND (Segmento4C = ISNULL(@pSegmento4C, Segmento4C))
 
 RETURN @@Error 

GO
