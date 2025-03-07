using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqTerEstadoActionEnum
        {            public enum EnumtesCheqTerEstadoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesCheqTerEstadoAction(tesCheqTerEstadoActionEnum.EnumtesCheqTerEstadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqTerEstadoActionEnum.EnumtesCheqTerEstadoAction.Guardar: lRetorno = "tesCheqTerEstadoGuardar"; break;
                case tesCheqTerEstadoActionEnum.EnumtesCheqTerEstadoAction.Datos: lRetorno = "tesCheqTerEstadoDevolverDatos"; break;
                case tesCheqTerEstadoActionEnum.EnumtesCheqTerEstadoAction.Eliminar: lRetorno = "tesCheqTerEstadoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
