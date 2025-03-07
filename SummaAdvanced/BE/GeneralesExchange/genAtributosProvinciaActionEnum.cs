using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 21 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAtributosProvinciaActionEnum
        {            public enum EnumgenAtributosProvinciaAction
            {
                Datos
            }
        public static string GetAcciongenAtributosProvinciaAction(genAtributosProvinciaActionEnum.EnumgenAtributosProvinciaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAtributosProvinciaActionEnum.EnumgenAtributosProvinciaAction.Datos: lRetorno = "genAtributosProvinciaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
