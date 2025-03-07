using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genContadorSegmento
    {
        public static genContadorSegmentoDS Datos(int /*0*/pSegmento2N, int /*1*/pSegmento3N, int /*2*/pSegmento4N,
            string /*3*/pSegmento1C, string /*4*/pSegmento2C, string /*5*/pSegmento3C, string /*6*/pSegmento4C, 
            string /*7*/pSegmento_Id, int /*8*/pEmpresa_Id, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento2N, /*1*/pSegmento3N, /*2*/pSegmento4N, /*3*/pSegmento1C, 
                /*4*/pSegmento2C, /*5*/pSegmento3C, /*6*/pSegmento4C, /*7*/pSegmento_Id, /*8*/pEmpresa_Id};

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genContadorSegmentoDatos", parametros);

            string[] camposTabla0 = { "Cai", "NumeroDesde", "NumeroHasta", "FechaAutoSRI", "FechaDesde" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genContadorSegmentoDS dsTipado = new genContadorSegmentoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static genContadorSegmentoDatosTodosDS DatosTodos(string /*0*/pSegmento_id, int /*1*/pEmpresa_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_id, /*1*/pEmpresa_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genContadorSegmentoDatosTodos", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Cai", "NumeroDesde", "NumeroHasta", "FechaAutoSRI", "FechaDesde" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genContadorSegmentoDatosTodosDS dsTipado = new genContadorSegmentoDatosTodosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(int /*0*/pSegmento2N, int /*1*/pSegmento3N, int /*2*/pSegmento4N, string /*3*/pSegmento1C, string /*4*/pSegmento2C, string /*5*/pSegmento3C, string /*6*/pSegmento4C, string /*7*/pSegmento_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pSegmento2N), new Generalidades.NullableInt(/*1*/pSegmento3N), new Generalidades.NullableInt(/*2*/pSegmento4N), new Generalidades.NullableString(/*3*/pSegmento1C), new Generalidades.NullableString(/*4*/pSegmento2C), new Generalidades.NullableString(/*5*/pSegmento3C), new Generalidades.NullableString(/*6*/pSegmento4C), /*7*/pSegmento_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genContadorSegmentoEliminar", parametros);
        }

        public static void EliminarTodos(string /*0*/pSegmento_id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genContadorSegmentoEliminarTodos", parametros);
        }


        public static void Guardar(int /*0*/pSegmento2N, int /*1*/pSegmento3N, int /*2*/pSegmento4N, string /*3*/pSegmento1C,
            string /*4*/pSegmento2C, string /*5*/pSegmento3C, string /*6*/pSegmento4C, string /*7*/pSegmento_Id,
            int /*8*/pEmpresa_Id, int /*9*/pPrimerNumero, string /*10*/pCai, DateTime /*11*/pFechaCai, int /*12*/pNumeroDesde, 
            int /*13*/pNumeroHasta, DateTime /*14*/pFechaAutoSRI, DateTime /*15*/pFechaDesde, int /*16*/pUsuario_Id,
            bool pTieneColumnaAutomatica,
            string /*17*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento2N, /*1*/pSegmento3N, /*2*/pSegmento4N, /*3*/pSegmento1C,
                /*4*/pSegmento2C, /*5*/pSegmento3C, /*6*/pSegmento4C, /*7*/pSegmento_Id, /*8*/pEmpresa_Id, /*9*/pPrimerNumero,
                /*10*/pCai, new Generalidades.NullableDate(/*11*/pFechaCai), /*12*/pNumeroDesde, /*13*/pNumeroHasta,
                new Generalidades.NullableDate(/*14*/pFechaAutoSRI), new Generalidades.NullableDate(/*15*/pFechaDesde),
                /*16*/pUsuario_Id, pTieneColumnaAutomatica };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genContadorSegmentoGuardar", parametros);
        }


        public static void Copiar(string /*0*/SucursalOrigen, string /*1*/SucursalDestinoDesde, string /*2*/SucursalDestinoHasta, int /*3*/Empresa_Id, int /*4*/Usuarios_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/SucursalOrigen, /*1*/SucursalDestinoDesde, /*2*/SucursalDestinoHasta, /*3*/Empresa_Id, /*4*/Usuarios_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genCopiaSegmentos", parametros);
        }


    }
}
