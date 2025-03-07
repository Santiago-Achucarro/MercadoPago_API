drop Procedure genHorariosIngreso
go
create Procedure genHorariosIngreso
(
    @pUsuario_Id int,
    @pHora datetime=null
    
)
AS

select Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo, Festivos, HoraDesde, HoraHasta
from genDiasLogin
left join genDiasFestivos on genDiasFestivos.Fecha=dbo.FechaSinHora(@pHora)
 where @pUsuario_Id=Usuario_Id and
dbo.HoraActual(@pHora) between HoraDesde and HoraHasta AND
(genDiasFestivos.Fecha is null or genDiasLogin.Festivos=1)
go

drop Procedure genHorariosIngresoGuardar
go
create Procedure genHorariosIngresoGuardar
(
    @pUsuario_Id varchar(25),
    @pLunes SiNo,
    @pMartes SiNo,
    @pMiercoles SiNo,
    @pJueves SiNo,
    @pViernes SiNo,
    @pSabado SiNo,
    @pDomingo SiNo,
    @pFestivo SiNo,
    @pHoraDesde char(5),
    @pHoraHasta char(5)
)
as
insert into genDiasLogin (Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo,
Festivos,HoraDesde, HoraHasta, Usuario_Id) VALUES 
(@pLunes, @pMartes, @pMiercoles, @pJueves, @pViernes, @pSabado, @pDomingo, @pFestivo,
@pHoraDesde, @pHoraHasta, dbo.FuncFKgenUsuarios(@pUsuario_Id))

go

drop  PROCEDURE genHorariosIngresoEliminar
go
create PROCEDURE genHorariosIngresoEliminar
(
    @pUsuario_Id varchar(25)
    
)
as
delete genDiasLogin where Usuario_Id=dbo.FuncFKgenUsuarios(@pUsuario_Id)
go