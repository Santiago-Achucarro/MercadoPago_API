using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 29 de agosto de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impArbaTxtActionEnum
        {            public enum EnumimpArbaTxtAction
            {
                Importar, Datos
            }
        public static string GetAccionimpArbaTxtAction(impArbaTxtActionEnum.EnumimpArbaTxtAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impArbaTxtActionEnum.EnumimpArbaTxtAction.Importar: lRetorno = "impArbaTxtImportar"; break;
                case impArbaTxtActionEnum.EnumimpArbaTxtAction.Datos: lRetorno = "impArbaTxtDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
