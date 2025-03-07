drop procedure genLicenciaGuardar
go
create procedure genLicenciaGuardar
(
    @pFecha datetime,
    @pUsuarios int,
    @pClave varchar(max),
    @pPorEmpresa bit,
    @pLicencia varchar(36)
)
as
update genInstalacion set Licencias=@pUsuarios, Clave=@pClave, FechaVencimiento=@pFecha, PorEmpresa=@pPorEmpresa 
WHERE Licencia=@pLicencia
go