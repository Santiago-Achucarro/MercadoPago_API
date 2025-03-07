using KSKCommon;
using System;

namespace KSKDAL
{
    public class espvenMovimientosConStockKSK
    {
        public static espGenAsiSegDatosKSKDS DatosSeg(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("espGenAsiSegDatosKSK", parametros);

            espGenAsiSegDatosKSKDS dsTipado = new espGenAsiSegDatosKSKDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
