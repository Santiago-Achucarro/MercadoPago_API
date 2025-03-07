ALTER TABLE discontrolesComboItems ADD Orden int Default 0 NOT NULL
GO

CREATE PROCEDURE tmpActualizarOrdenItemsCombo 
AS
declare @control varchar(200) 
declare @formu int
DECLARE combitems CURSOR 
FOR SELECT distinct formulario_id, control_id
FROM  disControlesComboItems

OPEN combitems  
FETCH NEXT FROM combitems
INTO @Formu, @control  
WHILE @@FETCH_STATUS = 0  
BEGIN  
	update disControlesComboItems
	set orden = aux.Row
	from disControlesComboItems TBL-- tabla que queremos modificar
	INNER JOIN	(select ROW_NUMBER () OVER (ORDER BY formulario_id, control_id, valor) AS Row, Formulario_Id, Control_Id, valor
				from disControlesComboItems
				where disControlesComboItems.Control_Id = @control
				and disControlesComboItems.Formulario_Id = @formu) as aux ON aux.Formulario_Id = TBL.Formulario_Id AND
																			 aux.Control_Id = TBL.Control_Id AND
	 																		 aux.valor = TBL.valor
	where tbl.Control_Id = @control
	and tbl.Formulario_Id = @formu

	FETCH NEXT FROM combitems
	INTO @Formu, @control  
END   
CLOSE combitems  
DEALLOCATE combitems  
GO

exec tmpActualizarOrdenItemsCombo
GO

DROP PROCEDURE tmpActualizarOrdenItemsCombo
GO

--ALTER TABLE discontrolesComboItems ALTER COLUMN Orden INT NOT NULL
--GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1020.05);
GO


