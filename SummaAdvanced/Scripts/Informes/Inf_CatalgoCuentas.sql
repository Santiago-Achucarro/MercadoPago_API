-- Inf_CatalgoCuentas ' ', 'ZZZ',1
DROP PROCEDURE Inf_CatalgoCuentas
GO
CREATE PROCEDURE Inf_CatalgoCuentas(
	 @CuentaDesde VarChar(25), 
	 @CuentaHasta VarChar(25), 
	 @Empresa_Id int
	)
AS

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel, 
	conCuentas.Imputable, conCuentas.Inactivo, conTiposContables.Tipo_Id, 
	conTiposContables.Descripcion as  DescripcionTipo, 
	conTiposSAT.TipoSAT_Id, conTiposSAT.Descripcion AS DescripcionTipoSat, 
	conBaseDistri.Base_Id,  conBaseDistri.Descripcion AS DescripcionBase, 
	conCuentas.Ajustable, conCuentas.Metodo, conCuadro1Filas.Cuadro1Fila_Id, conCuadro1Filas.Descripcion as DescripcionCuadro1,
	conCuentas.EliminaConsolida, isnull(CONVERT(char(10), conCuentas.Fecha_Reserva, 103), ' ') as  Fecha_Reserva, 
	conGruposCont.Grupo_Id, conGruposCont.Descripcion as DescripcionGrupo,
	conCuentas.NoSeReserva, conCuentas.Notas, conCuentas.Posteado, 
	conCuentas.Naturaleza, conCuentas.ReservadaPor, conCuentas.Rubro_Id , 
	conRubros.Descripcion as DescrpcionRubro, conIndicesAjustes.Indice_Id, 
	conIndicesAjustes.Descripcion as DescripcionIndice, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as NombreUsuario
	
from conCuentas left join conTiposContables ON
conCuentas.Tipo_Id = conTiposContables.Tipo_Id
left join conTiposSAT ON
conTiposSAT.TipoSAT_Id = conCuentas.TipoSAT_Id
LEFT join conBaseDistri ON
conBaseDistri.conBaseDistri = conCuentas.Base_Id
LEFT JOIN conCuadro1Filas on
conCuadro1Filas.conCuadro1Filas = conCuentas.Cuadro1Fila_Id
LEFT JOIN conGruposCont ON
conGruposCont.conGruposCont = conCuentas.Grupo_Id
inner join conRubros ON
conRubros.Rubro_Id = conCuentas.Rubro_Id
LEFT JOIN conIndicesAjustes ON
conIndicesAjustes.conIndicesAjuste = conCuentas.Indice_Id
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = conCuentas.Usuario_Id
Where
	conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and 
	@Empresa_Id = ISNULL(conCuentas.Empresa_Id , @Empresa_Id)
ORDER BY 1