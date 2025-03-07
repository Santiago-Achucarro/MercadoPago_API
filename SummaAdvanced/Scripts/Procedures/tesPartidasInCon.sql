drop procedure tesPartidasInConInsertar
go
create procedure tesPartidasInConInsertar
(
@pCartera_Id varchar(5),
@pFecha datetime,
@pComprobante int,
@pDebeHaber char(1),
@pImporte qMonedaD2,
@pEmpresa_Id int
)
as
insert into tesPartidasInCon (Cartera_Id, Fecha, Comprobante, Debe_Haber, Importe, Empresa_Id) values
(dbo.FuncFKtesIdentifica(@pCartera_Id), @pFecha, @pComprobante,convert(int,@pDebeHaber), @pImporte, @pEmpresa_Id)
go

drop procedure tesPartidasInConEliminar
go
create procedure tesPartidasInConEliminar
(
@pCartera_Id varchar(5),
@pFechaDesde Datetime,
@pFechaHasta DateTime,
@pComprobante int=null,
@pEmpresa_Id int
)
as
delete from tesPartidasInCon where Cartera_Id=dbo.FuncFKtesIdentifica(@pCartera_Id) and Fecha between @pFechaDesde and @pFechaHasta and 
Comprobante= ISNULL(@pComprobante,Comprobante) and @pEmpresa_Id=Empresa_Id
go

drop procedure tesPartidasInConDatos
go
create procedure tesPartidasInConDatos
(
@pCartera_Id varchar(5),
@pFechaDesde datetime,
@pFechaHasta datetime,
@pEmpresa_Id int
)
as
select @pCartera_Id as Cartera_Id, Descripcion as DescripcionCartera, @pFechaDesde as FechaDesde, @pFechaHasta as FechaHasta from tesIdentifica 
where tesIdentifica.Cartera_Id= @pCartera_Id
select Comprobante, Fecha, CONVERT(char(1), Debe_Haber) as Debe_Haber, Importe from tesPartidasInCon 
where Cartera_Id=dbo.FuncFKtesIdentifica(@pCartera_Id) and Fecha between @pFechaDesde and @pFechaHasta and Empresa_Id=@pEmpresa_Id
