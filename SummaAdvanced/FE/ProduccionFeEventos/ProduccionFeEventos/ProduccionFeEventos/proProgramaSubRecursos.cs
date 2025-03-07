using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProduccionCommon;

namespace ProduccionFeEventos
{
    public class proProgramaSubRecursos
    {

        [Generalidades.QFuncion_AccionGrilla]
        public proProgramaSubRecursosDS SumarCant(proProgramaSubRecursosDS exch, proProgramaSubRecursosDS exchNoPost,
int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Ordenes[0].CantidadSubRecurso = exchNoPost.SubRecursos.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarSubRecurso(proProgramaSubRecursosDS exch, proProgramaSubRecursosDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            if (exchNoPost.SubRecursos[0].SubRecurso_Id == "")
                return "Debe_Ingresar_Un_SubRecurso";
            if (exchNoPost.SubRecursos[0].Cantidad <= 0)
                return "La_Cantidad_Debe_Ser_Mayor_Que_Cero";

            ProduccionValidacion.proSubSubRecursos.ExisteActiva(exchNoPost.SubRecursos[0].SubRecurso_Id, cmd);

            
            return "";

        }

    }
}
