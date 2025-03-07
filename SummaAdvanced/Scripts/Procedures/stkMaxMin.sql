drop Procedure stkMaxMinDatos
go
create Procedure stkMaxMinDatos
(
@pDeposito_Id varchar(15), 
@pEmpresa_Id Int
)
as
set nocount on
select stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito, '' as Excel, cast(0 as bit) as Quita_No_Existentes
From stkDepositos 
where stkDepositos.Deposito_Id=@pDeposito_Id

select stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, stkMaxMin.Minimo,stkMaxMin.Maximo,stkMaxMin.Empresa_Id
from stkMaxMin 
inner join stkProductos on stkProductos.stkProductos = stkMaxMin.Producto_Id
inner join stkDepositos on stkDepositos.stkDepositos = stkMaxMin.Deposito_Id
where 
stkDepositos.Deposito_id =@pDeposito_Id and 
stkMaxMin.Empresa_Id = @pEmpresa_Id

go
drop procedure stkMaxMinInsertar
go
create Procedure stkMaxMinInsertar
(
@pProducto_Id varchar(25),
@pDeposito_Id varchar(15),
@pMin qCantidadD8,
@pMax qCantidadD8,
@pEmpresa_Id int
)
as
set nocount on
insert into stkMaxMin
(Producto_Id, Deposito_Id, Minimo,Maximo,Empresa_Id)
values
(dbo.FuncFKstkProductos(@pProducto_Id),dbo.FuncFKstkDepositos(@pDeposito_Id),@pMin,@pMax, @pEmpresa_Id)
go
drop procedure stkMaxMinEliminar
go
create Procedure stkMaxMinEliminar
(
@pProducto_Id varchar(25)=null,
@pDeposito_Id varchar(15), 
@pEmpresa_Id Int
)
as
set nocount on
delete from stkMaxMin 
	where Deposito_Id=dbo.FuncFKstkDepositos(@pDeposito_Id) and Producto_Id=isnull(@pProducto_Id,Producto_Id) and 
	Empresa_Id = @pEmpresa_Id
go