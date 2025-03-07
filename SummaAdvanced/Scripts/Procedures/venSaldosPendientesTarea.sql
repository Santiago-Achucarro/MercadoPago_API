drop procedure venSaldosPendientesTarea
go
create procedure venSaldosPendientesTarea
(
    @pEmpresa_Id int
)
as
select '' as abc

-- Inicio Cambio 13/3/2022
-- Se modifica para que todos los mails de contacto asociados a un cliente, est�n concatenados en una columna. 
--- Hasta ahora se retornaba una fila por mail
/*** Version Anterior
select DISTINCT venClientes.Cliente_Id, venClieContacto.Email, genEmpresas.RazonSocial as RazonSocialEmpresa, venClientes.RazonSocial as RazonSocialCliente
from venClientes
inner join venClieContacto on (venClieContacto.EnviaFacturas=1 or venClieContacto.EnviaRecibo=1) and 
								venClieContacto.Cliente_Id=venClientes.genEntidades
inner join genEmpresas on genEmpresas.genEmpresas=@pEmpresa_Id
WHERE 
EXISTS(SELECT 1 FROM GENMOVCUOTAS 
inner join venmovimientos on venMovimientos.venMovimientos=genMovCuotas.Asiento_Id
inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
inner join conAsientos on conAsientos.conAsientos=venMovimientos.venMovimientos
 where 
    venmovimientos.Cliente_Id = venClientes.genEntidades AND
	FechaVencimiento<dbo.FechaActual() and venTipoMov.Signo=1 and 
	genMovCuotas.Saldo>0 and 
	conAsientos.Anulado=0 and 
	conAsientos.Posteado=1 and 
	conAsientos.Empresa_Id=@pEmpresa_Id)
***/

DECLARE @lRazonSocial as Varchar(120)
-- Se hace esto solo para no tener que modificar el BE. Porque la raz�n social en lugar de repetirse en cada fila, 
-- podr�a haber ido en el primer select, que se asocia al datatable principal
SELECT @lRazonSocial = RazonSocial FROM genEmpresas WHERE genEmpresas.genEmpresas=@pEmpresa_Id


select venClientes.Cliente_Id, venClientes.RazonSocial as RazonSocialCliente, @lRazonSocial as RazonSocialEmpresa, 
							REPLACE(STUFF((SELECT ';'  + venClieContacto.Email
									  FROM venClieContacto 
                                      WHERE (venClieContacto.EnviaFacturas=1 or venClieContacto.EnviaRecibo=1)
									  -- No se diferencia sucursal, si una debe y otra no..les llega por igual a todos
	                                  AND venClieContacto.Cliente_Id=venClientes.genEntidades
                                      FOR XML PATH('')),
                             1, 1, ''), ' ', '') As Email
from venClientes
WHERE EXISTS(SELECT 1 
			FROM venClieContacto 
			WHERE venClieContacto.Cliente_Id=venClientes.genEntidades
			AND (venClieContacto.EnviaFacturas=1 or venClieContacto.EnviaRecibo=1)
			) -- No incluye a los que no tienen contactos
AND EXISTS(SELECT 1 FROM GENMOVCUOTAS 
inner join venmovimientos on venMovimientos.venMovimientos=genMovCuotas.Asiento_Id
inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
inner join conAsientos on conAsientos.conAsientos=venMovimientos.venMovimientos
 where 
    venmovimientos.Cliente_Id = venClientes.genEntidades AND
	FechaVencimiento<dbo.FechaActual() and venTipoMov.Signo=1 and 
	genMovCuotas.Saldo>0 and 
	conAsientos.Anulado=0 and 
	conAsientos.Posteado=1 and 
	conAsientos.Empresa_Id=@pEmpresa_Id)
-- Fin Cambio 13/3/2022

 go
