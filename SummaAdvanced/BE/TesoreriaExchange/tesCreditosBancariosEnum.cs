using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 7 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCreditosBancariosEnum
        {            public enum EnumtesCreditosBancarios
            {
                Guardar,Datos,Eliminar,TotalHaber,AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesCreditosBancarios(tesCreditosBancariosEnum.EnumtesCreditosBancarios pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCreditosBancariosEnum.EnumtesCreditosBancarios.Guardar:
                    lRetorno = "tesCreditosBancariosGuardar"; break;
                case tesCreditosBancariosEnum.EnumtesCreditosBancarios.Datos:
                    lRetorno = "tesCreditosBancariosDevolverDatos"; break;
                case tesCreditosBancariosEnum.EnumtesCreditosBancarios.Eliminar:
                    lRetorno = "tesCreditosBancariosEliminar"; break;
                case tesCreditosBancariosEnum.EnumtesCreditosBancarios.TotalHaber:
                    lRetorno = "tesCreditosBancariosTotalHaber"; break;
                case tesCreditosBancariosEnum.EnumtesCreditosBancarios.AsignarCambio:
                    lRetorno = "tesCreditosBancariosAsignarCambio"; break;
                case tesCreditosBancariosEnum.EnumtesCreditosBancarios.ReCalcularMonBase:
                    lRetorno = "tesCreditosBancariosReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
