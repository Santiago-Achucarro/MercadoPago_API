DROP PROCEDURE stkHojaSegmentosGuardar
GO
CREATE PROCEDURE stkHojaSegmentosGuardar
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
@pstkHojaDeRuta int,
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkHojaSegmentos 
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
	UPDATE stkHojaSegmentos
	SET		Empresa_Id = @pEmpresa_Id,
		stkHojaDeRuta = @pstkHojaDeRuta
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
		SET @pSegmento1N = (SELECT MAX(stkHojaSegmentos.Segmento1N)+1 AS Segmento1N 
				FROM stkHojaSegmentos 
					Where				
					stkHojaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					stkHojaSegmentos.Segmento2N = @pSegmento2N AND 
					stkHojaSegmentos.Segmento3N = @pSegmento3N AND 
					stkHojaSegmentos.Segmento4N = @pSegmento4N AND 
					stkHojaSegmentos.Segmento1C = @pSegmento1C AND 
					stkHojaSegmentos.Segmento2C = @pSegmento2C AND 
					stkHojaSegmentos.Segmento3C = @pSegmento3C AND 
					stkHojaSegmentos.Segmento4C = @pSegmento4C And
					stkHojaSegmentos.Empresa_Id = @pEmpresa_Id)
		
		If @pSegmento1N Is Null
			SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
				FROM genContadorSegmento Where 
					(genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
					(genContadorSegmento.Segmento2N = @pSegmento2N) AND 
					(genContadorSegmento.Segmento3N = @pSegmento3N) AND 
					(genContadorSegmento.Segmento4N = @pSegmento4N) AND 
					(genContadorSegmento.Segmento1C = @pSegmento1C) AND 
					(genContadorSegmento.Segmento2C = @pSegmento2C) AND 
					(genContadorSegmento.Segmento3C = @pSegmento3C) AND 
					(genContadorSegmento.Segmento4C = @pSegmento4C) And
					genContadorSegmento.Empresa_Id = @pEmpresa_Id)

		-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	
	End

	INSERT INTO stkHojaSegmentos
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
		stkHojaDeRuta
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
		@pstkHojaDeRuta
	)
END

SELECT @pSegmento1N as RetVal

GO

DROP PROCEDURE stkHojaSegmentosDatos
GO
CREATE PROCEDURE stkHojaSegmentosDatos
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

SELECT stkHojaSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genSegmentos.Descripcion as DescripcionSegmentos, stkHojaSegmentos.Segmento1N,
	stkHojaSegmentos.Segmento2N, stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N, stkHojaSegmentos.Segmento1C,
	stkHojaSegmentos.Segmento2C, stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, stkHojaSegmentos.stkHojaDeRuta,
	genSegmentos.TieneColumnaAutomatica
FROM stkHojaSegmentos 
INNER JOIN genSegmentos ON (genSegmentos.genSegmentos = stkHojaSegmentos.Segmento_Id)
WHERE (stkHojaSegmentos.Empresa_Id = @pEmpresa_Id)
AND genSegmentos.Segmento_Id = @pSegmento_Id
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

DROP PROCEDURE stkHojaSegmentosEliminar
GO
CREATE PROCEDURE stkHojaSegmentosEliminar
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

DELETE FROM stkHojaSegmentos 
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
