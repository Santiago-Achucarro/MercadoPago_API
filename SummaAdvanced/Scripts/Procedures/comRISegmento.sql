DROP PROCEDURE comRISegmentoGuardar
GO
CREATE PROCEDURE comRISegmentoGuardar
(
@pSegmento_Id varchar(5),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int,
@pcomReqInterno int,
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 

IF (EXISTS (SELECT 1 FROM comRISegmento WHERE (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND (Segmento1N = @pSegmento1N) AND (Segmento2N = @pSegmento2N) AND (Segmento3N = @pSegmento3N) AND (Segmento4N = @pSegmento4N) AND (Segmento1C = @pSegmento1C) AND (Segmento2C = @pSegmento2C) AND (Segmento3C = @pSegmento3C) AND (Segmento4C = @pSegmento4C) AND (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE comRISegmento
	SET		Empresa_Id = @pEmpresa_Id,
		comReqInterno = @pcomReqInterno
	WHERE (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND (Segmento1N = @pSegmento1N) AND (Segmento2N = @pSegmento2N) AND (Segmento3N = @pSegmento3N) AND (Segmento4N = @pSegmento4N) AND (Segmento1C = @pSegmento1C) AND (Segmento2C = @pSegmento2C) AND (Segmento3C = @pSegmento3C) AND (Segmento4C = @pSegmento4C) AND (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
if (@pTieneAutomatico=1)
	BEGIN
		
		
			SET @pSegmento1N = (SELECT MAX(comRISegmento.Segmento1N)+1 AS Segmento1N 
					FROM comRISegmento 
					Where
						comRISegmento.Empresa_id = @pEmpresa_Id and 
						comRISegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
						comRISegmento.Segmento2N = @pSegmento2N And
						comRISegmento.Segmento3N = @pSegmento3N And
						comRISegmento.Segmento4N = @pSegmento4N And
						comRISegmento.Segmento1C = @pSegmento1C And
						comRISegmento.Segmento2C = @pSegmento2C And
						comRISegmento.Segmento3C = @pSegmento3C And
						comRISegmento.Segmento4C = @pSegmento4C)
						
						
			IF (@pSegmento1N IS NULL) 
			begin
				SET @pSegmento1N = (SELECT PrimerNumero
					FROM genContadorSegmento Where
						(genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
						(genContadorSegmento.Segmento2N = @pSegmento2N) AND 
						(genContadorSegmento.Segmento3N = @pSegmento3N) AND 
						(genContadorSegmento.Segmento4N = @pSegmento4N) AND 
						(genContadorSegmento.Segmento1C = @pSegmento1C) AND 
						(genContadorSegmento.Segmento2C = @pSegmento2C) AND 
						(genContadorSegmento.Segmento3C = @pSegmento3C) AND 
						(genContadorSegmento.Segmento4C = @pSegmento4C) and 
						genContadorSegmento.Empresa_id = @pEmpresa_id and 
						genContadorSegmento.Segmento_Id =dbo.FuncFKgenSegmentos(@pSegmento_Id))
								
			end

			-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	
		
			
	END
	INSERT INTO comRISegmento
	(
		Segmento_Id,
		Segmento1N,
		Segmento2N,
		Segmento3N,
		Segmento4N,
		Segmento1C,
		Segmento2C,
		Segmento3C,
		Segmento4C,
		Empresa_Id,
		comReqInterno
	)
	VALUES 
	(
		dbo.FuncFKgenSegmentos(@pSegmento_Id),
		@pSegmento1N,
		@pSegmento2N,
		@pSegmento3N,
		@pSegmento4N,
		@pSegmento1C,
		@pSegmento2C,
		@pSegmento3C,
		@pSegmento4C,
		@pEmpresa_Id,
		@pcomReqInterno
	)
END 
SELECT @pSegmento1N as Segmento
GO

DROP PROCEDURE comRISegmentoDatos
GO
CREATE PROCEDURE comRISegmentoDatos
(
@pSegmento_Id varchar(5),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT genSegmentos.Segmento_Id, comRISegmento.Segmento1N, comRISegmento.Segmento2N,
	comRISegmento.Segmento3N, comRISegmento.Segmento4N, comRISegmento.Segmento1C, comRISegmento.Segmento2C,
	comRISegmento.Segmento3C, comRISegmento.Segmento4C, comRISegmento.Empresa_Id, comRISegmento.comReqInterno,
	genSegmentos.TieneColumnaAutomatica
FROM comRISegmento 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = comRISegmento.Segmento_Id)
LEFT JOIN comReqInterno  ON (comReqInterno.comReqInterno = comRISegmento.comReqInterno)
WHERE (genSegmentos.Segmento_Id = @pSegmento_Id)
AND (Segmento1N = @pSegmento1N)
AND (Segmento2N = @pSegmento2N)
AND (Segmento3N = @pSegmento3N)
AND (Segmento4N = @pSegmento4N)
AND (Segmento1C = @pSegmento1C)
AND (Segmento2C = @pSegmento2C)
AND (Segmento3C = @pSegmento3C)
AND (Segmento4C = @pSegmento4C)
AND (Empresa_Id = @pEmpresa_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE comRISegmentoEliminar
GO
CREATE PROCEDURE comRISegmentoEliminar
(
@pSegmento_Id varchar(10),
@pSegmento1N int = NULL,
@pSegmento2N int = NULL,
@pSegmento3N int = NULL,
@pSegmento4N int = NULL,
@pSegmento1C varchar(20) = NULL,
@pSegmento2C varchar(20) = NULL,
@pSegmento3C varchar(20) = NULL,
@pSegmento4C varchar(20) = NULL,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM comRISegmento 
WHERE (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
AND (Segmento1N = ISNULL(@pSegmento1N, Segmento1N))
AND (Segmento2N = ISNULL(@pSegmento2N, Segmento2N))
AND (Segmento3N = ISNULL(@pSegmento3N, Segmento3N))
AND (Segmento4N = ISNULL(@pSegmento4N, Segmento4N))
AND (Segmento1C = ISNULL(@pSegmento1C, Segmento1C))
AND (Segmento2C = ISNULL(@pSegmento2C, Segmento2C))
AND (Segmento3C = ISNULL(@pSegmento3C, Segmento3C))
AND (Segmento4C = ISNULL(@pSegmento4C, Segmento4C))
AND (Empresa_Id =  @pEmpresa_Id) 
 RETURN @@Error 

GO

GO
