using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 27 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkInventCuerpoActionEnum
        {            public enum EnumstkInventCuerpoAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionstkInventCuerpoAction(stkInventCuerpoActionEnum.EnumstkInventCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkInventCuerpoActionEnum.EnumstkInventCuerpoAction.Guardar: lRetorno = "stkInventCuerpoGuardar"; break;
                case stkInventCuerpoActionEnum.EnumstkInventCuerpoAction.Eliminar: lRetorno = "stkInventCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
