using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 4 de marzo de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impPadronTxtActionEnum
        {            public enum EnumimpPadronTxtAction
            {
                Datos,Importar,ImportarPadron
            }
        public static string GetAccionimpPadronTxtAction(impPadronTxtActionEnum.EnumimpPadronTxtAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impPadronTxtActionEnum.EnumimpPadronTxtAction.Datos: lRetorno = "impPadronTxtDevolverDatos"; break;
                case impPadronTxtActionEnum.EnumimpPadronTxtAction.Importar: lRetorno = "impPadronTxtImportar"; break;
                case impPadronTxtActionEnum.EnumimpPadronTxtAction.ImportarPadron: lRetorno = "impPadronTxtImportarPadron"; break;
            }
            return lRetorno;
        }
    }
}
