using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
namespace GeneralesExchange{
        public static class genMonedasActionEnum
        {            public enum EnumgenMonedasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenMonedasAction(genMonedasActionEnum.EnumgenMonedasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMonedasActionEnum.EnumgenMonedasAction.Guardar: lRetorno = "genMonedasGuardar"; break;
                case genMonedasActionEnum.EnumgenMonedasAction.Datos: lRetorno = "genMonedasDevolverDatos"; break;
                case genMonedasActionEnum.EnumgenMonedasAction.Eliminar: lRetorno = "genMonedasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
