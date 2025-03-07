using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 30 de abril de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLPTabCuerpoActionEnum
        {            public enum EnumvenLPTabCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenLPTabCuerpoAction(venLPTabCuerpoActionEnum.EnumvenLPTabCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLPTabCuerpoActionEnum.EnumvenLPTabCuerpoAction.Guardar: lRetorno = "venLPTabCuerpoGuardar"; break;
                case venLPTabCuerpoActionEnum.EnumvenLPTabCuerpoAction.Datos: lRetorno = "venLPTabCuerpoDevolverDatos"; break;
                case venLPTabCuerpoActionEnum.EnumvenLPTabCuerpoAction.Eliminar: lRetorno = "venLPTabCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
