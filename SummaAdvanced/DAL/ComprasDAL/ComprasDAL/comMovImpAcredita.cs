using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using interfaceDAAB;
using System.Data;

namespace ComprasDAL
{
    public class comMovImpAcredita
    {
        public static comMovImpAcreditaDS Datos(long /*0*/pAsiento_Id, int /*1*/pRenglonDebe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pRenglonDebe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovImpAcreditaDatos", parametros);

            string[] camposTabla0 = { "RenglonHaber", "comMovProv", "tesMovimientos", "RenDifCambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovImpAcreditaDS dsTipado = new comMovImpAcreditaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pAsiento_Id, int /*1*/pRenglonDebe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pRenglonDebe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovImpAcreditaEliminar", parametros);
        }



        public static void Guardar(long /*0*/pAsiento_Id, int /*1*/pRenglonDebe, int /*2*/pRenglonHaber, long /*3*/pcomMovProv, long /*4*/ptesMovimientos, string /*5*/pImpuesto_Id, string /*6*/pCartera_Id, decimal /*7*/pBaseImponible, decimal /*8*/pMonto, decimal /*9*/pTotalPago, string /*10*/pOrigen, decimal /*11*/pDifCambio, int /*12*/pRenDifCambio, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pRenglonDebe, new Generalidades.NullableInt(/*2*/pRenglonHaber), /*3*/pcomMovProv, /*4*/ptesMovimientos, /*5*/pImpuesto_Id, /*6*/pCartera_Id, /*7*/pBaseImponible, /*8*/pMonto, /*9*/pTotalPago, /*10*/pOrigen, /*11*/pDifCambio, new Generalidades.NullableInt(/*12*/pRenDifCambio) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovImpAcreditaGuardar", parametros);
        }





    }
}
