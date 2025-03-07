using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
namespace VentasDAL
{
    public class venSaldosPendientesTarea
    {
		public static venSaldosPendientesTareaDS Datos(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venSaldosPendientesTarea", parametros);

			venSaldosPendientesTareaDS dsTipado = new venSaldosPendientesTareaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Saldos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



	}
}
