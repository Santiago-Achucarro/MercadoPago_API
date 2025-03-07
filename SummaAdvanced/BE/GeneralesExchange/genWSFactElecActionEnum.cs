using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 30 de mayo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genWSFactElecActionEnum
        {            public enum EnumgenWSFactElecAction
            {
                Datos
            }
        public static string GetAcciongenWSFactElecAction(genWSFactElecActionEnum.EnumgenWSFactElecAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genWSFactElecActionEnum.EnumgenWSFactElecAction.Datos: lRetorno = "genWSFactElecDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
