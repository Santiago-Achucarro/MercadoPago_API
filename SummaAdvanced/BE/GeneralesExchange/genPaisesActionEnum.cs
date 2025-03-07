using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genPaisesActionEnum
        {            public enum EnumgenPaisesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenPaisesAction(genPaisesActionEnum.EnumgenPaisesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genPaisesActionEnum.EnumgenPaisesAction.Guardar: lRetorno = "genPaisesGuardar"; break;
                case genPaisesActionEnum.EnumgenPaisesAction.Datos: lRetorno = "genPaisesDevolverDatos"; break;
                case genPaisesActionEnum.EnumgenPaisesAction.Eliminar: lRetorno = "genPaisesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
