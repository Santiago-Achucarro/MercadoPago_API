using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de enero de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAlertasActionEnum
        {            public enum EnumgenAlertasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenAlertasAction(genAlertasActionEnum.EnumgenAlertasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAlertasActionEnum.EnumgenAlertasAction.Guardar: lRetorno = "genAlertasGuardar"; break;
                case genAlertasActionEnum.EnumgenAlertasAction.Datos: lRetorno = "genAlertasDevolverDatos"; break;
                case genAlertasActionEnum.EnumgenAlertasAction.Eliminar: lRetorno = "genAlertasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
