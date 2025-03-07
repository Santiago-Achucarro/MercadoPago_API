IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 42.05)
begin
insert into discontroles (Formulario_Id, Control_Id, NroControl, ControlParent_Id, TipoControl, Alto,
						Ancho, Arriba, Izquierda, Texto, Visible, Habilitado, Alineacion, TabStop,
						TabOrden, Requerido, Embebido, Ancla, EsCodigoNuevo, Paises, Fila, Columna,
						FilasExtension, ColumnasExtension, MaximaLongitud, ClickNuevoBlanquea, ControlaCambios,
						SoloLectura, TextoFijo, TextoControlVacio, Estilo, TituloLabel, AlineacionLabel, IgualaAnchoColumna,
						ControlSegmento, Heredado ,SegmentoOrigen)
select lform2.disFormularios, 'var_Auxiliar' + cast(lvar.Nombre as varchar(1)), nroCont + lvar.Nombre, lform2.Formulario_Id, 'Variable', 0,
							0, 0, 0, NULL, 0, 0, '', 0,
							-1, 1, 0, '', 0, NULL, 0, 0,
							0, 0, NULL, 1, 1, 
							0, 0, NULL, NULL, NULL, '', 0,
							NULL, case when lform.FormularioPadre_Id is null then 0 else 1 end, NULL
from disFormularios lform
inner join (select 1 as Nombre union 
			select 2 as Nombre union 
			select 3 as Nombre) as lvar on 1=1			
inner join (select disFormularios.disFormularios,disFormularios.Formulario_Id, MAX(NroControl) nroCont
			from disControles
			inner join disFormularios on disFormularios.disFormularios = disControles.Formulario_Id
			group by disFormularios.disFormularios,disFormularios.Formulario_Id) lform2 on lform2.disFormularios = lform.disFormularios

order by 1;

INSERT INTO genVersion(Version) Values(42.05);
end
GO