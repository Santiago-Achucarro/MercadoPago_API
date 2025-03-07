using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionFeEventos
{
    public class proRecursos
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(ProduccionCommon.proRecursosDS exch, ProduccionCommon.proRecursosDS excNoPos,
              int Indice, Framework.Core.Command cmd)
        {

            if (excNoPos.SubRecursos[0].SubRecurso_Id == "")
                return "Debe_Ingresar_El_Codigo_de_Recurso";


            return "";
        }
    }
}
