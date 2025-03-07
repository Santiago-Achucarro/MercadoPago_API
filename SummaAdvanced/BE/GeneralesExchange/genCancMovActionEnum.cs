using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 4 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCancMovActionEnum
        {            public enum EnumgenCancMovAction
            {
                Guardar,Datos,Eliminar,AplicarImportacion
        }
        public static string GetAcciongenCancMovAction(genCancMovActionEnum.EnumgenCancMovAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCancMovActionEnum.EnumgenCancMovAction.Guardar: lRetorno = "genCancMovGuardar"; break;
                case genCancMovActionEnum.EnumgenCancMovAction.Datos: lRetorno = "genCancMovDevolverDatos"; break;
                case genCancMovActionEnum.EnumgenCancMovAction.Eliminar: lRetorno = "genCancMovEliminar"; break;
                case genCancMovActionEnum.EnumgenCancMovAction.AplicarImportacion: lRetorno = "genCancMovAplicarImportacion"; break;
            }
            return lRetorno;
        }
    }
}
