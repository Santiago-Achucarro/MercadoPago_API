using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueVariables
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public String Validar(SueldosCommon.sueVariableDS exch, SueldosCommon.sueVariableDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            SueldosValidacion.sueGrupos.ExistePosteadoyActiva(exchNoPost.Cuerpo[0].Grupo_Id, cmd);
            SueldosValidacion.sueConceptos.ExistePosteadoyActiva(exchNoPost.Cuerpo[0].Concepto_Id, cmd);

            return "";

        }
    }
}
