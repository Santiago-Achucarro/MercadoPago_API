
-- venPediSegmentosGuardar  1,'FPRO',1003,0,0,0,'E','F',' ',' ',1,1
DROP PROCEDURE venPediSegmentosGuardar
GO
CREATE PROCEDURE venPediSegmentosGuardar
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
@pvenPedidos int, 
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venPediSegmentos WHERE 
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

BEGIN 
	UPDATE venPediSegmentos
	SET	Empresa_Id = @pEmpresa_Id,
		venPedidos = @pvenPedidos
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
	
	-- Averiguo el que sigue
	
	If (@pTieneAutomatico=1)
	BEGIN
		SET @pSegmento1N = (SELECT MAX(venPediSegmentos.Segmento1N)+1 AS Segmento1N 
				FROM venPediSegmentos 
					Where				
					venPediSegmentos.Segmento1N > 0 and 
					venPediSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					venPediSegmentos.Segmento2N = @pSegmento2N AND 
					venPediSegmentos.Segmento3N = @pSegmento3N AND 
					venPediSegmentos.Segmento4N = @pSegmento4N AND 
					venPediSegmentos.Segmento1C = @pSegmento1C AND 
					venPediSegmentos.Segmento2C = @pSegmento2C AND 
					venPediSegmentos.Segmento3C = @pSegmento3C AND 
					venPediSegmentos.Segmento4C = @pSegmento4C And
					venPediSegmentos.Empresa_Id = @pEmpresa_Id)
		
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

	/* FM 08/06/2020 Corregir el BE para que no pase esto
	if (@pSegmento1N = 0)
		SET @pSegmento1N = 1
	*/
	
	INSERT INTO venPediSegmentos
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
		venPedidos
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
		@pvenPedidos
	)
	
END 
SELECT @pSegmento1N as RetVal

GO

DROP PROCEDURE venPediSegmentosDatos
GO
CREATE PROCEDURE venPediSegmentosDatos
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

SELECT venPediSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	genSegmentos.Descripcion as DescripcionSegmentos, venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N, venPediSegmentos.Segmento1C,
	venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, 
	venPediSegmentos.venPedidos, genSegmentos.TieneColumnaAutomatica
FROM venPediSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = venPediSegmentos.Segmento_Id)
WHERE (venPediSegmentos.Empresa_Id = @pEmpresa_Id)
AND (venPediSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
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

DROP PROCEDURE venPediSegmentosEliminar
GO
CREATE PROCEDURE venPediSegmentosEliminar
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
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

DELETE FROM venPediSegmentos 
WHERE Empresa_Id = @pEmpresa_Id
AND  Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)
AND  Segmento1N = IsNull(@pSegmento1N, Segmento1N)
AND  Segmento2N = IsNull(@pSegmento2N, Segmento2N)
AND  Segmento3N = IsNull(@pSegmento3N, Segmento3N)
AND  Segmento4N = IsNull(@pSegmento4N, Segmento4N)
AND  Segmento1C = IsNull(@pSegmento1C, Segmento1C)
AND  Segmento2C = IsNull(@pSegmento2C, Segmento2C)
AND  Segmento3C = IsNull(@pSegmento3C, Segmento3C)
AND  Segmento4C = IsNull(@pSegmento4C, Segmento4C)
 
 RETURN @@Error 

GO


