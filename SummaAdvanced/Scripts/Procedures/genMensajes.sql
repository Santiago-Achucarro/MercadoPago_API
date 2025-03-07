drop procedure genMensajesPantallaGuardar
go
create procedure genMensajesPantallaGuardar
(
@pgenMensaje int=null,
@pMensaje varchar(max),
@pUsuarioDestino varchar(25),
@pUsuarioRemi int,
@pFechaEmision datetime,
@pFechaDesde qFechaHora=null,
@pFechaHasta qFechaHora=null
)
as
if exists(select 1 from genMensajes where @pgenMensaje=Mensaje_Id) 
begin
update genMensajes set Mensaje=@pMensaje, FechaEmision=@pFechaEmision, FechaDesde=@pFechaDesde, FechaHasta=@pFechaHasta,
	Leido=null 
	Where
		Mensaje_Id = @pgenMensaje
end
else
begin
insert into genMensajes(Mensaje, Leido, Usuario_Id, UsuarioDestino, FechaEmision, FechaDesde, FechaHasta)
values (@pMensaje, null, @pUsuarioRemi, dbo.FuncFKgenUsuarios(@pUsuarioDestino),@pFechaEmision, @pFechaDesde, @pFechaHasta)
end
go

DROP PROCEDURE genMensajesGuardar
GO
CREATE PROCEDURE genMensajesGuardar
(
@pMensaje_Id int,
@pMensaje varchar(max),
@pLeido qFechaHora = NULL,
@pUsuario_Id int ,
@pUsuarioDestino VarChar(25),
@pFechaEmision qFechaHora,
@pFechaDesde qFechaHora=null,
@pFechaHasta qFechaHora=null,
@pFormulario varchar(30)=NULL,
@pParametros varchar(max)=NULL,
@pTipo varchar(20)=NULL,
@pSubTipo varchar(20)=NULL
)
AS
IF (@pMensaje_Id<>0) and exists(select 1 from genMensajes where Mensaje=@pMensaje)
BEGIN 
	UPDATE genMensajes
	SET		
		Mensaje = @pMensaje,
		Leido = @pLeido,
		Usuario_Id = @pUsuario_Id,
		UsuarioDestino = dbo.FuncFKgenUsuarios(@pUsuarioDestino),
		FechaEmision = @pFechaEmision,
		FechaDesde=@pFechaDesde,
		FechaHasta=@pFechaHasta,
		Formulario_Id= dbo.FuncFKdisFormularios(@pFormulario),
		Parametros=@pParametros,
		Tipo = @pTipo, 
		SubTipo = @pSubTipo
	WHERE 
		Mensaje_Id = @pMensaje_Id 
END 
ELSE 
BEGIN 
	INSERT INTO genMensajes
	(
		Mensaje,
		Leido,
		Usuario_Id,
		UsuarioDestino,
		FechaEmision,
		FechaDesde,
		FechaHasta,
		Formulario_Id,
		Parametros,
		Tipo, 
		SubTipo
	)
	VALUES 
	(
		@pMensaje,
		@pLeido,
		@pUsuario_Id,
		dbo.FuncFKgenUsuarios(@pUsuarioDestino),
		@pFechaEmision,
		@pFechaDesde,
		@pFechaHasta,
		dbo.FuncFKdisFormularios(@pFormulario),
		@pParametros,
		@pTipo, 
		@pSubTipo
	)
	SET @pMensaje_Id =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @pMensaje_Id as RetVal 

GO

-- FM 15/12/2022 Que el formulario no esté hardcodeado sino que busque el orden en genMenus y traiga el formulario--
-- que tiene en esa opción por si se heredó y se cambíó la opción --
DROP PROCEDURE genMensajesUsuario
GO
CREATE PROCEDURE genMensajesUsuario
(
	@pUsuario_id int, 
	@pPendientes bit,
	@pEmpresa int
)
AS
SET NOCOUNT ON

-- Esta es la hora actual modificada por el huso horario --
-- Los mensajes que se hicieron desde el botón Notificación general están con la hora local del usuario --
Declare @lHoraActual datetime = (Select DateAdd(hour, (Select UsoHorario From genInstalacion), GETUTCDATE()))

select genUsuarios.genUsuarios, 
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	genUsuarios.Usuario_id, @pPendientes Pendientes
from genUsuarios
Where 
	genUsuarios.genUsuarios = @pUsuario_id


SELECT genMensajes.Mensaje_Id MensajeId, 
	genMensajes.FechaEmision, genMensajes.Leido as FechaLeido,
	genMensajes.Mensaje, genUsuarios.Usuario_id, 
		genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
		Cast(case when genMensajes.Leido is null then 0 else 1 end as bit) as Leido,
		disFormularios.disFormularios,disFormularios.Formulario_Id, genMensajes.FechaDesde, 
-- devuelvo tambien el titulo del formulario en Parametros (van concatenados con |) 
-- Esta solución es temporal hasta que se modifique genMensajes y se alamcene el orden en el menú del formulario en lugar del formulario
		genMensajes.FechaHasta, isnull (genMensajes.Parametros, '') + isnull ('|' + disFormularios.Titulo, '') as Parametros,
		genMensajes.Tipo,	genMensajes.SubTipo
FROM genMensajes inner join genUsuarios on 
genMensajes.Usuario_id =genUsuarios.genUsuarios
LEFT join disFormularios on disFormularios.disFormularios=genMensajes.Formulario_Id
WHERE genMensajes.UsuarioDestino = @pUsuario_Id and 
(@pPendientes=0 or genMensajes.Leido is null) and
-- Los mensajes del administrador enviados desde el formulario son los únicos que tienen fecha desde, 
-- y las fechas desde y hasta, quedan almacenadas en UTC
(genMensajes.FechaDesde is not null) and 
(@lHoraActual between isnull(genMensajes.FechaDesde, @lHoraActual) and isnull(genMensajes.FechaHasta, @lHoraActual)
/*or @pPendientes=0*/)
UNION ALL
SELECT genMensajes.Mensaje_Id MensajeId, 
	genMensajes.FechaEmision, genMensajes.Leido as FechaLeido,
	genMensajes.Mensaje, genUsuarios.Usuario_id, 
		genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
		Cast(case when genMensajes.Leido is null then 0 else 1 end as bit) as Leido,
		disFormularios.disFormularios,disFormularios.Formulario_Id, genMensajes.FechaDesde, 
-- devuelvo tambien el titulo del formulario en Parametros (van concatenados con |) 
-- Esta solución es temporal hasta que se modifique genMensajes y se alamcene el orden en el menú del formulario en lugar del formulario
		genMensajes.FechaHasta, isnull (genMensajes.Parametros, '') + isnull ('|' + disFormularios.Titulo, '') as Parametros,
		genMensajes.Tipo,	genMensajes.SubTipo
FROM genMensajes inner join genUsuarios on 
genMensajes.Usuario_id =genUsuarios.genUsuarios
LEFT join disFormularios on disFormularios.disFormularios=genMensajes.Formulario_Id
WHERE genMensajes.UsuarioDestino = @pUsuario_Id and 
(@pPendientes=0 or genMensajes.Leido is null) and
-- y las fechas desde y hasta, quedan almacenadas en UTC
(genMensajes.FechaDesde is null) and 
(dbo.FechaActual() between isnull(genMensajes.FechaDesde, dbo.FechaActual()) and isnull(genMensajes.FechaHasta,dbo.FechaActual())
/*or @pPendientes=0*/)
union all
select 0 as MensajeId, 
	getdate() as FechaEmision, cast(null as datetime) as FechaLeido,
	'Tiene_Ordenes_de_Compra_Por_Autorizar' as Mensaje, '' as Usuario_id, 
		'' as DescripcionUsuario, 
		cast(0 as bit) as Leido,
		0 as disFormularios,'frmcomOrdenCompPendAuto' as Formulario_Id, null, 
		null,'|Ingreso_de_Ordenes_de_Compra', NULL, NULL 
		Where exists(
Select distinct genUsuarios.Usuario_Id
from genUsuarios 
	left join genPermisos ON
		genPermisos.Formulario_Id = dbo.FuncFKdisFormularios('frmcomOrdenCompPendAuto') and
		genPermisos.Usuario_Id = genUsuarios.genUsuarios and 
		ISNULL(genPermisos.Empresa_Id,@pEmpresa)=@pEmpresa
		
	WHERE
		genUsuarios.genUsuarios = @pUsuario_id and 
		(genPermisos.Postear = 1  or genUsuarios.EsSupervisor = 1) and 
		exists(select 1 from comOrdenComp inner join comOCSegmentos on
			comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp and 
			comOCSegmentos.Empresa_Id = @pEmpresa
			inner join comOCAutorizando on comOCAutorizando.Usuario_Id is null and comOCAutorizando.comOrdenComp=comOrdenComp.comOrdenComp
            inner join comNivelesAutoUsu on comNivelesAutoUsu.Usuario_Id=@pUsuario_Id and comNivelesAutoUsu.NivelAuto_Id=comOCAutorizando.NivelAuto_Id
		 where
			comOrdenComp.Estado_Id = 'P'))
			
Union all
-- Validacion Comercial
select 0 as MensajeId, 
	getdate() as FechaEmision, cast(null as datetime) as FechaLeido,
	'Tiene_Pedidos_Pendientes_de_Validar' as Mensaje, '' as Usuario_id, 
		'' as DescripcionUsuario, 
		cast(0 as bit) as Leido,
		0 as disFormularios,'frmvenPedidosVCAutoriza' as Formulario_Id, null, 
		null,'|Pedidos', NULL, NULL 
	
		Where exists(
Select distinct genUsuarios.Usuario_Id
from genUsuarios 
	left join genPermisos ON
		genPermisos.Formulario_Id = dbo.FuncFKdisFormularios('frmvenPedidosVCAutoriza') and
		genPermisos.Usuario_Id = genUsuarios.genUsuarios and 
		ISNULL(genPermisos.Empresa_Id,@pEmpresa)=@pEmpresa
		
	WHERE
		genUsuarios.genUsuarios = @pUsuario_id and 
		(genPermisos.Postear = 1  or genUsuarios.EsSupervisor = 1) and 
		exists(select 1 from venPedidos inner join venPediSegmentos on
			venPedidos.venPedidos = venPediSegmentos.venPedidos and 
			venPediSegmentos.Empresa_Id = @pEmpresa
		 where
			venPedidos.Estado = 'C'))
Union all
-- Validacion Credito y Cobranza
select 0 as MensajeId, 
	getdate() as FechaEmision, cast(null as datetime) as FechaLeido,
	'Tiene_Pedidos_Pendientes_de_Autorizar' as Mensaje, '' as Usuario_id, 
		'' as DescripcionUsuario, 
		cast(0 as bit) as Leido,
		0 as disFormularios, disFormularios.Formulario_Id, null, 
		null,'|' + disFormularios.Titulo, NULL, NULL 
From genMenus
Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id
Where Orden = '521020' And
		Exists(
Select distinct genUsuarios.Usuario_Id
From genUsuarios
	Left join genPermisos ON genPermisos.Formulario_Id = 
		(Select disFormularios.disFormularios From genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id Where genMenus.Orden = '521020') And
		genPermisos.Usuario_Id = genUsuarios.genUsuarios And 
		ISNULL(genPermisos.Empresa_Id, @pEmpresa) = @pEmpresa
		
	WHERE
		genUsuarios.genUsuarios = @pUsuario_id and 
		(genPermisos.Postear = 1  or genUsuarios.EsSupervisor = 1) and 
		exists(select 1 from venPedidos inner join venPediSegmentos on
			venPedidos.venPedidos = venPediSegmentos.venPedidos and 
			venPediSegmentos.Empresa_Id = @pEmpresa
		 where
			venPedidos.Estado = 'P' AND 
			venPedidos.UsuarioAutoriz_Id IS NULL AND 
			venPedidos.Motivo_Id IS NOT NULL))
ORDER BY 2 Desc, 1 Desc 


RETURN @@Error 


GO

DROP PROCEDURE genMensajesEliminar
GO
CREATE PROCEDURE genMensajesEliminar
(
	@pMensaje_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM genMensajes 
	WHERE  genMensajes.Mensaje_Id =  @pMensaje_Id
	
RETURN @@Error 

GO



DROP PROCEDURE genMensajesDatos
GO
CREATE PROCEDURE genMensajesDatos
(
@pMensajeId int
)
AS
SET NOCOUNT ON 

SELECT genMensajes.Mensaje_Id AS MensajeId, 
	genMensajes.FechaEmision, genMensajes.Leido as FechaLeido,
	genUsuarios.genUsuarios,
	genMensajes.Mensaje, genUsuarios.Usuario_id, 
		genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
		Destino.Usuario_id as UsuarioDestino, 
		Destino.Apellido_y_Nombres as DescripcionUsuarioDestino,
		genMensajes.FechaDesde, genMensajes.FechaHasta,
		genMensajes.Parametros, disFormularios.disFormularios, disFormularios.Formulario_Id,
		genMensajes.Tipo, genMensajes.SubTipo
FROM genMensajes INNER JOIN genUsuarios on 
genMensajes.Usuario_id =genUsuarios.genUsuarios
INNER JOIN genUsuarios AS Destino ON
Destino.genUsuarios = genMensajes.UsuarioDestino
LEFT join disFormularios on disFormularios.disFormularios=genMensajes.Formulario_Id
WHERE (genMensajes.Mensaje_Id = @pMensajeId)
 
RETURN @@Error 

GO

DROP PROCEDURE genMensajesLeido
GO
CREATE PROCEDURE genMensajesLeido
(
@pMensaje_Id int,
@pFechaLeido DateTime = NULL
)
AS

UPDATE genMensajes SET Leido = @pFechaLeido Where
	Mensaje_Id = @pMensaje_Id
	
GO
	
drop procedure genMensajesPantallaDatos
go
create procedure genMensajesPantallaDatos
(
@pgenMensajes int=null,
@pUsuarioDestino varchar(25)=null,
@pUsuarioRemi int
)
as
set nocount on
select Mensaje_Id as genMensajes, Mensaje, Leido, Remitente.Usuario_Id as Remitente,
Remitente.Apellido_y_Nombres as DescripcionRemitente, Destino.Usuario_Id as Destino,
Destino.Apellido_y_Nombres as DescripcionDestino, FechaDesde, FechaHasta 
from genMensajes
left join genUsuarios Destino on Destino.Usuario_Id=@pUsuarioDestino
inner join genUsuarios Remitente on Remitente.genUsuarios=@pUsuarioRemi 
where Remitente.genUsuarios=@pUsuarioRemi and Destino.Usuario_Id=isnull(@pUsuarioDestino,Destino.Usuario_Id) and
Mensaje_Id=isnull(@pgenMensajes,0)
select Mensaje_Id as genMensajes, Mensaje, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, FechaEmision from genMensajes 
inner join genUsuarios on UsuarioDestino=genUsuarios where genMensajes.Usuario_Id=@pUsuarioRemi
go

drop procedure genMensajesPantallaAdminGuardar
go
create procedure genMensajesPantallaAdminGuardar
(
@pMensaje varchar(max),
@pUsuarioRemitente int,
@pFechaEmision datetime,
@pFechaDesde qFechaHora=null,
@pFechaHasta qFechaHora=null
)
as
begin
insert into genMensajes(Mensaje, Leido, Usuario_Id, UsuarioDestino, FechaEmision, FechaDesde, FechaHasta)
select @pMensaje, null, @pUsuarioRemitente, genUsuarios.genUsuarios, @pFechaEmision, @pFechaDesde, @pFechaHasta 
from genUsuarios 
where Inactivo = 0 and TipoUsuario = 'U'
end
go
