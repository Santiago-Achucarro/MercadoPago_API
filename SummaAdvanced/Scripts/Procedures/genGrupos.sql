--genGruposPertence 'ADMINSUMMA',1

DROP PROCEDURE genGruposPertence
GO
CREATE PROCEDURE genGruposPertence
(
	@Grupo_id VarChar(25),
	@Usuario_id int
)
as

DECLARE @Pertenese as Bit = 0
DECLARE @Usu1 as int

set @Usu1 = (SELECT genUsuarios from genUsuarios where 
			genUsuarios.Usuario_id = @Grupo_id)
if (@Usu1 = @Usuario_id )
	BEGIN
		SET @Pertenese = 1
	END
ELSE
	BEGIN
		set @Usu1 = (SELECT COUNT(1) 
			FROM 
				genGrupos INNER JOIN genUsuarios ON 
				genGrupos.Grupo_id = genUsuarios.genUsuarios
				Where
				genUsuarios.Usuario_id = @Grupo_id and 
				genGrupos.Usuario_id =@Usuario_id)
				
		if (@Usu1>0)
		BEGIN
			SET @Pertenese = 1		
		END	
	END
	SELECT @Grupo_id as Grupo_id, @Pertenese AS Pertenese
GO	 		


DROP PROCEDURE genGruposDatos
GO
CREATE PROCEDURE genGruposDatos
(
	@Usuario_Id varchar(25)
)
as
declare @Grupo_Id as int
set @Grupo_Id=(select genUsuarios from genUsuarios where genUsuarios.Usuario_Id=@Usuario_Id)

select genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres,' ' as GrupoNuevo, cast(0 as bit) as Posteado, 
	cast(case when Empresa_Id IS NULL then 1 else 0 end as bit) as PTEmpresas, genUsuarios.genUsuarios
from genUsuarios
WHERE genUsuarios.Usuario_Id=@Usuario_Id


select genGrupos.Usuario_Id, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres
from genUsuarios
inner join genGrupos on genUsuarios.genUsuarios=genGrupos.Usuario_Id

where genGrupos.Grupo_Id=@Grupo_Id

GO	 



DROP PROCEDURE genGruposGuardar
GO
CREATE PROCEDURE genGruposGuardar
(
@Usuario_Id int, 
@Grupo_Id int
)
AS
SET NOCOUNT ON  
	if(EXISTS(select 1 from genGrupos where Usuario_Id=@Usuario_Id and Grupo_Id=@Grupo_Id))
BEGIN
	UPDATE genGrupos
	SET		
		Usuario_id = @Usuario_id,
		Grupo_Id = @Grupo_Id
END
ELSE
BEGIN		
	INSERT INTO genGrupos
	(
		Usuario_id,
		Grupo_Id
	)
	VALUES 
	(
		@Usuario_id,
		@Grupo_Id
	)
END 
GO

DROP PROCEDURE genGruposEliminar
GO
CREATE PROCEDURE genGruposEliminar
(
@Grupo_Id int,
@Usuario_Id int=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genGrupos
WHERE  Usuario_Id= ISNULL(@Usuario_Id,Usuario_Id) And Grupo_Id = @Grupo_Id
 
RETURN @@Error 

GO

