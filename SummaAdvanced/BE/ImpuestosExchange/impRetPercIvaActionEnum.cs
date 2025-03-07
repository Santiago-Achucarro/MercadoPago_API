using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de marzo de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impRetPercIvaActionEnum
        {            public enum EnumimpRetPercIvaAction
            {
                Guardar
            }
        public static string GetAccionimpRetPercIvaAction(impRetPercIvaActionEnum.EnumimpRetPercIvaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impRetPercIvaActionEnum.EnumimpRetPercIvaAction.Guardar: lRetorno = "impRetPercIvaGuardar"; break;
            }
            return lRetorno;
        }
    }
}
