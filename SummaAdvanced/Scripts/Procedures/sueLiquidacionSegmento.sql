DROP PROCEDURE sueLiquidacionSegmentoGuardar
GO
CREATE PROCEDURE sueLiquidacionSegmentoGuardar
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
@psueLiquidacion int, 
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 


IF (EXISTS (SELECT 1 FROM sueLiquidacionSegmento WHERE 
	(Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C)))

		

		
			UPDATE sueLiquidacionSegmento
			SET	Empresa_Id = @pEmpresa_Id,
				sueLiquidacion = @psueLiquidacion
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
		
	
ELSE 
BEGIN 
	
	-- Averiguo el que sigue
	
	if (@pTieneAutomatico=1)
	BEGIN
		
		
			SET @pSegmento1N = (SELECT MAX(sueLiquidacionSegmento.Segmento1N)+1 AS Segmento1N 
					FROM sueLiquidacionSegmento 
					Where
						sueLiquidacionSegmento.Empresa_id = @pEmpresa_Id and 
						sueLiquidacionSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
						sueLiquidacionSegmento.Segmento2N = @pSegmento2N And
						sueLiquidacionSegmento.Segmento3N = @pSegmento3N And
						sueLiquidacionSegmento.Segmento4N = @pSegmento4N And
						sueLiquidacionSegmento.Segmento1C = @pSegmento1C And
						sueLiquidacionSegmento.Segmento2C = @pSegmento2C And
						sueLiquidacionSegmento.Segmento3C = @pSegmento3C And
						sueLiquidacionSegmento.Segmento4C = @pSegmento4C)
						
						
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

			-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end		
			end
		
			
	END
	
	INSERT INTO sueLiquidacionSegmento
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
		sueLiquidacion
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
		@psueLiquidacion
	)
	
END 
SELECT @pSegmento1N as RetVal

GO
DROP PROCEDURE sueLiquidacionSegmentoDatos
GO
CREATE PROCEDURE sueLiquidacionSegmentoDatos
(
@pSegmento_Id varchar(10),
@pEmpresa_Id int,
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

SELECT genSegmentos.Segmento_Id, sueLiquidacionSegmento.Empresa_Id, sueLiquidacionSegmento.Segmento1N, sueLiquidacionSegmento.Segmento2N,
	sueLiquidacionSegmento.Segmento3N, sueLiquidacionSegmento.Segmento4N, sueLiquidacionSegmento.Segmento1C, sueLiquidacionSegmento.Segmento2C,
	sueLiquidacionSegmento.Segmento3C, sueLiquidacionSegmento.Segmento4C, sueLiquidacionSegmento.sueLiquidacion
FROM sueLiquidacionSegmento
inner join genSegmentos on genSegmentos=sueLiquidacionSegmento.Segmento_Id
WHERE (genSegmentos.Segmento_Id = @pSegmento_Id)
AND (Empresa_Id = @pEmpresa_Id)
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

DROP PROCEDURE sueLiquidacionSegmentoEliminar
GO
CREATE PROCEDURE sueLiquidacionSegmentoEliminar
(
@pSegmento_Id varchar(10),
@pEmpresa_Id int,
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

DELETE FROM sueLiquidacionSegmento 
WHERE (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
AND (Empresa_Id = @pEmpresa_Id)
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

GO
