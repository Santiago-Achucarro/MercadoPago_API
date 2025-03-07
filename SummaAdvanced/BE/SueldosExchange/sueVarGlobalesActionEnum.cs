using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 9, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVarGlobalesActionEnum
        {            public enum EnumsueVarGlobalesAction
            {
                Guardar,Datos,Eliminar,DescargarWS
            }
        public static string GetAccionsueVarGlobalesAction(sueVarGlobalesActionEnum.EnumsueVarGlobalesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVarGlobalesActionEnum.EnumsueVarGlobalesAction.Guardar: lRetorno = "sueVarGlobalesGuardar"; break;
                case sueVarGlobalesActionEnum.EnumsueVarGlobalesAction.Datos: lRetorno = "sueVarGlobalesDevolverDatos"; break;
                case sueVarGlobalesActionEnum.EnumsueVarGlobalesAction.Eliminar: lRetorno = "sueVarGlobalesEliminar"; break;
                case sueVarGlobalesActionEnum.EnumsueVarGlobalesAction.DescargarWS: lRetorno = "sueVarGlobalesDescargarWS"; break;

            }
            return lRetorno;
        }
    }
}
