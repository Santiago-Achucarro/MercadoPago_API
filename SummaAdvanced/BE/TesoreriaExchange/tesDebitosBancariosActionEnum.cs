using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDebitosBancariosActionEnum
        {            public enum EnumtesDebitosBancariosAction
            {
            Guardar, Datos, Eliminar, TotalDebe, AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesDebitosBancariosAction(tesDebitosBancariosActionEnum.EnumtesDebitosBancariosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDebitosBancariosActionEnum.EnumtesDebitosBancariosAction.Guardar:
                    lRetorno = "tesDebitosBancariosGuardar"; break;
                case tesDebitosBancariosActionEnum.EnumtesDebitosBancariosAction.Datos:
                    lRetorno = "tesDebitosBancariosDevolverDatos"; break;
                case tesDebitosBancariosActionEnum.EnumtesDebitosBancariosAction.Eliminar:
                    lRetorno = "tesDebitosBancariosEliminar"; break;
                case tesDebitosBancariosActionEnum.EnumtesDebitosBancariosAction.TotalDebe:
                    lRetorno = "tesDebitosBancariosTotalDebe"; break;
                case tesDebitosBancariosActionEnum.EnumtesDebitosBancariosAction.AsignarCambio:
                    lRetorno = "tesDebitosBancariosAsignarCambio"; break;
                case tesDebitosBancariosActionEnum.EnumtesDebitosBancariosAction.ReCalcularMonBase:
                    lRetorno = "tesDebitosBancariosReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
