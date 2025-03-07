DROP PROCEDURE comEmbSegmentosGuardar
GO
CREATE PROCEDURE comEmbSegmentosGuardar
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
@pcomEmbarques int,
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comEmbSegmentos 
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
	UPDATE comEmbSegmentos
	SET		Empresa_Id = @pEmpresa_Id,
		comEmbarques = @pcomEmbarques
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
		SET @pSegmento1N = (SELECT MAX(comEmbSegmentos.Segmento1N)+1 AS Segmento1N 
				FROM comEmbSegmentos 
					Where				
					comEmbSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					comEmbSegmentos.Segmento2N = @pSegmento2N AND 
					comEmbSegmentos.Segmento3N = @pSegmento3N AND 
					comEmbSegmentos.Segmento4N = @pSegmento4N AND 
					comEmbSegmentos.Segmento1C = @pSegmento1C AND 
					comEmbSegmentos.Segmento2C = @pSegmento2C AND 
					comEmbSegmentos.Segmento3C = @pSegmento3C AND 
					comEmbSegmentos.Segmento4C = @pSegmento4C And
					comEmbSegmentos.Empresa_Id = @pEmpresa_Id)

		If @pSegmento1N Is Null
			SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
				FROM comEmbSegmentos 
				INNER JOIN genContadorSegmento ON genContadorSegmento.Empresa_Id = comEmbSegmentos.Empresa_id And
					(genContadorSegmento.Segmento_Id = comEmbSegmentos.Segmento_Id) AND 
					(genContadorSegmento.Segmento2N = comEmbSegmentos.Segmento2N) AND 
					(genContadorSegmento.Segmento3N = comEmbSegmentos.Segmento3N) AND 
					(genContadorSegmento.Segmento4N = comEmbSegmentos.Segmento4N) AND 
					(genContadorSegmento.Segmento1C = comEmbSegmentos.Segmento1C) AND 
					(genContadorSegmento.Segmento2C = comEmbSegmentos.Segmento2C) AND 
					(genContadorSegmento.Segmento3C = comEmbSegmentos.Segmento3C) AND 
					(genContadorSegmento.Segmento4C = comEmbSegmentos.Segmento4C)
					Where
					genContadorSegmento.Empresa_Id = @pEmpresa_Id)
-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	
	End


	INSERT INTO comEmbSegmentos
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
		comEmbarques
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
		@pcomEmbarques
	)
END 

GO

DROP PROCEDURE comEmbSegmentosDatos
GO
CREATE PROCEDURE comEmbSegmentosDatos
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

SELECT comEmbSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genSegmentos.Descripcion as DescripcionSegmentos, comEmbSegmentos.Segmento1N,
	comEmbSegmentos.Segmento2N, comEmbSegmentos.Segmento3N, comEmbSegmentos.Segmento4N, comEmbSegmentos.Segmento1C,
	comEmbSegmentos.Segmento2C, comEmbSegmentos.Segmento3C, comEmbSegmentos.Segmento4C, comEmbSegmentos.comEmbarques,
	genSegmentos.TieneColumnaAutomatica
FROM comEmbSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = comEmbSegmentos.Segmento_Id)
INNER JOIN comEmbarques  ON (comEmbarques.comEmbarques = comEmbSegmentos.comEmbarques)
WHERE (comEmbSegmentos.Empresa_Id = @pEmpresa_Id)
And (comEmbSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
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

DROP PROCEDURE comEmbSegmentosEliminar
GO
CREATE PROCEDURE comEmbSegmentosEliminar
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

DELETE FROM comEmbSegmentos 
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

GO
