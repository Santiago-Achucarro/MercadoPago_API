using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesIdVarios
    {
        public static tesIdVariosDS Datos(string /*0*/pCartera_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesIdVariosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpreas", "Cuenta_Id", "DescripcionCuentas", "Moneda_Id", "DescripcionMonedas", "UsuarioAmo", "DescripcionUsuarioAmo", "CtaValEnTransito", "DescripcionCtaValEnTransito", "FormaDePagoP", "OrdenPtoVta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesIdVariosDS dsTipado = new tesIdVariosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pCartera_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesIdVariosEliminar", parametros);
        }
        public static void Guardar(string /*0*/pCartera_Id, bool /*1*/pModi_Cuenta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pModi_Cuenta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesIdVariosGuardar", parametros);

            return;
        }
    }
}
