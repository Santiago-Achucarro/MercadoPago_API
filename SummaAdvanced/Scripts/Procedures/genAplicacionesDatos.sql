Drop Procedure genAplicacionesDatos
Go

Create Procedure genAplicacionesDatos
(
@pAsiento_Id_Ap bigint,
@pCuotaNro_Ap smallint = Null
)
As

Select @pAsiento_Id_Ap Asiento_Id_Ap, IsNull(@pCuotaNro_Ap, 0) CuotaNro_Ap

Select genCancMov.Asiento_Id, genCancMov.CuotaNro, genCancMov.NroAplicacion, genCancMov.FechaAplicacion,
genCancMov.Importe, genCancMov.Importe_Ap , genCancMov.EsAplicOriginal, genCancMov.EsVentaContado
From genCancMov 
inner join conAsientos ON conAsientos.conAsientos =genCancMov.Asiento_Id
Where 
conAsientos.Anulado = 0 AND 
genCancMov.Asiento_Id_Ap = @pAsiento_Id_Ap And
genCancMov.CuotaNro_Ap = IsNull(@pCuotaNro_Ap, genCancMov.CuotaNro_Ap)
union all
Select genCancMov.Asiento_Id_ap, genCancMov.CuotaNro_ap, genCancMov.NroAplicacion, genCancMov.FechaAplicacion,
genCancMov.Importe, genCancMov.Importe_Ap , genCancMov.EsAplicOriginal, genCancMov.EsVentaContado
From genCancMov 
inner join conAsientos ON conAsientos.conAsientos =genCancMov.Asiento_Id_ap
Where 
conAsientos.Anulado = 0 AND 
genCancMov.Asiento_Id = @pAsiento_Id_Ap And
genCancMov.CuotaNro = IsNull(@pCuotaNro_Ap, genCancMov.CuotaNro)

Go

