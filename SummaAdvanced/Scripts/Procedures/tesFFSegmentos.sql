DROP PROCEDURE tesFFSegmentosGuardar
GO
CREATE PROCEDURE tesFFSegmentosGuardar
(
@pEmpresa_Id int,
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@ptesFlujoFondo bigint,
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesFFSegmentos WHERE 
	tesFlujoFondo = @ptesFlujoFondo))

BEGIN 
	UPDATE tesFFSegmentos
	SET		Empresa_Id = @pEmpresa_Id,
			Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id), 
			Segmento1N = @pSegmento1N,
			Segmento2N = @pSegmento2N,
			Segmento3N = @pSegmento3N,
			Segmento4N = @pSegmento4N,
			Segmento1C = @pSegmento1C,
			Segmento2C = @pSegmento2C,
			Segmento3C = @pSegmento3C,
			Segmento4C = @pSegmento4C
	WHERE 
		tesFlujoFondo = @ptesFlujoFondo
END 
ELSE 
-- Averiguo el que sigue
	
	If (@pTieneAutomatico=1)
		BEGIN
		SET @pSegmento1N = (SELECT MAX(tesFFSegmentos.Segmento1N)+1 AS Segmento1N 
				FROM tesFFSegmentos 
					Where				
					tesFFSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					tesFFSegmentos.Segmento2N = @pSegmento2N AND 
					tesFFSegmentos.Segmento3N = @pSegmento3N AND 
					tesFFSegmentos.Segmento4N = @pSegmento4N AND 
					tesFFSegmentos.Segmento1C = @pSegmento1C AND 
					tesFFSegmentos.Segmento2C = @pSegmento2C AND 
					tesFFSegmentos.Segmento3C = @pSegmento3C AND 
					tesFFSegmentos.Segmento4C = @pSegmento4C And
					tesFFSegmentos.Empresa_Id = @pEmpresa_Id)
		
		If @pSegmento1N Is Null
			SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
				From genContadorSegmento Where
					genContadorSegmento.Empresa_Id = @pEmpresa_Id And
							(genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
							genContadorSegmento.Segmento2N = @pSegmento2N AND 
							genContadorSegmento.Segmento3N = @pSegmento3N AND 
							genContadorSegmento.Segmento4N = @pSegmento4N AND 
							genContadorSegmento.Segmento1C = @pSegmento1C AND 
							genContadorSegmento.Segmento2C = @pSegmento2C AND 
							genContadorSegmento.Segmento3C = @pSegmento3C AND 
							genContadorSegmento.Segmento4C = @pSegmento4C
					)

		-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	
	END



BEGIN 
	INSERT INTO tesFFSegmentos
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
		tesFlujoFondo
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
		@ptesFlujoFondo
	)
END 
SELECT @pSegmento1N as RetVal
GO

DROP PROCEDURE tesFFSegmentosDatos
GO
CREATE PROCEDURE tesFFSegmentosDatos
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
@pSegmento4C varchar(20)
)
AS
SET NOCOUNT ON 

SELECT tesFFSegmentos.Empresa_Id, genSegmentos.Segmento_Id, tesFFSegmentos.Segmento1N,
	tesFFSegmentos.Segmento2N, tesFFSegmentos.Segmento3N, tesFFSegmentos.Segmento4N, tesFFSegmentos.Segmento1C,
	tesFFSegmentos.Segmento2C, tesFFSegmentos.Segmento3C, tesFFSegmentos.Segmento4C, tesFFSegmentos.tesFlujoFondo, 
		genSegmentos.TieneColumnaAutomatica
FROM tesFFSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = tesFFSegmentos.Segmento_Id)
INNER JOIN tesFlujoFondo  ON (tesFlujoFondo.tesFlujoFondo = tesFFSegmentos.tesFlujoFondo)
WHERE (Empresa_Id = @pEmpresa_Id)
AND (genSegmentos.Segmento_Id = @pSegmento_Id)
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

DROP PROCEDURE tesFFSegmentosEliminar
GO
CREATE PROCEDURE tesFFSegmentosEliminar
(
@pEmpresa_Id int,
@pSegmento_Id varchar(10),
@pSegmento1N int ,
@pSegmento2N int ,
@pSegmento3N int ,
@pSegmento4N int ,
@pSegmento1C varchar(20) ,
@pSegmento2C varchar(20) ,
@pSegmento3C varchar(20) ,
@pSegmento4C varchar(20) 
)
AS
SET NOCOUNT ON 

DELETE FROM tesFFSegmentos 
WHERE (Empresa_Id = @pEmpresa_Id)
AND (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
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

GO
