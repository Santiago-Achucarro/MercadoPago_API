using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCondFiscalActionEnum
        {            public enum EnumvenCondFiscalAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCondFiscalAction(venCondFiscalActionEnum.EnumvenCondFiscalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCondFiscalActionEnum.EnumvenCondFiscalAction.Guardar: lRetorno = "venCondFiscalGuardar"; break;
                case venCondFiscalActionEnum.EnumvenCondFiscalAction.Datos: lRetorno = "venCondFiscalDevolverDatos"; break;
                case venCondFiscalActionEnum.EnumvenCondFiscalAction.Eliminar: lRetorno = "venCondFiscalEliminar"; break;
            }
            return lRetorno;
        }
    }
}
