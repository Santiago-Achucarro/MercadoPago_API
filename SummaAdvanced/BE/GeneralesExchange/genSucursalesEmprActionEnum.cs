using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genSucursalesEmprActionEnum
    {
        public enum EnumgenSucursalesEmprAction
        {
            Guardar, Datos, Eliminar, SetFechaCaja, AsignaLocalidad
        }
        public static string GetAcciongenSucursalesEmprAction(genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.Guardar:
                    lRetorno = "genSucursalesEmprGuardar";
                    break;
                case genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.Datos:
                    lRetorno = "genSucursalesEmprDevolverDatos";
                    break;
                case genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.Eliminar:
                    lRetorno = "genSucursalesEmprEliminar";
                    break;
                case genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.SetFechaCaja:
                    lRetorno = "genSucursalesEmprSetFechaCaja";
                    break;

                case genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.AsignaLocalidad:
                    lRetorno = "genSucursalesEmprAsignaLocalidad";
                    break;
                    
            }
            return lRetorno;
        }
    }
}
