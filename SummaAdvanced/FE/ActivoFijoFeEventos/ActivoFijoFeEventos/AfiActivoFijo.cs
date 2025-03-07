using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using ActivoFijoValidacion;

namespace ActivoFijoFeEventos
{
    public class AfiActivoFijo
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarResponsable(ActivoFijoCommon.afiActivoFijoDS pCommonDS, ActivoFijoCommon.afiActivoFijoDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            string lRetorno = "";

            ActivoFijoValidacion.AfiActivoFijo.ExisteResponsable(pCommonDSNoPost.Responsables[0].Responsable_Id,cmd);
            if (pCommonDSNoPost.Responsables[0].Responsable_Id=="") { 
                lRetorno = "El Responsable No Existe";
            }

           
            ///.................
            return lRetorno;
        }
    }
}
