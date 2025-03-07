using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkSalidasRIActionEnum
        {            public enum EnumstkSalidasRIAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkSalidasRIAction(stkSalidasRIActionEnum.EnumstkSalidasRIAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkSalidasRIActionEnum.EnumstkSalidasRIAction.Guardar: lRetorno = "stkSalidasRIGuardar"; break;
                case stkSalidasRIActionEnum.EnumstkSalidasRIAction.Datos: lRetorno = "stkSalidasRIDevolverDatos"; break;
                case stkSalidasRIActionEnum.EnumstkSalidasRIAction.Eliminar: lRetorno = "stkSalidasRIEliminar"; break;
            }
            return lRetorno;
        }
    }
}
