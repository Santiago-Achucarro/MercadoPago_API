using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, October 17, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comOrdenCompActionEnum
    {
        public enum EnumcomOrdenCompAction
        {
            Guardar, Datos, Eliminar, CalcularTotal, AsignarDatosProv, AgregarImpuesto, DatosInt, CambiarEstado, AdjuntosDatos, Enviar, ActualizarFechas
        }
        public static string GetAccioncomOrdenCompAction(comOrdenCompActionEnum.EnumcomOrdenCompAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.Guardar: lRetorno = "comOrdenCompGuardar"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.Datos: lRetorno = "comOrdenCompDevolverDatos"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.Eliminar: lRetorno = "comOrdenCompEliminar"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.DatosInt: lRetorno = "comOrdenCompDevolverDatosInt"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.CalcularTotal: lRetorno = "comOrdenCompCalcularTotal"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.AsignarDatosProv: lRetorno = "comOrdenCompAsignarDatosProv"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.AgregarImpuesto: lRetorno = "comOrdenCompAgregarImpuesto"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.CambiarEstado: lRetorno = "comOrdenCompCambiarEstado"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.AdjuntosDatos: lRetorno = "comOrdenCompAdjuntosDatos"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.Enviar: lRetorno = "comOrdenCompEnviar"; break;
                case comOrdenCompActionEnum.EnumcomOrdenCompAction.ActualizarFechas: lRetorno = "comOrdenCompActualizarFechas"; break;
            }
            return lRetorno;
        }
    }
}
