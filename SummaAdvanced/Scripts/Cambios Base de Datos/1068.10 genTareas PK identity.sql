
IF (EXISTS (SELECT 1
			FROM sys.objects o 
			INNER JOIN sys.columns c on o.object_id = c.object_id
			WHERE o.name = 'genTareas' 
			AND c.name = 'genTareas' 
			AND c.is_identity = 0)) 
BEGIN

exec sp_rename   'genTareas.genTareas' , 'genTareas1'

alter table genTareas add genTareas int identity

--ALTER TABLE [dbo].[genTareasProgramadas] DROP CONSTRAINT [FK__genTareas__Tarea__596D1D10]
DECLARE @SQL VARCHAR(MAX)
SET @SQL = (
SELECT 'Alter table genTareasProgramadas drop constraint  '+ sysobjectsC.name
	FROM sysconstraints 
	inner join sysobjects ON 
	sysconstraints.id = sysobjects.id
	INNER JOIN syscolumns ON 
	syscolumns.id = sysobjects.id  and
	syscolumns.Colid = sysconstraints.colid
	inner join sysobjects sysobjectsC on 
	sysobjectsC.id =  sysconstraints.constid
where 
	sysobjects.name = 'genTareasProgramadas' 
	and syscolumns.Name = 'Tarea_Id')
EXEC sp_sqlexec @SQL


SET @SQL = (
SELECT 'Alter table genTareasParametros drop constraint  '+ sysobjectsC.name
	FROM sysconstraints 
	inner join sysobjects ON 
	sysconstraints.id = sysobjects.id
	INNER JOIN syscolumns ON 
	syscolumns.id = sysobjects.id  and
	syscolumns.Colid = sysconstraints.colid
	inner join sysobjects sysobjectsC on 
	sysobjectsC.id =  sysconstraints.constid
where 
	sysobjects.name = 'genTareasParametros' 
	and syscolumns.Name = 'Tarea_Id')
EXEC sp_sqlexec @SQL

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

Insert into genVersion (Version) Values(1068.10)
END
GO
