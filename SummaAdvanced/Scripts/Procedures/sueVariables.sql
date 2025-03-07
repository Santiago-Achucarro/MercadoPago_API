DROP PROCEDURE sueVariableGuardar
GO
CREATE PROCEDURE sueVariableGuardar
(
@pLegajo int,
@pGrupo_Id int,
@pConcepto_Id int,
@pUsuario_Id int = NULL,
@pFechaRegistro qFechaHora
)
AS
SET NOCOUNT ON 

	INSERT INTO sueVariable
	(
		Legajo,
		Grupo_Id,
		Concepto_Id,
		Usuario_Id,
		FechaRegistro
	)
	VALUES 
	(
		dbo.FuncFKsuePersonal(@pLegajo),
		dbo.FuncFKsueGrupos( @pGrupo_Id),
		dbo.FuncFKsueConceptos( @pConcepto_Id),
		@pUsuario_Id,
		dbo.FechaActual()
	)

GO

DROP PROCEDURE sueVariableDatos
GO
CREATE PROCEDURE sueVariableDatos
(
@pLegajo int
)
AS
SET NOCOUNT ON 
Select suePersonal.Legajo, suePersonal.Nombres as DescripcionLegajo 
From suePersonal 
Where suePersonal.Legajo = @pLegajo

SELECT sueVariable.Legajo, sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupos, 
sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConceptos,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, sueVariable.FechaRegistro
FROM sueVariable 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = sueVariable.Legajo)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueVariable.Usuario_Id)
left join sueGrupos on sueGrupos.sueGrupos=sueVariable.Grupo_Id
left join sueConceptos on sueConceptos.sueConceptos=sueVariable.Concepto_Id
WHERE (suePersonal.Legajo = @pLegajo)
Order By sueGrupos.Grupo_Id, sueConceptos.Concepto_Id

RETURN @@Error 

GO

DROP PROCEDURE sueVariableEliminar
GO
CREATE PROCEDURE sueVariableEliminar
(
@pLegajo int,
@pGrupo_Id int = NULL,
@pConcepto_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueVariable 
WHERE (Legajo = dbo.funcfksuePersonal(@pLegajo))
AND (Grupo_Id = ISNULL(dbo.FuncFKsueGrupos(@pGrupo_Id), Grupo_Id))
AND (Concepto_Id = ISNULL(dbo.FuncFKsueConceptos(@pConcepto_Id), Concepto_Id))
 
 RETURN @@Error 

GO


