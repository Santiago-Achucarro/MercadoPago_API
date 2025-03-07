using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genReportes
    {

        public static genReportesDS Datos(string /*0*/pReporte_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReporte_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genReportesDatos", parametros);

            string[] camposTabla0 = { "Carpeta", "Estandar", "Local", "StoreProcedure", "TipoReporte", "TamanioHoja", "AnchoHoja", "AltoHoja" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genReportesDS dsTipado = new genReportesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Procedimientos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pReporte_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReporte_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genReportesEliminar", parametros);
        }

        public static int Guardar(string /*0*/pReporte_Id, string /*1*/pReporte_Id_Nueva, string /*2*/pTitulo, string /*3*/pCarpeta, string /*4*/pRpt, bool /*5*/pEstandar, bool /*6*/pLocal, string /*7*/pStoreProcedure, string /*8*/pTipoReporte, string /*9*/pTamanioHoja, int /*10*/pAnchoHoja, int /*11*/pAltoHoja, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReporte_Id, /*1*/pReporte_Id_Nueva, /*2*/pTitulo, new Generalidades.NullableString(/*3*/pCarpeta), /*4*/pRpt, new Generalidades.NullableBool(/*5*/pEstandar), new Generalidades.NullableBool(/*6*/pLocal), /*7*/pStoreProcedure, new Generalidades.NullableString(/*8*/pTipoReporte), new Generalidades.NullableString(/*9*/pTamanioHoja), /*10*/pAnchoHoja, /*11*/pAltoHoja };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("genReportesGuardar", parametros);
        }




        public static GeneralesCommon.genReporteEjecutarDS Ejecutar(string lStoreProcedure, string lParametros, string pAuxiliar)
        {

            object[] parametros = lParametros.Split('|');
            for (int i = 0; i < parametros.Length; i++)
            {

                if (parametros[i].ToString().EndsWith("+00:00"))
                    {
                        parametros[i] = parametros[i].ToString().Substring(0,
                            parametros[i].ToString().Length - 6);
                    }

                


            }

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject(lStoreProcedure, parametros);
            for (int i= 0; i < ds.Tables.Count; i++)
            {
                string[] camposTabla0 = new string[ds.Tables[i].Columns.Count];
                for (int j = 0; j < ds.Tables[i].Columns.Count; j++)
                {
                    camposTabla0[j] = ds.Tables[i].Columns[j].ColumnName;
                }
                Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[i], camposTabla0);
            }

            genReporteEjecutarDS dsTipado = new genReporteEjecutarDS();
            string[] nombreTablas = { "Resultado" };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            // Preservo los cambios para que me traiga todo
            dsTipado.Merge(ds, true);
            return (dsTipado);

        }

    }
}
