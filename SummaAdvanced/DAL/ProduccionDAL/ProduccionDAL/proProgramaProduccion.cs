using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProduccionCommon;
using interfaceDAAB;

namespace ProduccionDAL
{
    public class proProgramaProduccion
    {
        public static proProgramaProduccionDS Datos(string /*0*/pSegmento_Id, string /*1*/pSegmento1C, string /*2*/pSegmento2C, string /*3*/pSegmento3C, string /*4*/pSegmento4C, int /*5*/pSegmento1N, int /*6*/pSegmento2N, int /*7*/pSegmento3N, 
            int /*8*/pSegmento4N, DateTime /*9*/pFechaHastaPedidos, int pEmpresa,  string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1C, /*2*/pSegmento2C, /*3*/pSegmento3C, /*4*/pSegmento4C, /*5*/pSegmento1N, /*6*/pSegmento2N, /*7*/pSegmento3N, /*8*/pSegmento4N, /*9*/pFechaHastaPedidos, pEmpresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProgramaProduccionDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "Usuario_Id", "FechaHastaPedidos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proProgramaProduccionDS dsTipado = new proProgramaProduccionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Relaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static proProgramaProdCalcDS Calcular(string /*0*/pProductoDesde, string /*1*/pProductoHasta, DateTime /*2*/pFechaDesde, DateTime /*3*/pFechaHasta, string /*4*/pDeposito, DateTime /*5*/pFechaHastaPedidos, string /*6*/pFamiliaDesde, string /*7*/pFamiliaHasta, string /*8*/pGrupoDesde, string /*9*/pGrupoHasta, string /*10*/pDescripcion, int /*11*/pEmpresa_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProductoDesde, /*1*/pProductoHasta, /*2*/pFechaDesde, /*3*/pFechaHasta, /*4*/pDeposito, /*5*/pFechaHastaPedidos, /*6*/pFamiliaDesde, /*7*/pFamiliaHasta, /*8*/pGrupoDesde, /*9*/pGrupoHasta, /*10*/pDescripcion, /*11*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProgramaProdCalc", parametros);

            string[] camposTabla0 = { "Medida_Id", "DescripcionMedida", "Pedidos", "Stock", "MinNecesario", "Minimo", "Maximo", "Ult90Dias" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proProgramaProdCalcDS dsTipado = new proProgramaProdCalcDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static int Guardar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pproPrograma, string /*10*/pDescripcion, int /*11*/pEmpresa_Id, DateTime /*12*/pFecha, DateTime /*13*/pFechaDesde, DateTime /*14*/pFechaHasta, string /*15*/pDeposito_Id, string /*16*/pProductoDesde, string /*17*/pProductoHasta, bool /*18*/pLunes, bool /*19*/pMartes, bool /*20*/pMiercoles, bool /*21*/pJueves, bool /*22*/pViernes, bool /*23*/pSabado, bool /*24*/pDomingo, string /*25*/pGrupoDesde, string /*26*/pGrupoHasta, string /*27*/pFamiliaDesde, string /*28*/pFamiliaHasta, int /*29*/pUsuario_Id, string /*30*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pproPrograma, /*10*/pDescripcion, /*11*/pEmpresa_Id, /*12*/pFecha, /*13*/pFechaDesde, /*14*/pFechaHasta, /*15*/pDeposito_Id, /*16*/pProductoDesde, /*17*/pProductoHasta, /*18*/pLunes, /*19*/pMartes, /*20*/pMiercoles, /*21*/pJueves, /*22*/pViernes, /*23*/pSabado, /*24*/pDomingo, /*25*/pGrupoDesde, /*26*/pGrupoHasta, /*27*/pFamiliaDesde, /*28*/pFamiliaHasta, /*29*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("proProgramaProduccionGuardar", parametros));
        }

        public static proPendientesProdDS Pendientes(DateTime /*0*/FechaHasta, int /*1*/Empresa_Id, DateTime /*2*/Fecha, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FechaHasta, /*1*/Empresa_Id, new Generalidades.NullableDate(/*2*/Fecha) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proPendientesProd", parametros);

            string[] camposTabla0 = { "Existencia", "Fecha", "Consumo", "Produccion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proPendientesProdDS dsTipado = new proPendientesProdDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
