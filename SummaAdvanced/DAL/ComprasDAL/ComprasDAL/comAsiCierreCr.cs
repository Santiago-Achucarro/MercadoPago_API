using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comAsiCierreCr
    {
        public static comAsiCierreCrDS Datos(long /*0*/pAsiento_Id, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comAsiCierreCrDatos", parametros);

            comAsiCierreCrDS dsTipado = new comAsiCierreCrDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pAsiento_Id, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comAsiCierreCrEliminar", parametros);
        }
        public static void Guardar(long /*0*/pAsiento_Id, int /*1*/pconRenglon, string /*2*/pProveed_id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pconRenglon, /*2*/pProveed_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comAsiCierreCrGuardar", parametros);
        }
    }
}
