using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 12 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesRengMovicomMovProvActionEnum
        {            public enum EnumtesRengMovicomMovProvAction
            {
                Guardar,Datos,Eliminar,DatosxMovProv
            }
        public static string GetAcciontesRengMovicomMovProvAction(tesRengMovicomMovProvActionEnum.EnumtesRengMovicomMovProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRengMovicomMovProvActionEnum.EnumtesRengMovicomMovProvAction.Guardar: lRetorno = "tesRengMovicomMovProvGuardar"; break;
                case tesRengMovicomMovProvActionEnum.EnumtesRengMovicomMovProvAction.Datos: lRetorno = "tesRengMovicomMovProvDevolverDatos"; break;
                case tesRengMovicomMovProvActionEnum.EnumtesRengMovicomMovProvAction.Eliminar: lRetorno = "tesRengMovicomMovProvEliminar"; break;
                case tesRengMovicomMovProvActionEnum.EnumtesRengMovicomMovProvAction.DatosxMovProv: lRetorno = "tesRengMovicomMovProvDatosxMovProv"; break;
            }
            return lRetorno;
        }
    }
}
