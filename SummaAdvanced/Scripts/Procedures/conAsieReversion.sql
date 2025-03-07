DROP PROCEDURE conAsieReversionGuardar
GO
CREATE PROCEDURE conAsieReversionGuardar
(
@pAsiento_Id bigint,
@pAsiento_Rever bigint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conAsieReversion WHERE (Asiento_Id = @pAsiento_Id)))
BEGIN 
	UPDATE conAsieReversion
	SET		Asiento_Rever = @pAsiento_Rever
	WHERE (Asiento_Id = @pAsiento_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conAsieReversion
	(
		Asiento_Id,
		Asiento_Rever
	)
	VALUES 
	(
		@pAsiento_Id,
		@pAsiento_Rever
	)
END 

GO

DROP PROCEDURE conAsieReversionDatos
GO
CREATE PROCEDURE conAsieReversionDatos
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

SELECT conAsieReversion.Asiento_Id, conAsieReversion.Asiento_Rever , 
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,	
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C,	genAsiSegmentos.Segmento4C
FROM conAsieReversion inner join genAsiSegmentos on
conAsieReversion.Asiento_Rever = genAsiSegmentos.Asiento_Id
inner join genSegmentos on 
genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos

WHERE (conAsieReversion.Asiento_Id = @pAsiento_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE conAsieReversionEliminar
GO
CREATE PROCEDURE conAsieReversionEliminar
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

DELETE FROM conAsieReversion 
WHERE (Asiento_Id = @pAsiento_Id)
 
RETURN @@Error 

GO

