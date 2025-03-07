DROP PROCEDURE venAbonosSegmentosGuardar
GO
CREATE PROCEDURE venAbonosSegmentosGuardar
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
@pvenAbonos int, 
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venAbonosSegmentos WHERE 
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
	UPDATE venAbonosSegmentos
	SET	Empresa_Id = @pEmpresa_Id,
		venAbonos = @pvenAbonos
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
		SET @pSegmento1N = (SELECT MAX(venAbonosSegmentos.Segmento1N)+1 AS Segmento1N 
				FROM venAbonosSegmentos 
					Where				
					venAbonosSegmentos.Segmento1N > 0 and 
					venAbonosSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					venAbonosSegmentos.Segmento2N = @pSegmento2N AND 
					venAbonosSegmentos.Segmento3N = @pSegmento3N AND 
					venAbonosSegmentos.Segmento4N = @pSegmento4N AND 
					venAbonosSegmentos.Segmento1C = @pSegmento1C AND 
					venAbonosSegmentos.Segmento2C = @pSegmento2C AND 
					venAbonosSegmentos.Segmento3C = @pSegmento3C AND 
					venAbonosSegmentos.Segmento4C = @pSegmento4C And
					venAbonosSegmentos.Empresa_Id = @pEmpresa_Id)
		
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


	
	INSERT INTO venAbonosSegmentos
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
		venAbonos
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
		@pvenAbonos
	)
	
END 
SELECT @pSegmento1N as RetVal

GO

DROP PROCEDURE venAbonosSegmentosDatos
GO
CREATE PROCEDURE venAbonosSegmentosDatos
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

SELECT venAbonosSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	genSegmentos.Descripcion as DescripcionSegmentos, venAbonosSegmentos.Segmento1N,
	venAbonosSegmentos.Segmento2N, venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N, venAbonosSegmentos.Segmento1C,
	venAbonosSegmentos.Segmento2C, venAbonosSegmentos.Segmento3C, venAbonosSegmentos.Segmento4C, 
	venAbonosSegmentos.venAbonos, genSegmentos.TieneColumnaAutomatica
FROM venAbonosSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = venAbonosSegmentos.Segmento_Id)
WHERE (venAbonosSegmentos.Empresa_Id = @pEmpresa_Id)
AND (venAbonosSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
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

DROP PROCEDURE venAbonosSegmentosEliminar
GO
CREATE PROCEDURE venAbonosSegmentosEliminar
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

DELETE FROM venAbonosSegmentos 
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


