DROP PROCEDURE stkSolicitudCDSegmentoGuardar
GO
CREATE PROCEDURE stkSolicitudCDSegmentoGuardar
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
@pstkSolicitudCD bigint, 
@pTieneAutomatico bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkSolicitudCDSegmento WHERE 
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
	UPDATE stkSolicitudCDSegmento
	SET	Empresa_Id = @pEmpresa_Id,
		stkSolicitudCD = @pstkSolicitudCD
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
		SET @pSegmento1N = (SELECT MAX(stkSolicitudCDSegmento.Segmento1N)+1 AS Segmento1N 
				FROM stkSolicitudCDSegmento 
					Where				
					stkSolicitudCDSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					stkSolicitudCDSegmento.Segmento2N = @pSegmento2N AND 
					stkSolicitudCDSegmento.Segmento3N = @pSegmento3N AND 
					stkSolicitudCDSegmento.Segmento4N = @pSegmento4N AND 
					stkSolicitudCDSegmento.Segmento1C = @pSegmento1C AND 
					stkSolicitudCDSegmento.Segmento2C = @pSegmento2C AND 
					stkSolicitudCDSegmento.Segmento3C = @pSegmento3C AND 
					stkSolicitudCDSegmento.Segmento4C = @pSegmento4C And
					stkSolicitudCDSegmento.Empresa_Id = @pEmpresa_Id)
		
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
	
	INSERT INTO stkSolicitudCDSegmento
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
		stkSolicitudCD
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
		@pstkSolicitudCD
	)
	
END 
SELECT @pSegmento1N as RetVal

GO

DROP PROCEDURE stkSolicitudCDSegmentoEliminar
GO
CREATE PROCEDURE stkSolicitudCDSegmentoEliminar
(
@pSegmento_Id int = NULL,
@pSegmento1N int = NULL,
@pSegmento2N int = NULL,
@pSegmento3N int = NULL,
@pSegmento4N int = NULL,
@pSegmento1C varchar(20) = NULL,
@pSegmento2C varchar(20) = NULL,
@pSegmento3C varchar(20) = NULL,
@pSegmento4C varchar(20) = NULL,
@pEmpresa_Id varchar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM stkSolicitudCDSegmento 
WHERE (Segmento_Id = ISNULL(@pSegmento_Id, Segmento_Id))
AND (Segmento1N = ISNULL(@pSegmento1N, Segmento1N))
AND (Segmento2N = ISNULL(@pSegmento2N, Segmento2N))
AND (Segmento3N = ISNULL(@pSegmento3N, Segmento3N))
AND (Segmento4N = ISNULL(@pSegmento4N, Segmento4N))
AND (Segmento1C = ISNULL(@pSegmento1C, Segmento1C))
AND (Segmento2C = ISNULL(@pSegmento2C, Segmento2C))
AND (Segmento3C = ISNULL(@pSegmento3C, Segmento3C))
AND (Segmento4C = ISNULL(@pSegmento4C, Segmento4C))
AND (Empresa_Id = dbo.FuncFKgenEmpresas(@pEmpresa_Id))
 
 RETURN @@Error 

GO

GO
