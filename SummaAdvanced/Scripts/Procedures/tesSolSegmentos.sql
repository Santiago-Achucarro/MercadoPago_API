DROP PROCEDURE tesSolSegmentosInsertar
GO
CREATE PROCEDURE tesSolSegmentosInsertar
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
@ptesSolicitud bigint, 
@pTieneAutomatico bit, 
@pPrimerNumero INT
)
AS

if ((@pTieneAutomatico=1) AND (@pSegmento1N = 0))
		BEGIN
			
			set @pSegmento1N = ISNULL((SELECT MAX(Segmento1N) 
				FROM 	tesSolSegmentos inner join genSegmentos ON
				tesSolSegmentos.Segmento_id = genSegmentos.genSegmentos
				WHERE
				(tesSolSegmentos.Empresa_Id = @pEmpresa_Id) AND 
				(genSegmentos.Segmento_Id = @pSegmento_Id) AND 
				(Segmento2N = @pSegmento2N) AND 
				(Segmento3N = @pSegmento3N) AND 
				(Segmento4N = @pSegmento4N) AND 
				(Segmento1C = @pSegmento1C) AND 
				(Segmento2C = @pSegmento2C) AND 
				(Segmento3C = @pSegmento3C) AND 
				(Segmento4C = @pSegmento4C))+1,@pPrimerNumero) 

			-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	
		END

		

	INSERT INTO tesSolSegmentos
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
		tesSolicitud
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
		@ptesSolicitud
	)

SELECT @pSegmento1N as RetVal
GO

DROP PROCEDURE tesSolSegmentosDatos
GO
CREATE PROCEDURE tesSolSegmentosDatos
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

SELECT tesSolSegmentos.Empresa_Id, tesSolSegmentos.Segmento_Id, tesSolSegmentos.Segmento1N, tesSolSegmentos.Segmento2N,
	tesSolSegmentos.Segmento3N, tesSolSegmentos.Segmento4N, tesSolSegmentos.Segmento1C, tesSolSegmentos.Segmento2C,
	tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C, tesSolSegmentos.tesSolicitud
FROM tesSolSegmentos 
INNER JOIN tesSolicitud  ON (tesSolicitud.Solicitante_Id = tesSolSegmentos.tesSolicitud)
WHERE (Empresa_Id = @pEmpresa_Id)
AND (Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id))
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

DROP PROCEDURE tesSolSegmentosEliminar
GO
CREATE PROCEDURE tesSolSegmentosEliminar
(
@pEmpresa_Id Int,
@pSegmento_Id VarChar(10),
@pSegmento1N int ,
@pSegmento2N int ,
@pSegmento3N int ,
@pSegmento4N int ,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20)
)
AS
SET NOCOUNT ON 

DELETE FROM tesSolSegmentos 
WHERE (Empresa_Id = @pEmpresa_Id)
AND (Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id))
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
