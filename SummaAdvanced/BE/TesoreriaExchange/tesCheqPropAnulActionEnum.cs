using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqPropAnulActionEnum
        {            public enum EnumtesCheqPropAnulAction
            {
                Guardar,Datos
            }
        public static string GetAcciontesCheqPropAnulAction(tesCheqPropAnulActionEnum.EnumtesCheqPropAnulAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqPropAnulActionEnum.EnumtesCheqPropAnulAction.Guardar: lRetorno = "tesCheqPropAnulGuardar"; break;
                case tesCheqPropAnulActionEnum.EnumtesCheqPropAnulAction.Datos: lRetorno = "tesCheqPropAnulDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
