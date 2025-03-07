--  conVeriCentro12Datos '7300-102', '10000000',' '

DROP PROCEDURE conVeriCentro12Datos
GO
CREATE PROCEDURE conVeriCentro12Datos
(
	@pCuenta_Id VarChar(25),
	@pCentro1_Id VarChar(8),
	@pCentro2_Id VarChar(8)
)
as
Select  conCuentas.Cuenta_Id, conCuentas.Descripcion, conCentro1.Centro1_Id, conCentro2.Centro2_Id 
From conGrupoCentro 
Inner join conCuentas ON conGrupoCentro.Grupo_Id = conCuentas.Grupo_Id 
INNER JOIN conCentro1 ON conCentro1.conCentro1 = conGrupoCentro.Centro1_Id 
INNER JOIN conCentro2 ON conCentro2.conCentro2 = conGrupoCentro.Centro2_Id
Where
conCuentas.Cuenta_Id = @pCuenta_Id AND 
(conCentro2.Centro2_Id = @pCentro2_ID OR conCentro2.Centro2_Id='*' OR 
	(conCentro2.Centro2_Id='%' AND @pCentro2_Id != ' ')) and 
(conCentro1.Centro1_Id = @pCentro1_ID OR conCentro1.Centro1_Id='*' OR 
	(conCentro1.Centro1_Id='%' AND @pCentro1_Id != ' ')) 
GO

	

