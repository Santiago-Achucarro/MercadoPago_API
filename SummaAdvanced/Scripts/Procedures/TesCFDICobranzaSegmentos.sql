DROP PROCEDURE TesCFDICobranzaSegmentosGuardar
GO
CREATE PROCEDURE TesCFDICobranzaSegmentosGuardar
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
@pTesCFDICobranza int,
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM TesCFDICobranzaSegmentos WHERE (Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
		(Segmento1N = @pSegmento1N) AND (Segmento2N = @pSegmento2N) AND (Segmento3N = @pSegmento3N) AND (Segmento4N = @pSegmento4N) AND 
		(Segmento1C = @pSegmento1C) AND (Segmento2C = @pSegmento2C) AND (Segmento3C = @pSegmento3C) AND (Segmento4C = @pSegmento4C)))
BEGIN 
	UPDATE TesCFDICobranzaSegmentos
	SET		Empresa_Id = @pEmpresa_Id,
		TesCFDICobranza = @pTesCFDICobranza
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

	if (@pTieneAutomatico=1)
		BEGIN
		
			SET @pSegmento1N = (SELECT MAX(TesCFDICobranzaSegmentos.Segmento1N)+1 AS Segmento1N 
					FROM TesCFDICobranzaSegmentos 
					Where
						TesCFDICobranzaSegmentos.Empresa_id = @pEmpresa_Id and 
						TesCFDICobranzaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
						TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N And
						TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N And
						TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N And
						TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C And
						TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C And
						TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C And
						TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C)
						
						
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

	end

	INSERT INTO TesCFDICobranzaSegmentos
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
		TesCFDICobranza
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
		@pTesCFDICobranza
	)

end
SELECT @pSegmento1N as RetVal
GO

DROP PROCEDURE TesCFDICobranzaSegmentosDatos
GO
CREATE PROCEDURE TesCFDICobranzaSegmentosDatos
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

SELECT TesCFDICobranzaSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genSegmentos.Descripcion as DescripcionSegmentos, 
	TesCFDICobranzaSegmentos.Segmento1N,
	TesCFDICobranzaSegmentos.Segmento2N, TesCFDICobranzaSegmentos.Segmento3N, TesCFDICobranzaSegmentos.Segmento4N, 
	TesCFDICobranzaSegmentos.Segmento1C, tesCFDICobranzaSegmentos.Segmento2C, TesCFDICobranzaSegmentos.Segmento3C, 
	TesCFDICobranzaSegmentos.Segmento4C, TesCFDICobranzaSegmentos.TesCFDICobranza, genSegmentos.TieneColumnaAutomatica TieneAutomatico
FROM TesCFDICobranzaSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id)
INNER JOIN tesCFDICobranza  ON (tesCFDICobranza.tesCFDICobranza = TesCFDICobranzaSegmentos.TesCFDICobranza)
WHERE (TesCFDICobranzaSegmentos.Empresa_Id = @pEmpresa_Id)
AND (genSegmentos.Segmento_Id = @pSegmento_Id)
AND (TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N)
AND (TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N)
AND (TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N)
AND (TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N)
AND (TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C)
AND (TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C)
AND (TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C)
AND (TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C)
 
 RETURN @@Error 

GO

DROP PROCEDURE TesCFDICobranzaSegmentosEliminar
GO
CREATE PROCEDURE TesCFDICobranzaSegmentosEliminar
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

DELETE FROM TesCFDICobranzaSegmentos 
WHERE (Empresa_Id = @pEmpresa_Id)
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
