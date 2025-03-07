using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 28 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comOrdenCompDatosConsActionEnum
    {
        public enum EnumcomOrdenCompDatosConsAction
        {
            Datos, AdjuntosDatos,Desechar, MarcarTodas, Guardar
        }
        public static string GetAccioncomOrdenCompDatosConsAction(comOrdenCompDatosConsActionEnum.EnumcomOrdenCompDatosConsAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompDatosConsActionEnum.EnumcomOrdenCompDatosConsAction.Datos:
                    lRetorno = "comOrdenCompDatosConsDevolverDatos"; break;
                case comOrdenCompDatosConsActionEnum.EnumcomOrdenCompDatosConsAction.AdjuntosDatos:
                    lRetorno = "comOrdenCompDatosConsAdjuntosDatos"; break;
                case comOrdenCompDatosConsActionEnum.EnumcomOrdenCompDatosConsAction.Desechar:
                    lRetorno = "comOrdenCompDatosConsDesechar"; break;
                case comOrdenCompDatosConsActionEnum.EnumcomOrdenCompDatosConsAction.MarcarTodas:
                    lRetorno = "comOrdenCompDatosConsMarcarTodas"; break;
                case comOrdenCompDatosConsActionEnum.EnumcomOrdenCompDatosConsAction.Guardar:
                    lRetorno = "comOrdenCompDatosConsGuardar"; break;

            }
            return lRetorno;
        }
    }
}
