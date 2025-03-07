using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, August 8, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVariableCopiarActionEnum
        {            public enum EnumsueVariableCopiarAction
            {
                Guardar,Datos
            }
        public static string GetAccionsueVariableCopiarAction(sueVariableCopiarActionEnum.EnumsueVariableCopiarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVariableCopiarActionEnum.EnumsueVariableCopiarAction.Guardar: lRetorno = "sueVariableCopiarGuardar"; break;
                case sueVariableCopiarActionEnum.EnumsueVariableCopiarAction.Datos: lRetorno = "sueVariableCopiarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
