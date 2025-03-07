using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 3 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClieContactoActionEnum
        {            public enum EnumvenClieContactoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenClieContactoAction(venClieContactoActionEnum.EnumvenClieContactoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClieContactoActionEnum.EnumvenClieContactoAction.Guardar: lRetorno = "venClieContactoGuardar"; break;
                case venClieContactoActionEnum.EnumvenClieContactoAction.Datos: lRetorno = "venClieContactoDevolverDatos"; break;
                case venClieContactoActionEnum.EnumvenClieContactoAction.Eliminar: lRetorno = "venClieContactoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
