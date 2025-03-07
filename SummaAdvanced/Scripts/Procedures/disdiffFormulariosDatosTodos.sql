DROP PROCEDURE disdiffFormulariosDatosTodos 
GO

CREATE PROCEDURE disdiffFormulariosDatosTodos 
AS
select f.Formulario_id, f.Descripcion, f.Especializacion, f.UltimaModif, cast(case when f.FormularioPadre_Id is null then 0 else 1 end as bit) as Heredado,
		ISNULL(fc.Confirmado, 0) as Confirmado
from disFormularios f
left join disFormulariosConfirmados fc ON fc.Formulario_ID = f.disFormularios
order by 1

GO

DROP PROCEDURE disFormulariosConfirmadosDatos 
GO

CREATE PROCEDURE disFormulariosConfirmadosDatos  
@Formulario_ID varchar(100)
AS
select f.Confirmado, f.Comentario
from disFormulariosConfirmados f 
where f.Formulario_ID = dbo.FuncFKdisFormularios(@Formulario_ID)

GO

DROP PROCEDURE disFormulariosConfirmadosGuardar 
GO

CREATE PROCEDURE disFormulariosConfirmadosGuardar  
@Formulario_ID varchar(100),
@Confirmado bit,
@Comentario varchar(max)
AS
BEGIN


If (exists(select 1 from disFormulariosConfirmados where Formulario_Id = dbo.FuncFKdisFormularios(@Formulario_ID)))
	Update disFormulariosConfirmados
	set Confirmado = @Confirmado,
		Comentario = @Comentario
	where Formulario_Id = dbo.FuncFKdisFormularios(@Formulario_ID)
Else
	insert into disFormulariosConfirmados (Formulario_ID, Confirmado, Comentario)
	values (dbo.FuncFKdisFormularios(@Formulario_ID), @Confirmado, @Comentario)
END
GO
