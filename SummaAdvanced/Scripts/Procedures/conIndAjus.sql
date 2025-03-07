
--exec conIndAjusDatos 'INPC',2019,1
drop procedure conIndAjusDatos
go
create procedure conIndAjusDatos
(
@pIndice_Id varchar(5),
@pEjercicio smallint,
@pEmpresa_Id int
)
as
set nocount on
select conIndicesAjustes.Indice_Id, Descripcion, @pEjercicio as Ejercicio 
from conIndicesAjustes
where conIndicesAjustes.Indice_Id=@pIndice_Id

select conIndicesAjustes.Indice_Id, conIndAjusCuerpo.Indice, conPeriodos.Ejercicio, conPeriodos.Periodo,
conPeriodos.Empresa_Id, genEmpresas.Detalle as DescripcionEmpresa 
from conPeriodos left join 
	(conIndAjusCuerpo inner join conIndicesAjustes on 
		conIndicesAjustes.conIndicesAjuste=conIndAjusCuerpo.Indice_Id AND 
		conIndicesAjustes.Indice_Id=@pIndice_Id) ON 
conPeriodos.Periodo=conIndAjusCuerpo.Periodo AND 
conPeriodos.Ejercicio = conIndAjusCuerpo.Ejercicio 
inner join genEmpresas on genEmpresas.genEmpresas=conPeriodos.Empresa_Id
Where conPeriodos.Empresa_Id=@pEmpresa_Id and 
	  conPeriodos.Ejercicio=@pEjercicio 
	  
go


drop procedure conIndAjusGuardar
go
create procedure conIndAjusGuardar
(
@pIndice_Id varchar(5),
@pDescripcion varchar(50),
@pIndice qMonedaD4,
@pEjercicio smallint,
@pEmpresa int,
@pPeriodo smallint
)
as
set nocount on
if(exists(select 1 from conIndicesAjustes where Indice_Id=@pIndice_Id) )
begin
update conIndicesAjustes set Descripcion=@pDescripcion
end
else
begin
insert into conIndicesAjustes (Indice_Id, Descripcion)
values (@pIndice_Id, @pDescripcion)
end
if(exists(select 1 from conIndAjusCuerpo where Indice_Id=dbo.FuncFKconIndicesAjustes(@pIndice_Id) and
Empresa_Id=@pEmpresa and conIndAjusCuerpo.Ejercicio=@pEjercicio and conIndAjusCuerpo.Periodo=@pPeriodo))
BEGIN
update conIndAjusCuerpo set 
Indice=@pIndice where Indice_Id=dbo.FuncFKconIndicesAjustes(@pIndice_Id) and
Empresa_Id=@pEmpresa and conIndAjusCuerpo.Ejercicio=@pEjercicio and Periodo=@pPeriodo
end
else
begin
insert into conIndAjusCuerpo (Indice_Id,Indice,Ejercicio,Periodo,Empresa_Id)
values (dbo.FuncFKconIndicesAjustes(@pIndice_Id),@pIndice,@pEjercicio,@pPeriodo,@pEmpresa)
end
go

drop procedure conIndAjusEliminar
go
create procedure conIndAjusEliminar
(
@pIndice_Id varchar(5),
@pEjercicio smallint=null,
@pEmpresa int
)
as set nocount on
delete from conIndAjusCuerpo where Indice_Id=dbo.FuncFKconIndicesAjustes(@pIndice_Id) and
Ejercicio=isnull(@pEjercicio,Ejercicio) and Empresa_Id=isnull(@pEmpresa,Empresa_Id)
go