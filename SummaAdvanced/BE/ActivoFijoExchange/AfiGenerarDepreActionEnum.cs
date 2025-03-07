using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 28 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class AfiGenerarDepreActionEnum
        {            public enum EnumAfiGenerarDepreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionAfiGenerarDepreAction(AfiGenerarDepreActionEnum.EnumAfiGenerarDepreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case AfiGenerarDepreActionEnum.EnumAfiGenerarDepreAction.Guardar: lRetorno = "AfiGenerarDepreGuardar"; break;
                case AfiGenerarDepreActionEnum.EnumAfiGenerarDepreAction.Datos: lRetorno = "AfiGenerarDepreDevolverDatos"; break;
                case AfiGenerarDepreActionEnum.EnumAfiGenerarDepreAction.Eliminar: lRetorno = "AfiGenerarDepreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
