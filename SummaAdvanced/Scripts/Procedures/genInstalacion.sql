DROP PROCEDURE genInstalacionGuardar
GO
CREATE PROCEDURE genInstalacionGuardar
(
@pDominio_Id char(2) = NULL,
--@pLIcencias int,
@pRptServidor varchar(200) = NULL,
@pRptCarpeta varchar(200) = NULL,
@pRptUsuario varchar(200) = NULL,
@pRptClave varchar(200) = NULL,
@pRptDominio varchar(200) = NULL, 
@pUsoHorario int,
--@pLicencia VarChar(36)= NULL, 
--@pClave VarChar(max) = NULL, 
--@pFechaVencimiento DateTime=NULL, 
--@pPorEmpresa Bit, 
@pTamanioHoja VarChar(15)=NULL, 
@pLongitudClave Int,
@pDiasDuracionClave Int,
@pLoginGracia Int,
@pCantIntentosFallidos Int,
@pClaveSimbolos Bit,
@pClaveNumero Bit,
@pClaveMayuscula Bit,
@pClaveMinuscula Bit,
@pClaveComunes Bit,
@pconDigiCta smallint,
@pconDigiSubCta smallint,
@pcontMascaraCuenta VarChar(25)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genInstalacion))
BEGIN 
	UPDATE genInstalacion
	SET		Dominio_Id = @pDominio_Id,
		--LIcencias = @pLIcencias,
		RptServidor = @pRptServidor,
		RptCarpeta = @pRptCarpeta,
		RptUsuario = @pRptUsuario,
		RptClave = @pRptClave,
		RptDominio = @pRptDominio, 
		--Licencia = @pLicencia, 
		--Clave = @pClave, 
		--FechaVencimiento = @pFechaVencimiento, 
		UsoHorario = @pUsoHorario, 
		--PorEmpresa =@pPorEmpresa, 
		TamanioHoja =@pTamanioHoja, 
		LongitudClave = @pLongitudClave,
		DiasDuracionClave = @pDiasDuracionClave,
		LoginGracia = @pLoginGracia,
		CantIntentosFallidos = @pCantIntentosFallidos ,
		ClaveSimbolos = @pClaveSimbolos ,
		ClaveNumero = @pClaveNumero ,
		ClaveMayuscula = @pClaveMayuscula,
		ClaveMinuscula = @pClaveMinuscula,
		ClaveComunes  = @pClaveComunes,
		conDigiCta = @pconDigiCta, 
		conDigiSubCta = @pconDigiSubCta, 
		contMascaraCuenta = @pcontMascaraCuenta
END 
ELSE 
BEGIN 
	INSERT INTO genInstalacion
	(
		Dominio_Id,
		--LIcencias,
		RptServidor,
		RptCarpeta,
		RptUsuario,
		RptClave,
		RptDominio, 
		UsoHorario,
		--Licencia, 
		--Clave, 
		--FechaVencimiento, 
		--PorEmpresa, 
		TamanioHoja,
		LongitudClave ,
		DiasDuracionClave ,
		LoginGracia ,
		CantIntentosFallidos ,
		ClaveSimbolos ,
		ClaveNumero ,
		ClaveMayuscula ,
		ClaveMinuscula,
		ClaveComunes,
		conDigiCta, 
		conDigiSubCta,
		contMascaraCuenta
		 	)
	VALUES 
	(
		@pDominio_Id,
		--@pLIcencias,
		@pRptServidor,
		@pRptCarpeta,
		@pRptUsuario,
		@pRptClave,
		@pRptDominio, 
		--@pLicencia, 
		--@pClave, 
		--@pFechaVencimiento, 
		@pUsoHorario, 
		--@pPorEmpresa, 
		@pTamanioHoja, 
		@pLongitudClave ,
		@pDiasDuracionClave ,
		@pLoginGracia ,
		@pCantIntentosFallidos ,
		@pClaveSimbolos ,
		@pClaveNumero ,
		@pClaveMayuscula ,
		@pClaveMinuscula ,
		@pClaveComunes,
		@pconDigiCta, 
		@pconDigiSubCta,
		@pcontMascaraCuenta
	)
END 

GO

DROP PROCEDURE genInstalacionDatos
GO
CREATE PROCEDURE genInstalacionDatos
AS
SET NOCOUNT ON 

SELECT genInstalacion.Dominio_Id, genDominios.Descripcion as DescripcionDominios, 0 as Licencias,  genInstalacion.RptServidor,
	genInstalacion.RptCarpeta, genInstalacion.RptUsuario, genInstalacion.RptClave, 
		genInstalacion.RptDominio, '' as Licencia, '' as Clave, 
		GETDATE() as FechaVencimiento, genInstalacion.UsoHorario, cast(0 as bit) as PorEmpresa, 
			genInstalacion.TamanioHoja, genInstalacion.LongitudClave ,
		genInstalacion.DiasDuracionClave ,genInstalacion.LoginGracia ,
		genInstalacion.CantIntentosFallidos ,genInstalacion.ClaveSimbolos ,
		genInstalacion.ClaveNumero ,genInstalacion.ClaveMayuscula ,
		genInstalacion.ClaveMinuscula,genInstalacion.ClaveComunes ,
		genInstalacion.conDigiCta, genInstalacion.conDigiSubCta, genInstalacion.contMascaraCuenta,
		genInstalacion.TwoFactor, EntrarSiFallaCorreo, DuracionCookie
FROM genInstalacion 
LEFT JOIN genDominios  ON (genDominios.Dominio_Id = genInstalacion.Dominio_Id)

RETURN @@Error 

GO



DROP PROCEDURE genInstalacionSeguridadGuardar
GO
CREATE PROCEDURE genInstalacionSeguridadGuardar
(
@pDominio_Id char(2) = NULL,
@pUsoHorario int,
@pTamanioHoja VarChar(15)=NULL, 
@pLongitudClave Int,
@pDiasDuracionClave Int,
@pLoginGracia Int,
@pCantIntentosFallidos Int,
@pClaveSimbolos Bit,
@pClaveNumero Bit,
@pClaveMayuscula Bit,
@pClaveMinuscula Bit,
@pClaveComunes Bit, 
@pconDigiCta smallint,
@pconDigiSubCta smallint,
@pcontMascaraCuenta VarChar(25),
@pTwoFactor SiNo,
@pEntrarSiFallaCorreo bit,
@pDuracionCookie int
)
AS
SET NOCOUNT ON 

	UPDATE genInstalacion
	SET		Dominio_Id = @pDominio_Id,
		UsoHorario = @pUsoHorario, 
		TamanioHoja =@pTamanioHoja, 
		LongitudClave = @pLongitudClave,
		DiasDuracionClave = @pDiasDuracionClave,
		LoginGracia = @pLoginGracia,
		CantIntentosFallidos = @pCantIntentosFallidos ,
		ClaveSimbolos = @pClaveSimbolos ,
		ClaveNumero = @pClaveNumero ,
		ClaveMayuscula = @pClaveMayuscula,
		ClaveMinuscula = @pClaveMinuscula,
		ClaveComunes  = @pClaveComunes,
		conDigiCta = @pconDigiCta, 
		conDigiSubCta = @pconDigiSubCta, 
		contMascaraCuenta = @pcontMascaraCuenta,
		TwoFactor=@pTwoFactor,
		EntrarSiFallaCorreo=@pEntrarSiFallaCorreo,
		DuracionCookie=@pDuracionCookie

GO


