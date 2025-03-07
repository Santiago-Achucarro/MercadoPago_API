--EXEC impArbaTxtModifDatos 8, 2021, '20-00012532-7'

DROP PROCEDURE impArbaTxtModifDatos
GO
CREATE PROCEDURE impArbaTxtModifDatos
(
@Mes SMALLINT,    
@Anio SMALLINT,
@CUIT char(14)
)
AS
SELECT impARBATxt.Anio, impARBATxt.Mes, impARBATxt.CUIT,
	Alicuota AlicuotaPer, 
	(SELECT ISNULL(Alicuota,0) FROM impARBATxt Arba 
	WHERE impARBATxt.CUIT = Arba.CUIT AND  
	impARBATxt.Mes = Arba.Mes AND 
	impARBATxt.Anio = Arba.Anio AND 
	Regimen = 'R') AlicuotaRet 
	FROM impARBATxt 
	WHERE Anio = @Anio AND Mes = @Mes AND 
	CUIT = @CUIT AND Regimen = 'P'
GO


DROP PROCEDURE impArbaTxtModifGuardar
GO
CREATE PROCEDURE impArbaTxtModifGuardar
(
@Mes SMALLINT,    
@Anio SMALLINT,
@CUIT char(14),
@AliPer qPorcentaje,
@AliRet qPorcentaje
)
AS
SET NOCOUNT ON 
BEGIN 
	UPDATE impArbaTxt
	SET	Alicuota = @AliRet 
	WHERE Anio = @Anio AND Mes = @Mes AND
		Regimen = 'R' AND CUIT = @CUIT

	UPDATE impArbaTxt
	SET	Alicuota = @AliPer 
	WHERE Anio = @Anio AND Mes = @Mes AND
		Regimen = 'P' AND CUIT = @CUIT
END 
GO




