using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 26 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesteoExchange{
        public static class espstkColorTestActionEnum
        {            public enum EnumespstkColorTestAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkColorTestAction(espstkColorTestActionEnum.EnumespstkColorTestAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkColorTestActionEnum.EnumespstkColorTestAction.Guardar: lRetorno = "espstkColorTestGuardar"; break;
                case espstkColorTestActionEnum.EnumespstkColorTestAction.Datos: lRetorno = "espstkColorTestDevolverDatos"; break;
                case espstkColorTestActionEnum.EnumespstkColorTestAction.Eliminar: lRetorno = "espstkColorTestEliminar"; break;
            }
            return lRetorno;
        }
    }
}
