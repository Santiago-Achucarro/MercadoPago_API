Begin tran
Select genCancMov.* Into __FMgenCancMov
From genCancMov
Inner Join venMovimientos On venMovimientos.venMovimientos = genCancMov.Asiento_Id
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Inner Join venTipoMov On venTipoMov.venTipoMov = venSubTipoMov.venTipoMov
Where venTipoMov.Signo <> 1

Delete From genCancMov From 
(Select genCancMov.*
From genCancMov
Inner Join venMovimientos On venMovimientos.venMovimientos = genCancMov.Asiento_Id
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Inner Join venTipoMov On venTipoMov.venTipoMov = venSubTipoMov.venTipoMov
Where venTipoMov.Signo <> 1) a Where genCancMov.Asiento_Id = a.Asiento_Id And genCancMov.CuotaNro = a.CuotaNro And
genCancMov.Asiento_Id_Ap = a.Asiento_Id_Ap And genCancMov.CuotaNro_Ap = a.CuotaNro_Ap And genCancMov.NroAplicacion = a.NroAplicacion

Insert Into genCancMov (Asiento_Id, CuotaNro, Asiento_Id_Ap, CuotaNro_Ap, NroAplicacion, Usuario_Id, FechaAplicacion, Importe, Importe_Ap, AsientoApli_Id, Importacion)
Select Asiento_Id_Ap, CuotaNro_Ap, Asiento_Id, CuotaNro, NroAplicacion, Usuario_Id, FechaAplicacion, Importe, Importe_Ap, AsientoApli_Id, Importacion From __FMgenCancMov 

Drop table __FMgenCancMov




Select genCancMov.* Into __FMgenCancMov
From genCancMov
Inner Join comMovProv On comMovProv.comMovProv = genCancMov.Asiento_Id
Inner Join comMovTipos On comMovTipos.TipoMov = comMovProv.TipoMov
Where comMovTipos.Signo <> 1

Delete From genCancMov From 
(Select genCancMov.*
From genCancMov
Inner Join comMovProv On comMovProv.comMovProv = genCancMov.Asiento_Id
Inner Join comMovTipos On comMovTipos.TipoMov = comMovProv.TipoMov
Where comMovTipos.Signo <> 1) a Where genCancMov.Asiento_Id = a.Asiento_Id And genCancMov.CuotaNro = a.CuotaNro And
genCancMov.Asiento_Id_Ap = a.Asiento_Id_Ap And genCancMov.CuotaNro_Ap = a.CuotaNro_Ap And genCancMov.NroAplicacion = a.NroAplicacion

Insert Into genCancMov (Asiento_Id, CuotaNro, Asiento_Id_Ap, CuotaNro_Ap, NroAplicacion, Usuario_Id, FechaAplicacion, Importe, Importe_Ap, AsientoApli_Id, Importacion)
Select Asiento_Id_Ap, CuotaNro_Ap, Asiento_Id, CuotaNro, NroAplicacion, Usuario_Id, FechaAplicacion, Importe, Importe_Ap, AsientoApli_Id, Importacion From __FMgenCancMov 

Drop table __FMgenCancMov

Insert Into genVersion (Version) Values (63.10)

Commit

