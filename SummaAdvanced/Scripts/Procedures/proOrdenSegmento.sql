DROP PROCEDURE proOrdenSegmentoGuardar
GO
CREATE PROCEDURE proOrdenSegmentoGuardar
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
@pproOrden bigint, 
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 


IF (EXISTS (SELECT 1 FROM proOrdenSegmento WHERE 
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

		

		
			UPDATE proOrdenSegmento
			SET	Empresa_Id = @pEmpresa_Id,
				proOrden = @pproOrden
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
		
		
			SET @pSegmento1N = (SELECT MAX(proOrdenSegmento.Segmento1N)+1 AS Segmento1N 
					FROM proOrdenSegmento 
					Where
						proOrdenSegmento.Empresa_id = @pEmpresa_Id and 
						proOrdenSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
						proOrdenSegmento.Segmento2N = @pSegmento2N And
						proOrdenSegmento.Segmento3N = @pSegmento3N And
						proOrdenSegmento.Segmento4N = @pSegmento4N And
						proOrdenSegmento.Segmento1C = @pSegmento1C And
						proOrdenSegmento.Segmento2C = @pSegmento2C And
						proOrdenSegmento.Segmento3C = @pSegmento3C And
						proOrdenSegmento.Segmento4C = @pSegmento4C)
						
						
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
	
	if (@pSegmento1N = 0)
			SET @pSegmento1N = 1

	INSERT INTO proOrdenSegmento
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
		proOrden
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
		@pproOrden
	)
	
END 
SELECT @pSegmento1N as RetVal

GO
DROP PROCEDURE proOrdenSegmentoDatos
GO
CREATE PROCEDURE proOrdenSegmentoDatos
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

SELECT genSegmentos.Segmento_Id, proOrdenSegmento.Empresa_Id, proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
	proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N, proOrdenSegmento.Segmento1C, proOrdenSegmento.Segmento2C,
	proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C, proOrdenSegmento.proOrden
FROM proOrdenSegmento
inner join genSegmentos on genSegmentos=proOrdenSegmento.Segmento_Id
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

DROP PROCEDURE proOrdenSegmentoEliminar
GO
CREATE PROCEDURE proOrdenSegmentoEliminar
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

DELETE FROM proOrdenSegmento 
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
