using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genDiasFestivos
    {
        public static genDiasFestivosDS Datos( string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genDiasFestivosDatos", parametros);

            string[] camposTabla1 = { "Descripcion", "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genDiasFestivosDS dsTipado = new genDiasFestivosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genDiasFestivosEliminar", parametros);
        }

        public static void Guardar(DateTime /*0*/pFecha, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFecha, /*1*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genDiasFestivosGuardar", parametros);
        }
        public static genDiasFestivosFechaDS FechaDatos(DateTime /*0*/Fecha, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Fecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genDiasFestivosFechaDatos", parametros);

            string[] camposTabla0 = { "Descripcion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genDiasFestivosFechaDS dsTipado = new genDiasFestivosFechaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
