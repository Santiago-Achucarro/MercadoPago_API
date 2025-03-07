using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genEmpresasActionEnum
    {
        public enum EnumgenEmpresasAction
        {
            Guardar, Datos, Eliminar, SetFechaCompras, SetFechaCalculoStock, SetFechaStock, SetFechaTesoreria, SetFechaVentas, AsignaLocalidad
        }
        public static string GetAcciongenEmpresasAction(genEmpresasActionEnum.EnumgenEmpresasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genEmpresasActionEnum.EnumgenEmpresasAction.Guardar: lRetorno = "genEmpresasGuardar"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.Datos: lRetorno = "genEmpresasDevolverDatos"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.Eliminar: lRetorno = "genEmpresasEliminar"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.SetFechaCompras: lRetorno = "genEmpresasSetFechaCompras"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.SetFechaCalculoStock: lRetorno = "genEmpresasSetFechaCalculoStock"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.SetFechaStock: lRetorno = "genEmpresasSetFechaStock"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.SetFechaTesoreria: lRetorno = "genEmpresasSetFechaTesoreria"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.SetFechaVentas: lRetorno = "genEmpresasSetFechaVentas"; break;
                case genEmpresasActionEnum.EnumgenEmpresasAction.AsignaLocalidad:lRetorno = "genEmpresasAsignaLocalidad"; break;
                    
            }
            return lRetorno;
        }
    }
}
