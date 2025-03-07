using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueDato
    {
        public static sueDatoDS Datos(int /*0*/pLegajo, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, int /*10*/pEmpresa_Id, int /*11*/pGrupo_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pEmpresa_Id, /*11*/pGrupo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueDatoDatos", parametros);

            string[] camposTabla0 = { "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Legajo", "DescripcionLegajo", "FechaInicial", "FechaFinal", "Grupo_Id", "DescripcionGrupo", "DatoOculto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "sueLiquidacion", "Dato", "Dato2", "FechaRegistro", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueDatoDS dsTipado = new sueDatoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.DatoRetro.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pLegajo, int /*1*/pConcepto_Id, string /*2*/pSegmento_Id, int /*3*/pSegmento1N, int /*4*/pSegmento2N, int /*5*/pSegmento3N, int /*6*/pSegmento4N, string /*7*/pSegmento1C, string /*8*/pSegmento2C, string /*9*/pSegmento3C, string /*10*/pSegmento4C, int /*11*/pEmpresa_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pConcepto_Id, /*2*/pSegmento_Id, /*3*/pSegmento1N, /*4*/pSegmento2N, /*5*/pSegmento3N, /*6*/pSegmento4N, /*7*/pSegmento1C, /*8*/pSegmento2C, /*9*/pSegmento3C, /*10*/pSegmento4C, /*11*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueDatoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pLegajo, int /*1*/pConcepto_Id, decimal /*2*/pDato, decimal /*3*/pDato2, int /*4*/pUsuario_Id, DateTime /*5*/pFechaRegistro, string /*6*/pSegmento_Id, int /*7*/pSegmento1N, int /*8*/pSegmento2N, int /*9*/pSegmento3N, int /*10*/pSegmento4N, string /*11*/pSegmento1C, string /*12*/pSegmento2C, string /*13*/pSegmento3C, string /*14*/pSegmento4C, int /*15*/pEmpresa_Id, string /*16*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pConcepto_Id, /*2*/pDato, /*3*/pDato2, new Generalidades.NullableInt(/*4*/pUsuario_Id), /*5*/pFechaRegistro, /*6*/pSegmento_Id, /*7*/pSegmento1N, /*8*/pSegmento2N, /*9*/pSegmento3N, /*10*/pSegmento4N, /*11*/pSegmento1C, /*12*/pSegmento2C, /*13*/pSegmento3C, /*14*/pSegmento4C, /*15*/pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueDatoGuardar", parametros);
        }

        public static sueDatoXConceptoDS DatosXConcepto(int /*0*/pGrupo_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, int /*10*/pEmpresa_Id, int /*11*/pConcepto_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pEmpresa_Id, /*11*/pConcepto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueDatoXConceptoDatos", parametros);

            string[] camposTabla0 = { "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Concepto_Id", "DescripcionConcepto", "FechaInicial", "FechaFinal", "Grupo_Id", "DescripcionGrupo", "DatoOculto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "sueLiquidacion", "Dato", "Dato2", "FechaRegistro", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueDatoXConceptoDS dsTipado = new sueDatoXConceptoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.DatosRetro.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
