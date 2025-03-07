using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesCheqTercerosActionEnum
    {
        public enum EnumtesCheqTercerosAction
        {
            Guardar, Datos, Eliminar, Actualizar, Modificar
        }
        public static string GetAcciontesCheqTercerosAction(tesCheqTercerosActionEnum.EnumtesCheqTercerosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqTercerosActionEnum.EnumtesCheqTercerosAction.Guardar: lRetorno = "tesCheqTercerosGuardar"; break;
                case tesCheqTercerosActionEnum.EnumtesCheqTercerosAction.Datos: lRetorno = "tesCheqTercerosDevolverDatos"; break;
                case tesCheqTercerosActionEnum.EnumtesCheqTercerosAction.Eliminar: lRetorno = "tesCheqTercerosEliminar"; break;
                case tesCheqTercerosActionEnum.EnumtesCheqTercerosAction.Actualizar: lRetorno = "tesCheqTercerosActualizar"; break;
                case tesCheqTercerosActionEnum.EnumtesCheqTercerosAction.Modificar: lRetorno = "tesCheqTercerosModificar"; break;
            }
            return lRetorno;
        }
    }
}
