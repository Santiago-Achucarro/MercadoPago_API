DROP PROCEDURE stkInvenSegmentosInsertar
GO
CREATE PROCEDURE stkInvenSegmentosInsertar
(
@pstkInventarios int,
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
@pAutomatico bit
)
AS
if ((@pAutomatico=1) and (@pSegmento1N=0)) 
begin


	SET @pSegmento1N = (SELECT isnull(max(stkInvenSegmentos.Segmento1N),0)+1 AS Segmento1N
	FROM stkInvenSegmentos 
	WHERE 
	stkInvenSegmentos.Empresa_id = @pEmpresa_id and 
	stkInvenSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	stkInvenSegmentos.Segmento2N = @pSegmento2N and 
	stkInvenSegmentos.Segmento3N = @pSegmento3N and 
	stkInvenSegmentos.Segmento4N = @pSegmento4N and 
	stkInvenSegmentos.Segmento1C = @pSegmento1C and 
	stkInvenSegmentos.Segmento2C = @pSegmento2C and 
	stkInvenSegmentos.Segmento3C = @pSegmento3C and 
	stkInvenSegmentos.Segmento4C = @pSegmento4C )

	-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	


end


INSERT INTO stkInvenSegmentos
(
	stkInventarios,
	Empresa_Id,
	Segmento_Id,
	Segmento1N,
	Segmento2N,
	Segmento3N,
	Segmento4N,
	Segmento1C,
	Segmento2C,
	Segmento3C,
	Segmento4C
)
VALUES 
(
	@pstkInventarios,
	@pEmpresa_Id,
	dbo.FuncFKgenSegmentos(@pSegmento_id),
	@pSegmento1N,
	@pSegmento2N,
	@pSegmento3N,
	@pSegmento4N,
	@pSegmento1C,
	@pSegmento2C,
	@pSegmento3C,
	@pSegmento4C
)
	
SELECT @pSegmento1N as RetVal

GO

DROP PROCEDURE stkInvenSegmentosDatos
GO
CREATE PROCEDURE stkInvenSegmentosDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

SELECT genSegmentos.genSegmentos,
	stkInvenSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genSegmentos.Descripcion as DescripcionSegmentos,
	stkInvenSegmentos.Segmento1N, stkInvenSegmentos.Segmento2N, stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N,
	stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C, stkInvenSegmentos.Segmento3C, stkInvenSegmentos.Segmento4C
FROM stkInvenSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = stkInvenSegmentos.Segmento_Id)
WHERE 
stkInvenSegmentos.Empresa_id = @pEmpresa_id and 
genSegmentos.Segmento_id = @pSegmento_id and 
stkInvenSegmentos.Segmento1N = @pSegmento1N and 
stkInvenSegmentos.Segmento2N = @pSegmento2N and 
stkInvenSegmentos.Segmento3N = @pSegmento3N and 
stkInvenSegmentos.Segmento4N = @pSegmento4N and 
stkInvenSegmentos.Segmento1C = @pSegmento1C and 
stkInvenSegmentos.Segmento2C = @pSegmento2C and 
stkInvenSegmentos.Segmento3C = @pSegmento3C and 
stkInvenSegmentos.Segmento4C = @pSegmento4C 
 
 RETURN @@Error 

GO

DROP PROCEDURE stkInvenSegmentosEliminar
GO
CREATE PROCEDURE stkInvenSegmentosEliminar
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

DELETE FROM stkInvenSegmentos 
WHERE 
stkInvenSegmentos.Empresa_id = @pEmpresa_id and 
stkInvenSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
stkInvenSegmentos.Segmento1N = @pSegmento1N and 
stkInvenSegmentos.Segmento2N = @pSegmento2N and 
stkInvenSegmentos.Segmento3N = @pSegmento3N and 
stkInvenSegmentos.Segmento4N = @pSegmento4N and 
stkInvenSegmentos.Segmento1C = @pSegmento1C and 
stkInvenSegmentos.Segmento2C = @pSegmento2C and 
stkInvenSegmentos.Segmento3C = @pSegmento3C and 
stkInvenSegmentos.Segmento4C = @pSegmento4C 
 
 RETURN @@Error 

GO




