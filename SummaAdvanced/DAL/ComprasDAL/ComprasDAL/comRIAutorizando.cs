using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comRIAutorizando
    {
        public static void Eliminar(int /*0*/pcomReqInterno, int /*1*/pSecuencia, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, new Generalidades.NullableInt(/*1*/pSecuencia) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comRIAutorizandoEliminar", parametros);
        }

        public static comRIAutorizandoDS Datos(int /*0*/pcomReqInterno, int /*1*/pSecuencia, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, new Generalidades.NullableInt(/*1*/pSecuencia) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comRIAutorizandoDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula", "genUsuarios" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comRIAutorizandoDS dsTipado = new comRIAutorizandoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static int Guardar(int /*0*/pcomReqInterno, int /*1*/pSecuencia, string /*2*/pNivelAuto_Id, int /*3*/pUsuario_Id, DateTime /*4*/pFecha, string /*5*/pTipoApro, string /*6*/pResultadoFormula, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pSecuencia, /*2*/pNivelAuto_Id, new Generalidades.NullableInt(/*3*/pUsuario_Id), new Generalidades.NullableDate(/*4*/pFecha), /*5*/pTipoApro, new Generalidades.NullableString(/*6*/pResultadoFormula) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comRIAutorizandoGuardar", parametros);
        }

        public static comRIAutorizandoDS DatosSecuencia(int /*0*/pcomReqInterno, int /*1*/pSecuencia, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pSecuencia };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comRiAutorizandoDatosSecuencia", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula", "genUsuarios" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comRIAutorizandoDS dsTipado = new comRIAutorizandoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
