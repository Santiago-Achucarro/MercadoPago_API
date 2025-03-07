using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesRengMoviRetProvActionEnum
    {
        public enum EnumtesRengMoviRetProvAction
        {
            Guardar, Eliminar, Datos, AsignarNombre, GenerarPDF, DevolverPDF
        }
        public static string GetAcciontesRengMoviRetProvAction(tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.Guardar: lRetorno = "tesRengMoviRetProvGuardar"; break;
                case tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.Eliminar: lRetorno = "tesRengMoviRetProvEliminar"; break;
                case tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.Datos: lRetorno = "tesRengMoviRetProvDevolverDatos"; break;
                case tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.AsignarNombre: lRetorno = "tesRengMoviRetProvAsignarNombre"; break;
                case tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.GenerarPDF: lRetorno = "tesRengMoviRetProvGenerarPDF"; break;
                case tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.DevolverPDF: lRetorno = "tesRengMoviRetProvDevolverPDF"; break;
            }
            return lRetorno;
        }
    }
}
