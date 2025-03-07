using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 30 de abril de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proProgramaSubRecursosActionEnum
        {            public enum EnumproProgramaSubRecursosAction
            {
                Guardar,Datos,AsignarSubRecurso
            }
        public static string GetAccionproProgramaSubRecursosAction(proProgramaSubRecursosActionEnum.EnumproProgramaSubRecursosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proProgramaSubRecursosActionEnum.EnumproProgramaSubRecursosAction.Guardar: lRetorno = "proProgramaSubRecursosGuardar"; break;
                case proProgramaSubRecursosActionEnum.EnumproProgramaSubRecursosAction.Datos: lRetorno = "proProgramaSubRecursosDevolverDatos"; break;
                case proProgramaSubRecursosActionEnum.EnumproProgramaSubRecursosAction.AsignarSubRecurso: lRetorno = "proProgramaSubRecursosAsignarSubRecurso"; break;
            }
            return lRetorno;
        }
    }
}
