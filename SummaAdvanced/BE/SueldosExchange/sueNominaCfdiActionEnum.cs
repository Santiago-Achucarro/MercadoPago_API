using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 18 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueNominaCfdiActionEnum
        {            public enum EnumsueNominaCfdiAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueNominaCfdiAction(sueNominaCfdiActionEnum.EnumsueNominaCfdiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueNominaCfdiActionEnum.EnumsueNominaCfdiAction.Guardar: lRetorno = "sueNominaCfdiGuardar"; break;
                case sueNominaCfdiActionEnum.EnumsueNominaCfdiAction.Datos: lRetorno = "sueNominaCfdiDevolverDatos"; break;
                case sueNominaCfdiActionEnum.EnumsueNominaCfdiAction.Eliminar: lRetorno = "sueNominaCfdiEliminar"; break;
            }
            return lRetorno;
        }
    }
}
