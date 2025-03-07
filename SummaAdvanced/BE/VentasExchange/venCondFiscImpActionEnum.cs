using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCondFiscImpActionEnum
        {            public enum EnumvenCondFiscImpAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCondFiscImpAction(venCondFiscImpActionEnum.EnumvenCondFiscImpAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCondFiscImpActionEnum.EnumvenCondFiscImpAction.Guardar: lRetorno = "venCondFiscImpGuardar"; break;
                case venCondFiscImpActionEnum.EnumvenCondFiscImpAction.Datos: lRetorno = "venCondFiscImpDevolverDatos"; break;
                case venCondFiscImpActionEnum.EnumvenCondFiscImpAction.Eliminar: lRetorno = "venCondFiscImpEliminar"; break;
            }
            return lRetorno;
        }
    }
}
