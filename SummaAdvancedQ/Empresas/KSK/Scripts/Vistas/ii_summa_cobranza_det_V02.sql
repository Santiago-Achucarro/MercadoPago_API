alter VIEW [dbo].[ii_summa_cobranza_det_V02] as    
SELECT A.tesMovimientos    
      ,a.[Comprobante] 
	  , isnull (f.Segmento,'') as DocumentoAplica
	  ,isnull (f.Asiento_Id,'')  as VenMOvimientos  --aquí lo dejo como char para dejar un ´vacío cuando no tiene movimiento
	  ,ISNULL (j.Importe,0) as ImporteFactura
      ,a.[conRenglon]    
      ,A.[Cartera_Id]    
 --  , e.TipoCartera
   ,isnull ( h.TipoTarjeta,'') as TipoTarjeta    
   , e.Descripcion as DescripcionTarjeta
   ,isnull (i.Banco_Id,'') as BancoID
   ,isnull(i.Descripcion,'') as DescripcionBanco 
   ,A.ImporteMonedaOriginal
   ,A.Cambio   
      ,A.[Importe]    
     ,  A.Cartera_Id+SUBSTRING(COMPROBANTE,3,5) CAJA    
--  , e.Centro1_Id CardBrand  
  , isnull (t3.Cuotas,'') as Cuotas  
  , isnull (t3.Cupon,'') as Cupon  
  , isnull (t3.Lote,'') as Lote  
  FROM [SummaAdv].[dbo].[vtesRengmovi] A LEFT JOIN tesIdentifica B ON A.Cartera_Id = B.Cartera_Id    
 -- LEFT JOIN tesIdTarjetas3 C ON C.Cartera_Id = B.tesIdentifica    
  --LEFT JOIN tesIdTarjetasTipo D ON C.TipoTarjeta = D.tesIdTarjetasTipo    
  left join tesIdentifica e on e.Cartera_Id = a.Cartera_Id   
  left join  tesIdTarjetas3 g on g.Cartera_Id = e.tesidentifica 
  left join tesIDtarjetasTipo h on h.tesIdTarjetasTipo = g.TipoTarjeta
  left join tesBancos i on i.tesBancos = g.Banco_Id
left join tesT3Link t on t.tesMovimientos = a.tesMovimientos and t.conRenglon = a.conRenglon 
LEFT join testarjetas3 t3 on t.tesTarjetas3 = t3.tesTarjetas3
left join vgenCancMov f on f.Asiento_Id_Ap = A.tesMovimientos 
left join venMovimientos j on j.venMovimientos =  f.Asiento_Id
  WHERE A.Cartera_Id not in ('cli','RED')    
  AND A.Importe<>0  
 
go

select top 3 * from venMovimientos where venMovimientos = 64074
select * from test3promociones
select top 10 * from tesIdentifica
select * from vtesmovimientos
select * from tesidentifica where Cartera_Id = '10'
select * from tesIdTarjetas3
select * from tesBancos
select * from tesIdBancoPropio
select * from tesIDtarjetasTipo
select * from testarjetas3 order by tesTarjetas3 desc
select * from tesIdTarjetas3   --- aquí banco y TipoTarjeta
select * from tesTiposId
select top 3  * from tesT3Link
select a.* from [vtesRengmovi] a where Cartera_Id = 'red'

 WHERE A.Cartera_Id <>'cli'  

 
 select * from [dbo].[tesMovimientos]
 select * from [dbo].[tesRengMovi]
 select * from tesFFCobClientes

 select top 5 * from [dbo].[tesT3Promociones]
 select top 5 * from tesTarjetasPromociones


 select top 10 * from venMovimientos
 select top 10 * from tesmovimientos

 select * from ve

 SELECT object_id as ID
    , name as Nombre
    , create_date as FechaCreacion
    , modify_date as FechaModificacion
FROM sys.objects
WHERE name LIKE '%canc%'

select * from vgenCancMov

select * from[ii_summa_cobranza_det_V02]
/************************************************************************************/
create procedure _Angel0 
@a int
as
begin
if @a >= 5 begin select @a end
else select 'es menor'
end 
go

exec _Angel0 -28
/***************************************************************************************/

[dbo].[AL_FE_MTXCA_Items_20240428]

select TipoComprobanteAfip, * from AL_FE_DocumentProcess where documenttype ='ncstk' order by DocumentNumber desc
/*
1 = FA
3 = NCA
6 = FB
8 = NCB
*/
alter procedure _AL_FE_MTXCA_Items_V010  
@venMovimientos BIGINT
as
begin
if (select TipoComprobanteAfip from AL_FE_DocumentProcess where DocumentNumber = @venMovimientos) in (1,3) begin select 'documento A' end
else if (select TipoComprobanteAfip from AL_FE_DocumentProcess where DocumentNumber = @venMovimientos) in (6,8) begin select 'documento B' end
else select '????'
end 
go

alter procedure _AL_FE_MTXCA_Items_V010  
@venMovimientos BIGINT
as
begin
if OBJECT_ID ( 'tempdb..#AL_FE_MTXCA_Detalle', 'P' ) IS NOT NULL 
drop table #AL_FE_MTXCA_Detalle
create table #AL_FE_MTXCA_Detalle (importeTotal numeric (19,8), importeNoGravado numeric(19,8), importeGravado numeric(19,8), importeExcento numeric(19,8), importeIVA numeric(19,8), importeOtrosTributos numeric(19,8));
insert #AL_FE_MTXCA_Detalle
SELECT     
 convert(NUMERIC(19,2), v.Importe) AS importeTotal    
 ,convert(numeric(19,2), 0) AS importeNoGravado    
 ,convert(numeric(19,2),v.SubTotalBonif) AS importeGravado     
 ,convert(numeric(19,2), 0) AS importeExento    
 ,convert(numeric(19,2), v.Importe-v.SubTotalBonif   ) AS importeIVA    
 ,convert(numeric(19,2),isnull((    
  SELECT Importe    
  FROM vvenMovImpuestos i    
  WHERE i.venMovimientos = @venMovimientos AND Impuesto_Id LIKE 'PI%'    
 ),0)) AS importeOtrosTributos       
FROM vvenClientes A    
 INNER JOIN vVenMovimientos B ON A.Cliente_Id = B.Cliente_Id    
 INNER JOIN conAsientos c ON B.venMovimientos = c.conAsientos    
 INNER JOIN vgenAsiSegmentos G ON G.Asiento_Id = B.venMovimientos    
 INNER JOIN genTiposCompAfip E ON E.Segmento1C = G.Segmento1C AND E.Segmento4C = G.Segmento3C    
 inner join venMovimientos v on v.venMovimientos = b.venMovimientos
WHERE B.venMovimientos = @venMovimientos 


alter procedure _AL_FE_MTXCA_Items_V011  
@venMovimientos BIGINT
as
begin
if (select TipoComprobanteAfip from AL_FE_DocumentProcess where DocumentNumber = @venMovimientos) is null begin select 'no existe docuemnto' end
else if (select TipoComprobanteAfip from AL_FE_DocumentProcess where DocumentNumber = @venMovimientos) not in (1,3,6,8) begin select 'ipodocuemnto desconocido' end
else if (select TipoComprobanteAfip from AL_FE_DocumentProcess where DocumentNumber = @venMovimientos) in (1,3) begin exec _AL_FE_MTXCA_ItemsA_V011 @venMovimientos end
else if (select TipoComprobanteAfip from AL_FE_DocumentProcess where DocumentNumber = @venMovimientos) in (6,8) begin exec _AL_FE_MTXCA_ItemsB_V011 @venMovimientos end
else select '????' end


create procedure _AL_FE_MTXCA_ItemsA_V011 
@venMovimientos BIGINT
AS    
SELECT 1 unidadesMtx    
 ,'7792034113667' as codigoMtx    
 ,A.Producto_Id as codigo    
 ,b.Descripcion as descripcion    
 , case    WHEN a.CantFacturada < 0 THEN convert(numeric(19,6), 0)    
 else convert(numeric(19,6), a.CantFacturada)   
 END as cantidad    
,  CASE    WHEN a.CantFacturada < 0 THEN cast(99 as smallint)    
    ELSE cast(7 as smallint)    
 END as codigoUnidadMedida    
  
 ---preciounitario en A sin iva y en B con iva    
, convert(numeric(19,6)  
, case  WHEN a.CantFacturada < 0 THEN 0 --descuentos no debe informar precio unitario.  
 else case substring(SegVentas,4,1)    
  when 'A' then PrecioVenta    
 -- else Round(abs(precioSubTotalFormImpuestoB) / CantFacturada,2) -- Editado Comentado 20240225 Angel Celaya
 -- else Round(abs(precioSubTotalFormImpuestoB) / CantFacturada,2)  -- Editado Agregado 20240225 Angel Celaya 
      else Round(abs(PrecioVenta * 1.21) ,2)   --- Agregado 20240430 Angel Celaya  
 end  
end) as precioUnitario    
, 0.0 as importeBonificacion ---esta neteado en PrecioVenta o en precioSubTotalFormImpuestoB    
, cast(5 as smallint) codigoCondicionIVA    
, convert(numeric(19,2),   
 case substring(SegVentas,4,1)    
  when 'A' then case when a.CantFacturada < 0 then ((PrecioForm * a.CantFacturada )/1.21*0.21)  
   else   (precioSubTotalFormImpuestoB-PrecioVenta*CantFacturada) -- / CantFacturada se elimina la cantidad facturada proque el iva debe ser el total    
  end  
  else 0.0     
 end) as importeIVA    
 
-- ,  ( Round(convert (numeric(19,2), case when a.CantFacturada < 0 then PrecioForm * a.CantFacturada else SubTotalFormImpuesto end) ,2))as importeItem     -- Editado Comentado 20240225 Angel Celaya
--,  ( Round(convert (numeric(19,2), case when a.CantFacturada < 0 then PrecioVenta * a.CantFacturada else precioSubTotalFormImpuestoB end) ,2))as importeItem     -- Editado Agregado 20240225 Angel Celaya
--,( Round(convert (numeric(19,2), precioSubTotalFormImpuestoB) ,2))as importeItem     -- Editado Agregado 20240228 Angel Celaya
--,  ( Round(convert (numeric(19,2), case when a.CantFacturada < 0 then SubTotalFormImpuesto  else precioSubTotalFormImpuestoB end) ,2))as importeItem     -- Editado comentado 20240225 Angel Celaya
,  ( Round(convert (numeric(19,2), case when a.CantFacturada < 0 then PrecioVenta * 1.21 * a.CantFacturada else PrecioVenta * 1.21 * a.CantFacturada end) ,2))as importeItem  --- Agregado 20240430 Angel Celaya
/* Modificación 20230815 modifico el cálculo del importe del item para pasar a afip     
 ,convert(numeric(19,2), subtotalFormImpuesto / CantFacturada) as importeItem    
*/    
FROM vvenMovConStockCrKSK a    
INNER JOIN stkProductos b ON a.Producto_Id = b.Producto_Id    
WHERE a.venMovimientos = @venMovimientos 
GO



select * from #AL_FE_MTXCA_Detalle
go


exec _AL_FE_MTXCA_Items_V010 61801
exec [dbo].[AL_FE_MTXCA_IVA] 61801
exec [dbo].[AL_FE_MTXCA_Detalle] 61801



select TipoComprobanteAfip, * from AL_FE_DocumentProcess where DocumentNumber = 54545


declare @importeTotal numeric (19,8), @importeNoGravado numeric(19,8), @importeGravado numeric(19,8)
select @importeTotal = convert(NUMERIC(19,2), v.Importe)
 ,@importeNoGravado = convert(numeric(19,2), 0)
 ,@importeGravado = convert(numeric(19,2),v.SubTotalBonif)
 FROM vvenClientes A    
 INNER JOIN vVenMovimientos B ON A.Cliente_Id = B.Cliente_Id    
 INNER JOIN conAsientos c ON B.venMovimientos = c.conAsientos    
 INNER JOIN vgenAsiSegmentos G ON G.Asiento_Id = B.venMovimientos    
 INNER JOIN genTiposCompAfip E ON E.Segmento1C = G.Segmento1C AND E.Segmento4C = G.Segmento3C    
 inner join venMovimientos v on v.venMovimientos = b.venMovimientos
WHERE B.venMovimientos = 61801 

select @importeTotal, @importeNoGravado, @importeGravado