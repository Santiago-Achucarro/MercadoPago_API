using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 10 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesConciliacionActionEnum
        {            public enum EnumtesConciliacionAction
            {
                Guardar,Datos,Eliminar,SubirXml,MarcarTodos,DesMarcarTodos
        }
        public static string GetAcciontesConciliacionAction(tesConciliacionActionEnum.EnumtesConciliacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesConciliacionActionEnum.EnumtesConciliacionAction.Guardar: lRetorno = "tesConciliacionGuardar"; break;
                case tesConciliacionActionEnum.EnumtesConciliacionAction.Datos: lRetorno = "tesConciliacionDevolverDatos"; break;
                case tesConciliacionActionEnum.EnumtesConciliacionAction.Eliminar: lRetorno = "tesConciliacionEliminar"; break;
                case tesConciliacionActionEnum.EnumtesConciliacionAction.SubirXml: lRetorno = "tesConciliacionSubirXml"; break;
                case tesConciliacionActionEnum.EnumtesConciliacionAction.MarcarTodos: lRetorno = "tesConciliacionMarcarTodos"; break;
                case tesConciliacionActionEnum.EnumtesConciliacionAction.DesMarcarTodos: lRetorno = "tesConciliacionDesMarcarTodos"; break;

            }
            return lRetorno;
        }
    }
}
