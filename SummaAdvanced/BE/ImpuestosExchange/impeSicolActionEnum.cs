using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 22 de marzo de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impeSicolActionEnum
        {            public enum EnumimpeSicolAction
            {
                Guardar
            }
        public static string GetAccionimpeSicolAction(impeSicolActionEnum.EnumimpeSicolAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impeSicolActionEnum.EnumimpeSicolAction.Guardar: lRetorno = "impeSicolGuardar"; break;
            }
            return lRetorno;
        }
    }
}
