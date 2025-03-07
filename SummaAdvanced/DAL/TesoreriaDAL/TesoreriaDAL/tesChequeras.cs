using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesChequeras
    {
        public static tesChequerasDS Datos(int /*0*/pChequera_id, string /*1*/pCartera_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pChequera_id, /*1*/pCartera_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesChequerasDatos", parametros);

            string[] camposTabla0 = { "FechaBaja" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesChequerasDS dsTipado = new tesChequerasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pChequera_id, string /*1*/pCartera_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pChequera_id), /*1*/pCartera_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesChequerasEliminar", parametros);
        }
        public static int Guardar(int /*0*/pChequera_id, string /*1*/pCartera_Id, int empresa, string /*2*/pTipoChequera, string /*3*/pEstado_id, int /*4*/pDesde, int /*5*/pHasta, int /*6*/pProximo, DateTime /*7*/pFechaAlta, DateTime /*8*/pFechaBaja, string /*9*/pMotivoBaja, bool /*10*/pInactivo, int /*11*/pUsuario_Id, bool /*12*/pPosteado, string /*13*/ pAuxiliar)
        {

            // daba error el SP
            pFechaAlta = DateTime.Now.Date;

            Object[] parametros = new Object[] {/*0*/pChequera_id, /*1*/pCartera_Id, empresa, /*2*/pTipoChequera, /*3*/pEstado_id, /*4*/pDesde, /*5*/pHasta, /*6*/pProximo, /*7*/pFechaAlta, new Generalidades.NullableDate(/*8*/pFechaBaja), /*9*/pMotivoBaja, /*10*/pInactivo, /*11*/pUsuario_Id, /*12*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesChequerasGuardar", parametros);
        }
    }
}
