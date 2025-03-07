using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqPropEstadoActionEnum
        {            public enum EnumtesCheqPropEstadoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesCheqPropEstadoAction(tesCheqPropEstadoActionEnum.EnumtesCheqPropEstadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqPropEstadoActionEnum.EnumtesCheqPropEstadoAction.Guardar: lRetorno = "tesCheqPropEstadoGuardar"; break;
                case tesCheqPropEstadoActionEnum.EnumtesCheqPropEstadoAction.Datos: lRetorno = "tesCheqPropEstadoDevolverDatos"; break;
                case tesCheqPropEstadoActionEnum.EnumtesCheqPropEstadoAction.Eliminar: lRetorno = "tesCheqPropEstadoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
