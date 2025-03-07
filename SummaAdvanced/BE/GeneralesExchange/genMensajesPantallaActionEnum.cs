using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 27 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genMensajesPantallaActionEnum
        {            public enum EnumgenMensajesPantallaAction
            {
                Guardar,Datos,Eliminar,AdminGuardar 
            }
        public static string GetAcciongenMensajesPantallaAction(genMensajesPantallaActionEnum.EnumgenMensajesPantallaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMensajesPantallaActionEnum.EnumgenMensajesPantallaAction.Guardar: lRetorno = "genMensajesPantallaGuardar"; break;
                case genMensajesPantallaActionEnum.EnumgenMensajesPantallaAction.Datos: lRetorno = "genMensajesPantallaDevolverDatos"; break;
                case genMensajesPantallaActionEnum.EnumgenMensajesPantallaAction.Eliminar: lRetorno = "genMensajesPantallaEliminar"; break;
                case genMensajesPantallaActionEnum.EnumgenMensajesPantallaAction.AdminGuardar: lRetorno = "genMensajesPantallaAdminGuardar"; break;
            }
            return lRetorno;
        }
    }
}
