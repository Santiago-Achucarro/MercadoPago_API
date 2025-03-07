using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCategCreditoActionEnum
        {            public enum EnumvenCategCreditoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCategCreditoAction(venCategCreditoActionEnum.EnumvenCategCreditoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCategCreditoActionEnum.EnumvenCategCreditoAction.Guardar: lRetorno = "venCategCreditoGuardar"; break;
                case venCategCreditoActionEnum.EnumvenCategCreditoAction.Datos: lRetorno = "venCategCreditoDevolverDatos"; break;
                case venCategCreditoActionEnum.EnumvenCategCreditoAction.Eliminar: lRetorno = "venCategCreditoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
