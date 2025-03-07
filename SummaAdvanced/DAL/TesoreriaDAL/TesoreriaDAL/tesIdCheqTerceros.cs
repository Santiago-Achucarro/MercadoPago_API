using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesIdCheqTerceros
    {
        public static tesIdCheqTercerosDS Datos(string /*0*/pCartera_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesIdCheqTercerosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpreas", "Cuenta_Id", "DescripcionCuentas", "Moneda_Id", "DescripcionMonedas", "UsuarioAmo", "DescripcionUsuarioAmo", "CtaValEnTransito", "DescripcionCtaValEnTransito", "CtaChqRechazado", "DescripcionCtaChqRechazado", "FormaDePagoP", "OrdenPtoVta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesIdCheqTercerosDS dsTipado = new tesIdCheqTercerosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pCartera_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesIdCheqTercerosEliminar", parametros);
        }
        public static void Guardar(string /*0*/pCartera_Id, string /*1*/pCtaChqRechazado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pCtaChqRechazado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesIdCheqTercerosGuardar", parametros);
            return;
        }
    }
}
