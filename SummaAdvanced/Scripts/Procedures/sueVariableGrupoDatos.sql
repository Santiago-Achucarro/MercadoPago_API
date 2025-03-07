
Drop Procedure sueVariableGrupoDatos  
GO
Create Procedure sueVariableGrupoDatos  
(
	@Legajo Int, 
	@Grupo_Id Int
)
AS

Select @Legajo as Legajo, @Grupo_Id as Grupo_Id


SELECT sueConceptos.Concepto_Id
	from suevariable inner join suePersonal ON 
		suevariable.Legajo = suePersonal.genEntidades 
		inner join sueGrupos ON 
		sueGrupos.sueGrupos = suevariable.Grupo_Id
		INNER JOIN sueConceptos ON 
		sueConceptos.sueConceptos = suevariable.Concepto_Id
WHERE
		sueGrupos.Grupo_Id = @Grupo_Id and
		suePersonal.Legajo = @Legajo AND 
		sueConceptos.Inactivo = 0 AND 
		sueConceptos.Posteado = 1
ORDER BY 1

GO