using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 14 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProvedoresXlsActionEnum
        {            public enum EnumcomProvedoresXlsAction
            {
                Guardar
            }
        public static string GetAccioncomProvedoresXlsAction(comProvedoresXlsActionEnum.EnumcomProvedoresXlsAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProvedoresXlsActionEnum.EnumcomProvedoresXlsAction.Guardar: lRetorno = "comProvedoresXlsGuardar"; break;
            }
            return lRetorno;
        }
    }
}
