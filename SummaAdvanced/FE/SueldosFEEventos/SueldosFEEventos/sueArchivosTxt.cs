using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueArchivosTxt
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public String Validar(SueldosCommon.sueArchivosTxtDS exch, SueldosCommon.sueArchivosTxtDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {
            if (exchNoPost.Cuerpo[0].Tipo != "N")
                if (exchNoPost.Cuerpo[0].Relleno.Length > 1)
                    Generalidades.qFunctionalException.GenerarExcepcion("El_Relleno_Debe_Tener_Un_Solo_Caracter");



            //if (exchNoPost.Cuerpo[0].Tipo != "C" && exchNoPost.Cuerpo[0].Tipo != "N")
            //    Generalidades.qFunctionalException.GenerarExcepcion("El_Tipo_Debe_Ser_C_o_N");

            //if (exchNoPost.Cuerpo[0].Longitud < 1)
            //    Generalidades.qFunctionalException.GenerarExcepcion("La_Longitud_debe_Ser_Mayor_que_Cero");

            // busco si esta columna ya existe
            for (int i = 0; i < exch.Cuerpo.Count; i++)
            {
                if (i != pIndice)
                {
                    if (exch.Cuerpo[i].Columna == exchNoPost.Cuerpo[0].Columna)
                        Generalidades.qFunctionalException.GenerarExcepcion("La_Columna_<0>_ya_Existe", new object[] { exchNoPost.Cuerpo[0].Columna });
                }

            }
            Formulas.Formulas.Validar(exchNoPost.Cuerpo[0].Formula, "SUELEXICO", exchNoPost.Cuerpo[0].Tipo, cmd);
            return "";
        }
    }
}
