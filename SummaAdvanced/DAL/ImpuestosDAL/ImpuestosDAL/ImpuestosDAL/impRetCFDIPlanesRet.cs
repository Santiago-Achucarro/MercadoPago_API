using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
    public class impRetCFDIPlanesRet
    {
        public static impRetCFDIPlanesRetDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIPlanesRetDatos", parametros);

            impRetCFDIPlanesRetDS dsTipado = new impRetCFDIPlanesRetDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIPlanesRetEliminar", parametros);
        }

        public static void Guardar(int /*0*/pimpRetencionesCFDI, string /*1*/pSistemaFinanc, decimal /*2*/pMontTotAportAnioInmAnterior, decimal /*3*/pMontIntRealesDevengAniooInmAnt, string /*4*/pHuboRetirosAnioInmAntPer, decimal /*5*/pMontTotRetiradoAnioInmAntPer, decimal /*6*/pMontTotExentRetiradoAnioInmAnt, decimal /*7*/pMontTotExedenteAnioInmAnt, string /*8*/pHuboRetirosAnioInmAnt, decimal /*9*/pMontTotRetiradoAnioInmAnt, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pSistemaFinanc, /*2*/pMontTotAportAnioInmAnterior, /*3*/pMontIntRealesDevengAniooInmAnt, /*4*/pHuboRetirosAnioInmAntPer, /*5*/pMontTotRetiradoAnioInmAntPer, /*6*/pMontTotExentRetiradoAnioInmAnt, /*7*/pMontTotExedenteAnioInmAnt, /*8*/pHuboRetirosAnioInmAnt, /*9*/pMontTotRetiradoAnioInmAnt };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIPlanesRetGuardar", parametros);
        }


    }
}
