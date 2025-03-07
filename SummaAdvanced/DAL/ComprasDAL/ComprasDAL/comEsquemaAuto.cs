using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comEsquemaAuto
    {
        public static comEsquemaAutoDS Datos(string /*0*/pEsquemaAuto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEsquemaAutoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "NivelAuto_Id", "DescripcioncomNivelesAuto", "Formula" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            comEsquemaAutoDS dsTipado = new comEsquemaAutoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pEsquemaAuto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEsquemaAutoEliminar", parametros);
        }

        public static int Guardar(string /*0*/pEsquemaAuto_Id, string /*1*/pEsquemaAuto_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, bool /*4*/pInactivo, bool /*5*/pPosteado, int /*6*/pUsuario_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id, /*1*/pEsquemaAuto_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pInactivo, /*5*/pPosteado, /*6*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("comEsquemaAutoGuardar", parametros));
        }

        public static void EliminarCuerpo(string /*0*/pEsquemaAuto_Id, int /*1*/pOrden, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id, new Generalidades.NullableInt(/*1*/pOrden) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEsquemaAutoRengEliminar", parametros);
        }

        public static void GuardarCuerpo(string /*0*/pEsquemaAuto_Id, int /*1*/pOrden, string /*2*/pNivelAuto_Id, string /*3*/pFormula, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id, /*1*/pOrden, /*2*/pNivelAuto_Id, /*3*/pFormula };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEsquemaAutoRengGuardar", parametros);
        }


    }
}
