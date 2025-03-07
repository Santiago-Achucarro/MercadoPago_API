drop procedure genSaldoAnticipo
go
create procedure genSaldoAnticipo
(
@pAsiento_Id bigint
)
as
select @pAsiento_Id as Asiento_Id,Cuenta_Id,Sum(importe) AS Importe
FROM (
select conCuentas.Cuenta_Id,conMovCont.Importe  * (-2*conMovCont.TipoMov+3) AS Importe from genCancMov inner JOIN conAsientos ON
genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
conAsientos.Anulado = 0 
inner join conMovCont on
conMovCont.conAsientos = conAsientos.conAsientos and 
(conMovCont.Clase in( 'ANTCL' , 'ANTPR'))
inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
where Asiento_Id_ap = @pAsiento_Id
union all

select conCuentas.Cuenta_Id,conMovCont.Importe  * (-2*conMovCont.TipoMov+3) AS Importe from genCancMov inner JOIN conAsientos ON
genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
conAsientos.Anulado = 0 
inner join conMovCont on
conMovCont.conAsientos = conAsientos.conAsientos and 
(conMovCont.Clase in( 'ANTCL' , 'ANTPR'))
inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
where Asiento_Id = @pAsiento_Id

UNION ALL 

select conCuentas.Cuenta_Id,conMovCont.Importe  * (-2*conMovCont.TipoMov+3) from genCancMov inner JOIN conAsientos ON
genCancMov.AsientoApli_Id = conAsientos.conAsientos and 
conAsientos.Anulado = 0 
inner join conMovCont on
conMovCont.conAsientos = conAsientos.conAsientos and 
(conMovCont.Clase in( 'ANTCL' , 'ANTPR'))
inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
where Asiento_Id_Ap = @pAsiento_Id
union all

select conCuentas.Cuenta_Id,conMovCont.Importe  * (-2*conMovCont.TipoMov+3) from genCancMov inner JOIN conAsientos ON
genCancMov.AsientoApli_Id = conAsientos.conAsientos and 
conAsientos.Anulado = 0 
inner join conMovCont on
conMovCont.conAsientos = conAsientos.conAsientos and 
(conMovCont.Clase in( 'ANTCL' , 'ANTPR'))
inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
where Asiento_Id = @pAsiento_Id

)
 AS xxx
group by Cuenta_Id
having sum(importe)!=0
go