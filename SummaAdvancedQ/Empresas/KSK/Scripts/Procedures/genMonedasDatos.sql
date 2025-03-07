USE [SummaAdv]
GO
/****** Object:  StoredProcedure [dbo].[genMonedasDatos]    Script Date: 7/11/2023 4:02:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[genMonedasDatos]
(
@pMoneda_Id varchar(3) = 'PES' -- -- Gustavo 11/07/2023 el formulario no la llena asi que el default pasa a ser Pesos
)
AS
SET NOCOUNT ON 



SELECT genMonedas.genMonedas, genMonedas.Moneda_Id, genMonedas.Empresa_Id, 
	Cast( Case When genMonedas.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	genMonedas.Descripcion, genMonedas.Simbolo, genMonedas.CodigoFiscal,
	conCuentasFAR.Cuenta_Id CtaFactaRecibir, conCuentasFAR.Descripcion DescripcionCtaFactaRecibir,
	conCuentasFARI.Cuenta_Id CtaFactaRecibirImp, conCuentasFARI.Descripcion DescripcionCtaFactaRecibirImp,
	genMonedas.CantidadDigitos, genMonedas.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genMonedas.Posteado
FROM genMonedas 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genMonedas.Usuario_Id)
Left Join conCuentas conCuentasFAR On conCuentasFAR.conCuentas = genMonedas.CtaFactaRecibir
Left Join conCuentas conCuentasFARI On conCuentasFARI.conCuentas = genMonedas.CtaFactaRecibirImp
WHERE (genMonedas.Moneda_Id = @pMoneda_Id)
 


Declare @pidentity bigint= dbo.FuncFKgenMonedas(@pMoneda_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'genMonedas'
RETURN @@Error 
