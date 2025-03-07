using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 29 de agosto de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impCABATxtActionEnum
        {            public enum EnumimpCABATxtAction
            {
                Datos,Importar
            }
        public static string GetAccionimpCABATxtAction(impCABATxtActionEnum.EnumimpCABATxtAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impCABATxtActionEnum.EnumimpCABATxtAction.Datos: lRetorno = "impCABATxtDevolverDatos"; break;
                case impCABATxtActionEnum.EnumimpCABATxtAction.Importar: lRetorno = "impCABATxtImportar"; break;
            }
            return lRetorno;
        }
    }
}
