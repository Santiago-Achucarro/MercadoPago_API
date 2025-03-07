DROP PROCEDURE sueConcAcumSegmentoGuardar
GO
CREATE PROCEDURE sueConcAcumSegmentoGuardar
(
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int,
@psueConcAcum int, 
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueConcAcumSegmento WHERE (Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C) AND (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE sueConcAcumSegmento
	SET		sueConcAcum = @psueConcAcum
	WHERE 
	(Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C) AND (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN
	if (@pTieneAutomatico=1)
	begin
	SET @pSegmento1N = ISNULL((SELECT MAX(Segmento1N) FROM sueConcAcumSegmento
		Where
		Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id) AND 
		Segmento2N = @pSegmento2N AND 
		Segmento3N = @pSegmento3N AND 
		Segmento4N = @pSegmento4N AND 
		Segmento1C = @pSegmento1C AND 
		Segmento2C = @pSegmento2C AND 
		Segmento3C = @pSegmento3C AND 
		Segmento4C = @pSegmento4C AND Empresa_Id = @pEmpresa_Id),0) +1
		

	end
 
	INSERT INTO sueConcAcumSegmento
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
		sueConcAcum
	)
	VALUES 
	(
		dbo.FuncFkgenSegmentos(@pSegmento_Id),
		@pSegmento1N,
		@pSegmento2N,
		@pSegmento3N,
		@pSegmento4N,
		@pSegmento1C,
		@pSegmento2C,
		@pSegmento3C,
		@pSegmento4C,
		@pEmpresa_Id,
		@psueConcAcum
	)
END 
SELECT @pSegmento1N as RETVAL
GO

DROP PROCEDURE sueConcAcumSegmentoDatos
GO
CREATE PROCEDURE sueConcAcumSegmentoDatos
(
@pSegmento_Id VarChar(10),
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

SELECT genSegmentos.Segmento_Id, sueConcAcumSegmento.Segmento1N, sueConcAcumSegmento.Segmento2N,
	sueConcAcumSegmento.Segmento3N, sueConcAcumSegmento.Segmento4N, 
	sueConcAcumSegmento.Segmento1C, sueConcAcumSegmento.Segmento2C,
	sueConcAcumSegmento.Segmento3C, sueConcAcumSegmento.Segmento4C, 
	sueConcAcumSegmento.Empresa_Id, sueConcAcumSegmento.sueConcAcum, genSegmentos.TieneColumnaAutomatica
FROM sueConcAcumSegmento 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = sueConcAcumSegmento.Segmento_Id)
INNER JOIN sueConcAcum  ON (sueConcAcum.sueConcAcum = sueConcAcumSegmento.sueConcAcum)
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

DROP PROCEDURE sueConcAcumSegmentoEliminar
GO
CREATE PROCEDURE sueConcAcumSegmentoEliminar
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

DELETE FROM sueConcAcumSegmento 
WHERE (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
AND (Segmento1N = ISNULL(@pSegmento1N, Segmento1N))
AND (Segmento2N = ISNULL(@pSegmento2N, Segmento2N))
AND (Segmento3N = ISNULL(@pSegmento3N, Segmento3N))
AND (Segmento4N = ISNULL(@pSegmento4N, Segmento4N))
AND (Segmento1C = ISNULL(@pSegmento1C, Segmento1C))
AND (Segmento2C = ISNULL(@pSegmento2C, Segmento2C))
AND (Segmento3C = ISNULL(@pSegmento3C, Segmento3C))
AND (Segmento4C = ISNULL(@pSegmento4C, Segmento4C))
AND Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO


