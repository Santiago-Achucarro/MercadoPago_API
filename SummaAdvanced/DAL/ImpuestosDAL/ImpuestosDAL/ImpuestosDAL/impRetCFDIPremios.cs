using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impRetCFDIPremios
    {

        public static impRetCFDIPremiosDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIPremiosDatos", parametros);

            string[] camposTabla0 = { "Provincia_id", "DescripcionProvincia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            impRetCFDIPremiosDS dsTipado = new impRetCFDIPremiosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIPremiosEliminar", parametros);
        }

        public static void Guardar(int /*0*/pimpRetencionesCFDI, string /*1*/pProvincia_id, decimal /*2*/pMontTotPago, decimal /*3*/pMontTotPagoGrav, decimal /*4*/pMontTotPagoExent, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, new Generalidades.NullableString(/*1*/pProvincia_id), /*2*/pMontTotPago, /*3*/pMontTotPagoGrav, /*4*/pMontTotPagoExent };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIPremiosGuardar", parametros);
        }


    }
}
