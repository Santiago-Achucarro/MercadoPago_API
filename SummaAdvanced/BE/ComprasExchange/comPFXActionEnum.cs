using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 21 de diciembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comPFXActionEnum
        {            public enum EnumcomPFXAction
            {
                Guardar,Datos
            }
        public static string GetAccioncomPFXAction(comPFXActionEnum.EnumcomPFXAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comPFXActionEnum.EnumcomPFXAction.Guardar: lRetorno = "comPFXGuardar"; break;
                case comPFXActionEnum.EnumcomPFXAction.Datos: lRetorno = "comPFXDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
