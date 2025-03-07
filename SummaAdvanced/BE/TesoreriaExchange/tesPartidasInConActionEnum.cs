using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesPartidasInConActionEnum
        {            public enum EnumtesPartidasInConAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesPartidasInConAction(tesPartidasInConActionEnum.EnumtesPartidasInConAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPartidasInConActionEnum.EnumtesPartidasInConAction.Guardar: lRetorno = "tesPartidasInConGuardar"; break;
                case tesPartidasInConActionEnum.EnumtesPartidasInConAction.Datos: lRetorno = "tesPartidasInConDevolverDatos"; break;
                case tesPartidasInConActionEnum.EnumtesPartidasInConAction.Eliminar: lRetorno = "tesPartidasInConEliminar"; break;
            }
            return lRetorno;
        }
    }
}
