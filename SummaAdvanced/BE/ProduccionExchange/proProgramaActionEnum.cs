using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 1 de abril de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proProgramaActionEnum
        {            public enum EnumproProgramaAction
            {
                Guardar,Datos,AsignarProveed
            }
        public static string GetAccionproProgramaAction(proProgramaActionEnum.EnumproProgramaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proProgramaActionEnum.EnumproProgramaAction.Guardar: lRetorno = "proProgramaGuardar"; break;
                case proProgramaActionEnum.EnumproProgramaAction.Datos: lRetorno = "proProgramaDevolverDatos"; break;
                case proProgramaActionEnum.EnumproProgramaAction.AsignarProveed: lRetorno = "proProgramaAsignarProveed"; break;
            }
            return lRetorno;
        }
    }
}
