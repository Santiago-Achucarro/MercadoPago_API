-- Exec comProvvedoresImportarMails

CREATE PROCEDURE comProvvedoresImportarMails
AS
SET NOCOUNT ON 

--Borro Tabla de contactos
--select * from comProveedoresContacto order by proveed_id, nroContacto
delete from comProveedoresContacto


/************ FACTURAS ******************************************************/
--primero trato solo los que tengan ';' como separador
INSERT INTO comProveedoresContacto (Proveed_Id, NroContacto, Nombre, Telefono, 
											Movil, Interno, EnvioOC, EnvioOP,
											Puesto, Email )
SELECT A.Prov_id,  ROW_NUMBER() OVER(Partition BY A.Prov_id  ORDER BY A.Prov_id ASC) as NroContacto, 
	 case when A.Contacto <> '' then A.Contacto else rTRIM(Split.a.value('.', 'VARCHAR(100)')) end as Nombre, a.Telefono, 
	 '', '', 1, 1, '', rTRIM(Split.a.value('.', 'VARCHAR(100)')) AS EMail
 FROM  
 (
     SELECT genEntidades as Prov_id, Contacto, Telefono, 
         CAST ('<M>' + REPLACE(REPLACE(REPLACE(rTRIM(Email), '>', ''), '<', ''), ';', '</M><M>') + '</M>' AS XML) AS Data  
	 from comProveedores
	 where Email like '%;%'
 ) AS A CROSS APPLY Data.nodes ('/M') AS Split(a)

 -- Ahora trato los que tienen como separador ' o '
INSERT INTO comProveedoresContacto (Proveed_Id, NroContacto, Nombre, Telefono, 
											Movil, Interno, EnvioOC, EnvioOP,
											Puesto, Email )
SELECT A.Prov_id,  ROW_NUMBER() OVER(Partition BY A.Prov_id  ORDER BY A.Prov_id ASC) as NroContacto, 
	 case when A.Contacto <> '' then A.Contacto else rTRIM(Split.a.value('.', 'VARCHAR(100)')) end as Nombre, a.Telefono, 
	 '', '', 1, 1, '', rTRIM(Split.a.value('.', 'VARCHAR(100)')) AS EMail
 FROM  
 (
     SELECT genEntidades as Prov_id, Contacto, Telefono, 
         CAST ('<M>' + REPLACE(REPLACE(REPLACE(rTRIM(Email), '>', ''), '<', ''), ' o ', '</M><M>') + '</M>' AS XML) AS Data  
	 from comProveedores
	 where Email like '% o %'
 ) AS A CROSS APPLY Data.nodes ('/M') AS Split(a)

 

  -- Ahora trato los que tienen como separador '/'
INSERT INTO comProveedoresContacto (Proveed_Id, NroContacto, Nombre, Telefono, 
											Movil, Interno, EnvioOC, EnvioOP,
											Puesto, Email )
SELECT A.Prov_id,  ROW_NUMBER() OVER(Partition BY A.Prov_id  ORDER BY A.Prov_id ASC) as NroContacto, 
	 case when A.Contacto <> '' then A.Contacto else rTRIM(Split.a.value('.', 'VARCHAR(100)')) end as Nombre, a.Telefono, 
	 '', '', 1, 1, '', rTRIM(Split.a.value('.', 'VARCHAR(100)')) AS EMail
 FROM  
 (
     SELECT genEntidades as Prov_id, Contacto, Telefono, 
         CAST ('<M>' + REPLACE(REPLACE(REPLACE(rTRIM(Email), '>', ''), '<', ''), '/', '</M><M>') + '</M>' AS XML) AS Data  
	 from comProveedores
	 where Email like '%/%'
 ) AS A CROSS APPLY Data.nodes ('/M') AS Split(a)


-- Ahora trato los que tienen como separador ' ', pero debo contemplar que no hayan sido tratados ya
INSERT INTO comProveedoresContacto (Proveed_Id, NroContacto, Nombre, Telefono, 
											Movil, Interno, EnvioOC, EnvioOP,
											Puesto, Email )
SELECT A.Prov_id,  ROW_NUMBER() OVER(Partition BY A.Prov_id  ORDER BY A.Prov_id ASC) as NroContacto, 
	 case when A.Contacto <> '' then A.Contacto else rTRIM(Split.a.value('.', 'VARCHAR(100)')) end as Nombre, a.Telefono, 
	 '', '', 1, 1, '', rTRIM(Split.a.value('.', 'VARCHAR(100)')) AS EMail
 FROM  
 (
     SELECT genEntidades as Prov_id, Contacto, Telefono, 
         CAST ('<M>' + REPLACE(REPLACE(REPLACE(rTRIM(Email), '>', ''), '<', ''), ' ', '</M><M>') + '</M>' AS XML) AS Data  
	 from comProveedores
	 where Email like '% %'
	 and not exists (select 1 from comProveedoresContacto where comProveedoresContacto.Proveed_Id = comProveedores.genEntidades) 
 ) AS A CROSS APPLY Data.nodes ('/M') AS Split(a)

 -- Borro los que quedaron sin mail, puede ser, por ejemplo, porque terminaba en ; y no tenia otro mail a continuacion
delete from comProveedoresContacto where rtrim(email) = '' and NroContacto > 1

-- Ahora trato los que tienen un unico mail, contemplar que no hayan sido tratados ya
INSERT INTO comProveedoresContacto (Proveed_Id, NroContacto, Nombre, Telefono, 
											Movil, Interno, EnvioOC, EnvioOP,
											Puesto, Email )
SELECT genEntidades,  ROW_NUMBER() OVER(Partition BY genEntidades  ORDER BY genEntidades ASC) as NroContacto, 
	 case when Contacto <> '' then Contacto else rTRIM(Email) end, Telefono, 
	 '', '', 1, 1, '', rTRIM(Email)
FROM  comProveedores
where ((contacto <> '') OR (email<>'')) 
and not exists (select 1 from comProveedoresContacto where comProveedoresContacto.Proveed_Id = comProveedores.genEntidades) 


 RETURN @@Error 

GO

Exec comProvvedoresImportarMails
Go

DROP PROCEDURE comProvvedoresImportarMails
GO

Insert Into genVersion (Version) Values (1099.25)
Go

