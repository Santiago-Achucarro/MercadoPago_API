/*
exec sp_rename   'genTareas.genTareas' , 'genTareas1'

alter table genTareas add genTareas int identity

ALTER TABLE [dbo].[genTareasProgramadas] DROP CONSTRAINT [FK__genTareas__Tarea__596D1D10]



ALTER TABLE [dbo].[genTareas] DROP CONSTRAINT [XPKgenTareas] WITH ( ONLINE = OFF )


ALTER TABLE [dbo].[genTareas] ADD  CONSTRAINT [XPKgenTareas] PRIMARY KEY CLUSTERED 
(
	[genTareas] ASC
)



ALTER TABLE [dbo].[genTareasProgramadas]  WITH CHECK ADD FOREIGN KEY([Tarea_Id])
REFERENCES [dbo].[genTareas] ([genTareas])



ALTER TABLE [dbo].[genTareasParametros]  WITH CHECK ADD FOREIGN KEY([Tarea_Id])
REFERENCES [dbo].[genTareas] ([genTareas])



alter table genTareas drop column genTareas1 

*/


insert into genTareas (Tarea_Id, Descripcion) values  ( 'SALDOVENC', 'Envia Correos a Clientes Con Saldos Vencidos')
insert into genTareas (Tarea_Id, Descripcion) values  ( 'RESPALDOS', 'Crea Respaldos de La Base de Datos')
insert into genTareasParametros (Tarea_Id, Parametro, Descripcion, Obligatorio) values (dbo.FuncFKgenTareas('Respaldos'), 'UbicacionRespaldos', 'Carpeta Donde se Guardaran los Respaldos', 1)
GO

insert into genVersion (version) values (1028.02)
GO