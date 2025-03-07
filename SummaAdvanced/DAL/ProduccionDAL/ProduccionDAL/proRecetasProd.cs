using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;
namespace ProduccionDAL
{
    public class proRecetasProd
    {
        public static proRecetasProdDS Datos(int /*0*/pReceta_Id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proRecetasProdDatos", parametros);

            string[] camposTabla0 = { "Producto_Id", "DescripcionProducto", "Medida_Id", "DescripcionMedida_Id", "Deposito_Id", "DescripcionDepositos", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proRecetasProdDS dsTipado = new proRecetasProdDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pReceta_Id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proRecetasProdEliminar", parametros);
        }

        public static void Guardar(string /*0*/pReceta_Id, int /*1*/pRenglon, string /*2*/pProducto_Id, string /*3*/pEntradaSalida, string /*4*/pMedida_Id, string /*5*/pFormula, decimal /*6*/pCantidad, decimal /*7*/pPorcentajeCosto, string /*8*/pDeposito_Id, string /*9*/pObservaciones, bool /*10*/pTomaDepoT3, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id, /*1*/pRenglon, /*2*/pProducto_Id, /*3*/pEntradaSalida, new Generalidades.NullableString(/*4*/pMedida_Id), /*5*/pFormula, /*6*/pCantidad, /*7*/pPorcentajeCosto, new Generalidades.NullableString(/*8*/pDeposito_Id), new Generalidades.NullableString(/*9*/pObservaciones), /*10*/pTomaDepoT3 };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proRecetasProdGuardar", parametros);
        }

        public static proFormulasConVarDS FormulasConVar(string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proFormulasConVar", parametros);

            string[] camposTabla0 = { "Medida_Id", "Deposito_Id", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proFormulasConVarDS dsTipado = new proFormulasConVarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
