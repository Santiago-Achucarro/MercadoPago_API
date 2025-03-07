/// Generado por QBI jueves, 19 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesT3PromocionesActionEnum
    {
        public enum EnumtesT3PromocionesAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAcciontesT3PromocionesAction(tesT3PromocionesActionEnum.EnumtesT3PromocionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesT3PromocionesActionEnum.EnumtesT3PromocionesAction.Guardar: lRetorno = "tesT3PromocionesGuardar"; break;
                case tesT3PromocionesActionEnum.EnumtesT3PromocionesAction.Datos: lRetorno = "tesT3PromocionesDevolverDatos"; break;
                case tesT3PromocionesActionEnum.EnumtesT3PromocionesAction.Eliminar: lRetorno = "tesT3PromocionesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
