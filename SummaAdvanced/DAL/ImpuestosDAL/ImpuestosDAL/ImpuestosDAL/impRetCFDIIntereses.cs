using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
   public class impRetCFDIIntereses
    {
        public static impRetCFDIInteresesDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("impRetCFDIInteresesDatos", parametros);

            impRetCFDIInteresesDS dsTipado = new impRetCFDIInteresesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIInteresesEliminar", parametros);
        }

        public static void Guardar(int /*0*/pimpRetencionesCFDI, string /*1*/pSistFinanciero, string /*2*/pRetiroAORESRetInt, string /*3*/pOperFinancDerivad, decimal /*4*/pMontIntNominal, decimal /*5*/pMontIntReal, decimal /*6*/pPerdida, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pSistFinanciero, /*2*/pRetiroAORESRetInt, /*3*/pOperFinancDerivad, /*4*/pMontIntNominal, /*5*/pMontIntReal, /*6*/pPerdida };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIInteresesGuardar", parametros);
        }



    }
}
