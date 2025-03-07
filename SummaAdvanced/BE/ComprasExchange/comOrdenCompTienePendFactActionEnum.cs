using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 4 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOrdenCompTienePendFactActionEnum
        {            public enum EnumcomOrdenCompTienePendFactAction
            {
                Datos
            }
        public static string GetAccioncomOrdenCompTienePendFactAction(comOrdenCompTienePendFactActionEnum.EnumcomOrdenCompTienePendFactAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompTienePendFactActionEnum.EnumcomOrdenCompTienePendFactAction.Datos: lRetorno = "comOrdenCompTienePendFactDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
