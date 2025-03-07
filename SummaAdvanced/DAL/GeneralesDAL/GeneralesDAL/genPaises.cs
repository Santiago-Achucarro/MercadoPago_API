using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genPaises
    {
        public static genPaisesDS Datos(short /*0*/pPais_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPais_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genPaisesDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CodFiscal", "Dominio_Id", "DescripcionDominios" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genPaisesDS dsTipado = new genPaisesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(short /*0*/pPais_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableShort(/*0*/pPais_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genPaisesEliminar", parametros);
        }

        public static int Guardar(short /*0*/pPais_Id, short /*1*/pPais_Id_Nuevo, int /*2*/pEmpresa_Id, 
            string /*3*/pDescripcion, string /*4*/pCodFiscal, string /*5*/pDominio_Id, bool /*6*/pInactivo, 
            int /*7*/pUsuario_Id, bool /*8*/pPosteado, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPais_Id, /*1*/pPais_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pCodFiscal), new Generalidades.NullableString(/*5*/pDominio_Id), /*6*/pInactivo, /*7*/pUsuario_Id, /*8*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("genPaisesGuardar", parametros);
        }






    }
}
