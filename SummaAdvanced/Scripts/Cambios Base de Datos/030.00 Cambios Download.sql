
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 30.00)
begin

insert into disControlesTexto (Formulario_Id, Control_Id, MultiplesLineas, CharCasing)
select Formulario_Id, Control_Id, 0, 'Normal'
from disControles
where TipoControl = 'SummaAdvDisenio.Controles.DisenioDownLoad';


update disControles
set TipoControl = 'SummaAdvDisenio.Controles.DisenioTxtEditor', 
	MaximaLongitud = 100,
	TituloLabel = 'Este Tipo de Ctrl no se usa mas',
	Texto = 'Este Tipo de Ctrl no se usa mas'
where TipoControl = 'SummaAdvDisenio.Controles.DisenioDownLoad';


Update disAcciones
set Accion = 'Mensaje',
ControlDestino_Id = NULL,
Texto = 'El funcionamiento de la accion Descargar Archivo ha cambiado. Modifique el diseño'
where Accion = 'DescargarArchivo';

update disTablasColumnas
set TipoControl = 'SummaAdvDisenio.Controles.DisenioTxtEditor' 
where TipoControl = 'SummaAdvDisenio.Controles.DisenioDownLoad';

delete from disControlesDownLoad;


INSERT INTO genVersion(Version) Values(30.00);

end