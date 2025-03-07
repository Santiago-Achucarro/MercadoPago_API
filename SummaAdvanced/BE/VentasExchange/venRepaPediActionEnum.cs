using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 9 de abril de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venRepaPediActionEnum
    {
        public enum EnumvenRepaPediAction
        {
            Guardar, Eliminar, MarcarFacturado, MarcarRemitido, RepXPed, DesMarcarFacturado, DesMarcarRemitido
        }
        public static string GetAccionvenRepaPediAction(venRepaPediActionEnum.EnumvenRepaPediAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRepaPediActionEnum.EnumvenRepaPediAction.Guardar: lRetorno = "venRepaPediGuardar"; break;
                case venRepaPediActionEnum.EnumvenRepaPediAction.Eliminar: lRetorno = "venRepaPediEliminar"; break;
                case venRepaPediActionEnum.EnumvenRepaPediAction.MarcarFacturado: lRetorno = "venRepaPediMarcarFacturado"; break;
                case venRepaPediActionEnum.EnumvenRepaPediAction.MarcarRemitido: lRetorno = "venRepaPediMarcarRemitido"; break;
                case venRepaPediActionEnum.EnumvenRepaPediAction.RepXPed: lRetorno = "venRepaPediRepXPed"; break;
                case venRepaPediActionEnum.EnumvenRepaPediAction.DesMarcarFacturado: lRetorno = "venRepaPediDesMarcarFacturado"; break;
                case venRepaPediActionEnum.EnumvenRepaPediAction.DesMarcarRemitido: lRetorno = "venRepaPediDesMarcarRemitido"; break;
            }
            return lRetorno;
        }
    }
}
