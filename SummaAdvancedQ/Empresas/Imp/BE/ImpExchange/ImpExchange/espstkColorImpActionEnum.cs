using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 22 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpExchange{
        public static class espstkColorImpActionEnum
        {            public enum EnumespstkColorImpAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkColorImpAction(espstkColorImpActionEnum.EnumespstkColorImpAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkColorImpActionEnum.EnumespstkColorImpAction.Guardar: lRetorno = "espstkColorImpGuardar"; break;
                case espstkColorImpActionEnum.EnumespstkColorImpAction.Datos: lRetorno = "espstkColorImpDevolverDatos"; break;
                case espstkColorImpActionEnum.EnumespstkColorImpAction.Eliminar: lRetorno = "espstkColorImpEliminar"; break;
            }
            return lRetorno;
        }
    }
}
