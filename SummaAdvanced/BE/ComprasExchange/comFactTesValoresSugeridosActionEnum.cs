using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 12 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comFactTesValoresSugeridosActionEnum
        {            public enum EnumcomFactTesValoresSugeridosAction
            {
                Datos
            }
        public static string GetAccioncomFactTesValoresSugeridosAction(comFactTesValoresSugeridosActionEnum.EnumcomFactTesValoresSugeridosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comFactTesValoresSugeridosActionEnum.EnumcomFactTesValoresSugeridosAction.Datos: lRetorno = "comFactTesValoresSugeridosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
