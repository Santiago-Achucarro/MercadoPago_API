using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
public    class comLibrosrpt
    {


        [Generalidades.QFuncion_Condicion]
        public string NumeroColumnas(ComprasReportesCommon.comLibrosDS exch, Command cmd)
        {
            ComprasExchange.comLIbrosActionExchange exchLib = new ComprasExchange.comLIbrosActionExchange(ComprasExchange.comLIbrosActionEnum.EnumcomLIbrosAction.Datos);
            exchLib.Libro_Id = exch.Principal[0].Libro_Id;
            exchLib= new ComprasExchange.comLIbrosActionExchange( Generalidades.QBIInternal.WrapperExecuteActionInternal(exchLib, cmd));

            if (!exchLib.Existe)
             Generalidades.qFunctionalException.GenerarExcepcion("El_Libro_No_Tiene_Columnas");
          
                return Math.Max(exchLib.Param.Columnas.Count,5).ToString();
          


        }

    }
}
