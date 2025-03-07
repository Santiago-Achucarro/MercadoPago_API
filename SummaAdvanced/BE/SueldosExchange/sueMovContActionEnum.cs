using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 11 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueMovContActionEnum
        {            public enum EnumsueMovContAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueMovContAction(sueMovContActionEnum.EnumsueMovContAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueMovContActionEnum.EnumsueMovContAction.Guardar: lRetorno = "sueMovContGuardar"; break;
                case sueMovContActionEnum.EnumsueMovContAction.Datos: lRetorno = "sueMovContDevolverDatos"; break;
                case sueMovContActionEnum.EnumsueMovContAction.Eliminar: lRetorno = "sueMovContEliminar"; break;
            }
            return lRetorno;
        }
    }
}
