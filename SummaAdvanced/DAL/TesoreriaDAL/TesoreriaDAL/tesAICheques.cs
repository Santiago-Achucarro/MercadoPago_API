using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using TesoreriaCommon;
using System.Data;

namespace TesoreriaDAL
{
    public class tesAICheques
    {
        public static tesAIChequesDS Datos(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id, new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesAIChequesDatos", parametros);

            string[] camposTabla0 = { "Chequera_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesAIChequesDS dsTipado = new tesAIChequesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);

        }





        public static void Eliminar(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id, new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesAIChequesEliminar", parametros);
        }

        public static void Guardar(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, int /*2*/pRenglon, DateTime /*3*/pFechaVencimiento, int /*4*/pChequera_Id, int /*5*/pnumCheque, string /*6*/pAlaOrden, decimal /*7*/pImporte, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id, /*2*/pRenglon, /*3*/pFechaVencimiento, /*4*/pChequera_Id, /*5*/pnumCheque, /*6*/pAlaOrden, /*7*/pImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesAIChequesGuardar", parametros);
        }



    }
}
