using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genAlertas
    {
        public static genAlertasDS Datos(int /*0*/pAlertaId, string /*1*/ pAuxiliar)
        {
            
            Object[] parametros = new Object[] {/*0*/pAlertaId };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAlertasDatos", parametros);

            string[] camposTabla0 = { "FechaLeido" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAlertasDS dsTipado = new genAlertasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pAlertaId, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAlertaId };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genAlertasEliminar", parametros);
        }

        public static void Guardar(int /*0*/pAlertaId, int /*1*/pUsuario_id, DateTime /*2*/pFechaEmision, DateTime /*3*/pFechaLeido, string /*4*/pMensaje, string /*5*/pLiga, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAlertaId, /*1*/pUsuario_id, /*2*/pFechaEmision, new Generalidades.NullableDate(/*3*/pFechaLeido), /*4*/pMensaje, /*5*/pLiga };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genAlertasGuardar", parametros);
        }

        public static genAlertasUsuarioDS AlertasUsuario(int /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAlertasUsuario", parametros);

            string[] camposTabla0 = { "Usuario_id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAlertasUsuarioDS dsTipado = new genAlertasUsuarioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Mensajes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void EliminarMensajesUsuario(int /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genAlertasEliminarUsuario", parametros);
        }






    }
}
