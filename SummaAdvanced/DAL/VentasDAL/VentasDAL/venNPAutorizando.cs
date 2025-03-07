using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;


namespace VentasDAL
{
    public class venNPAutorizando
    {
        public static venNPAutorizandoDS Datos(int /*0*/pvenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venNPAutorizandoDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venNPAutorizandoDS dsTipado = new venNPAutorizandoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pvenPedidos, int /*1*/pSecuencia, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, new Generalidades.NullableInt(/*1*/pSecuencia) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venNPAutorizandoEliminar", parametros);
        }

        public static int Guardar(int /*0*/pvenPedidos, int /*1*/pSecuencia, string /*2*/pNivelAuto_Id, string /*3*/pUsuario_Id, DateTime /*4*/pFecha, string /*5*/pTipoApro, string /*6*/pResultadoFormula, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pSecuencia, /*2*/pNivelAuto_Id, new Generalidades.NullableString(/*3*/pUsuario_Id), new Generalidades.NullableDate(/*4*/pFecha), /*5*/pTipoApro, new Generalidades.NullableString(/*6*/pResultadoFormula) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venNPAutorizandoGuardar", parametros);
        }





    }
}
