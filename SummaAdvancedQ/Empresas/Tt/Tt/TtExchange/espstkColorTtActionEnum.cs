using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 22 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TtExchange{
        public static class espstkColorTtActionEnum
        {            public enum EnumespstkColorTtAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkColorTtAction(espstkColorTtActionEnum.EnumespstkColorTtAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkColorTtActionEnum.EnumespstkColorTtAction.Guardar: lRetorno = "espstkColorTtGuardar"; break;
                case espstkColorTtActionEnum.EnumespstkColorTtAction.Datos: lRetorno = "espstkColorTtDevolverDatos"; break;
                case espstkColorTtActionEnum.EnumespstkColorTtAction.Eliminar: lRetorno = "espstkColorTtEliminar"; break;
            }
            return lRetorno;
        }
    }
}
