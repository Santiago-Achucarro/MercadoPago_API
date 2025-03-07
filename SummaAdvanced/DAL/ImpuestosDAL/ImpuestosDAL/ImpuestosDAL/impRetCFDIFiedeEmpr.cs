using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
    public class impRetCFDIFiedeEmpr
    {

        public static impRetCFDIFiedeEmprDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIFiedeEmprDatos", parametros);

            impRetCFDIFiedeEmprDS dsTipado = new impRetCFDIFiedeEmprDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIFiedeEmprEliminar", parametros);
        }

        public static void Guardar(int /*0*/pimpRetencionesCFDI, decimal /*1*/pMontTotEntradasPeriodo, decimal /*2*/pPartPropAcumDelFideicom, decimal /*3*/pPropDelMontTot, string /*4*/pConcepto, decimal /*5*/pMontTotEgresPeriodo, decimal /*6*/pPartPropDelFideicom, decimal /*7*/pPropDelMontTotE, string /*8*/pConseptoS, decimal /*9*/pMontRetRelPagFideic, string /*10*/pDescRetRelPagFideic, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pMontTotEntradasPeriodo, /*2*/pPartPropAcumDelFideicom, /*3*/pPropDelMontTot, /*4*/pConcepto, /*5*/pMontTotEgresPeriodo, /*6*/pPartPropDelFideicom, /*7*/pPropDelMontTotE, /*8*/pConseptoS, /*9*/pMontRetRelPagFideic, /*10*/pDescRetRelPagFideic };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIFiedeEmprGuardar", parametros);
        }


    }
}
