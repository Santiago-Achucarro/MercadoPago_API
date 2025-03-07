using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 3 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosCFDIRActionEnum
        {            public enum EnumvenMovimientosCFDIRAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionvenMovimientosCFDIRAction(venMovimientosCFDIRActionEnum.EnumvenMovimientosCFDIRAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosCFDIRActionEnum.EnumvenMovimientosCFDIRAction.Guardar: lRetorno = "venMovimientosCFDIRGuardar"; break;
                case venMovimientosCFDIRActionEnum.EnumvenMovimientosCFDIRAction.Eliminar: lRetorno = "venMovimientosCFDIREliminar"; break;
            }
            return lRetorno;
        }
    }
}
