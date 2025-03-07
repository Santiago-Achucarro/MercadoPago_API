using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 30 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class AficonMovcontActionEnum
        {            public enum EnumAficonMovcontAction
            {
                Guardar,Datos,Eliminar, InsertarAsiento
        }
        public static string GetAccionAficonMovcontAction(AficonMovcontActionEnum.EnumAficonMovcontAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case AficonMovcontActionEnum.EnumAficonMovcontAction.Guardar: lRetorno = "AficonMovcontGuardar"; break;
                case AficonMovcontActionEnum.EnumAficonMovcontAction.Datos: lRetorno = "AficonMovcontDevolverDatos"; break;
                case AficonMovcontActionEnum.EnumAficonMovcontAction.Eliminar: lRetorno = "AficonMovcontEliminar"; break;
                case AficonMovcontActionEnum.EnumAficonMovcontAction.InsertarAsiento:lRetorno = "AficonMovcontInsertarAsiento"; break;
                    
            }
            return lRetorno;
        }
    }
}
