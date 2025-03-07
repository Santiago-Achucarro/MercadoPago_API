using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 26 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class AfiCentrosActionEnum
        {            public enum EnumAfiCentrosAction
            {
                Guardar,Datos,Eliminar
        }
        public static string GetAccionAfiCentrosAction(AfiCentrosActionEnum.EnumAfiCentrosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case AfiCentrosActionEnum.EnumAfiCentrosAction.Guardar: lRetorno = "AfiCentrosGuardar"; break;
                case AfiCentrosActionEnum.EnumAfiCentrosAction.Datos: lRetorno = "AfiCentrosDevolverDatos"; break;
                case AfiCentrosActionEnum.EnumAfiCentrosAction.Eliminar: lRetorno = "AfiCentrosEliminar"; break;
                
            }
            return lRetorno;
        }
    }
}
