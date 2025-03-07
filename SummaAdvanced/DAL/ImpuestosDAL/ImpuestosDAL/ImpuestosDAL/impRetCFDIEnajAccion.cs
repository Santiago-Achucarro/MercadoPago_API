using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
    public class impRetCFDIEnajAccion
    {
        public static impRetCFDIEnajAccionDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIEnajAccionDatos", parametros);

            impRetCFDIEnajAccionDS dsTipado = new impRetCFDIEnajAccionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIEnajAccionEliminar", parametros);
        }

        public static void Guardar(int /*0*/pimpRetencionesCFDI, string /*1*/pContratoIntermediacion, decimal /*2*/pGanancia, decimal /*3*/pPerdida, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pContratoIntermediacion, /*2*/pGanancia, /*3*/pPerdida };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIEnajAccionGuardar", parametros);
        }


    }
}
