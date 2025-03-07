using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueVacTomadas
    {
        public enum sueVacTomadasVar
        {
            Anio
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> AnioActual(SueldosCommon.sueVacTomadasDatosDetalladoDS exch,
            SueldosCommon.sueVacTomadasDatosDetalladoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {


            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            lRetorno.Add(sueVacTomadasVar.Anio.ToString(), GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).Year.ToString());

            return lRetorno;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public SueldosCommon.sueVacTomadasDatosDetalladoDS Dias(SueldosCommon.sueVacTomadasDatosDetalladoDS exch, SueldosCommon.sueVacTomadasDatosDetalladoDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            if (exchNoPost.Cuerpo[0].FechaDesde > exchNoPost.Cuerpo[0].FechaHasta)
                exchNoPost.Cuerpo[0].FechaHasta = exchNoPost.Cuerpo[0].FechaDesde;
            exchNoPost.Cuerpo[0].Dias = Math.Abs((int)((exchNoPost.Cuerpo[0].FechaDesde - exchNoPost.Cuerpo[0].FechaHasta).TotalDays))+1;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }
    }
}
