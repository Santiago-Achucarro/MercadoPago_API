using KSKCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKDAL
{
    public class esptesIdentificaKSK
    {
        public static esptesMPCobranzaKSKDS Datos(int /*0*/pid, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pid };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("esptesMPCobranzaKSKDatos", parametros);

            esptesMPCobranzaKSKDS dsTipado = new esptesMPCobranzaKSKDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pid, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pid) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("esptesMPCobranzaKSKEliminar", parametros);
        }
        public static void Guardar(int /*0*/pid, string /*1*/pstatus, string /*2*/pexternal_reference, decimal /*3*/ppay_transaction_amount, string /*4*/ppay_status, string /*5*/pdate_created, int /*6*/pcol_id, string /*7*/pcol_email, string /*8*/pcol_nickname, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pid, /*1*/pstatus, /*2*/pexternal_reference, /*3*/ppay_transaction_amount, /*4*/ppay_status, /*5*/pdate_created, /*6*/pcol_id, /*7*/pcol_email, /*8*/pcol_nickname };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("esptesMPCobranzaKSKGuardar", parametros);
        }

    }
}
