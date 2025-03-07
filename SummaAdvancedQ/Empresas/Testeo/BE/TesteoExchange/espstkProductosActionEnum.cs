using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 02 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesteoExchange{
        public static class espstkProductosActionEnum
        {            public enum EnumespstkProductosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkProductosAction(espstkProductosActionEnum.EnumespstkProductosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkProductosActionEnum.EnumespstkProductosAction.Guardar: lRetorno = "espstkProductosGuardar"; break;
                case espstkProductosActionEnum.EnumespstkProductosAction.Datos: lRetorno = "espstkProductosDevolverDatos"; break;
                case espstkProductosActionEnum.EnumespstkProductosAction.Eliminar: lRetorno = "espstkProductosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
