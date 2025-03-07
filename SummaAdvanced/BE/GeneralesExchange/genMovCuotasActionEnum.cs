using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genMovCuotasActionEnum
        {            public enum EnumgenMovCuotasAction
            {
                Guardar,Datos,Eliminar,Aplicar
            }
        public static string GetAcciongenMovCuotasAction(genMovCuotasActionEnum.EnumgenMovCuotasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMovCuotasActionEnum.EnumgenMovCuotasAction.Guardar: lRetorno = "genMovCuotasGuardar"; break;
                case genMovCuotasActionEnum.EnumgenMovCuotasAction.Datos: lRetorno = "genMovCuotasDevolverDatos"; break;
                case genMovCuotasActionEnum.EnumgenMovCuotasAction.Eliminar: lRetorno = "genMovCuotasEliminar"; break;
                case genMovCuotasActionEnum.EnumgenMovCuotasAction.Aplicar: lRetorno = "genMovCuotasAplicar"; break;
            }
            return lRetorno;
        }
    }
}
