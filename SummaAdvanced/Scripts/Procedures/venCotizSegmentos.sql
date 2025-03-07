DROP PROCEDURE venCotizSegmentoGuardar
GO
CREATE PROCEDURE venCotizSegmentoGuardar
(
@pEmpresa_Id int = NULL,
@pSegmento_Id varchar(10) = NULL,
@pSegmento1N int = NULL,
@pSegmento2N int = NULL,
@pSegmento3N int = NULL,
@pSegmento4N int = NULL,
@pSegmento1C varchar(20) = NULL,
@pSegmento2C varchar(20) = NULL,
@pSegmento3C varchar(20) = NULL,
@pSegmento4C varchar(20) = NULL,
@pTieneAutomatico bit,
@pvenCotizaciones int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCotizSegmento WHERE 
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
	UPDATE venCotizSegmento
	SET	Empresa_Id = @pEmpresa_Id,
		venCotizaciones = @pvenCotizaciones
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
	If (@pTieneAutomatico=1)
	BEGIN
		SET @pSegmento1N = (SELECT MAX(venCotizSegmento.Segmento1N)+1 AS Segmento1N 
				FROM venCotizSegmento 
					Where				
					Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) AND 
					Segmento2N = @pSegmento2N AND 
					Segmento3N = @pSegmento3N AND 
					Segmento4N = @pSegmento4N AND 
					Segmento1C = @pSegmento1C AND 
					Segmento2C = @pSegmento2C AND 
					Segmento3C = @pSegmento3C AND 
					Segmento4C = @pSegmento4C And
					Empresa_Id = @pEmpresa_Id)
		
		If @pSegmento1N Is Null
			SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
				FROM venCotizSegmento 
				INNER JOIN genContadorSegmento ON genContadorSegmento.Empresa_Id = venCotizSegmento.Empresa_id And
					(genContadorSegmento.Segmento_Id = venCotizSegmento.Segmento_Id) AND 
					(genContadorSegmento.Segmento2N = venCotizSegmento.Segmento2N) AND 
					(genContadorSegmento.Segmento3N = venCotizSegmento.Segmento3N) AND 
					(genContadorSegmento.Segmento4N = venCotizSegmento.Segmento4N) AND 
					(genContadorSegmento.Segmento1C = venCotizSegmento.Segmento1C) AND 
					(genContadorSegmento.Segmento2C = venCotizSegmento.Segmento2C) AND 
					(genContadorSegmento.Segmento3C = venCotizSegmento.Segmento3C) AND 
					(genContadorSegmento.Segmento4C = venCotizSegmento.Segmento4C)
					Where
					genContadorSegmento.Empresa_Id = @pEmpresa_Id And
							(genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
							genContadorSegmento.Segmento2N = @pSegmento2N AND 
							genContadorSegmento.Segmento3N = @pSegmento3N AND 
							genContadorSegmento.Segmento4N = @pSegmento4N AND 
							genContadorSegmento.Segmento1C = @pSegmento1C AND 
							genContadorSegmento.Segmento2C = @pSegmento2C AND 
							genContadorSegmento.Segmento3C = @pSegmento3C AND 
							genContadorSegmento.Segmento4C = @pSegmento4C)

	-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N <= 0
			begin
				set @pSegmento1N = 1
			end	
	END
	if (@pSegmento1N = 0)
			SET @pSegmento1N = 1

	INSERT INTO venCotizSegmento
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
		venCotizaciones
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
		@pvenCotizaciones
	)
	
END 
SELECT @pSegmento1N as RetVal

GO

DROP PROCEDURE venCotizSegmentoDatos
GO
CREATE PROCEDURE venCotizSegmentoDatos
(
@pSegmento_Id varchar(25),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20)
)
as
select Empresa_Id, genSegmentos.Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C, Segmento3C,
Segmento4C, venCotizaciones,	genSegmentos.TieneColumnaAutomatica 
from venCotizSegmento inner join genSegmentos on genSegmentos=venCotizSegmento.Segmento_Id where 
@pSegmento_Id =genSegmentos.Segmento_Id and
@pSegmento1N =Segmento1N and
@pSegmento2N =Segmento2N and
@pSegmento3N =Segmento3N and
@pSegmento4N =Segmento4N and
@pSegmento1C =Segmento1C and
@pSegmento2C =Segmento2C and
@pSegmento3C = Segmento3C and
@pSegmento4C = Segmento4C
go