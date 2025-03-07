DROP PROCEDURE conCuentasGuardar
GO
CREATE PROCEDURE conCuentasGuardar
(
@pCuenta_Id varchar(25),
@pCuenta_Id_Nuevo varchar(25),
@pEmpresa_Id int = NULL,
@pTipo_Id varchar(5) = NULL,
@pDescripcion varchar(80),
@pRubro_Id char(1) = NULL,
@pImputable bit,
@pNivel int,
@pBase_Id varchar(5) = NULL,
@pGrupo_Id varchar(5) = NULL,
@pCuadro1Fila_Id int = NULL,
@pReservadaPor varchar(3) = NULL,
@pFecha_Reserva qFecha,
@pSubCuenta_Id VarChar(24) = NULL,
@pNoSeReserva Sino,
@pRubro_Balance varchar(15) = NULL,
@pAjustable Sino,
@pNotas VarChar(max) = NULL,
@pMoneda_Id varchar(3) = NULL,
@pIndice_Id char(5) = NULL,
@pMetodo smallint,
@pEliminaConsolida Sino,
@pTipoSAT_Id varchar(25) = NULL,
@pNaturaleza Char(1), 
@pInactivo bit,
@pUsuario_Id int,
@pPosteado Sino, 
@pDescription VarChar(80), 
@pRubroAxi_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conCuentas WHERE (Cuenta_Id = @pCuenta_Id)))
BEGIN 
	UPDATE conCuentas
	SET		@lIdentidad = conCuentas,
		Cuenta_Id = @pCuenta_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Tipo_Id = @pTipo_Id,
		Descripcion = @pDescripcion,
		Rubro_Id = @pRubro_Id,
		Imputable = @pImputable,
		Nivel = @pNivel,
		Base_Id = dbo.FuncFKconBaseDistri(@pBase_Id),
		Grupo_Id = dbo.FuncFKconGruposCont(@pGrupo_Id),
		Cuadro1Fila_Id = @pCuadro1Fila_Id,
		ReservadaPor = @pReservadaPor,
		Fecha_Reserva = @pFecha_Reserva,
		SubCuenta_Id = dbo.FuncFkconSubCuentas(@pSubCuenta_Id),
		NoSeReserva = @pNoSeReserva,
		Rubro_Balance = @pRubro_Balance,
		Ajustable = @pAjustable,
		Notas = @pNotas,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Indice_Id = dbo.FuncFKconIndicesAjustes(@pIndice_Id),
		Metodo = @pMetodo,
		EliminaConsolida = @pEliminaConsolida,
		TipoSAT_Id = @pTipoSAT_Id,
		Naturaleza = @pNaturaleza,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		Description = @pDescription, 
		RubroAxi_Id = dbo.FuncFkconRubrosAxi(@pRubroAxi_Id)
	WHERE (Cuenta_Id = @pCuenta_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conCuentas
	(
		Cuenta_Id,
		Empresa_Id,
		Tipo_Id,
		Descripcion,
		Rubro_Id,
		Imputable,
		Nivel,
		Base_Id,
		Grupo_Id,
		Cuadro1Fila_Id,
		ReservadaPor,
		Fecha_Reserva,
		SubCuenta_Id,
		NoSeReserva,
		Rubro_Balance,
		Ajustable,
		Notas,
		Moneda_Id,
		Indice_Id,
		Metodo,
		EliminaConsolida,
		TipoSAT_Id,
		Naturaleza,
		Inactivo,
		Usuario_Id,
		Posteado, 
		Description,
		RubroAxi_Id 
	)
	VALUES 
	(
		@pCuenta_Id,
		@pEmpresa_Id,
		@pTipo_Id,
		@pDescripcion,
		@pRubro_Id,
		@pImputable,
		@pNivel,
		dbo.FuncFKconBaseDistri(@pBase_Id),
		dbo.FuncFKconGruposCont(@pGrupo_Id),
		@pCuadro1Fila_Id,
		@pReservadaPor,
		@pFecha_Reserva,
		dbo.FuncFkconSubCuentas(@pSubCuenta_Id),
		@pNoSeReserva,
		@pRubro_Balance,
		@pAjustable,
		@pNotas,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKconIndicesAjustes(@pIndice_Id),
		@pMetodo,
		@pEliminaConsolida,
		@pTipoSAT_Id,
		@pNaturaleza,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pDescription,
		dbo.FuncFkconRubrosAxi(@pRubroAxi_Id)
	)
	SET @lIdentidad =  Cast(SCOPE_IdENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE conCuentasDatos
GO
CREATE PROCEDURE conCuentasDatos(
@pCuenta_Id varchar (25)
)
AS
SELECT conCuentas.conCuentas, conCuentas.Cuenta_Id, conCuentas.Empresa_Id,
	Cast(case When conCuentas.Empresa_Id is null then 1 else 0 end  as bit) as PTodasEmpresas,
conTiposContables.Tipo_Id, conCuentas.Descripcion, 
conRubros.Rubro_Id, conCuentas.Imputable, 
conCuentas.Nivel, conBaseDistri.Base_Id, conGruposCont.Grupo_Id, 
conCuadro1Filas.Cuadro1Fila_Id, conCuentas.ReservadaPor, conCuentas.Fecha_Reserva, 
conSubCuentas.SubCuenta_Id, conCuentas.NoSeReserva, 
conSituPatri.Rubro_Balance, conCuentas.Ajustable, conCuentas.Notas, 
genMonedas.Moneda_Id, 
conIndicesAjustes.Indice_Id, conCuentas.Metodo, conCuentas.EliminaConsolida, 
conTiposSAT.TipoSAT_Id, conCuentas.Naturaleza, conCuentas.Inactivo, 
genUsuarios.Usuario_Id,  conCuentas.Posteado ,conBaseDistri.Descripcion as DescripcionconBaseDistri
 ,conCuadro1Filas.Descripcion as DescripcionconCuadro1Filas
 ,conGruposCont.Descripcion as DescripcionconGruposCont
 ,conRubros.Descripcion as DescripcionconRubros ,conSituPatri.Descripcion as DescripcionconSituPatri
 ,conSubCuentas.Descripcion as DescripcionconSubCuentas
 ,conTiposContables.Descripcion as DescripcionconTiposContables
 ,conTiposSAT.Descripcion as DescripcionconTiposSAT
 ,conIndicesAjustes.Descripcion as DescripcionIndicesAjustes
 ,genEmpresas.Detalle as DescripcionEmpresa ,genMonedas.Descripcion as DescripciongenMonedas
 ,genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	conCuentas.Description, 
	conRubrosAxi.RubroAxi_Id, conRubrosAxi.Descripcion as DescripcionRubroAxi
 FROM conCuentas  
 LEFT OUTER JOIN conBaseDistri ON conBaseDistri.conBaseDistri=conCuentas.Base_Id
 LEFT OUTER JOIN conCuadro1Filas ON conCuadro1Filas.Cuadro1Fila_Id=conCuentas.Cuadro1Fila_Id
 LEFT OUTER JOIN conGruposCont ON conGruposCont.conGruposCont=conCuentas.Grupo_Id
 LEFT OUTER JOIN conRubros ON conRubros.Rubro_Id=conCuentas.Rubro_Id
 LEFT OUTER JOIN conSituPatri ON conSituPatri.Rubro_Balance=conCuentas.Rubro_Balance
 LEFT OUTER JOIN conSubCuentas ON conSubCuentas.conSubCuentas=conCuentas.SubCuenta_Id
 LEFT OUTER JOIN conTiposContables ON conTiposContables.Tipo_Id=conCuentas.Tipo_Id
 LEFT OUTER JOIN conTiposSAT ON conTiposSAT.TipoSAT_Id=conCuentas.TipoSAT_Id
 LEFT OUTER JOIN genEmpresas ON genEmpresas.genEmpresas=conCuentas.Empresa_Id
 LEFT OUTER JOIN genMonedas ON genMonedas.genMonedas=conCuentas.Moneda_Id
 INNER JOIN genUsuarios ON genUsuarios.genUsuarios=conCuentas.Usuario_Id
 LEFT OUTER JOIN conIndicesAjustes ON conIndicesAjustes.conIndicesAjuste = conCuentas.Indice_id
 LEFT OUTER JOIN conRubrosAxi ON conRubrosAxi.conRubrosAxi = conCuentas.RubroAxi_Id
 	
 Where 
	conCuentas.Cuenta_Id = @pCuenta_Id



GO


DROP PROCEDURE conCuentasActualizacionDatos
GO
CREATE PROCEDURE conCuentasActualizacionDatos(
@pCuenta_Id varchar (25), 
@pEmpresa_Id int
)
AS

DECLARE @pCuenta1 varCHAR(25)
DECLARE @pDigitos int

SELECT @pDigitos = conDigiCta FROM genInstalacion

set @pCuenta1 = LEFT(@pCuenta_Id, @pDigitos)+'%'


SELECT conCuentas.conCuentas, conCuentas.Cuenta_Id, conCuentas.Cuenta_Id as Cuenta_Id_Nueva, conCuentas.Empresa_Id,
	Cast(case When conCuentas.Empresa_Id is null then 1 else 0 end  as bit) as PTodasEmpresas,
conTiposContables.Tipo_Id, conCuentas.Descripcion, 
conRubros.Rubro_Id, conCuentas.Imputable, conRubros.Tipo as TipoRubro,
conCuentas.Nivel, conBaseDistri.Base_Id, conGruposCont.Grupo_Id, 
conCuadro1Filas.Cuadro1Fila_Id, conCuentas.ReservadaPor, conCuentas.Fecha_Reserva, 
conSubCuentas.SubCuenta_Id, conCuentas.NoSeReserva, 
conSituPatri.Rubro_Balance, conCuentas.Ajustable, conCuentas.Notas, 
genMonedas.Moneda_Id, 
conIndicesAjustes.Indice_Id, conCuentas.Metodo, conCuentas.EliminaConsolida, 
conTiposSAT.TipoSAT_Id, conCuentas.Naturaleza,  conCuentas.Inactivo, 
genUsuarios.Usuario_Id,  conCuentas.Posteado ,conBaseDistri.Descripcion as DescripcionconBaseDistri
 ,conCuadro1Filas.Descripcion as DescripcionconCuadro1Filas
 ,conGruposCont.Descripcion as DescripcionconGruposCont
 ,conRubros.Descripcion as DescripcionconRubros ,conSituPatri.Descripcion as DescripcionconSituPatri
 ,conSubCuentas.Descripcion as DescripcionconSubCuentas
 ,conTiposContables.Descripcion as DescripcionconTiposContables
 ,conTiposSAT.Descripcion as DescripcionconTiposSAT
 ,conIndicesAjustes.Descripcion as DescripcionIndicesAjustes
 ,genEmpresas.Detalle as DescripcionEmpresa ,genMonedas.Descripcion as DescripciongenMonedas
 ,genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
 LEFT(conCuentas.Cuenta_id,@pDigitos) as CuentaSC, conCuentasSinSC.Descripcion DescripcionSC,
 cast(0 as bit) as PorSubCuenta, conCuentas.Description, 
 conRubrosAxi.RubroAxi_Id, conRubrosAxi.Descripcion as DescripcionRubroAxi
 
 FROM conCuentas  
 LEFT OUTER JOIN conBaseDistri ON conBaseDistri.conBaseDistri=conCuentas.Base_Id
 LEFT OUTER JOIN conCuadro1Filas ON conCuadro1Filas.Cuadro1Fila_Id=conCuentas.Cuadro1Fila_Id
 LEFT OUTER JOIN conGruposCont ON conGruposCont.conGruposCont=conCuentas.Grupo_Id
 LEFT OUTER JOIN conRubros ON conRubros.Rubro_Id=conCuentas.Rubro_Id
 LEFT OUTER JOIN conSituPatri ON conSituPatri.Rubro_Balance=conCuentas.Rubro_Balance
 LEFT OUTER JOIN conSubCuentas ON conSubCuentas.conSubCuentas=conCuentas.SubCuenta_Id
 LEFT OUTER JOIN conTiposContables ON conTiposContables.Tipo_Id=conCuentas.Tipo_Id
 LEFT OUTER JOIN conTiposSAT ON conTiposSAT.TipoSAT_Id=conCuentas.TipoSAT_Id
 LEFT OUTER JOIN genEmpresas ON genEmpresas.genEmpresas=conCuentas.Empresa_Id
 LEFT OUTER JOIN genMonedas ON genMonedas.genMonedas=conCuentas.Moneda_Id
 INNER JOIN genUsuarios ON genUsuarios.genUsuarios=conCuentas.Usuario_Id
 LEFT OUTER JOIN conIndicesAjustes  ON conIndicesAjustes.conIndicesAjuste = conCuentas.Indice_id
 LEFT OUTER JOIN conCuentasSinSC ON conCuentasSinSC.Cuenta_id = conCuentas.conCuentas
 LEFT OUTER JOIN conRubrosAxi ON conRubrosAxi.conRubrosAxi = conCuentas.RubroAxi_Id
 Where conCuentas.Cuenta_Id = @pCuenta_Id


SELECT conSubCuentas.conSubCuentas, conSubCuentas.SubCuenta_Id, 
	conSubCuentas.Descripcion, 
		Cast(case when conCuentas.SubCuenta_Id is null then 0 else 1 end  as Bit) as Marca,
	conTiposSAT.TipoSAT_Id, conBaseDistri.Base_Id,
	conTiposSAT.Descripcion as DescripcionTipoSat ,
	conBaseDistri.Descripcion as  DescripcionBaseDistri,
	conCuentas.Inactivo, conGruposCont.Grupo_Id, conGruposCont.Descripcion as DescripcionGrupo
From conSubCuentas 
Left outer join conCuentas ON conCuentas.SubCuenta_Id = conSubCuentas.conSubCuentas and 
		conCuentas.Cuenta_Id like @pCuenta1
left outer join conBaseDistri on ISNULL(conCuentas.Base_Id, conSubCuentas.Base_Id) = conBaseDistri.conBaseDistri
left outer join conTiposSat ON conCuentas.TipoSat_Id = conTiposSat.TipoSat_Id 
left join conGruposCont on conGruposCont.conGruposCont=conCuentas.Grupo_Id
Where ISNULL(conSubCuentas.Empresa_id, @pEmpresa_id) = @pEmpresa_id and 
			conSubCuentas.Inactivo = 0
ORDER BY 2		
GO

DROP PROCEDURE conCuentasEliminar
GO
CREATE PROCEDURE conCuentasEliminar
(
@pCuenta_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conCuentas 
WHERE (Cuenta_Id = @pCuenta_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconCuentas
GO

CREATE FUNCTION FuncFKconCuentas
(
@pCuenta_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conCuentas FROM conCuentas WHERE 
	Cuenta_Id = @pCuenta_Id
  RETURN @pIdentity
END


GO


drop procedure conCuentasSinSCGuardar
go
create procedure conCuentasSinSCGuardar
(
@pCuenta_Id varchar(25),
@pDescripcion varchar(80)
)
as
if(exists(select 1 from conCuentasSinSC where Cuenta_Id=dbo.FuncFKconCuentas( @pCuenta_Id)))
begin
update conCuentasSinSC set Descripcion=@pDescripcion
where Cuenta_Id=dbo.FuncFKconCuentas( @pCuenta_Id)
end
else
begin
insert into conCuentasSinSC values(dbo.FuncFKconCuentas(@pCuenta_Id), @pDescripcion)
end
go
drop procedure conCuentasSinSCDatos
go
create procedure conCuentasSinSCDatos
(
@pCuenta_Id varchar(25)
)
aS
select conCuentas.Cuenta_Id, conCuentasSinSC.Descripcion 
from conCuentasSinSC inner join conCuentas on conCuentasSinSC.Cuenta_Id=conCuentas.conCuentas
where conCuentas.Cuenta_Id=@pCuenta_Id

go

drop procedure conCuentasSinSCEliminar
go
create procedure conCuentasSinSCEliminar
(
@pCuenta_Id varchar(25)
)
AS
delete from conCuentasSinSC where Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id)

go


Drop Procedure conCuentasCuentasDatos
GO
create procedure conCuentasCuentasDatos
AS
SELECT COUNT(1) as Cantidad FROM concuentas

go

