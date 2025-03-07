using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 21 de octubre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impArbaTxtModifActionEnum
        {            public enum EnumimpArbaTxtModifAction
            {
                Guardar,Datos
            }
        public static string GetAccionimpArbaTxtModifAction(impArbaTxtModifActionEnum.EnumimpArbaTxtModifAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impArbaTxtModifActionEnum.EnumimpArbaTxtModifAction.Guardar: lRetorno = "impArbaTxtModifGuardar"; break;
                case impArbaTxtModifActionEnum.EnumimpArbaTxtModifAction.Datos: lRetorno = "impArbaTxtModifDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
