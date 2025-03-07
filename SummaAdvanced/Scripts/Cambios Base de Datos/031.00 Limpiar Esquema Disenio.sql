IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 31.00)
begin


drop table disControlesDownLoad;


drop table disControlesGrillaColBoton;


drop table disControlesGrillaColBotonTemp;


drop table disControlesGrillaColComboTemp;


drop table disControlesGrillaColComboItems;


drop table disControlesGrillaColComboItemsTemp;


drop table disControlesGrillaColCombo;


drop table disControlesGrillaColFecha;


drop table disControlesGrillaColFechaTemp;


drop table disControlesGrillaColNumerico;


drop table disControlesGrillaColNumericoTemp;


drop table disControlesGrillaColTexto;


drop table disControlesGrillaColTextoTemp;


drop table disAccionesColumnas;


drop table disAccionesColumnasTemp;


drop table disEventosColumnas;

drop table disEventosColumnasTemp;

DROP PROCEDURE disAccionesColumnasGuardar;

DROP PROCEDURE disAccionesColumnasEliminar;

DROP PROCEDURE disControlesDownLoadGuardar;

DROP PROCEDURE disControlesDownLoadEliminar;

DROP PROCEDURE disEventosColumnasGuardar;

DROP PROCEDURE disEventosColumnasEliminar;

INSERT INTO genVersion(Version) Values(31.00);

end
