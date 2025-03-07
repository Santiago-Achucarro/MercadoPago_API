using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvActionEnum
        {            public enum EnumcomMovProvAction
            {
                Guardar,Eliminar,Datos,AdjuntarXML
            }
        public static string GetAccioncomMovProvAction(comMovProvActionEnum.EnumcomMovProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvActionEnum.EnumcomMovProvAction.Guardar: lRetorno = "comMovProvGuardar"; break;
                case comMovProvActionEnum.EnumcomMovProvAction.Eliminar: lRetorno = "comMovProvEliminar"; break;
                case comMovProvActionEnum.EnumcomMovProvAction.Datos:lRetorno = "comMovProvDevolverDatos"; break;
                case comMovProvActionEnum.EnumcomMovProvAction.AdjuntarXML: lRetorno = "comMovProvAdjuntarXML"; break;
            }
            return lRetorno;
        }
    }
}
