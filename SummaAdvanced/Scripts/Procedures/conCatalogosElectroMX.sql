drop procedure conCatalogoElectroMX
go
create procedure conCatalogoElectroMX
(
@pEmpresa_Id int,
@pNivel int
)
as
select YEAR(GETDATE()) as Anio, MONTH(GETDATE()) as Mes, cast(0 as bit) as Genera_Catalogo, cast(0 as bit) as Genera_Balanza, 
cast(0 as bit) as Genera_Poliza, ' ' as TipoSolicitud, ' ' as Numorden, ' ' as NumTramite, 99 as Nivel
	

SELECT Cuenta_id, Descripcion, Nivel, TipoSat_Id, Naturaleza, 
 (select max(cuenta_id) from conCuentas c1 where
  c1.Cuenta_Id < concuentas.Cuenta_Id and 
  c1.Nivel < conCuentas.Nivel) SubcuentaDe
  FROM conCuentas where isnull(conCuentas.Empresa_Id,@pEmpresa_Id)=@pEmpresa_Id and conCuentas.Nivel<=@pNivel
order by 1
go
