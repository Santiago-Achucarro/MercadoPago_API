using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 2 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkRemiPendFactProActionEnum
        {            public enum EnumstkRemiPendFactProAction
            {
                Guardar,Datos,Eliminar, ActuCantPendiente
        }
        public static string GetAccionstkRemiPendFactProAction(stkRemiPendFactProActionEnum.EnumstkRemiPendFactProAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRemiPendFactProActionEnum.EnumstkRemiPendFactProAction.Guardar: lRetorno = "stkRemiPendFactProGuardar"; break;
                case stkRemiPendFactProActionEnum.EnumstkRemiPendFactProAction.Datos: lRetorno = "stkRemiPendFactProDevolverDatos"; break;
                case stkRemiPendFactProActionEnum.EnumstkRemiPendFactProAction.Eliminar: lRetorno = "stkRemiPendFactProEliminar"; break;
                case stkRemiPendFactProActionEnum.EnumstkRemiPendFactProAction.ActuCantPendiente:lRetorno = "stkRemiPendFactProActuCantPendiente"; break;
                    
            }
            return lRetorno;
        }
    }
}
