DROP Procedure Inf_conCuentas 
GO
CREATE Procedure Inf_conCuentas (
	@CuentaDesde VarChar(25),@CuentaHasta VarChar(25), @pEmpresa_Id Int)
AS

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Rubro_Id, conCuentas.Imputable, conCuentas.Nivel, 
		conCuentas.Naturaleza, conCuentas.NoSeReserva, 
		conCuentas.EliminaConsolida, conCuentas.Inactivo, 	
		conCuentas.Posteado, conTiposContables.Tipo_id, 
		conTiposContables.Descripcion as DescripcionTipo, 
		conBaseDistri.Base_Id, conBaseDistri.Descripcion as DescripcionBase, 
		conGruposCont.Grupo_Id, conGruposCont.Descripcion as DescripcionGrupo, 
		conSituPatri.Descripcion as Rubro_Balance	, 
		genMonedas.Moneda_Id, conCuentas.TipoSat_Id
FROM conCuentas	LEFT OUTER JOIN conTiposContables ON
conCuentas.Tipo_id = conTiposContables.Tipo_Id
LEFT OUTER JOIN conBaseDistri ON
conBaseDistri.conBaseDistri = conCuentas.Base_Id
LEFT OUTER JOIN conGruposCont ON
conGruposCont.conGruposCont = conCuentas.Grupo_Id
LEFT OUTER JOIN conSituPatri ON
conSituPatri.Rubro_Balance =conCuentas.Rubro_Balance
LEFT OUTER JOIN genMonedas ON
genMonedas.genMonedas = ConCuentas.Moneda_Id
WHERE
	conCuentas.Cuenta_Id BETWEEN @CuentaDesde and @CuentaHasta and 
	ISNULL(conCuentas.Empresa_Id,@pEmpresa_id) = @pEmpresa_id
ORDER BY 1