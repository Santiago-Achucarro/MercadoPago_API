drop procedure comMovProvAdjuntarXML
go
create procedure comMovProvAdjuntarXML
(
@pcomMovProv bigint,
@pXml text,
@pClaveFiscal varchar(36)
)
as
update comMovProv set XMLFiscal=@pXml, ClaveFiscal=@pClaveFiscal where comMovProv.comMovProv=@pcomMovProv
go