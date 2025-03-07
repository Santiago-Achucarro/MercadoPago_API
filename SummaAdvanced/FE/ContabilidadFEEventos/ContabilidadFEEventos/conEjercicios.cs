using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ContabilidadFEEventos
{
    public class conEjercicios
    {
        [Generalidades.QFuncion_Condicion]
        public string EsNuevo(ContabilidadCommon.conEjercicioPeriodoDS lDs, Command cmd)
        {
            return (lDs.grdPeriodos.Count >0? "N":"S");
        }

        [Generalidades.QFuncion_Condicion]
        public string PrimerEjercicio(ContabilidadCommon.conEjercicioPeriodoDS lDs, Command cmd)
        {
            // Si MX o ya tienen períodos definidos que no pueda editar el primer mes del ejercicio //
            return (cmd.Dominio_Id == "MX" || lDs.grdPeriodos.Count >= 0 && lDs.Principal[0].Ejercicios > 0 ? "N" : "S");
        }
    }
}
