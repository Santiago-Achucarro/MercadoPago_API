using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 30 de abril de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLPTablaActionEnum
        {            public enum EnumvenLPTablaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenLPTablaAction(venLPTablaActionEnum.EnumvenLPTablaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLPTablaActionEnum.EnumvenLPTablaAction.Guardar: lRetorno = "venLPTablaGuardar"; break;
                case venLPTablaActionEnum.EnumvenLPTablaAction.Datos: lRetorno = "venLPTablaDevolverDatos"; break;
                case venLPTablaActionEnum.EnumvenLPTablaAction.Eliminar: lRetorno = "venLPTablaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
