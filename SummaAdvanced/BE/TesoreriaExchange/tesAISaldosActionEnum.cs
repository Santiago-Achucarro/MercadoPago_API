using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 4 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesAISaldosActionEnum
        {            public enum EnumtesAISaldosAction
            {
                Guardar,Datos,Eliminar, Confirmar
        }
        public static string GetAcciontesAISaldosAction(tesAISaldosActionEnum.EnumtesAISaldosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesAISaldosActionEnum.EnumtesAISaldosAction.Guardar: lRetorno = "tesAISaldosGuardar"; break;
                case tesAISaldosActionEnum.EnumtesAISaldosAction.Datos: lRetorno = "tesAISaldosDevolverDatos"; break;
                case tesAISaldosActionEnum.EnumtesAISaldosAction.Eliminar: lRetorno = "tesAISaldosEliminar"; break;
                case tesAISaldosActionEnum.EnumtesAISaldosAction.Confirmar: lRetorno = "tesAISaldosConfirmar"; break;
            }
            return lRetorno;
        }
    }
}
