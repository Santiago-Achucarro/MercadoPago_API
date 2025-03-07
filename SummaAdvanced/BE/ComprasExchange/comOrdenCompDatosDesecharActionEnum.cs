using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 23 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOrdenCompDatosDesecharActionEnum
        {            public enum EnumcomOrdenCompDatosDesecharAction
            {
                Guardar
            }
        public static string GetAccioncomOrdenCompDatosDesecharAction(comOrdenCompDatosDesecharActionEnum.EnumcomOrdenCompDatosDesecharAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompDatosDesecharActionEnum.EnumcomOrdenCompDatosDesecharAction.Guardar: lRetorno = "comOrdenCompDatosDesecharGuardar"; break;
            }
            return lRetorno;
        }
    }
}
