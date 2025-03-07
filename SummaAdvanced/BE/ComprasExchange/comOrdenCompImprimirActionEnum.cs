using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, April 2, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOrdenCompImprimirActionEnum
        {            public enum EnumcomOrdenCompImprimirAction
            {
                Guardar,Datos,Enviar,AsignarNombre
            }
        public static string GetAccioncomOrdenCompImprimirAction(comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction.Guardar: lRetorno = "comOrdenCompImprimirGuardar"; break;
                case comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction.Datos: lRetorno = "comOrdenCompImprimirDevolverDatos"; break;
                case comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction.Enviar: lRetorno = "comOrdenCompImprimirEnviar"; break;
                case comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction.AsignarNombre: lRetorno = "comOrdenCompImprimirAsignarNombre"; break;
            }
            return lRetorno;
        }
    }
}
