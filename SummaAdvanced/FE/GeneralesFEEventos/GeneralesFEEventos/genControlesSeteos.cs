using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace GeneralesFEEventos
{
    public class genControlesSeteos
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(GeneralesCommon.genControlesSeteosDS pCommonDS, GeneralesCommon.genControlesSeteosDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            string lRetorno = "";
        
            if (pCommonDSNoPost.Controles[0].Control_Id.Trim() == "")
                lRetorno =  "Debe_seleccionar_un_control";
            else if (pCommonDSNoPost.Controles[0].Orden <= 0)
                lRetorno = "Debe_indicar_el_orden";
            else if ((!pCommonDSNoPost.Controles[0].ModificoValor) &&
                     (!pCommonDSNoPost.Controles[0].Ocultar) &&
                     (!pCommonDSNoPost.Controles[0].Deshabilitar))
                lRetorno = "Debe_seleccionar_al_menos_una_accion_(modificar_ocultar_deshabilitar)";
            else //debo chequear que el orden no esté asignado a otro control
            {
                foreach (GeneralesCommon.genControlesSeteosDS.ControlesRow lrow in pCommonDS.Controles)
                {
                    if ((pCommonDSNoPost.Controles[0].Orden == lrow.Orden) &&
                         (pCommonDSNoPost.Controles[0].Control_Id.ToLower() != lrow.Control_Id.ToLower()))
                        lRetorno = "Ese_mismo_orden_esta_asignado_a_otro_control";
                }
            }


            return lRetorno;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarEliminarFila(GeneralesCommon.genControlesSeteosDS pCommonDS, GeneralesCommon.genControlesSeteosDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            string lRetorno = "";

            if (pCommonDS.Controles[pIndice].SeteadoPorSistema)
                lRetorno = "No_se_puede_eliminar_un_seteo_del_sistema";


            return lRetorno;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string MuestroControles(GeneralesCommon.genControlesSeteosDS pCommonDS, GeneralesCommon.genControlesSeteosDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            string lRetorno = "T"; //Todos
            //Si es una grilla, columna o solapa, solo puede ingresar si la oculta o no
            if ((pCommonDSNoPost.Controles[0].TipoControl.Contains("Grid")) ||
                (pCommonDSNoPost.Controles[0].TipoControl.Contains("TabPage")) ||
                (pCommonDSNoPost.Controles[0].TipoControl.Contains("Columna")))
                lRetorno = "O";
            //Si es un Boton puede ocultar y desahbilitar
            else if (pCommonDSNoPost.Controles[0].TipoControl.Contains("Boton"))
                lRetorno = "OD";
            return lRetorno;
        }
    }
}
