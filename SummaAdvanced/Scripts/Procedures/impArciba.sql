--impArciba 1, '20220801', '20220930'
--impArciba 1, '20220701', '20220731'
Drop procedure impArciba
Go
  
  
  
Create procedure impArciba  
(  
@pEmpresa_Id int,  
@pFechaDesde datetime,  
@pFechaHasta datetime  
)  
As  
  
  
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta  
--- "a" es el resultado de una subconsulta así la puedo ordenar por fecha.  
Select a.Renglon From (  
SELECT conAsientos.fecha, '1029'+convert(char(10),tesMovimientos.Fecha_Real,103)+'03 0000'+ genAsiSegmentos.Segmento4C+  
  genAsiSegmentos.Segmento2C +RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+  
     +convert(char(10),conAsientos.Fecha,103)+  
  RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(tesRengMoviRetProv.BaseImponible as decimal(15,2)),1))),16)+  
     right(replicate('0',16)+Ltrim(Rtrim(convert(varchar(14),tesRengMoviRetProv.tesMovimientos))),16)+'3'+  
	 RIGHT(Replicate('0',11) +lTrim(rTrim(Cast(Replace(genEntidades.Cuit, '-', '') As varchar(11)))),11) + 
     Isnull(cast(genJurisCoeficientes.Situacion as varchar(1)),' ')+  
	 RIGHT(Replicate('0',11) +lTrim(rTrim(Cast(Replace(comProveedores.ibrutos, '-', '') As varchar(11)))),11) + '1'+ 
     cast(comProveedores.RAZONSOCIAL as char(30))+  
  RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(ISNULL(tesRengMoviRetProv.BaseImponible-(Servicio.Importe+Mercaderia.importe),0) as decimal(15,2)),1))),16) +  -- Otros conceptos Mantis 12869  
  +'0000000000000.00'+  
     --RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(ISNULL(Servicio.Importe,0)+ISNULL(Mercaderia.importe,0) as decimal(15,2)),1))),16) +  
     RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(tesRengMoviRetProv.BaseImponible as decimal(15,2)),1))),16) +  
     RIGHT(REPLICATE('0',1)+ltrim(rtrim(convert(varchar(5),cast(tesRengMoviRetProv.Porcentaje as decimal(4,2)),1))),16) +  
     --RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(ROUND((((ISNULL(Servicio.Importe,0)+ISNULL(Mercaderia.importe,0))*tesRengMoviRetProv.Porcentaje)/100), 2) as decimal(15,2)),1))),16) +  
     --RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(ROUND((((ISNULL(Servicio.Importe,0)+ISNULL(Mercaderia.importe,0))*tesRengMoviRetProv.Porcentaje)/100), 2) as decimal(15,2)),1))),16) +  
     RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(conMovcont.Importe As decimal(15,2)),1))),16) +  
     RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(16),cast(conMovcont.Importe as decimal(15,2)),1))),16) +  
  '           ' Renglon   
     FROM tesRengMovi   
     INNER JOIN tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos  
     INNER JOIN tesidretprov on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id  
  INNER JOIN tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica  
  INNER JOIN conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon  
  INNER JOIN tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon  
  INNER JOIN conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos  
  INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id   
  INNER JOIN comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov  
  INNER JOIN comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades  
  INNER JOIN genEntidades on comProveedores.genEntidades = genEntidades.genEntidades  
  INNER JOIN comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal  
  Left Join (genJurisCoeficientes Inner Join impJurisdicciones on genJurisCoeficientes.Juris_Id = impJurisdicciones.impjurisdicciones And impJurisdicciones.juris_id = '901')  
  On genEntidades.genEntidades = genJurisCoeficientes.genEntidades   
  left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2   
  left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1  
  where conAsientos.fecha between @pFechaDesde and @pFechaHasta  
  and genAsiSegmentos.Empresa_Id = @pEmpresa_Id   
  and comMovprov.TipoMov = 'P'  
  and tesIdRetProv.TipoImpuesto = 1901  
  and conAsientos.Anulado = 0 And conAsientos.Posteado = 1  
Union all  
 -- Facturas y Notas de débitos comunes --  
 SELECT conAsientos.fecha, '2029' +  
 convert(char(10),conAsientos.Fecha, 103) +  
 --RIGHT(replicate('0',2)+lTrim(rTrim(Convert(varchar(2), Cast(ISNULL(venMovimientosFiscal.Comprobante_Id,0) as int),1))),2) + -- Tipo de comprobante Afip --  
 Case When venMovimientos.venTipoMov In ('F', 'I') Then '01' Else '09' End + -- Según documentación 01 Factura 09 Otro comprobante  
 Case When venMovimientos.venTipoMov In ('F', 'I') Then Substring(genAsiSegmentos.Segmento3C, 1, 1) Else ' ' End + -- Letra solo en caso de facturas --  
 '0000'+   
 genAsiSegmentos.Segmento2C + -- Sucursal --  
 RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))), 8) + -- Comprobante --  
 Convert(char(10),conAsientos.Fecha, 103) + -- Otra vez la Fecha --  
 RIGHT(Replicate('0',16)+lTrim(rTrim(Convert(varchar(16), Cast(TotalFactura.Importe As decimal(15,2)),1))),16) + -- Total en pesos --  
 Replicate(' ',16) + '3'+    
 --Substring(genEntidades.Cuit,1,2) + Substring(genEntidades.Cuit,4,8) + Substring(genEntidades.Cuit,13,1) + 
 RIGHT(Replicate('0',11) +lTrim(rTrim(Cast(Replace(genEntidades.Cuit, '-', '') As varchar(11)))),11) + -- Cuit sin guiones --
 Cast(isNull(genJurisCoeficientes.Situacion, ' ') As varchar(1)) + -- Situación en CABA. Si no tiene este dato en la grilla sale mal pero sale el renglón --  
 RIGHT(Replicate('0',11) +  
 lTrim(rTrim(Cast(Replace(venClientes.IBrutos, '-', '') As varchar(11)))),11) + -- IIBB sin guiones --  
 '1'+    
 Cast(venClientes.RazonSocial As char(30)) +  
 -- Ahora Otros conceptos que son todos los impuestos que no son IVA --  
 RIGHT(Replicate('0',16) + lTrim(rTrim(Convert(varchar(16), Cast(TotalFactura.Importe - (isNull(venMovImpuestos.BaseImponibleMonedaNac, 0) + isNull(Iva1.ImporteIva,0)) As decimal(15,2)),1))),16)+    
  --'0000000000000.00'+
-- FM 03/07/2023 13816. En facturas B no se informan ni la BI ni el Iva --
Case genAsiSegmentos.Segmento3C When 'B' Then Replicate('0',16) Else RIGHT(Replicate('0',16)+lTrim(rTrim(Convert(varchar(16), Cast(isNull(Iva1.ImporteIva, 0) as decimal(15,2)),1))),16) End +
Case genAsiSegmentos.Segmento3C When 'B' Then Replicate('0',16) Else RIGHT(Replicate('0',16)+lTrim(rTrim(Convert(varchar(16), Cast(isNull(Iva1.BIPes, 0) as decimal(15,2)),1))),16) End +    
 RIGHT(Replicate('0',1)+lTrim(rTrim(Convert(varchar(5), Cast(venMovImpuestos.Porcentaje as decimal(4,2)),1))),16) +    
 RIGHT(Replicate('0',16)+lTrim(rTrim(Convert(varchar(16), Cast(isNull(conMovCont.Importe,0) as decimal(15,2)),1))),16) +    
 RIGHT(Replicate('0',16)+lTrim(rTrim(Convert(varchar(16), Cast(isNull(conMovCont.Importe,0) as decimal(15,2)),1))),16) +    
 '           ' Renglon    
 FROM venMovimientos    
 Inner Join venMovImpuestos On venMovimientos.venMovimientos = venMovImpuestos.venMovimientos  
 Inner Join venImpuestos on venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos  
 INNER JOIN conMovcont On conMovcont.conAsientos = venMovImpuestos.venMovimientos And conMovcont.Renglon = venMovImpuestos.conRenglon    
 INNER JOIN (Select conAsientos, Sum(Importe) Importe From conMovCont   
    Where Clase = 'CLI' Group by Conasientos) TotalFactura ON TotalFactura.conAsientos = venMovimientos.venMovimientos  
 INNER JOIN conAsientos on venMovimientos.venMovimientos = conAsientos.conAsientos    
 INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id     
 INNER JOIN venClientes on venMovimientos.Cliente_Id = venClientes.genEntidades    
 INNER JOIN genEntidades on venClientes.genEntidades = genEntidades.genEntidades    
 INNER JOIN venCondFiscal on venClientes.CondFisc_Id= venCondFiscal.venCondFiscal    
 Left JOIN (genJurisCoeficientes Inner Join impJurisdicciones On genJurisCoeficientes.Juris_Id = impJurisdicciones.impjurisdicciones And impJurisdicciones.juris_id = '901')   
    On genEntidades.genEntidades = genJurisCoeficientes.genEntidades     
 /*INNER JOIN impRentasCapGralTxt on genEntidades.Cuit = impRentasCapGralTxt.CUIT and     
 impRentasCapGralTxt.Anio = year(conAsientos.Fecha) and     
 impRentasCapGralTxt.Mes = month(conAsientos.Fecha) */    
 Inner Join (Select venMovimpuestos.venMovimientos, isNull(Sum(conMovCont.Importe),0) ImporteIva, isNull(Sum(venMovImpuestos.BaseImponibleMonedaNac), 0) BIPes  
  From venMovImpuestos    
  Inner join venImpuestos on venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos   
  Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto    
  Inner join conMovCont on conMovCont.conAsientos = venmovimpuestos.venMovimientos and   
              conMovCont.Renglon = venMovImpuestos.conRenglon  
  Where  impTipoImpuesto.Referencia01 = 'IVA' Group by venMovimpuestos.venMovimientos ) Iva1 On venMovimientos.venMovimientos = Iva1.venMovimientos    
 --INNER JOIN venMovimientosFiscal On venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos       
 Where conAsientos.fecha between @pFechaDesde and @pFechaHasta    
 and genAsiSegmentos.Empresa_Id = @pEmpresa_Id    
 and genAsiSegmentos.Segmento1C in ('F','D', 'I','B')    
 and venImpuestos.TipoImpuesto = 1901 And venMovImpuestos.Importe > 0    
      
 and conAsientos.Anulado = 0 And conAsientos.Posteado = 1  
  ) a order by a.Fecha  
  
--- "a" es el resultado de una subconsulta así la puedo ordenar por fecha.  
  
-- Notas de Crédito comunes y de crédito --  
SELECT a.Renglon2 FROM (SELECT conAsiRela.Fecha, '2' + -- 2 indica Percepción --  
 + genAsiSegmentos.Segmento2C + -- Sucursal --  
 RIGHT('00000000' + lTrim(rTrim(Convert(varchar(8),genAsiSegmentos.Segmento1N))),8) + -- Comprobante --  
 Convert(char(10),conAsientos.Fecha,103) + -- Fecha --  
 --RIGHT(Replicate('0',16) + lTrim(rTrim(Convert(varchar(16), Cast(isNull(TotalFactura.Importe, 0) as decimal(15,2)),1))),16) + -- Total de la NC --  
 RIGHT(Replicate('0',16) + lTrim(rTrim(Convert(varchar(16), Cast(isNull(Iva1.BIPes, 0) as decimal(15,2)),1))),16) + -- BI de la NC --  
 Replicate(' ',16) +  
  
 --CASE WHEN VenMov.venTipomov = 'F' THEN '01' WHEN VenMov.venTipomov IS NULL THEN '01' ELSE '09' END+   
 '01' + -- Siempre el comprobante relacionado en factura y por eso el 01 --  
  
 --CASE WHEN VenMov.venTipomov = 'F' THEN substring(genAsiSegmentos.Segmento3C,1,1)   
 -- WHEN VenMov.venTipomov IS NULL THEN ' ' ELSE Substring(genAsiSegmentos.Segmento3C,1,1) END +    
 Substring(genAsiSegmentos.Segmento3C, 1, 1) + -- Letra de la NC que es la misma que la de la factura --  
  
 --CASE WHEN VenMov.venTipomov IS NOT NULL THEN   
 -- +'0000'+genasiapli.Segmento2C + RIGHT('00000000' + lTrim(rTrim(Convert(varchar(8),genasiapli.Segmento1N))),8)  
 -- --+RIGHT('000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)   
 -- ELSE '0000000000000000' END +  
 '0000' + FactRelaSeg.Segmento2C + RIGHT('00000000' + lTrim(rTrim(Convert(varchar(8), FactRelaSeg.Segmento1N))),8) + -- Suc y comprobante de la factura relacionada --  
  
 --Substring(genEntidades.Cuit,1,2) + Substring(genEntidades.Cuit,4,8) + Substring(genEntidades.Cuit,13,1) + 
 RIGHT(Replicate('0',11) +lTrim(rTrim(Cast(Replace(genEntidades.Cuit, '-', '') As varchar(11)))),11) + -- Cuit sin guiones del cliente --
 '029' + -- Código de norma --  
   
 --CASE WHEN VenMov.venTipomov IS NOT NULL THEN convert(char(10),conAsi.Fecha,103) ELSE Convert(char(10),conAsientos.Fecha,103) END +  
 Convert(char(10),conAsiRela.Fecha,103) + -- Fecha de la percepción que es la misma que la fecha de la NC --  
  
    RIGHT(Replicate('0',16) + lTrim(rTrim(Convert(varchar(16), cast(isNull(conMovCont.Importe,0) as decimal(15,2)),1))),16)+ -- Monto de la percepción --  
 RIGHT(Replicate('0',1) + lTrim(rTrim(Convert(varchar(5), cast(venMovimpuestos.Porcentaje as decimal(4,2)),1))),16) Renglon2 -- Alícuota de la percepción --  
 --'           ' Renglon2  
FROM venMovimientos  
INNER JOIN venMovImpuestos ON venMovimientos.venMovimientos = venMovImpuestos.venMovimientos  
INNER JOIN venImpuestos ON venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos  
INNER JOIN conMovcont ON conMovcont.conAsientos = venMovimientos.venMovimientos AND conMovcont.Renglon = venMovImpuestos.conRenglon  
INNER JOIN (Select conAsientos, sum(importe) Importe From conMovCont   
	Where Clase='CLI' Group by conAsientos) TotalFactura ON TotalFactura.conAsientos = venMovimientos.venMovimientos   
INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos  
INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id   
INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades  
INNER JOIN genEntidades ON venClientes.genEntidades = genEntidades.genEntidades  
INNER JOIN venCondFiscal ON venClientes.CondFisc_Id= venCondFiscal.venCondFiscal  
Left Join (genJurisCoeficientes Inner Join impJurisdicciones ON genJurisCoeficientes.Juris_Id = impJurisdicciones.impjurisdicciones And impJurisdicciones.Juris_Id='901')  
	ON genEntidades.genEntidades = genJurisCoeficientes.genEntidades   
INNER JOIN (SELECT venMovimpuestos.venMovimientos, ISNULL(SUM(conMovcont.importe),0) ImporteIva, isNull(Sum(venMovImpuestos.BaseImponibleMonedaNac), 0) BIPes
	FROM venMovImpuestos  
	INNER JOIN venImpuestos ON venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos  
	INNER JOIN impTipoImpuesto ON impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto  
	Inner Join conMovcont on conMovCont.conAsientos = venMovImpuestos.venMovimientos and conmovcont.Renglon = venMovImpuestos.conRenglon  
	WHERE  impTipoImpuesto.Referencia01 = 'IVA' GROUP BY venMovimpuestos.venMovimientos) Iva1 ON venMovimientos.venMovimientos = Iva1.venMovimientos  
--INNER JOIN venMovimientosFiscal ON venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos  
Inner Join venMovimientosCFDIR On venMovimientosCFDIR.venMovimientos = venMovimientos.venMovimientos  
Inner Join venMovimientos FactRela On FactRela.venMovimientos = venMovimientosCFDIR.venMovimientosR  
Inner Join genAsiSegmentos FactRelaSeg On FactRelaSeg.Asiento_Id = FactRela.venMovimientos  
Inner Join conAsientos conAsiRela On conAsiRela.conAsientos = FactRela.venMovimientos
WHERE conAsientos.fecha BETWEEN @pFechaDesde and @pFechaHasta  
AND genAsiSegmentos.Empresa_Id = @pEmpresa_Id   
AND genAsiSegmentos.Segmento1C In ('R', 'E')  
AND venImpuestos.TipoImpuesto = 1901 and venMovImpuestos.Importe > 0  
AND conAsientos.Anulado = 0 And conAsientos.Posteado = 1   
   
   
) a ORDER BY a.Fecha