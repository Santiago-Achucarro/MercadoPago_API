using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using KSKCommon;
using System.Data;

namespace KSKDAL
{
    public class venMovimientosResu
    {

        public static espVenMovimientosResuDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("espVenMovimientosResuDatos", parametros);

            espVenMovimientosResuDS dsTipado = new espVenMovimientosResuDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("espVenMovimientosResuEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, decimal /*1*/pCantidad, string /*2*/pMedida_Id, string /*3*/pLeyenda, decimal /*4*/pValorUnitario, string /*5*/pClaveFiscal, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pCantidad, /*2*/pMedida_Id, /*3*/pLeyenda, /*4*/pValorUnitario, /*5*/pClaveFiscal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("espVenMovimientosResuGuardar", parametros);
        }





    }
}
