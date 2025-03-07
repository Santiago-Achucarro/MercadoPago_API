using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange
{
    public static class impPadronActionEnum
    {
        public enum EnumimpPadronAction
        {
            Guardar, Datos, Eliminar, Buscar, EstaEn
        }
        public static string GetAccionimpPadronAction(impPadronActionEnum.EnumimpPadronAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impPadronActionEnum.EnumimpPadronAction.Guardar: lRetorno = "impPadronGuardar"; break;
                case impPadronActionEnum.EnumimpPadronAction.Datos: lRetorno = "impPadronDevolverDatos"; break;
                case impPadronActionEnum.EnumimpPadronAction.Eliminar: lRetorno = "impPadronEliminar"; break;
                case impPadronActionEnum.EnumimpPadronAction.Buscar: lRetorno = "impPadronBuscar"; break;
                case impPadronActionEnum.EnumimpPadronAction.EstaEn: lRetorno = "impPadronEstaEn"; break;
            }
            return lRetorno;
        }
    }
}
