using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueVacCorrespondientes
    {
        public enum sueVacCorrespondientesVar
        {
            Anio
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> AnioActual(SueldosCommon.sueVacCorrespondenDatosRangoDS exch,
            SueldosCommon.sueVacCorrespondenDatosRangoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            lRetorno.Add(sueVacCorrespondientesVar.Anio.ToString(), GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).Year.ToString());
                
            return lRetorno;
        }
    }
}
