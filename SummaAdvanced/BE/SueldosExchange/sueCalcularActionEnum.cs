using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 10 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueCalcularActionEnum
        {            public enum EnumsueCalcularAction
            {
                Guardar
            }
        public static string GetAccionsueCalcularAction(sueCalcularActionEnum.EnumsueCalcularAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueCalcularActionEnum.EnumsueCalcularAction.Guardar: lRetorno = "sueCalcularGuardar"; break;
            }
            return lRetorno;
        }
    }
}
