using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 4 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class ComprasCerrarActionEnum
        {            public enum EnumComprasCerrarAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionComprasCerrarAction(ComprasCerrarActionEnum.EnumComprasCerrarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case ComprasCerrarActionEnum.EnumComprasCerrarAction.Guardar: lRetorno = "ComprasCerrarGuardar"; break;
                case ComprasCerrarActionEnum.EnumComprasCerrarAction.Datos: lRetorno = "ComprasCerrarDevolverDatos"; break;
                case ComprasCerrarActionEnum.EnumComprasCerrarAction.Eliminar: lRetorno = "ComprasCerrarEliminar"; break;
            }
            return lRetorno;
        }
    }
}
