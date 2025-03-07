INSERT INTO genVersion (Version) Values('063.00')
GO
ALTER Table genCancMov Add AsieDifCambio_Id BigInt
GO

ALTER Table genCancMov Add Constraint fkgenCancMovDC Foreign Key (AsieDifCambio_Id) References conAsientos
GO

