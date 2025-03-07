using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impRetCFDIDividendos
    {

        public static impRetCFDIDividendosDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIDividendosDatos", parametros);

            impRetCFDIDividendosDS dsTipado = new impRetCFDIDividendosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIDividendosEliminar", parametros);
        }



        public static void Guardar(int /*0*/pimpRetencionesCFDI, string /*1*/pCveTipDivOUtil, decimal /*2*/pMontISRAcredRetMexico, decimal /*3*/pMontISRAcredRetExtranjero, decimal /*4*/pMontRetExtDivExt, string /*5*/pTipoSocDistrDiv, decimal /*6*/pMontISRAcredNal, decimal /*7*/pMontDivAcumNal, decimal /*8*/pMontDivAcumExt, decimal /*9*/pProporcionRem, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pCveTipDivOUtil, /*2*/pMontISRAcredRetMexico, /*3*/pMontISRAcredRetExtranjero, /*4*/pMontRetExtDivExt, /*5*/pTipoSocDistrDiv, /*6*/pMontISRAcredNal, /*7*/pMontDivAcumNal, /*8*/pMontDivAcumExt, /*9*/pProporcionRem };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIDividendosGuardar", parametros);
        }


    }
}
