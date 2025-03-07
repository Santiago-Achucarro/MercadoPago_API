DROP PROCEDURE disFormulariosDatosTodos 
GO
CREATE PROCEDURE disFormulariosDatosTodos 
AS
select '' as Vacio
select Formulario_id, Descripcion, disFormularios.Especializacion  from disFormularios
Where inactivo = 0
ORDER BY 1

GO

DROP PROCEDURE disFormulariosMenuDatosTodos 
GO
CREATE PROCEDURE disFormulariosMenuDatosTodos 
AS

select orden, disFormularios.Formulario_id, Descripcion, Titulo  
from genMenus 
inner join disFormularios on disFormularios.disFormularios = genMenus.Formulario_Id
Where ((disFormularios.inactivo = 0) AND (genMenus.inactivo = 0))
ORDER BY 2

GO