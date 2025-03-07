using KSKCommon;
using System;

namespace KSKDAL
{
    public class espvenClieHabitualKSK
    {
        public static espvenClieHabitualKSKDS Datos(long /*0*/pCliente_id, int /*1*/pSucursal, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_id, /*1*/pSucursal };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("espvenClieHabitualKSKDatos", parametros);

            espvenClieHabitualKSKDS dsTipado = new espvenClieHabitualKSKDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pCliente_id, int /*1*/pSucursal, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_id, /*1*/pSucursal };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("espvenClieHabitualKSKEliminar", parametros);
        }

        public static void Guardar(long /*0*/pCliente_id, int /*1*/pSucursal, string /*2*/pCelular, int /*3*/pMes, int /*4*/pAnio, string /*5*/pInstagram, string /*6*/pYoutube, string /*7*/pLinkedin, string /*8*/pFacebook, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_id, /*1*/pSucursal, /*2*/pCelular, /*3*/pMes, /*4*/pAnio, /*5*/pInstagram, /*6*/pYoutube, /*7*/pLinkedin, /*8*/pFacebook };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("espvenClieHabitualKSKGuardar", parametros);
        }

    }
}
