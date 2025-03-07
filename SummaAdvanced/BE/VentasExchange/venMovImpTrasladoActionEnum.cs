using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 23 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovImpTrasladoActionEnum
        {            public enum EnumvenMovImpTrasladoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovImpTrasladoAction(venMovImpTrasladoActionEnum.EnumvenMovImpTrasladoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovImpTrasladoActionEnum.EnumvenMovImpTrasladoAction.Guardar: lRetorno = "venMovImpTrasladoGuardar"; break;
                case venMovImpTrasladoActionEnum.EnumvenMovImpTrasladoAction.Datos: lRetorno = "venMovImpTrasladoDevolverDatos"; break;
                case venMovImpTrasladoActionEnum.EnumvenMovImpTrasladoAction.Eliminar: lRetorno = "venMovImpTrasladoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
