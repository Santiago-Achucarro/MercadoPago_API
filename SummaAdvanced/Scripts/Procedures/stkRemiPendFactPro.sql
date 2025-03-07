drop procedure stkRemiPendFactProInsertar
go
create procedure stkRemiPendFactProInsertar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pCantidadPendiente numeric (19,8)
)
as
set nocount on
insert into stkRemiPendFactPro
(
stkMoviCabe,
Renglon,
CantidadPendiente
)
values
(
@pstkMoviCabe,
@pRenglon,
@pCantidadPendiente
)
go
drop procedure stkRemiPendFactProEliminar
go
create procedure stkRemiPendFactProEliminar
(
@pstkMoviCabe bigint,
@pRenglon int=null
)
as
set nocount on
delete from stkRemiPendFactPro
where stkMoviCabe=@pstkMoviCabe and isnull(@pRenglon,Renglon)=Renglon
go
drop Procedure stkRemiPendFactProDatos
go
create Procedure stkRemiPendFactProDatos
(
@pstkMoviCabe bigint, 
@pRenglon Int=NULL
)
as
set nocount on
select stkMoviCabe,Renglon,CantidadPendiente from stkRemiPendFactPro
wHERE
	stkMoviCabe = @pstkMoviCabe and 
	Renglon = ISNULL(@pRenglon,Renglon)
go

drop procedure stkRemiPendFactProActuCant
go
create procedure stkRemiPendFactProActuCant
(
@pstkMoviCabe bigint,
@pRenglon int,
@pCantidad numeric (19,8)
)
as
UPDATE stkRemiPendFactPro SET CantidadPendiente = 
	CantidadPendiente  - @pCantidad 
	Where
		stkMoviCabe = @pstkMoviCabe AND 
		Renglon = @pRenglon
GO