using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAtributosValorIdentidadActionEnum
        {            public enum EnumgenAtributosValorIdentidadAction
            {
                Guardar
            }
        public static string GetAcciongenAtributosValorIdentidadAction(genAtributosValorIdentidadActionEnum.EnumgenAtributosValorIdentidadAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAtributosValorIdentidadActionEnum.EnumgenAtributosValorIdentidadAction.Guardar: lRetorno = "genAtributosValorIdentidadGuardar"; break;
            }
            return lRetorno;
        }
    }
}
