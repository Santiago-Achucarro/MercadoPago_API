using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueConvenioActionEnum
        {            public enum EnumsueConvenioAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueConvenioAction(sueConvenioActionEnum.EnumsueConvenioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueConvenioActionEnum.EnumsueConvenioAction.Guardar: lRetorno = "sueConvenioGuardar"; break;
                case sueConvenioActionEnum.EnumsueConvenioAction.Datos: lRetorno = "sueConvenioDevolverDatos"; break;
                case sueConvenioActionEnum.EnumsueConvenioAction.Eliminar: lRetorno = "sueConvenioEliminar"; break;
            }
            return lRetorno;
        }
    }
}
