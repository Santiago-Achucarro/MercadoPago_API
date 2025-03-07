DROP PROCEDURE inf_conCentro1
GO

CREATE PROCEDURE inf_conCentro1
(
	@CentroDesde VarChar(8),
	@CentroHasta VarChar(8),
	@Empresa_Id Int
)

as 

Select conCentro1,Centro1_Id,Empresa_Id,Descripcion,Nivel,Imputable,Notas,Inactivo,Usuario_Id,Posteado 
From conCentro1
Where 
Centro1_Id between @CentroDesde and @CentroHasta and	
isnull(Empresa_Id,@Empresa_Id) = @Empresa_Id and 
Centro1_Id NOT IN ('%','*',' ')
