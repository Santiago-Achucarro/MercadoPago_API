using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 2 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqPropDiferidosActionEnum
        {            public enum EnumtesCheqPropDiferidosAction
            {
                Datos
            }
        public static string GetAcciontesCheqPropDiferidosAction(tesCheqPropDiferidosActionEnum.EnumtesCheqPropDiferidosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqPropDiferidosActionEnum.EnumtesCheqPropDiferidosAction.Datos: lRetorno = "tesCheqPropDiferidosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
