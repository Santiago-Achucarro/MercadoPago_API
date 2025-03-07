using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace VentasFEEventos
{
    public class venLibrosrpt
    {

        [Generalidades.QFuncion_Condicion]

        public string NumeroColumnas(VentasReportesCommon.venLibrosDS exch, Command cmd)

        {
            VentasExchange.venLibrosActionExchange exchLib = new VentasExchange.venLibrosActionExchange(VentasExchange.venLibrosActionEnum.EnumvenLibrosAction.Datos);
            exchLib.Libro_Id = exch.Principal[0].Libro_Id;
            exchLib = new VentasExchange.venLibrosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchLib, cmd));

            if (!exchLib.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("El_Libro_No_Tiene_Columnas");

            return Math.Max(exchLib.Param.Columnas.Count, 5).ToString();




        }
    }
}
