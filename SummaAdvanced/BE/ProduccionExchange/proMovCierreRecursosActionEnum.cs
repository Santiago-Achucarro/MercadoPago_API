using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 11 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proMovCierreRecursosActionEnum
        {            public enum EnumproMovCierreRecursosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproMovCierreRecursosAction(proMovCierreRecursosActionEnum.EnumproMovCierreRecursosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proMovCierreRecursosActionEnum.EnumproMovCierreRecursosAction.Guardar: lRetorno = "proMovCierreRecursosGuardar"; break;
                case proMovCierreRecursosActionEnum.EnumproMovCierreRecursosAction.Datos: lRetorno = "proMovCierreRecursosDevolverDatos"; break;
                case proMovCierreRecursosActionEnum.EnumproMovCierreRecursosAction.Eliminar: lRetorno = "proMovCierreRecursosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
