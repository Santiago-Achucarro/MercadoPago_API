using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using VentasCommon;
using interfaceDAAB;

namespace VentasDAL
{
public   class venLibros
    {


        public static venLibrosDS Datos(string /*0*/pLibro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLibro_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venLibrosDatos", parametros);

            string[] camposTabla0 = { "PTodasLasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            venLibrosDS dsTipado = new venLibrosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Columnas.TableName, dsTipado.Impuestos.TableName, dsTipado.Retenciones.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pLibro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLibro_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venLibrosEliminar", parametros);
        }


        public static int Guardar(string /*0*/pLibro_Id, int /*1*/pEmpresa_Id, string /*2*/pLibro_Id_Nuevo, string /*3*/pDescripcion, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLibro_Id, new Generalidades.NullableInt(/*1*/pEmpresa_Id), /*2*/pLibro_Id_Nuevo, /*3*/pDescripcion };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venLibrosGuardar", parametros);
        }



    }
}
