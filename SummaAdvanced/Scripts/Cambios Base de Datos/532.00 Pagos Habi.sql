alter table suepagosHabi alter column FechaHabilitacion DateTime null
GO

alter table suePagosHabiPorEmpleado  alter column FechaHabilitacion DateTime null
GO

INSERT INTO genVersion (Version) Values(532.00)
GO