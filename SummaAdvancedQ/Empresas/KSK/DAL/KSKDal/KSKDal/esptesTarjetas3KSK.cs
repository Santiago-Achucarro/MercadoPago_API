using KSKCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKDAL
{
    public class esptesTarjetas3KSK
    {
        public static esptesTarjetas3KSKDS Datos(int /*0*/ptesTarjetas3, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesTarjetas3 };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("esptesTarjetas3KSKDatos", parametros);

            esptesTarjetas3KSKDS dsTipado = new esptesTarjetas3KSKDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/ptesTarjetas3, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/ptesTarjetas3) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("esptesTarjetas3KSKEliminar", parametros);
        }

        public static void Guardar(int /*0*/ptesTarjetas3, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/ptesTarjetas3) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("esptesTarjetas3KSKEliminar", parametros);
        }




    }
}
