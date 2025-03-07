/// Generado por QBI miércoles, 19 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange
{
    public static class conEjercicioPeriodoActionEnum
    {
        public enum EnumconEjercicioPeriodoAction
        {
            Guardar, Datos, Eliminar, Definir, EjerciciosTodos
        }
        public static string GetAccionconEjercicioPeriodoAction(conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction.Guardar: lRetorno = "conEjercicioPeriodoGuardar"; break;
                case conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction.Datos: lRetorno = "conEjercicioPeriodoDevolverDatos"; break;
                case conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction.Eliminar: lRetorno = "conEjercicioPeriodoEliminar"; break;
                case conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction.Definir: lRetorno = "conEjercicioPeriodoDefinir"; break;
                case conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction.EjerciciosTodos: lRetorno = "conEjercicioPeriodoEjerciciosTodos"; break;
            }
            return lRetorno;
        }
    }
}
