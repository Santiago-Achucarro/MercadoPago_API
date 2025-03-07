using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genMensajesPantalla
    {
        public static genMensajesPantallaDS Datos(int /*0*/pgenMensajes, string /*1*/pUsuarioDestino, int /*2*/pUsuarioRemi, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pgenMensajes), 
                    new Generalidades.NullableString(/*1*/pUsuarioDestino), /*2*/pUsuarioRemi };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMensajesPantallaDatos", parametros);

            string[] camposTabla0 = { "Leido", "Destino", "DescripcionDestino", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genMensajesPantallaDS dsTipado = new genMensajesPantallaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Enviados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Guardar(int /*0*/pgenMensaje, string /*1*/pMensaje, string /*2*/pUsuarioDestino, int /*3*/pUsuarioRemi, DateTime /*4*/pFechaEmision, DateTime /*5*/pFechaDesde, DateTime /*6*/pFechaHasta, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pgenMensaje), 
                    /*1*/pMensaje, /*2*/pUsuarioDestino, /*3*/pUsuarioRemi, /*4*/pFechaEmision, /*5*/pFechaDesde, 
                        new Generalidades.NullableDate(/*6*/pFechaHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genMensajesPantallaGuardar", parametros);
        }

        public static void AdminGuardar(string /*1*/pMensaje, int /*2*/pUsuarioRemi, DateTime /*3*/pFechaEmision, DateTime /*4*/pFechaDesde, DateTime /*5*/pFechaHasta, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { /*1*/pMensaje, /*2*/pUsuarioRemi, /*3*/pFechaEmision, /*4*/pFechaDesde, /*5*/pFechaHasta };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genMensajesPantallaAdminGuardar", parametros);
        }

    }
}
