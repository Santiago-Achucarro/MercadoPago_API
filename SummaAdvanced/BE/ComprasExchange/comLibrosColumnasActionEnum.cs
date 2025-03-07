using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 31 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comLibrosColumnasActionEnum
        {            public enum EnumcomLibrosColumnasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomLibrosColumnasAction(comLibrosColumnasActionEnum.EnumcomLibrosColumnasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comLibrosColumnasActionEnum.EnumcomLibrosColumnasAction.Guardar: lRetorno = "comLibrosColumnasGuardar"; break;
                case comLibrosColumnasActionEnum.EnumcomLibrosColumnasAction.Datos: lRetorno = "comLibrosColumnasDevolverDatos"; break;
                case comLibrosColumnasActionEnum.EnumcomLibrosColumnasAction.Eliminar: lRetorno = "comLibrosColumnasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
