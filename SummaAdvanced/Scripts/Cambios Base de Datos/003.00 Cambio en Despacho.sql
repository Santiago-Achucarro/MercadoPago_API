IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 3.0)
begin
INSERT INTO genVersion (Version) Values(3.0)
GO

Alter table comDespachos add Cambio Numeric(18,4) 
Alter table comDespachos add FechaModificacion DateTime
Alter table comDespachos add Moneda_Id int
GO

update comDespachos SET Cambio = xxx.CambioCompra
from (SELECT TOP 1 genTipoCambio.Fecha, genTipoCambio.CambioCompra
	from genTipoCambio inner join genMonedas on
	genTipoCambio.Moneda_Id = genMonedas.genMonedas 
	Where
		genMonedas.Moneda_Id = 'DOL'
		order by 1 Desc
		) AS XXX
Where
	xxx.Fecha <= comDespachos.Fecha

GO

Alter table comDespachos Alter Column Cambio Numeric(18,4)  NOT NULL
GO

Update comDespachos SET Usuario_Id = 1
Update comDespachos SET FechaModificacion = dbo.FechaActual()
Update comDespachos set Moneda_Id = dbo.FuncFKgenMonedas('DOL')
--select * from comDespachos
Alter table comDespachos Alter Column FechaModificacion DATETIME NOT NULL
Alter table comDespachos Alter Column Moneda_Id INT NOT NULL
go


Alter table comDespachos add Foreign KEY (Moneda_Id) References genMonedas
GO

INSERT INTO comEmbEstado(Estado_Id, Descripcion) Values('P','Pendiente')
INSERT INTO comEmbEstado(Estado_Id, Descripcion) Values('C','Cerrado')
end
GO






