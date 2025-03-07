using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genMensajes
    {
        public static genMensajesUsuarioDS DatosUsuario(int /*0*/pUsuario_id, bool /*1*/pPendientes, int /*2*/pEmpresa, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_id, /*1*/pPendientes, /*2*/pEmpresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMensajesUsuario", parametros);

            string[] camposTabla0 = { "Pendientes" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "FechaLeido", "Leido", "FechaDesde", "FechaHasta", "disFormularios", "Formulario_Id", "Parametros", "Tipo", "SubTipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genMensajesUsuarioDS dsTipado = new genMensajesUsuarioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Mensajes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static int Guardar(int /*0*/pMensaje_Id, string /*1*/pMensaje, DateTime /*2*/pLeido, int /*3*/pUsuario_Id, string /*4*/pUsuarioDestino, DateTime /*5*/pFechaEmision, DateTime /*6*/pFechaDesde, DateTime /*7*/pFechaHasta, string /*8*/pFormulario, string /*9*/pParametros, string /*10*/pTipo, string /*11*/pSubTipo, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMensaje_Id, /*1*/pMensaje, new Generalidades.NullableDate(/*2*/pLeido), /*3*/pUsuario_Id, /*4*/pUsuarioDestino, /*5*/pFechaEmision, new Generalidades.NullableDate(/*6*/pFechaDesde), new Generalidades.NullableDate(/*7*/pFechaHasta), new Generalidades.NullableString(/*8*/pFormulario), new Generalidades.NullableString(/*9*/pParametros), new Generalidades.NullableString(/*10*/pTipo), new Generalidades.NullableString(/*11*/pSubTipo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("genMensajesGuardar", parametros);
        }


        public static genMensajesDS Datos(int /*0*/pMensajeId, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMensajeId };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMensajesDatos", parametros);

            string[] camposTabla0 = { "FechaLeido", "FechaDesde", "FechaHasta", "Parametros" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genMensajesDS dsTipado = new genMensajesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Leido(int /*0*/pMensaje_Id, DateTime /*1*/pFechaLeido, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMensaje_Id, new Generalidades.NullableDate(/*1*/pFechaLeido) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genMensajesLeido", parametros);
        }



        public static void Eliminar(int /*0*/pMensaje_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMensaje_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genMensajesEliminar", parametros);
        }



    }
}
