using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ContabilidadFEEventos
{
    public class conBaseDistri
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(ContabilidadCommon.conBaseDistriDS Exc, ContabilidadCommon.conBaseDistriDS exchNoPost, 
            int pIndice, Command cmd)
        {
            ContabilidadCommon.conBaseDistriDS.grdconBaseCentroDataTable lDs = exchNoPost.grdconBaseCentro;

            if (lDs[0].Centro1_Id == "")
                return "El_Centro_De_Costos_No_puede_ser_Vacio";

            ContabilidadValidacion.conCentro1.ExistePosteadoyActivo(lDs[0].Centro1_Id, cmd);
            return "";

        }
    }
}
