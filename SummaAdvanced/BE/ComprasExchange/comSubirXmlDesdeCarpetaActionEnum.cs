using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 9 de mayo de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comSubirXmlDesdeCarpetaActionEnum
        {            public enum EnumcomSubirXmlDesdeCarpetaAction
            {
                Guardar
            }
        public static string GetAccioncomSubirXmlDesdeCarpetaAction(comSubirXmlDesdeCarpetaActionEnum.EnumcomSubirXmlDesdeCarpetaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comSubirXmlDesdeCarpetaActionEnum.EnumcomSubirXmlDesdeCarpetaAction.Guardar: lRetorno = "comSubirXmlDesdeCarpetaGuardar"; break;
            }
            return lRetorno;
        }
    }
}
