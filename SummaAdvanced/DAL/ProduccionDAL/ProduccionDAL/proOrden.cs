using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proOrden
    {
        public static proOrdenDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("proOrdenDatos", parametros);

            string[] camposTabla0 = { "FechaEmision", "FechaNecesidad", "FechaProduccion", "FechaFin", "CierreAutomatico", "Medida_Id", "DescripcionMedida", "Anulado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla5 = { "Vencimiento", "Existencia", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            proOrdenDS dsTipado = new proOrdenDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Productos.TableName, dsTipado.Recursos.TableName, dsTipado.Trabajo3.TableName, dsTipado.SubRecursos.TableName, dsTipado.grdMoviSerie.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, int /*10*/pUsuario_Id, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id, /*10*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pProducto_Id, decimal /*11*/pTamBatch, string /*12*/pReceta_Id, string /*13*/pObservaciones, decimal /*14*/pCantidad, decimal /*15*/pCantidadProgramada, decimal /*16*/pCantidadTerminada, decimal /*17*/pCantidadIngresada, DateTime /*18*/pFechaEmision, DateTime /*19*/pFechaNecesidad, DateTime /*20*/pFechaProduccion, DateTime /*21*/pFechaFin, string /*22*/pMedida_Id, decimal /*23*/pFactor, bool /*24*/pAnulado, int /*25*/pUsuario_Id, string /*26*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, new Generalidades.NullableString(/*10*/pProducto_Id), /*11*/pTamBatch, new Generalidades.NullableString(/*12*/pReceta_Id), /*13*/pObservaciones, /*14*/pCantidad, /*15*/pCantidadProgramada, /*16*/pCantidadTerminada, /*17*/pCantidadIngresada, /*18*/pFechaEmision, /*19*/pFechaNecesidad, new Generalidades.NullableDate(/*20*/pFechaProduccion), new Generalidades.NullableDate(/*21*/pFechaFin), /*22*/pMedida_Id, /*23*/pFactor, /*24*/pAnulado, /*25*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("proOrdenGuardar", parametros));
        }


        public static proExistenciaDS Existencia(string /*0*/Producto_Id, string /*1*/Deposito_Id, int /*2*/Empresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_Id, /*1*/Deposito_Id, /*2*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proExistencia", parametros);

            string[] camposTabla0 = { "Empresa_Id", "Produccion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proExistenciaDS dsTipado = new proExistenciaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void ProgramaEliminar(int /*0*/proProgramas, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/proProgramas, /*1*/FechaDesde, /*2*/FechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenesProgramaEliminar", parametros);
        }

        public static void Terminar(int /*0*/proOrden, decimal /*1*/pCantidad, DateTime /*2*/pFechaFin, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/proOrden, /*1*/pCantidad, new Generalidades.NullableDate(/*2*/pFechaFin) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proOrdenTerminar", parametros);
        }


    }
}
