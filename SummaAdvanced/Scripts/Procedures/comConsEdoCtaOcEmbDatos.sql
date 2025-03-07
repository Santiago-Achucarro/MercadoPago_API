
--exec comConsEdoCtaOcEmbDatos 5176

drop procedure comConsEdoCtaOcEmbDatos
go

create procedure comConsEdoCtaOcEmbDatos
(@pcomMovProv bigint)
as
select comMovProv , comMovPOC.comOrdenComp,	dbo.Segmento(Segmento_Id,Segmento1C,Segmento2C,Segmento3C,Segmento4C,Segmento1N,Segmento2N,Segmento3N,Segmento4N)as SegmentoSTR from comMovPOC
inner join comOCSegmentos on comOCSegmentos.comOrdenComp=comMovPOC.comOrdenComp
where comMovProv = @pcomMovProv

union
select comMovProv, comOcMovProv.comOrdenComp,	dbo.Segmento(Segmento_Id,Segmento1C,Segmento2C,Segmento3C,Segmento4C,Segmento1N,Segmento2N,Segmento3N,Segmento4N)as SegmentoSTR  from comOcMovProv 
inner join comOCSegmentos on comOCSegmentos.comOrdenComp=comOcMovProv.comOrdenComp
where comMovProv = @pcomMovProv


select comMovProv, comEmbarques,	dbo.Segmento(Segmento_Id,Segmento1C,Segmento2C,Segmento3C,Segmento4C,Segmento1N,Segmento2N,Segmento3N,Segmento4N)as SegmentoSTR  from comMovProvEmb
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=comMovProvEmb.comEmbarques
 where  comMovProv = @pcomMovProv

union
select comMovProv, comEmbarques,	dbo.Segmento(Segmento_Id,Segmento1C,Segmento2C,Segmento3C,Segmento4C,Segmento1N,Segmento2N,Segmento3N,Segmento4N)as SegmentoSTR  from comEmbGastoMovProv 
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=comEmbGastoMovProv.comEmbarques
where  comMovProv = @pcomMovProv
go

