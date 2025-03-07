--- Cambio Para tomar el maximo con el proximo Numero
-- genAsiSegmentosGuardar  1,'FPRO',1003,0,0,0,'E','F',' ',' ',1,1
DROP PROCEDURE genAsiSegmentosGuardar
GO
CREATE PROCEDURE genAsiSegmentosGuardar
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
@pAsiento_Id bigint, 
@pTieneAutomatico bit,
@pPosteado bit
)
AS
SET NOCOUNT ON 



IF (EXISTS (SELECT 1 FROM genAsiSegmentos WHERE 
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

		

		if @pPosteado=1 and @pSegmento1N < 0
		begin 
			-- Esta posteando uno pendiente
			SELECT @pSegmento1N = 
			(SELECT MAX(PrimerNumero)
			FROM (SELECT 
				MAX(genAsiSegmentos.Segmento1N)+1 AS PrimerNumero
					FROM genAsiSegmentos 
					Where
						genAsiSegmentos.Segmento1N > 0 and 
						genAsiSegmentos.Empresa_id = @pEmpresa_Id and 
						genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
						genAsiSegmentos.Segmento2N = @pSegmento2N And
						genAsiSegmentos.Segmento3N = @pSegmento3N And
						genAsiSegmentos.Segmento4N = @pSegmento4N And
						genAsiSegmentos.Segmento1C = @pSegmento1C And
						genAsiSegmentos.Segmento2C = @pSegmento2C And
						genAsiSegmentos.Segmento3C = @pSegmento3C And
						genAsiSegmentos.Segmento4C = @pSegmento4C
				UNION ALL
					SELECT PrimerNumero
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
						genContadorSegmento.Segmento_Id =dbo.FuncFKgenSegmentos(@pSegmento_Id)) AS XXX) 
						
			-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	

			UPDATE genAsiSegmentos	SET	Empresa_Id = @pEmpresa_Id,
					Segmento1N = @pSegmento1N 
					WHERE Asiento_id = @pAsiento_Id

		end

	else
		BEGIN 
			UPDATE genAsiSegmentos
			SET	Empresa_Id = @pEmpresa_Id,
				Asiento_Id = @pAsiento_Id
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
	
	if (@pTieneAutomatico=1)
	BEGIN
		
		if @pPosteado=1
		BEGIN
			SET @pSegmento1N =(SELECT MAX(PrimerNumero)
			FROM (SELECT 
				MAX(genAsiSegmentos.Segmento1N)+1 AS PrimerNumero
					FROM genAsiSegmentos 
					Where
						genAsiSegmentos.Segmento1N > 0 and 
						genAsiSegmentos.Empresa_id = @pEmpresa_Id and 
						genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
						genAsiSegmentos.Segmento2N = @pSegmento2N And
						genAsiSegmentos.Segmento3N = @pSegmento3N And
						genAsiSegmentos.Segmento4N = @pSegmento4N And
						genAsiSegmentos.Segmento1C = @pSegmento1C And
						genAsiSegmentos.Segmento2C = @pSegmento2C And
						genAsiSegmentos.Segmento3C = @pSegmento3C And
						genAsiSegmentos.Segmento4C = @pSegmento4C
				UNION ALL
					SELECT PrimerNumero
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
						genContadorSegmento.Segmento_Id =dbo.FuncFKgenSegmentos(@pSegmento_Id)) AS XXX) 
						
						
			-- esto solo pasa si empieza en 1 esta prendido
			if @pSegmento1N is null or @pSegmento1N < 0
			begin
				set @pSegmento1N = 1
			end	


		END
		ELSE
			BEGIN

			SET @pSegmento1N = isnull((SELECT MIN(genAsiSegmentos.Segmento1N) AS Segmento1N 
					FROM genAsiSegmentos 
					Where
						genAsiSegmentos.Segmento1N  < 0 and 
						genAsiSegmentos.Empresa_id = @pEmpresa_Id and 
						genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
						genAsiSegmentos.Segmento2N = @pSegmento2N And
						genAsiSegmentos.Segmento3N = @pSegmento3N And
						genAsiSegmentos.Segmento4N = @pSegmento4N And
						genAsiSegmentos.Segmento1C = @pSegmento1C And
						genAsiSegmentos.Segmento2C = @pSegmento2C And
						genAsiSegmentos.Segmento3C = @pSegmento3C And
						genAsiSegmentos.Segmento4C = @pSegmento4C),0)-1
						
		
		END
			
	END
	
	INSERT INTO genAsiSegmentos
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
		Asiento_Id
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
		@pAsiento_Id
	)
	
END 
SELECT @pSegmento1N as RetVal

GO

DROP PROCEDURE genAsiSegmentosDatos
GO
CREATE PROCEDURE genAsiSegmentosDatos
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

SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	genSegmentos.Descripcion as DescripcionSegmentos, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Asiento_Id, genSegmentos.TieneColumnaAutomatica TieneAutomatico, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N ) as Segmento_Str ,
	conAsientos.Posteado
FROM genAsiSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id)
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
WHERE (genAsiSegmentos.Empresa_Id = @pEmpresa_Id)
AND (genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
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

DROP PROCEDURE genAsiSegmentosEliminar
GO
CREATE PROCEDURE genAsiSegmentosEliminar
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

DELETE FROM genAsiSegmentos 
WHERE Empresa_Id = @pEmpresa_Id
AND  Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)
AND  Segmento1N = @pSegmento1N
AND  Segmento2N = @pSegmento2N
AND  Segmento3N = @pSegmento3N
AND  Segmento4N = @pSegmento4N
AND  Segmento1C = @pSegmento1C
AND  Segmento2C = @pSegmento2C
AND  Segmento3C = @pSegmento3C
AND  Segmento4C = @pSegmento4C
 
 RETURN @@Error 

GO


DROP PROCEDURE genAsiSegmentosDatosInt
GO
CREATE PROCEDURE genAsiSegmentosDatosInt
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	genSegmentos.Descripcion as DescripcionSegmentos, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Asiento_Id,  genSegmentos.TieneColumnaAutomatica TieneAutomatico,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N ) as Segmento_Str,
	conAsientos.Posteado
FROM genAsiSegmentos 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id)
inner join conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
WHERE 
genAsiSegmentos.Asiento_Id = @pAsiento_Id

 RETURN @@Error 

GO

DROP PROCEDURE genAsiSegmentosModificar1N
GO
CREATE PROCEDURE genAsiSegmentosModificar1N
(
@pAsiento_Id bigint,
@pSegmento1N int
)
As

Update genAsiSegmentos Set Segmento1N = @pSegmento1N Where Asiento_Id = @pAsiento_Id
Go

Drop procedure genAsiSegmentosProxComprobante
Go
Create procedure genAsiSegmentosProxComprobante
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


SELECT @pSegmento1N = 
(SELECT MAX(PrimerNumero)
FROM (SELECT 
	MAX(genAsiSegmentos.Segmento1N) + 1 AS PrimerNumero
		FROM genAsiSegmentos 
		Where
			genAsiSegmentos.Segmento1N > 0 And 
			genAsiSegmentos.Empresa_Id = @pEmpresa_Id And 
			genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And
			genAsiSegmentos.Segmento2N = @pSegmento2N And
			genAsiSegmentos.Segmento3N = @pSegmento3N And
			genAsiSegmentos.Segmento4N = @pSegmento4N And
			genAsiSegmentos.Segmento1C = @pSegmento1C And
			genAsiSegmentos.Segmento2C = @pSegmento2C And
			genAsiSegmentos.Segmento3C = @pSegmento3C And
			genAsiSegmentos.Segmento4C = @pSegmento4C
	UNION ALL
		SELECT PrimerNumero
		FROM genContadorSegmento Where
			(genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) And 
			(genContadorSegmento.Segmento2N = @pSegmento2N) And 
			(genContadorSegmento.Segmento3N = @pSegmento3N) And 
			(genContadorSegmento.Segmento4N = @pSegmento4N) And 
			(genContadorSegmento.Segmento1C = @pSegmento1C) And 
			(genContadorSegmento.Segmento2C = @pSegmento2C) And 
			(genContadorSegmento.Segmento3C = @pSegmento3C) And 
			(genContadorSegmento.Segmento4C = @pSegmento4C) And 
			genContadorSegmento.Empresa_Id = @pEmpresa_id And 
			genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AS XXX) 
						
-- esto solo pasa si empieza en 1 esta prendido
If @pSegmento1N Is Null
Begin
	Set @pSegmento1N = 1
End

Select @pSegmento1N Segmento1N
Go


