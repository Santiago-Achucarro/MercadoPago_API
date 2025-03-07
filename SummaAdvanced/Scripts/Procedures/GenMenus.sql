DROP PROCEDURE genMenusDatos 
GO
CREATE PROCEDURE genMenusDatos @Usuario_id int, @Dominio_id VarChar(2), @Empresa_id int 
AS

DECLARE @ListaDeFormularios Table (Usuario_Id int, 
									Formulario_id varchar(30), 
									Descripcion varchar(80), 
									PTodasEmpresas bit, 
									Consultar bit, 
									Actualizar bit, 
									Borrar bit, 
									Postear bit, 
									ModificaCodigos bit)

INSERT INTO @ListaDeFormularios
EXEC genPermisosDatos @Usuario_Id, @Empresa_id, null

SELECT genMenus.Orden, genMenus.Nivel, genMenus.Tipo, 
		ISNULL(genReportes.Titulo, isnull(disFormularios.Titulo, genMenus.Opcion)) as Opcion,
		disFormularios.Formulario_id, genMenus.FrmEspecial, 
		genReportes.Reporte_Id, genMenus.Orientacion, genMenus.Pais
FROM genMenus 
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_id
LEFT JOIN genReportes ON genReportes.genReportes =  genMenus.Reporte_Id
LEFT JOIN @ListaDeFormularios as lstfrm ON lstfrm.Formulario_id =  disFormularios.Formulario_Id
Inner Join genMenusOrden On genMenusOrden.Opcion = Substring(genMenus.Orden, 1, 1)
WHERE (Pais IS NULL OR Pais Like '%'+ @Dominio_id +'%')		
AND ((genMenus.Formulario_id IS NULL) OR (isnull(lstfrm.Consultar, 0) = 1))
AND (genMenus.Inactivo = 0)

ORDER BY genMenusOrden.Orden, genMenus.Orden
	
GO

DROP FUNCTION FuncFKgenMenusFormulario
GO

CREATE FUNCTION FuncFKgenMenusFormulario
(
@pFormulario_id varchar (30)
)
RETURNS varchar(10)

AS
BEGIN
  DECLARE @pOrdenMenu varchar(10)
  SELECT @pOrdenMenu = Orden FROM genMenus WHERE 
	Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_id)
  RETURN @pOrdenMenu
END
GO
