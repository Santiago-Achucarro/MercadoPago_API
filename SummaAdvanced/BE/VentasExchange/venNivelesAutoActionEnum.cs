using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venNivelesAutoActionEnum
        {            public enum EnumvenNivelesAutoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenNivelesAutoAction(venNivelesAutoActionEnum.EnumvenNivelesAutoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venNivelesAutoActionEnum.EnumvenNivelesAutoAction.Guardar: lRetorno = "venNivelesAutoGuardar"; break;
                case venNivelesAutoActionEnum.EnumvenNivelesAutoAction.Datos: lRetorno = "venNivelesAutoDevolverDatos"; break;
                case venNivelesAutoActionEnum.EnumvenNivelesAutoAction.Eliminar: lRetorno = "venNivelesAutoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
