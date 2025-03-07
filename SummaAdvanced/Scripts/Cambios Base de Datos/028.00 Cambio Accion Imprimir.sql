IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 28.00)
begin


update disAcciones
set ControlDestino_Id = cs.Control_Id
from disControlesSegmento cs  
inner join disTablasColumnas df on df.Formulario_Id = cs.Formulario_Id and cs.Control_Id = df.Control_Id and df.Tabla_Id = 'Principal'
where disAcciones.Accion like 'Imprimir'
and cs.Formulario_Id = disAcciones.Formulario_Id 
and cs.Control_Id like 'ctrSegmento_Id%' AND 
disAcciones.ControlDestino_Id IS NULL; 


INSERT INTO genVersion(Version) Values(28.00);

end

