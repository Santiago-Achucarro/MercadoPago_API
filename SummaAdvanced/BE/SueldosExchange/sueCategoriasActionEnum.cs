using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueCategoriasActionEnum
        {            public enum EnumsueCategoriasAction
            {
                Guardar,Datos,Eliminar,DatosXFecha
            }
        public static string GetAccionsueCategoriasAction(sueCategoriasActionEnum.EnumsueCategoriasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueCategoriasActionEnum.EnumsueCategoriasAction.Guardar: lRetorno = "sueCategoriasGuardar"; break;
                case sueCategoriasActionEnum.EnumsueCategoriasAction.Datos: lRetorno = "sueCategoriasDevolverDatos"; break;
                case sueCategoriasActionEnum.EnumsueCategoriasAction.Eliminar: lRetorno = "sueCategoriasEliminar"; break;
                case EnumsueCategoriasAction.DatosXFecha:lRetorno= "sueCategoriasDatosXFecha"; break;

            }
            return lRetorno;
        }
    }
}
