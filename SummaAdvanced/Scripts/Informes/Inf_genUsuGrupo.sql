-- Inf_genUsuGrupo ' ','ZZZ'
DROP PROCEDURE Inf_genUsuGrupo
GO
CREATE PROCEDURE Inf_genUsuGrupo (
@GrupoDesde VarChar(25), 
@GrupoHasta VarChar(25), 
@Empresa Int
)
as

SELECT Grupo.Usuario_Id AS Grupo_Id, Grupo.Apellido_y_Nombres as DescripcionGrupo,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM genGrupos INNER JOIN  genUsuarios as Grupo on 
Grupo.genUsuarios = genGrupos.Grupo_Id
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = genGrupos.Usuario_Id
Where
	Grupo.Usuario_Id between @GrupoDesde And @GrupoHasta and 
	ISNULL(genUsuarios.Empresa_Id, @Empresa) = @Empresa

ORDER BY 1, 3

go