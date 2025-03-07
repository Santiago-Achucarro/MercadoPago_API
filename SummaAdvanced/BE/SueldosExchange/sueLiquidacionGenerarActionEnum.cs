using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 6 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiquidacionGenerarActionEnum
        {            public enum EnumsueLiquidacionGenerarAction
            {
                Guardar,Datos,Eliminar, EliminarVacios
        }
        public static string GetAccionsueLiquidacionGenerarAction(sueLiquidacionGenerarActionEnum.EnumsueLiquidacionGenerarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiquidacionGenerarActionEnum.EnumsueLiquidacionGenerarAction.Guardar: lRetorno = "sueLiquidacionGenerarGuardar"; break;
                case sueLiquidacionGenerarActionEnum.EnumsueLiquidacionGenerarAction.Datos: lRetorno = "sueLiquidacionGenerarDevolverDatos"; break;
                case sueLiquidacionGenerarActionEnum.EnumsueLiquidacionGenerarAction.Eliminar: lRetorno = "sueLiquidacionGenerarEliminar"; break;
                case sueLiquidacionGenerarActionEnum.EnumsueLiquidacionGenerarAction.EliminarVacios: lRetorno = "sueLiquidacionGenerarEliminarVacios"; break;
            }
            return lRetorno;
        }
    }
}
