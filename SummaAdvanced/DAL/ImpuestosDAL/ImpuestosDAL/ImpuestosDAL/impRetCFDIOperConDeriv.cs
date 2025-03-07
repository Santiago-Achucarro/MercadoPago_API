using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impRetCFDIOperConDeriv
    {
        public static impRetCFDIOperConDerivDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIOperConDerivDatos", parametros);

            impRetCFDIOperConDerivDS dsTipado = new impRetCFDIOperConDerivDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIOperConDerivEliminar", parametros);
        }

        public static void Guardar(int /*0*/pimpRetencionesCFDI, decimal /*1*/pMontGanAcum, decimal /*2*/pMontPerdDed, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pMontGanAcum, /*2*/pMontPerdDed };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIOperConDerivGuardar", parametros);
        }




    }
}
