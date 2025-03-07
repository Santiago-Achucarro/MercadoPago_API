using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdCheqTercerosActionEnum
        {            public enum EnumtesIdCheqTercerosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdCheqTercerosAction(tesIdCheqTercerosActionEnum.EnumtesIdCheqTercerosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdCheqTercerosActionEnum.EnumtesIdCheqTercerosAction.Guardar: lRetorno = "tesIdCheqTercerosGuardar"; break;
                case tesIdCheqTercerosActionEnum.EnumtesIdCheqTercerosAction.Datos: lRetorno = "tesIdCheqTercerosDevolverDatos"; break;
                case tesIdCheqTercerosActionEnum.EnumtesIdCheqTercerosAction.Eliminar: lRetorno = "tesIdCheqTercerosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
