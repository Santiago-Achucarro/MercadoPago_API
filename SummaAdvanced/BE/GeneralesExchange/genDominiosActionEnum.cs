using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
/// 
namespace GeneralesExchange{
        public static class genDominiosActionEnum
        {            public enum EnumgenDominiosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenDominiosAction(genDominiosActionEnum.EnumgenDominiosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genDominiosActionEnum.EnumgenDominiosAction.Guardar: lRetorno = "genDominiosGuardar"; break;
                case genDominiosActionEnum.EnumgenDominiosAction.Datos: lRetorno = "genDominiosDevolverDatos"; break;
                case genDominiosActionEnum.EnumgenDominiosAction.Eliminar: lRetorno = "genDominiosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
