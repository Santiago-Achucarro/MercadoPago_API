DROP PROCEDURE inf_conCentro2
GO

CREATE PROCEDURE inf_conCentro2
(
	@CentroDesde VarChar(8),
	@CentroHasta VarChar(8),
	@Empresa_Id Int
)

as 

select conCentro2,Centro2_Id,Empresa_Id,Descripcion,Nivel,Imputable,Notas,Inactivo,Usuario_Id,Posteado 
From conCentro2
Where 
Centro2_Id between @CentroDesde and @CentroHasta and	
isnull(Empresa_Id,@Empresa_Id) = @Empresa_Id AND 
Centro2_Id NOT IN ('%','*',' ')
