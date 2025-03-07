DROP PROCEDURE venRepaSegmentosGuardar
GO
CREATE PROCEDURE venRepaSegmentosGuardar
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
@pvenReparto int,
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venRepaSegmentos 
	WHERE 
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
	UPDATE venRepaSegmentos
	SET Empresa_Id = @pEmpresa_Id,
		venReparto = @pvenReparto
	WHERE 
	(Empresa_Id = @pEmpresa_Id) AND 
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
		SET @pSegmento1N = (SELECT MAX(venRepaSegmentos.Segmento1N)+1 AS Segmento1N 
				FROM venRepaSegmentos 
					Where				
					venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					venRepaSegmentos.Segmento2N = @pSegmento2N AND 
					venRepaSegmentos.Segmento3N = @pSegmento3N AND 
					venRepaSegmentos.Segmento4N = @pSegmento4N AND 
					venRepaSegmentos.Segmento1C = @pSegmento1C AND 
					venRepaSegmentos.Segmento2C = @pSegmento2C AND 
					venRepaSegmentos.Segmento3C = @pSegmento3C AND 
					venRepaSegmentos.Segmento4C = @pSegmento4C And
					venRepaSegmentos.Empresa_Id = @pEmpresa_Id)
		
		If @pSegmento1N Is Null
			SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
				FROM genContadorSegmento Where genContadorSegmento.Empresa_Id = @pEmpresa_id And
					genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					genContadorSegmento.Segmento2N = @pSegmento2N AND 
					genContadorSegmento.Segmento3N = @pSegmento3N AND 
					genContadorSegmento.Segmento4N = @pSegmento4N AND 
					genContadorSegmento.Segmento1C = @pSegmento1C AND 
					genContadorSegmento.Segmento2C = @pSegmento2C AND 
					genContadorSegmento.Segmento3C = @pSegmento3C AND 
					genContadorSegmento.Segmento4C = @pSegmento4C)

		-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	
	End

	INSERT INTO venRepaSegmentos
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
		venReparto
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
		@pvenReparto
	)
END 
SELECT @pSegmento1N as RetVal
GO

DROP PROCEDURE venRepaSegmentosDatos
GO
CREATE PROCEDURE venRepaSegmentosDatos
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

SELECT venRepaSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genSegmentos.Descripcion as DescripcionSegmentos, venRepaSegmentos.Segmento1N,
	venRepaSegmentos.Segmento2N, venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N, venRepaSegmentos.Segmento1C,
	venRepaSegmentos.Segmento2C, venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.venReparto,
	genSegmentos.TieneColumnaAutomatica
FROM venRepaSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = venRepaSegmentos.Segmento_Id)
WHERE (venRepaSegmentos.Empresa_Id = @pEmpresa_Id)
AND (venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
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

DROP PROCEDURE venRepaSegmentosEliminar
GO
CREATE PROCEDURE venRepaSegmentosEliminar
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
@pSegmento4C varchar(20)
)
AS
SET NOCOUNT ON 

DELETE FROM venRepaSegmentos 
WHERE Empresa_Id = @pEmpresa_Id
AND (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
AND Segmento1N = @pSegmento1N
AND Segmento2N = @pSegmento2N
AND Segmento3N = @pSegmento3N
AND Segmento4N = @pSegmento4N
AND Segmento1C = @pSegmento1C
AND Segmento2C = @pSegmento2C
AND Segmento3C = @pSegmento3C
AND Segmento4C = @pSegmento4C
 
 RETURN @@Error 

GO

GO
