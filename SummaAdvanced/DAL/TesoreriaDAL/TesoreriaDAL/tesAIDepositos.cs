using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using TesoreriaCommon;
using System.Data;

namespace TesoreriaDAL
{
    public class tesAIDepositos
    {

        public static tesAIDepositosDS Datos(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id, new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesAIDepositosDatos", parametros);

            string[] camposTabla0 = { "Cliente_Id", "DescripcionClientes" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesAIDepositosDS dsTipado = new tesAIDepositosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id, new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesAIDepositosEliminar", parametros);
        }

        public static void Guardar(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, int /*2*/pRenglon, string /*3*/pCarteraCheq_Id, int /*4*/pnumCheque, DateTime /*5*/pFechaVencimiento, decimal /*6*/pImporte, string /*7*/pClearing, string /*8*/pBanco_Id, string /*9*/pCliente_Id, string /*10*/pcuentaBanco, string /*11*/psucBanco, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id, /*2*/pRenglon, /*3*/pCarteraCheq_Id, /*4*/pnumCheque, /*5*/pFechaVencimiento, /*6*/pImporte, /*7*/pClearing, /*8*/pBanco_Id, new Generalidades.NullableString(/*9*/pCliente_Id), /*10*/pcuentaBanco, /*11*/psucBanco };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesAIDepositosGuardar", parametros);
        }










    }
}
