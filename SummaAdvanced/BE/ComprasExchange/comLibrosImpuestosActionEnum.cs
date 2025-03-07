using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 31 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comLibrosImpuestosActionEnum
        {            public enum EnumcomLibrosImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomLibrosImpuestosAction(comLibrosImpuestosActionEnum.EnumcomLibrosImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comLibrosImpuestosActionEnum.EnumcomLibrosImpuestosAction.Guardar: lRetorno = "comLibrosImpuestosGuardar"; break;
                case comLibrosImpuestosActionEnum.EnumcomLibrosImpuestosAction.Datos: lRetorno = "comLibrosImpuestosDevolverDatos"; break;
                case comLibrosImpuestosActionEnum.EnumcomLibrosImpuestosAction.Eliminar: lRetorno = "comLibrosImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
